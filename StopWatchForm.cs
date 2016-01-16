/*
 * Created by SharpDevelop.
 * User: Steve
 * Date: 1/13/2016
 * Time: 12:50 PM
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace stopwatch
{
	/// <summary>
	/// Just a simple stopwatch application.
	/// </summary>
	public partial class StopWatchForm : Form
	{
		public StopWatchForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			timerStopWatch.Interval = 1000;
			
		}
//		global elapsed = 0;
		int elapsed = 0;
		void timerStopWatchTick(object sender, EventArgs e)
		{
			 
			 elapsed += 1;
			 lblTime.Text = elapsed.ToString();
		}
		void btnStartClick(object sender, EventArgs e)
		{
			if( timerStopWatch.Enabled == false){
				timerStopWatch.Start();
				btnStart.Text = "Stop";
				toolStripMenuItemStart.Text = "Stop";
			}
			else {
				timerStopWatch.Stop();
				btnStart.Text = "Start";
				toolStripMenuItemStart.Text = "Start";
			}
		}
		void NotifyIcon1DoubleClick(object sender, EventArgs e)
		{
		if(this.Visible == true)
				this.Hide();
			else
				this.Show();
		}
		void ToolStripMenuItemExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			timerStopWatch.Stop();
			elapsed = 0;
			lblTime.Text = 0.ToString();
		}
		
	}
}
