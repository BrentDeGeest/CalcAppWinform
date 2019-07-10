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
using System.Diagnostics;

namespace ProjectWinforms
{
    public partial class Calculator : Form
    {
        char[] delimiterChars = { '+', '/', '*' };
        Calculation calc = new Calculation();

        double num1;
        double num2;

        string oper; 


        public Calculator()
        {
            InitializeComponent();
        }

        private void GetNumber() // Zet num1 of num2 op het nummer in de textbox
        {
            string[] nummers = ResultTextBox.Text.Split(delimiterChars);
            foreach (string num in nummers)
            {
                calc.ConvertNumbers(ref num1, ref num2, num);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length < 10|| num1 != 0)
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
            num1 = 0;
            num2 = 0;
            Debug.WriteLine("nummer 1(Reset): " + num1);
            Debug.WriteLine("nummer 2(Reset): " + num2);
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
            GetNumber();

            oper = "/";
            CalculationTextBox.Text = num1.ToString() + " / ";
            ResultTextBox.Text = "";
        }

        private void MaalButton_Click(object sender, EventArgs e)
        {
            GetNumber();

            oper = "*";
            CalculationTextBox.Text = num1.ToString() + " * ";
            ResultTextBox.Text = "";
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            GetNumber();

            oper = "-";
            CalculationTextBox.Text = num1.ToString() + " - ";
            ResultTextBox.Text = "";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            GetNumber();

            oper = "+";
            CalculationTextBox.Text = num1.ToString() + " + ";
            ResultTextBox.Text = "";
        }

        private void GelijkButton_Click(object sender, EventArgs e)
        {
            GetNumber();
            CalculationTextBox.Text += ResultTextBox.Text;
            switch (oper)
            {
                case "+": num1 += num2; num2 = 0; break;
                case "-": num1 -= num2; num2 = 0; break;
                case "*": num1 *= num2; num2 = 0; break;
                case "/": num1 /= num2; num2 = 0; break;
                default: break;
            }
            CalculationTextBox.Text = num1.ToString();
            Debug.WriteLine("nummer 1(GelijkAan): " + num1);
            Debug.WriteLine("nummer 2(GelijkAan): " + num2);
        }

        private void PuntButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += ",";
        }

        private void PosNegButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = calc.PosNeg(ResultTextBox.Text);
        }

        
    }
}
