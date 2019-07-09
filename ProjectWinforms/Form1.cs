using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinforms
{
    public partial class Calculator : Form
    {

        

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '1';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '2';

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '3';

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '4';

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '5';

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '6';

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '7';

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '8';

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '9';

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text += '0';

        }

        private void Reset()
        {
            ResultTextBox.Text = "0";

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void DeelButton_Click(object sender, EventArgs e)
        {

        }

        private void MaalButton_Click(object sender, EventArgs e)
        {

        }

        private void MinButton_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }

        private void GelijkButton_Click(object sender, EventArgs e)
        {

        }

        private void PuntButton_Click(object sender, EventArgs e)
        {

        }

        private void PosNegButton_Click(object sender, EventArgs e)
        {

        }
    }
}
