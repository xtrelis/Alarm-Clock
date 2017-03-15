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
    public partial class frmWMP : Form
    {
        public frmWMP()
        {
            InitializeComponent();
        }

        private void frmWMP_Shown(object sender, EventArgs e)
        {
            try
            {
                myWMPlayer.settings.autoStart = true;
                myWMPlayer.URL = @"https://www.youtube.com/v/TcLKvJEtm8c&autoplay=1";
                myWMPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Υπάρχει πρόβλημα στην αναπαραγωγή του βίντεο.");
            }
        }

        private void btnSnooze_Click(object sender, EventArgs e)
        {
            myWMPlayer.Ctlcontrols.stop();
            Close();
        }
    }
}
