/* Copyright 2023 Dual Tachyon
 * https://github.com/DualTachyon
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 *     Unless required by applicable law or agreed to in writing, software
 *     distributed under the License is distributed on an "AS IS" BASIS,
 *     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *     See the License for the specific language governing permissions and
 *     limitations under the License.
 */

namespace RT_890_Flasher {
	partial class Flasher {
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
		private void InitializeComponent()
		{
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.PickButton = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.UartLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.BackupButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.FlashButton = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FastButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SlowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoUART = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ComPorts = new System.Windows.Forms.ToolStripComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilenameBox
            // 
            this.FilenameBox.Location = new System.Drawing.Point(83, 32);
            this.FilenameBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.ReadOnly = true;
            this.FilenameBox.Size = new System.Drawing.Size(220, 20);
            this.FilenameBox.TabIndex = 3;
            // 
            // PickButton
            // 
            this.PickButton.BackColor = System.Drawing.Color.White;
            this.PickButton.Location = new System.Drawing.Point(5, 29);
            this.PickButton.Margin = new System.Windows.Forms.Padding(2);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(74, 26);
            this.PickButton.TabIndex = 4;
            this.PickButton.Text = "&Open";
            this.PickButton.UseVisualStyleBackColor = false;
            this.PickButton.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // Copyright
            // 
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.Location = new System.Drawing.Point(11, 196);
            this.Copyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(305, 26);
            this.Copyright.TabIndex = 11;
            this.Copyright.Text = "Copyright (c) 2023 Dual Tachyon";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UartLog
            // 
            this.UartLog.BackColor = System.Drawing.Color.White;
            this.UartLog.Location = new System.Drawing.Point(13, 224);
            this.UartLog.Margin = new System.Windows.Forms.Padding(2);
            this.UartLog.Multiline = true;
            this.UartLog.Name = "UartLog";
            this.UartLog.ReadOnly = true;
            this.UartLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UartLog.Size = new System.Drawing.Size(308, 285);
            this.UartLog.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PickButton);
            this.groupBox1.Controls.Add(this.FilenameBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select firmware file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogButton);
            this.groupBox2.Controls.Add(this.Progress);
            this.groupBox2.Controls.Add(this.BackupButton);
            this.groupBox2.Controls.Add(this.EraseButton);
            this.groupBox2.Controls.Add(this.FlashButton);
            this.groupBox2.Location = new System.Drawing.Point(11, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 91);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(230, 22);
            this.LogButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(70, 26);
            this.LogButton.TabIndex = 18;
            this.LogButton.Text = "&Log";
            this.LogButton.UseVisualStyleBackColor = false;
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.White;
            this.Progress.Location = new System.Drawing.Point(5, 52);
            this.Progress.Margin = new System.Windows.Forms.Padding(2);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(295, 26);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progress.TabIndex = 17;
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.Color.White;
            this.BackupButton.Location = new System.Drawing.Point(5, 22);
            this.BackupButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(74, 26);
            this.BackupButton.TabIndex = 16;
            this.BackupButton.Text = "&Backup SPI";
            this.BackupButton.UseVisualStyleBackColor = false;
            // 
            // EraseButton
            // 
            this.EraseButton.BackColor = System.Drawing.Color.White;
            this.EraseButton.Enabled = false;
            this.EraseButton.Location = new System.Drawing.Point(156, 22);
            this.EraseButton.Margin = new System.Windows.Forms.Padding(2);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(70, 26);
            this.EraseButton.TabIndex = 15;
            this.EraseButton.Text = "&Erase";
            this.EraseButton.UseVisualStyleBackColor = false;
            // 
            // FlashButton
            // 
            this.FlashButton.BackColor = System.Drawing.Color.White;
            this.FlashButton.Enabled = false;
            this.FlashButton.Location = new System.Drawing.Point(83, 22);
            this.FlashButton.Margin = new System.Windows.Forms.Padding(2);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(70, 26);
            this.FlashButton.TabIndex = 14;
            this.FlashButton.Text = "&Flash";
            this.FlashButton.UseVisualStyleBackColor = false;
            this.FlashButton.Click += new System.EventHandler(this.FlashButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(93, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.AutoUART,
            this.RefreshButton});
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.communicationToolStripMenuItem.Text = "Communication";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FastButton,
            this.SlowButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Speed";
            // 
            // FastButton
            // 
            this.FastButton.Checked = true;
            this.FastButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FastButton.Name = "FastButton";
            this.FastButton.Size = new System.Drawing.Size(110, 22);
            this.FastButton.Text = "&115200";
            this.FastButton.Click += new System.EventHandler(this.FastButton_Click);
            // 
            // SlowButton
            // 
            this.SlowButton.Name = "SlowButton";
            this.SlowButton.Size = new System.Drawing.Size(110, 22);
            this.SlowButton.Text = "1&9200";
            this.SlowButton.Click += new System.EventHandler(this.SlowButton_Click);
            // 
            // AutoUART
            // 
            this.AutoUART.CheckOnClick = true;
            this.AutoUART.Name = "AutoUART";
            this.AutoUART.Size = new System.Drawing.Size(186, 22);
            this.AutoUART.Text = "&Auto UART after flash";
            this.AutoUART.CheckedChanged += new System.EventHandler(this.AutoUART_CheckedChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(186, 22);
            this.RefreshButton.Text = "Refresh COM devices";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ComPorts
            // 
            this.ComPorts.Name = "ComPorts";
            this.ComPorts.Size = new System.Drawing.Size(121, 23);
            this.ComPorts.SelectedIndexChanged += new System.EventHandler(this.ComPorts_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.communicationToolStripMenuItem,
            this.ComPorts});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(322, 27);
            this.menu.TabIndex = 17;
            this.menu.Text = "menuStrip1";
            // 
            // Flasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UartLog);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Flasher";
            this.Text = "Radtel RT-890 Flasher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox FilenameBox;
		private System.Windows.Forms.Button PickButton;
		private System.Windows.Forms.Label Copyright;
		private System.Windows.Forms.TextBox UartLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button FlashButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FastButton;
        private System.Windows.Forms.ToolStripMenuItem SlowButton;
        private System.Windows.Forms.ToolStripMenuItem AutoUART;
        private System.Windows.Forms.ToolStripMenuItem RefreshButton;
        private System.Windows.Forms.ToolStripComboBox ComPorts;
        private System.Windows.Forms.MenuStrip menu;
    }
}

