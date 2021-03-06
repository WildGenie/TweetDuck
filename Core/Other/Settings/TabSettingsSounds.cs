﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TweetDck.Core.Notification;
using TweetDck.Core.Notification.Sound;

namespace TweetDck.Core.Other.Settings{
    partial class TabSettingsSounds : BaseTabSettings{
        private readonly ISoundNotificationPlayer soundNotification;

        public TabSettingsSounds(){
            InitializeComponent();

            soundNotification = SoundNotification.New();
            soundNotification.PlaybackError += sound_PlaybackError;

            tbCustomSound.Text = Config.NotificationSoundPath;
            tbCustomSound_TextChanged(tbCustomSound, new EventArgs());

            Disposed += (sender, args) => soundNotification.Dispose();
        }

        public override void OnReady(){
            tbCustomSound.TextChanged += tbCustomSound_TextChanged;
            btnPlaySound.Click += btnPlaySound_Click;
            btnBrowseSound.Click += btnBrowseSound_Click;
            btnResetSound.Click += btnResetSound_Click;
        }

        public override void OnClosing(){
            Config.NotificationSoundPath = tbCustomSound.Text;
        }

        private void tbCustomSound_TextChanged(object sender, EventArgs e){
            bool isEmpty = string.IsNullOrEmpty(tbCustomSound.Text);
            tbCustomSound.ForeColor = isEmpty || File.Exists(tbCustomSound.Text) ? SystemColors.WindowText : Color.Maroon;
            btnPlaySound.Enabled = !isEmpty;
            btnResetSound.Enabled = !isEmpty;
        }

        private void btnPlaySound_Click(object sender, EventArgs e){
            soundNotification.Play(tbCustomSound.Text);
        }

        private void sound_PlaybackError(object sender, PlaybackErrorEventArgs e){
            MessageBox.Show("Could not play custom notification sound."+Environment.NewLine+e.Message, "Notification Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBrowseSound_Click(object sender, EventArgs e){
            using(OpenFileDialog dialog = new OpenFileDialog{
                AutoUpgradeEnabled = true,
                DereferenceLinks = true,
                Title = "Custom Notification Sound",
                Filter = "Sound file ("+soundNotification.SupportedFormats+")|"+soundNotification.SupportedFormats+"|All files (*.*)|*.*"
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
