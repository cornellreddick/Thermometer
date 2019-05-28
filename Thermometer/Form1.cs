using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int degrFahr = 200 - vScrollBar1.Value;
            double cent = (degrFahr - 32.0)*(5.0/9.0);

            flabel.Text = degrFahr.ToString();
            clabel.Text = Convert.ToInt16(cent).ToString();
        }
            
    }
}
