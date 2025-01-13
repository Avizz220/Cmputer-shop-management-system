using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DESKTOP_APP.Allusercontrol
{
    public partial class UC_WELCOME : UserControl
    {
        public UC_WELCOME()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(97, 367);
                labelBanner.ForeColor = Color.Blue;
                num++;

            }

            else if (num == 1)
            {
                labelBanner.Location = new Point(166, 367);
                labelBanner.ForeColor = Color.Red;
                num++;

            }
           else  if (num == 2)
            {
                labelBanner.Location = new Point(268, 367);
                labelBanner.ForeColor = Color.Brown;
                num = 0;

            }
        }

        private void labelBanner_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
