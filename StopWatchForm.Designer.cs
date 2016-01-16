/*
 * Created by SharpDevelop.
 * User: Steve
 * Date: 1/13/2016
 * Time: 12:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace stopwatch
{
	partial class StopWatchForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timerStopWatch;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.ContextMenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.Button btnReset;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatchForm));
			this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// timerStopWatch
			// 
			this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatchTick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.mainMenu;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1DoubleClick);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemStart,
			this.toolStripMenuItemExit});
			this.mainMenu.Name = "contextMenuStrip1";
			this.mainMenu.Size = new System.Drawing.Size(99, 48);
			// 
			// toolStripMenuItemStart
			// 
			this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
			this.toolStripMenuItemStart.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItemStart.Text = "Start";
			this.toolStripMenuItemStart.Click += new System.EventHandler(this.btnStartClick);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItemExit.Text = "Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExitClick);
			// 
			// btnStart
			// 
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStart.Location = new System.Drawing.Point(12, 62);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStartClick);
			// 
			// lblTime
			// 
			this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(44, 9);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(100, 23);
			this.lblTime.TabIndex = 1;
			this.lblTime.Text = "0";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnReset
			// 
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Location = new System.Drawing.Point(93, 62);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// StopWatchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(198, 104);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.btnStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StopWatchForm";
			this.Text = "stopwatch";
			this.mainMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
