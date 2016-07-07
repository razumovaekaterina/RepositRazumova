using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator.OneArgument;
using calculator.TwoArguments;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(TBArg1.Text);
                double second = Convert.ToDouble(TBArg2.Text);
                ITwoArgumentCalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(first, second); ;
                TBRes.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Сообщение об ошибке: " + exc.Message);
            }
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(TBArg1.Text);
                IOneArgumentCalculator calculator = OneArgumentCalculatorFactory.CreateCalculator(((Button) sender).Name);

                double result = calculator.Calculate(first);
                ;
                TBRes.Text = result.ToString();

            }
            catch (Exception exc)
            {
                if (exc.Message == "-")
                {
                    TBRes.Text = "-";
                }
                else
                {
                    MessageBox.Show("Сообщение об ошибке: " + exc.Message);    
                }
                
            }
        }
    }
}
