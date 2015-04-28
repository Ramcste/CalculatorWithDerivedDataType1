using System;

using System.Windows.Forms;

namespace CalculatorWithDerivedDataType
{
    public partial class CalculatorUi : Form
    {
        Calculator aNumber =new Calculator();

        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            

            reultTextBox.Text = aNumber.GetAddition(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text)).ToString();
        
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
           

            reultTextBox.Text = aNumber.GetSubtraction(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text)).ToString();
        
        }

      

        private void multiplyButton_Click(object sender, EventArgs e)
        {
                                
            reultTextBox.Text = aNumber.GetMultiplication(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text)).ToString();
        
        }
        

        private void divideButton_Click(object sender, EventArgs e)
        {
            
             reultTextBox.Text = aNumber.GetDivision(double.Parse(firstNumberTextBox.Text), double.Parse(secondNumberTextBox.Text)).ToString();

        }

        
    }
}
