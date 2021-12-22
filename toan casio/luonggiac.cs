using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class luonggiac : Form
    {
        public luonggiac()
        {
            InitializeComponent();
        }
      double rad;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            txt2.Clear();
            txt2cos.Clear();
            txt2cotan.Clear();
            txt2sin.Clear();
            txt2tan.Clear();
            lblnhap2.Text = "";
        }

        private void btn2sin_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = (Math.Sin(Math.PI * rad / 180));
                txt2sin.Text = rad.ToString();
            }
            else txt2sin.Text = "nhap so";
        }

        private void btn2cos_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = (Math.Cos(Math.PI * rad / 180));
                txt2cos.Text = rad.ToString();
            }
            else txt2cos.Text = "nhap so";
        }

        private void btn2tan_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = ((Math.Sin(Math.PI * rad / 180)) / (Math.Cos(Math.PI * rad / 180)));
                txt2tan.Text = rad.ToString();
            }
            else txt2tan.Text = "nhap so";
        }

        private void btn2cotan_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = ((Math.Cos(Math.PI * rad / 180)) / (Math.Sin(Math.PI * rad / 180)));
                txt2cotan.Text = rad.ToString();
            }
            else txt2cotan.Text = "nhap so";
        }


        private void txt2_TextChanged(object sender, EventArgs e)
        {
            lblnhap2.Text = txt2.Text + "°";
        }

    }
}