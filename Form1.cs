using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            myLabel.Text = curDate.ToShortDateString() + " " + curDate.ToLongTimeString();

            if (chkOnOff.Checked)
            {
                DateTime alarmTime = new DateTime(pickerDateTime.Value.Year, pickerDateTime.Value.Month, pickerDateTime.Value.Day, pickerDateTime.Value.Hour, pickerDateTime.Value.Minute, 0);
                TimeSpan ts = alarmTime - curDate;

                if (ts.Seconds == 0)
                {
                    TimerBoom();
                }
            }
        }

        private void TimerBoom()
        {
            chkOnOff.Checked = false;
            frmWMP newFormWMP = new frmWMP();
            newFormWMP.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout newFormAbout = new frmAbout();
            newFormAbout.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.F11 | Keys.Control | Keys.Shift))
            {
                chkOnOff.Checked = !chkOnOff.Checked;
            }
        }
    }
}
