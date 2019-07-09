using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorAppLibrary;

namespace ProjectWinforms
{
    public partial class Calculator : Form
    {
        char[] delimiterChars = { '+', '-', '/', '*' };
        DataTable dataTable = new DataTable();
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            int newNum;
            string[] test = ResultTextBox.Text.Split(delimiterChars);
            foreach (string num in test)
            {
                if(num != null && num != "")
                {
                    Console.WriteLine(num);
                    newNum = Convert.ToInt32(num);
                    if (temp1 == 0)
                    {
                        temp1 = newNum;
                    }
                    else
                    {
                        temp2 = newNum;
                    }
                }
            }
        }
        */
        private void Button1_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '1';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '2';

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '3';

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '4';

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '5';

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '6';

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '7';

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '8';

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '9';

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '0';

        }

        private void Reset()
        {
            ResultTextBox.Text = "";
            CalculationTextBox.Text = "";
            
        }



        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTextBox.Text = ResultTextBox.Text.Remove(ResultTextBox.Text.Length - 1);
            }
            catch (Exception)
            {

            }
            

        }

        private void DeelButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += "/";

        }

        private void MaalButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += "*";

        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += "-";


        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += "+";

        }

        private void GelijkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CalculationTextBox.Text = ResultTextBox.Text;
                ResultTextBox.Text = dataTable.Compute(ResultTextBox.Text, null).ToString();
            }
            catch (Exception)
            {

                Console.WriteLine("Error, resetting values.");
                Reset();
            } 
        }

        private void PuntButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += ".";

        }

        private void PosNegButton_Click(object sender, EventArgs e)
        {
            try
            {
                double numSwitch = Convert.ToDouble(ResultTextBox.Text);
                numSwitch *= -1;
                ResultTextBox.Text = numSwitch.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
