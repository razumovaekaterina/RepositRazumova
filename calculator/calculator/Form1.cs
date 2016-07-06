using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(TBArg1.Text);
            double second = Convert.ToDouble(TBArg2.Text);
            double result = first + second;
            TBRes.Text = result.ToString();

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(TBArg1.Text);
            double second = Convert.ToDouble(TBArg2.Text);
            double result = first - second;
            TBRes.Text = result.ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(TBArg1.Text);
            double second = Convert.ToDouble(TBArg2.Text);
            double result = first * second;
            TBRes.Text = result.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

            double first = Convert.ToDouble(TBArg1.Text);
            double second = Convert.ToDouble(TBArg2.Text);
            double result = first / second;
            TBRes.Text = result.ToString();
        }
    }
}
