﻿namespace TweetDick.Core.Other {
    partial class FormSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupNotificationLocation = new System.Windows.Forms.GroupBox();
            this.labelEdgeDistance = new System.Windows.Forms.Label();
            this.trackBarEdgeDistance = new System.Windows.Forms.TrackBar();
            this.radioLocCustom = new System.Windows.Forms.RadioButton();
            this.radioLocBR = new System.Windows.Forms.RadioButton();
            this.radioLocBL = new System.Windows.Forms.RadioButton();
            this.radioLocTR = new System.Windows.Forms.RadioButton();
            this.radioLocTL = new System.Windows.Forms.RadioButton();
            this.groupNotificationDuration = new System.Windows.Forms.GroupBox();
            this.radioDurVeryLong = new System.Windows.Forms.RadioButton();
            this.radioDurLong = new System.Windows.Forms.RadioButton();
            this.radioDurMedium = new System.Windows.Forms.RadioButton();
            this.radioDurShort = new System.Windows.Forms.RadioButton();
            this.groupNotificationLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdgeDistance)).BeginInit();
            this.groupNotificationDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNotificationLocation
            // 
            this.groupNotificationLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNotificationLocation.Controls.Add(this.labelEdgeDistance);
            this.groupNotificationLocation.Controls.Add(this.trackBarEdgeDistance);
            this.groupNotificationLocation.Controls.Add(this.radioLocCustom);
            this.groupNotificationLocation.Controls.Add(this.radioLocBR);
            this.groupNotificationLocation.Controls.Add(this.radioLocBL);
            this.groupNotificationLocation.Controls.Add(this.radioLocTR);
            this.groupNotificationLocation.Controls.Add(this.radioLocTL);
            this.groupNotificationLocation.Location = new System.Drawing.Point(13, 13);
            this.groupNotificationLocation.Name = "groupNotificationLocation";
            this.groupNotificationLocation.Size = new System.Drawing.Size(148, 217);
            this.groupNotificationLocation.TabIndex = 0;
            this.groupNotificationLocation.TabStop = false;
            this.groupNotificationLocation.Text = "Notification Location";
            // 
            // labelEdgeDistance
            // 
            this.labelEdgeDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEdgeDistance.AutoSize = true;
            this.labelEdgeDistance.Location = new System.Drawing.Point(6, 150);
            this.labelEdgeDistance.Name = "labelEdgeDistance";
            this.labelEdgeDistance.Size = new System.Drawing.Size(103, 13);
            this.labelEdgeDistance.TabIndex = 6;
            this.labelEdgeDistance.Text = "Distance From Edge";
            // 
            // trackBarEdgeDistance
            // 
            this.trackBarEdgeDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarEdgeDistance.LargeChange = 8;
            this.trackBarEdgeDistance.Location = new System.Drawing.Point(6, 166);
            this.trackBarEdgeDistance.Maximum = 40;
            this.trackBarEdgeDistance.Minimum = 8;
            this.trackBarEdgeDistance.Name = "trackBarEdgeDistance";
            this.trackBarEdgeDistance.Size = new System.Drawing.Size(136, 45);
            this.trackBarEdgeDistance.SmallChange = 2;
            this.trackBarEdgeDistance.TabIndex = 5;
            this.trackBarEdgeDistance.TickFrequency = 2;
            this.trackBarEdgeDistance.Value = 8;
            this.trackBarEdgeDistance.ValueChanged += new System.EventHandler(this.trackBarEdgeDistance_ValueChanged);
            // 
            // radioLocCustom
            // 
            this.radioLocCustom.AutoSize = true;
            this.radioLocCustom.Location = new System.Drawing.Point(7, 116);
            this.radioLocCustom.Name = "radioLocCustom";
            this.radioLocCustom.Size = new System.Drawing.Size(60, 17);
            this.radioLocCustom.TabIndex = 4;
            this.radioLocCustom.TabStop = true;
            this.radioLocCustom.Text = "Custom";
            this.radioLocCustom.UseVisualStyleBackColor = true;
            this.radioLocCustom.CheckedChanged += new System.EventHandler(this.radioLoc_CheckedChanged);
            // 
            // radioLocBR
            // 
            this.radioLocBR.AutoSize = true;
            this.radioLocBR.Location = new System.Drawing.Point(7, 92);
            this.radioLocBR.Name = "radioLocBR";
            this.radioLocBR.Size = new System.Drawing.Size(86, 17);
            this.radioLocBR.TabIndex = 3;
            this.radioLocBR.TabStop = true;
            this.radioLocBR.Text = "Bottom Right";
            this.radioLocBR.UseVisualStyleBackColor = true;
            this.radioLocBR.CheckedChanged += new System.EventHandler(this.radioLoc_CheckedChanged);
            // 
            // radioLocBL
            // 
            this.radioLocBL.AutoSize = true;
            this.radioLocBL.Location = new System.Drawing.Point(7, 68);
            this.radioLocBL.Name = "radioLocBL";
            this.radioLocBL.Size = new System.Drawing.Size(79, 17);
            this.radioLocBL.TabIndex = 2;
            this.radioLocBL.TabStop = true;
            this.radioLocBL.Text = "Bottom Left";
            this.radioLocBL.UseVisualStyleBackColor = true;
            this.radioLocBL.CheckedChanged += new System.EventHandler(this.radioLoc_CheckedChanged);
            // 
            // radioLocTR
            // 
            this.radioLocTR.AutoSize = true;
            this.radioLocTR.Location = new System.Drawing.Point(7, 44);
            this.radioLocTR.Name = "radioLocTR";
            this.radioLocTR.Size = new System.Drawing.Size(72, 17);
            this.radioLocTR.TabIndex = 1;
            this.radioLocTR.TabStop = true;
            this.radioLocTR.Text = "Top Right";
            this.radioLocTR.UseVisualStyleBackColor = true;
            this.radioLocTR.CheckedChanged += new System.EventHandler(this.radioLoc_CheckedChanged);
            // 
            // radioLocTL
            // 
            this.radioLocTL.AutoSize = true;
            this.radioLocTL.Location = new System.Drawing.Point(7, 20);
            this.radioLocTL.Name = "radioLocTL";
            this.radioLocTL.Size = new System.Drawing.Size(65, 17);
            this.radioLocTL.TabIndex = 0;
            this.radioLocTL.TabStop = true;
            this.radioLocTL.Text = "Top Left";
            this.radioLocTL.UseVisualStyleBackColor = true;
            this.radioLocTL.CheckedChanged += new System.EventHandler(this.radioLoc_CheckedChanged);
            // 
            // groupNotificationDuration
            // 
            this.groupNotificationDuration.Controls.Add(this.radioDurVeryLong);
            this.groupNotificationDuration.Controls.Add(this.radioDurLong);
            this.groupNotificationDuration.Controls.Add(this.radioDurMedium);
            this.groupNotificationDuration.Controls.Add(this.radioDurShort);
            this.groupNotificationDuration.Location = new System.Drawing.Point(167, 13);
            this.groupNotificationDuration.Name = "groupNotificationDuration";
            this.groupNotificationDuration.Size = new System.Drawing.Size(148, 118);
            this.groupNotificationDuration.TabIndex = 1;
            this.groupNotificationDuration.TabStop = false;
            this.groupNotificationDuration.Text = "Notification Duration";
            // 
            // radioDurVeryLong
            // 
            this.radioDurVeryLong.AutoSize = true;
            this.radioDurVeryLong.Location = new System.Drawing.Point(6, 92);
            this.radioDurVeryLong.Name = "radioDurVeryLong";
            this.radioDurVeryLong.Size = new System.Drawing.Size(73, 17);
            this.radioDurVeryLong.TabIndex = 3;
            this.radioDurVeryLong.TabStop = true;
            this.radioDurVeryLong.Text = "Very Long";
            this.radioDurVeryLong.UseVisualStyleBackColor = true;
            this.radioDurVeryLong.CheckedChanged += new System.EventHandler(this.radioDur_CheckedChanged);
            this.radioDurVeryLong.Click += new System.EventHandler(this.radioDur_Click);
            // 
            // radioDurLong
            // 
            this.radioDurLong.AutoSize = true;
            this.radioDurLong.Location = new System.Drawing.Point(6, 68);
            this.radioDurLong.Name = "radioDurLong";
            this.radioDurLong.Size = new System.Drawing.Size(49, 17);
            this.radioDurLong.TabIndex = 2;
            this.radioDurLong.TabStop = true;
            this.radioDurLong.Text = "Long";
            this.radioDurLong.UseVisualStyleBackColor = true;
            this.radioDurLong.CheckedChanged += new System.EventHandler(this.radioDur_CheckedChanged);
            this.radioDurLong.Click += new System.EventHandler(this.radioDur_Click);
            // 
            // radioDurMedium
            // 
            this.radioDurMedium.AutoSize = true;
            this.radioDurMedium.Location = new System.Drawing.Point(6, 44);
            this.radioDurMedium.Name = "radioDurMedium";
            this.radioDurMedium.Size = new System.Drawing.Size(62, 17);
            this.radioDurMedium.TabIndex = 1;
            this.radioDurMedium.TabStop = true;
            this.radioDurMedium.Text = "Medium";
            this.radioDurMedium.UseVisualStyleBackColor = true;
            this.radioDurMedium.CheckedChanged += new System.EventHandler(this.radioDur_CheckedChanged);
            this.radioDurMedium.Click += new System.EventHandler(this.radioDur_Click);
            // 
            // radioDurShort
            // 
            this.radioDurShort.AutoSize = true;
            this.radioDurShort.Location = new System.Drawing.Point(6, 20);
            this.radioDurShort.Name = "radioDurShort";
            this.radioDurShort.Size = new System.Drawing.Size(50, 17);
            this.radioDurShort.TabIndex = 0;
            this.radioDurShort.TabStop = true;
            this.radioDurShort.Text = "Short";
            this.radioDurShort.UseVisualStyleBackColor = true;
            this.radioDurShort.CheckedChanged += new System.EventHandler(this.radioDur_CheckedChanged);
            this.radioDurShort.Click += new System.EventHandler(this.radioDur_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 242);
            this.Controls.Add(this.groupNotificationDuration);
            this.Controls.Add(this.groupNotificationLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TweetDick Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.groupNotificationLocation.ResumeLayout(false);
            this.groupNotificationLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdgeDistance)).EndInit();
            this.groupNotificationDuration.ResumeLayout(false);
            this.groupNotificationDuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNotificationLocation;
        private System.Windows.Forms.RadioButton radioLocCustom;
        private System.Windows.Forms.RadioButton radioLocBR;
        private System.Windows.Forms.RadioButton radioLocBL;
        private System.Windows.Forms.RadioButton radioLocTR;
        private System.Windows.Forms.RadioButton radioLocTL;
        private System.Windows.Forms.Label labelEdgeDistance;
        private System.Windows.Forms.TrackBar trackBarEdgeDistance;
        private System.Windows.Forms.GroupBox groupNotificationDuration;
        private System.Windows.Forms.RadioButton radioDurVeryLong;
        private System.Windows.Forms.RadioButton radioDurLong;
        private System.Windows.Forms.RadioButton radioDurMedium;
        private System.Windows.Forms.RadioButton radioDurShort;
    }
}