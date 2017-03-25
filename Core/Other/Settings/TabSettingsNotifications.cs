﻿using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using TweetDck.Core.Controls;
using TweetDck.Core.Notification;

namespace TweetDck.Core.Other.Settings{
    partial class TabSettingsNotifications : BaseTabSettings{
        private readonly FormNotificationMain notification;

        public TabSettingsNotifications(FormNotificationMain notification){
            InitializeComponent();

            this.notification = notification;
            this.notification.CanMoveWindow = () => radioLocCustom.Checked;

            this.notification.Move += (sender, args) => {
                if (radioLocCustom.Checked){
                    Config.CustomNotificationPosition = this.notification.Location;
                }
            };
            
            this.notification.Initialized += (sender, args) => {
                this.InvokeAsyncSafe(() => this.notification.ShowNotificationForSettings(true));
            };

            this.notification.Activated += notification_Activated;
            this.notification.Show();

            switch(Config.NotificationPosition){
                case TweetNotification.Position.TopLeft: radioLocTL.Checked = true; break;
                case TweetNotification.Position.TopRight: radioLocTR.Checked = true; break;
                case TweetNotification.Position.BottomLeft: radioLocBL.Checked = true; break;
                case TweetNotification.Position.BottomRight: radioLocBR.Checked = true; break;
                case TweetNotification.Position.Custom: radioLocCustom.Checked = true; break;
            }

            trackBarDuration.SetValueSafe(Config.NotificationDurationValue);
            labelDurationValue.Text = Config.NotificationDurationValue+" ms/c";

            comboBoxDisplay.Items.Add("(Same As "+Program.BrandName+")");

            foreach(Screen screen in Screen.AllScreens){
                comboBoxDisplay.Items.Add(screen.DeviceName+" ("+screen.Bounds.Width+"x"+screen.Bounds.Height+")");
            }

            comboBoxDisplay.SelectedIndex = Math.Min(comboBoxDisplay.Items.Count-1, Config.NotificationDisplay);

            checkNotificationTimer.Checked = Config.DisplayNotificationTimer;
            checkTimerCountDown.Enabled = checkNotificationTimer.Checked;
            checkTimerCountDown.Checked = Config.NotificationTimerCountDown;
            checkNonIntrusive.Checked = Config.NotificationNonIntrusiveMode;

            trackBarEdgeDistance.SetValueSafe(Config.NotificationEdgeDistance);
            labelEdgeDistanceValue.Text = trackBarEdgeDistance.Value.ToString(CultureInfo.InvariantCulture)+" px";

            tbCustomSound.Text = Config.NotificationSoundPath;
            tbCustomSound_TextChanged(tbCustomSound, new EventArgs());

            Disposed += (sender, args) => this.notification.Dispose();
        }

        public override void OnReady(){
            radioLocTL.CheckedChanged += radioLoc_CheckedChanged;
            radioLocTR.CheckedChanged += radioLoc_CheckedChanged;
            radioLocBL.CheckedChanged += radioLoc_CheckedChanged;
            radioLocBR.CheckedChanged += radioLoc_CheckedChanged;
            radioLocCustom.CheckedChanged += radioLoc_CheckedChanged;

            trackBarDuration.ValueChanged += trackBarDuration_ValueChanged;
            btnDurationShort.Click += btnDurationShort_Click;
            btnDurationMedium.Click += btnDurationMedium_Click;
            btnDurationLong.Click += btnDurationLong_Click;

            checkNotificationTimer.CheckedChanged += checkNotificationTimer_CheckedChanged;
            checkTimerCountDown.CheckedChanged += checkTimerCountDown_CheckedChanged;
            checkNonIntrusive.CheckedChanged += checkNonIntrusive_CheckedChanged;

            comboBoxDisplay.SelectedValueChanged += comboBoxDisplay_SelectedValueChanged;
            trackBarEdgeDistance.ValueChanged += trackBarEdgeDistance_ValueChanged;

            tbCustomSound.TextChanged += tbCustomSound_TextChanged;
            btnBrowseSound.Click += btnBrowseSound_Click;
            btnResetSound.Click += btnResetSound_Click;
        }

