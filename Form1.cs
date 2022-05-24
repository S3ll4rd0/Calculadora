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
    }
}
