using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LapTimeTracker
{
	public partial class LapTimer_Form : Form
	{
		public DateTime startTime;
		public int lapCount = 1;

		public string fileName;

		public LapTimer_Form()
		{
			InitializeComponent();
		}

		private void LapTimer_Form_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				if (Start_Button.Text == "Start")
				{
					startTime = DateTime.Now;
					Start_Button.Text = "Lap";
					fileName = OutputLocation_TextBox.Text;
					for (int i = 0; i < 100; i++)
					{
						if (File.Exists(fileName + i + ".csv"))
						{
							continue;
						}
						else
						{
							using (StreamWriter fileWrite = File.CreateText(fileName + i + ".csv"))
							{
								fileWrite.WriteLine("Lap, Time");
							}

							fileName = fileName + i + ".csv";

							break;
						}
					}
				}
				else
				{
					WriteLapTime(DateTime.Now);

					lapCount++;
				}
			}
		}

		private void WriteLapTime(DateTime lapDateTime)
		{
			TimeSpan lapTime = lapDateTime - startTime;

			using (StreamWriter fileWriter = File.AppendText(fileName))
			{
				fileWriter.WriteLine($"{lapCount},{lapTime.Minutes}:{lapTime.Seconds}.{lapTime.Milliseconds}");
			}

			// Reassign current time back to start time variable so it can be used to calculate next lap time.
			startTime = lapDateTime;

			LastTime_Label.Text = $"Last Lap Time: {lapTime.Minutes}:{lapTime.Seconds}.{lapTime.Milliseconds}";
			LapTimesLog_Textbox.AppendText($"{lapCount} - { lapTime.Minutes}:{ lapTime.Seconds}.{ lapTime.Milliseconds}");
			LapTimesLog_Textbox.AppendText("\r\n");
		}

		private void Start_Button_Click(object sender, EventArgs e)
		{
			if (Start_Button.Text == "Start")
			{
				startTime = DateTime.Now;
				Start_Button.Text = "Lap";
				fileName = OutputLocation_TextBox.Text;
				for (int i = 0; i < 100; i++)
				{
					if (File.Exists(fileName + i + ".csv"))
					{
						continue;
					}
					else
					{
						using (StreamWriter fileWrite = File.CreateText(fileName + i + ".csv"))
						{
							fileWrite.WriteLine("Lap, Time");
						}

						fileName = fileName + i + ".csv";

						break;
					}
				}
			}
			else
			{
				WriteLapTime(DateTime.Now);

				lapCount++;
			}
		}
	}
}