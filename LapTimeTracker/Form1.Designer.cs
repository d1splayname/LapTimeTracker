
namespace LapTimeTracker
{
	partial class LapTimer_Form
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Start_Button = new System.Windows.Forms.Button();
			this.OutputLocation_TextBox = new System.Windows.Forms.TextBox();
			this.OutputPath_Label = new System.Windows.Forms.Label();
			this.LastTime_Label = new System.Windows.Forms.Label();
			this.LapTimesLog_Textbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Start_Button
			// 
			this.Start_Button.Location = new System.Drawing.Point(12, 33);
			this.Start_Button.Name = "Start_Button";
			this.Start_Button.Size = new System.Drawing.Size(75, 23);
			this.Start_Button.TabIndex = 1;
			this.Start_Button.Text = "Start";
			this.Start_Button.UseVisualStyleBackColor = true;
			this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
			// 
			// OutputLocation_TextBox
			// 
			this.OutputLocation_TextBox.Location = new System.Drawing.Point(93, 12);
			this.OutputLocation_TextBox.Name = "OutputLocation_TextBox";
			this.OutputLocation_TextBox.Size = new System.Drawing.Size(250, 23);
			this.OutputLocation_TextBox.TabIndex = 2;
			this.OutputLocation_TextBox.Text = "output";
			// 
			// OutputPath_Label
			// 
			this.OutputPath_Label.AutoSize = true;
			this.OutputPath_Label.Location = new System.Drawing.Point(12, 15);
			this.OutputPath_Label.Name = "OutputPath_Label";
			this.OutputPath_Label.Size = new System.Drawing.Size(63, 15);
			this.OutputPath_Label.TabIndex = 3;
			this.OutputPath_Label.Text = "File Name:";
			// 
			// LastTime_Label
			// 
			this.LastTime_Label.AutoSize = true;
			this.LastTime_Label.Location = new System.Drawing.Point(93, 37);
			this.LastTime_Label.Name = "LastTime_Label";
			this.LastTime_Label.Size = new System.Drawing.Size(85, 15);
			this.LastTime_Label.TabIndex = 4;
			this.LastTime_Label.Text = "Last Lap Time: ";
			// 
			// LapTimesLog_Textbox
			// 
			this.LapTimesLog_Textbox.Location = new System.Drawing.Point(349, 12);
			this.LapTimesLog_Textbox.Multiline = true;
			this.LapTimesLog_Textbox.Name = "LapTimesLog_Textbox";
			this.LapTimesLog_Textbox.ReadOnly = true;
			this.LapTimesLog_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LapTimesLog_Textbox.Size = new System.Drawing.Size(439, 426);
			this.LapTimesLog_Textbox.TabIndex = 5;
			this.LapTimesLog_Textbox.TabStop = false;
			// 
			// LapTimer_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LapTimesLog_Textbox);
			this.Controls.Add(this.LastTime_Label);
			this.Controls.Add(this.OutputPath_Label);
			this.Controls.Add(this.OutputLocation_TextBox);
			this.Controls.Add(this.Start_Button);
			this.Name = "LapTimer_Form";
			this.Text = "Lap Timer";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LapTimer_Form_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Start_Button;
		private System.Windows.Forms.TextBox OutputLocation_TextBox;
		private System.Windows.Forms.Label OutputPath_Label;
		private System.Windows.Forms.Label LastTime_Label;
		private System.Windows.Forms.TextBox LapTimesLog_Textbox;
	}
}

