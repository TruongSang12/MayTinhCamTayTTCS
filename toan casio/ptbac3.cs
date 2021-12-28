using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ptbac3 : Form
    {
        public ptbac3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            txt_d.Clear();
            lbl_kq.Text = "";
            lbl_pt.Text = "";
            txt_a.Focus();
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x² + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x² + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x² + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_d_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x² + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);
            double d = Convert.ToDouble(txt_d.Text);
            double delta, k, x, x1, x2, x3;
            delta = b * b - 3 * a * c;
            k = (9 * a * b * c - 2 * b * b * b - 27 * a * a * d) / (2 * Math.Sqrt(Math.Pow(Math.Abs(delta), 3)));
            if(delta > 0)
            {
                if (Math.Abs(k) <= 1)
                {
                    x1 = (2 * Math.Sqrt(delta) * Math.Cos(Math.Acos(k) / 3) - b) / (3 * a);
                    x2 = (2 * Math.Sqrt(delta) * Math.Cos(Math.Acos(k) / 3 - (2 * Math.PI / 3)) - b) / (3 * a);
                    x3 = (2 * Math.Sqrt(delta) * Math.Cos(Math.Acos(k) / 3 + (2 * Math.PI / 3)) - b) / (3 * a);
                    lbl_kq.Text = "phuong trinh co 3 nghiem:\nx1 = " + x1 + "\nx2 = " + x2 + "\nx3 = " + x3;
                }
                if (Math.Abs(k) > 1)
                {
                    x = ((Math.Sqrt(delta) * Math.Abs(k)) / (3 * a * k)) * (Math.Pow((Math.Abs(k) + Math.Sqrt(k * k - 1)), 1.0 / 3) + Math.Pow((Math.Abs(k) - Math.Sqrt(k * k - 1)), 1.0 / 3)) - (b/(3*a));
                    lbl_kq.Text = "phuong trinh co nghiem duy nhất: x = " + x;
                }
            }    
            else if(delta == 0)
            {
                x = (-b + Math.Pow(b * b * b - 27 * a * a * d, 1.0 / 3)) / (3 * a);
                lbl_kq.Text = "phuong trinh co nghiem boi: x = " + x;
            }    
            else
            {
                x = ((Math.Sqrt(delta) * Math.Abs(k)) / (3 * a * k)) * (Math.Pow((Math.Abs(k) + Math.Sqrt(k * k - 1)), 1.0 / 3) + Math.Pow((Math.Abs(k) - Math.Sqrt(k * k - 1)), 1.0 / 3)) - (b / (3 * a));
                lbl_kq.Text = "phuong trinh co nghiem duy nhất: x = " + x;
            }    

        }
    }
}
