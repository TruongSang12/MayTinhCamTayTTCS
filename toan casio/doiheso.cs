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
    public partial class doiheso : Form
    {
        public doiheso()
        {
            InitializeComponent();
        }

        private void doiheso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Strconvert = textBox1.Text;
            int Decimals;
            string x;

            // Decimal
            if (comboBox1.Text == "Decimal")
                if (comboBox2.Text == "Binary")
                {
                    Decimals = Convert.ToInt32(Strconvert);
                    x = Convert.ToString(Decimals, 2);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Octal")
                {
                    Decimals = Convert.ToInt32(Strconvert);
                    x = Convert.ToString(Decimals, 8);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Hexadecimal")
                {
                    Decimals = Convert.ToInt32(Strconvert);
                    x = Convert.ToString(Decimals, 16);
                    textBox2.Text = x;
                }
                else if (comboBox2.Text == "Decimal")
                    textBox2.Text = textBox1.Text;
            // Binary
            if (comboBox1.Text == "Binary")
                if (comboBox2.Text == "Decimal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 2);
                    textBox2.Text = Decimals.ToString();
                }
                else
                    if (comboBox2.Text == "Octal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 2);
                    x = Convert.ToString(Decimals, 8);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Hexadecimal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 2);
                    x = Convert.ToString(Decimals, 16);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Binary")
                    textBox2.Text = textBox1.Text;

            //Octal
            if (comboBox1.Text == "Octal")
                if (comboBox2.Text == "Decimal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 8);
                    textBox2.Text = Decimals.ToString();
                }
                else
                    if (comboBox2.Text == "Binary")
                {
                    Decimals = Convert.ToInt32(Strconvert, 8);
                    x = Convert.ToString(Decimals, 2);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Hexadecimal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 8);
                    x = Convert.ToString(Decimals, 16);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Octal")
                    textBox2.Text = textBox1.Text;

            //Hexadecimal
            if (comboBox1.Text == "Hexadecimal")
                if (comboBox2.Text == "Decimal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 16);
                    textBox2.Text = Decimals.ToString();
                }
                else
                    if (comboBox2.Text == "Octal")
                {
                    Decimals = Convert.ToInt32(Strconvert, 16);
                    x = Convert.ToString(Decimals, 8);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Binary")
                {
                    Decimals = Convert.ToInt32(Strconvert, 16);
                    x = Convert.ToString(Decimals, 2);
                    textBox2.Text = x;
                }
                else
                    if (comboBox2.Text == "Hexadecimal")
                    textBox2.Text = textBox1.Text;
        }
    }
}
