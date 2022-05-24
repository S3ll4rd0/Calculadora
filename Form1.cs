using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "+";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "/";
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "*";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += "0";
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            txt_operacion.Text += ".";
        }
    }
}
