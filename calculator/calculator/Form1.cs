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
            Button_Click(BtnAdd, e);
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            Button_Click(BtnSub, e);
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            Button_Click(BtnMul, e);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

            Button_Click(BtnDiv, e);
        }
    

    private void Button_Click(object sender, EventArgs e)
        {

            double first = Convert.ToDouble(TBArg1.Text);
            double second = Convert.ToDouble(TBArg2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "BtnAdd":
	                result = first + second;
		            break;
	            case "BtnSub":
	                result = first - second;
		            break;
	            case "BtnMul":
	                result = first * second;
		            break;
	            case "BtnDiv":
	                result = first / second;
		            break;
	            default:
                    throw new Exception("Неизвестная операция");
  
            }
            TBRes.Text = result.ToString();
        }
    }
}