        public override void OnClosing(){
            Config.NotificationSoundPath = tbCustomSound.Text;
        }

        private void TabSettingsNotifications_ParentChanged(object sender, EventArgs e){
            if (Parent == null){
                notification.HideNotification(false);
            }
            else{
                notification.ShowNotificationForSettings(true);
            }
        }

        private void notification_Activated(object sender, EventArgs e){
            notification.Hide();
            notification.Activated -= notification_Activated;
        }

        private void radioLoc_CheckedChanged(object sender, EventArgs e){
            if (radioLocTL.Checked)Config.NotificationPosition = TweetNotification.Position.TopLeft;
            else if (radioLocTR.Checked)Config.NotificationPosition = TweetNotification.Position.TopRight;
            else if (radioLocBL.Checked)Config.NotificationPosition = TweetNotification.Position.BottomLeft;
            else if (radioLocBR.Checked)Config.NotificationPosition = TweetNotification.Position.BottomRight;
            else if (radioLocCustom.Checked){
                if (!Config.IsCustomNotificationPositionSet){
                    Config.CustomNotificationPosition = notification.Location;
                }

                Config.NotificationPosition = TweetNotification.Position.Custom;
            }

            comboBoxDisplay.Enabled = trackBarEdgeDistance.Enabled = !radioLocCustom.Checked;
            notification.ShowNotificationForSettings(false);
        }

        private void trackBarDuration_ValueChanged(object sender, EventArgs e){
            Config.NotificationDurationValue = trackBarDuration.Value;
            labelDurationValue.Text = Config.NotificationDurationValue+" ms/c";

            notification.ShowNotificationForSettings(true);
        }

        private void btnDurationShort_Click(object sender, EventArgs e){
            trackBarDuration.Value = 15;
        }

        private void btnDurationMedium_Click(object sender, EventArgs e){
            trackBarDuration.Value = 25;
        }

        private void btnDurationLong_Click(object sender, EventArgs e){
            trackBarDuration.Value = 35;
        }

        private void checkNotificationTimer_CheckedChanged(object sender, EventArgs e){
            Config.DisplayNotificationTimer = checkNotificationTimer.Checked;
            checkTimerCountDown.Enabled = checkNotificationTimer.Checked;
            notification.ShowNotificationForSettings(true);
        }

        private void checkTimerCountDown_CheckedChanged(object sender, EventArgs e){
            Config.NotificationTimerCountDown = checkTimerCountDown.Checked;
            notification.ShowNotificationForSettings(true);
        }

        private void checkNonIntrusive_CheckedChanged(object sender, EventArgs e){
            Config.NotificationNonIntrusiveMode = checkNonIntrusive.Checked;
        }

        private void comboBoxDisplay_SelectedValueChanged(object sender, EventArgs e){
            Config.NotificationDisplay = comboBoxDisplay.SelectedIndex;
            notification.ShowNotificationForSettings(false);
        }

        private void trackBarEdgeDistance_ValueChanged(object sender, EventArgs e){
            labelEdgeDistanceValue.Text = trackBarEdgeDistance.Value.ToString(CultureInfo.InvariantCulture)+" px";
            Config.NotificationEdgeDistance = trackBarEdgeDistance.Value;
            notification.ShowNotificationForSettings(false);
        }

        private void tbCustomSound_TextChanged(object sender, EventArgs e){

            bool fileExists = string.IsNullOrEmpty(tbCustomSound.Text) || File.Exists(tbCustomSound.Text);
            tbCustomSound.ForeColor = fileExists ? SystemColors.WindowText : Color.Maroon;
        }

        private void btnBrowseSound_Click(object sender, EventArgs e){
            using(OpenFileDialog dialog = new OpenFileDialog{
                AutoUpgradeEnabled = true,
                DereferenceLinks = true,
                Title = "Custom Notification Sound",
                Filter = "Wave file (*.wav)|*.wav"
            }){
                if (dialog.ShowDialog() == DialogResult.OK){
                    tbCustomSound.Text = dialog.FileName;
                }
            }
        }

        private void btnResetSound_Click(object sender, EventArgs e){
            tbCustomSound.Text = string.Empty;
        }
    }
}
