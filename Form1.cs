using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__2__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txtX0.Text);
            double xk = Convert.ToDouble(txtXk.Text);
            double dx = Convert.ToDouble(txtDx.Text);
            double a = Convert.ToDouble(txtA.Text);
            txt.Text = "Работу выполнила студент Коршикова Э.П." + Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Log(x);
                txt.Text += "x = " + Convert.ToString(x) + "; y = "
                    + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
