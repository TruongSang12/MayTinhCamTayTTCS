using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class loglncs : Form
    {
        public loglncs()
        {
            InitializeComponent();
        }
        double log;
        const double E = 2.718281828;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtln.Text="";
            txtlog.Text="";
            txtnlog.Text="";
            txtnlog.Focus();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtnlog.Text != "")
            {
                log =Convert.ToDouble(txtnlog.Text);
                if (log > 0)
                {
                    log = Math.Log10(log);
                    txtlog.Text = log.ToString();
                }
                else txtlog.Text = "Error";
            }
            else txtlog.Text  = "nhap co so";         
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            if (txtnlog.Text != "")
            {
                log =Convert.ToDouble(txtnlog.Text);
                if (log > 0)
                {
                log = Math.Log(log,E);
                txtln.Text = log.ToString();
                }
                else txtln.Text = "Error";
            }
            else txtlog.Text = "nhap co so"; 
        }
        private void txtnlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }




    }
}