﻿namespace CMNCOM
{
    partial class DeviceUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DevPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DevPanel
            // 
            this.DevPanel.Location = new System.Drawing.Point(0, 0);
            this.DevPanel.Name = "DevPanel";
            this.DevPanel.Size = new System.Drawing.Size(279, 429);
            this.DevPanel.TabIndex = 0;
            // 
            // DeviceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 430);
            this.Controls.Add(this.DevPanel);
            this.Name = "DeviceUI";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DevPanel;
    }
}