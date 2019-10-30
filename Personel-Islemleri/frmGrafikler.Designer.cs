namespace Personel_Islemleri
{
	partial class frmGrafikler
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
			this.xuıClock1 = new XanderUI.XUIClock();
			this.SuspendLayout();
			// 
			// xuıClock1
			// 
			this.xuıClock1.CircleThickness = 6;
			this.xuıClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
			this.xuıClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
			this.xuıClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
			this.xuıClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
			this.xuıClock1.Font = new System.Drawing.Font("Impact", 15F);
			this.xuıClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
			this.xuıClock1.Location = new System.Drawing.Point(107, 194);
			this.xuıClock1.Name = "xuıClock1";
			this.xuıClock1.ShowAmPm = false;
			this.xuıClock1.ShowHexagon = true;
			this.xuıClock1.ShowMinutesCircle = true;
			this.xuıClock1.ShowSecondsCircle = true;
			this.xuıClock1.Size = new System.Drawing.Size(120, 130);
			this.xuıClock1.TabIndex = 0;
			this.xuıClock1.Text = "xuıClock1";
			this.xuıClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
			this.xuıClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
			this.xuıClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
			// 
			// frmGrafikler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.xuıClock1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmGrafikler";
			this.Text = "frmGrafikler";
			this.ResumeLayout(false);

		}

		#endregion

		private XanderUI.XUIClock xuıClock1;
	}
}