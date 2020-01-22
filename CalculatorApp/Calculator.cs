using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private string displayText = "0";
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        private double Result { get; set; }
        private string operation;

        public Calculator()
        {
            InitializeComponent();
            this.TextSelectionRemove();
            this.Clear();
        }

        private void TextSelectionRemove()
        {
            this.txtDisplay.SelectionLength = 0;
            this.txtDisplay.SelectionStart= this.txtDisplay.Text.Length;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!this.txtDisplay.Text.Contains("."))
            {
                
                this.txtDisplay.AppendText(".");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.displayText != "0")
            {
                this.txtDisplay.AppendText("0");
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.Text = "0";
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "0";
            this.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "1";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("1");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "2";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("2");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "3";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("3");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "4";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("4");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "5";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("5");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "6";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("6");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "7";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("7");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "8";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("8");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.displayText == "0")
            {
                this.txtDisplay.Text = "9";
                this.displayText = this.txtDisplay.Text;
            }
            else
            {
                this.txtDisplay.AppendText("9");
                this.displayText = this.txtDisplay.Text;
            }
        }

        private void txtDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            this.TextSelectionRemove();
        }

        private void txtDisplay_DoubleClick(object sender, EventArgs e)
        {
            this.TextSelectionRemove();
        }

        private void Clear()
        {
            this.Number1 = 0;
            this.Number2 = 0;
            this.Result = 0;
            this.displayText = "0";
            this.operation = null;
        }
        private void Addition()
        {
            this.Result =this.Number1 + this.Number2;
           // this.operation = null;

        }
        private void Subtraction()
        {
            this.Result = this.Number1 - this.Number2;
            //this.operation = null;
        }
        private void Multiplication()
        {
            this.Result = this.Number1 * this.Number2;
            //this.operation = null;
        }
        private void Division()
        {
            if (Number2 != 0)
            {
                this.Result = this.Number1 / this.Number2;
                //this.operation = null;
            }
            else
            {
                
                MessageBox.Show("Cannot divided by zero", "Error");
                this.txtDisplay.Text = "0";
                this.Clear();
            }
        }
       

        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            
                this.Number1 = Convert.ToDouble(this.txtDisplay.Text);
                this.operation = "+";
                this.displayText = "0";
                
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            
                this.Number1 = Convert.ToDouble(this.txtDisplay.Text);
                this.operation = "-";
                this.displayText = "0";
                
            
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            
                this.Number1 = Convert.ToDouble(this.txtDisplay.Text);
                this.operation = "*";
                this.displayText = "0";
                
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            
                this.Number1 = Convert.ToDouble(this.txtDisplay.Text);
                this.operation = "/";
                this.displayText = "0";
                
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.Equal();
        }

        private void Equal()
        {
            this.Number2 = Convert.ToDouble(this.txtDisplay.Text);
            if (operation == "+")
            {
                this.Addition();
            }
            else if (operation == "-")
            {
                this.Subtraction();
            }
            else if (operation == "*")
            {
                this.Multiplication();
            }
            else if (operation == "/")
            {
                this.Division();
            }
            this.Number1 = Result;
            this.txtDisplay.Text = this.Result.ToString();
            this.displayText = "0";
            //MessageBox.Show(Result.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text.Remove(this.txtDisplay.Text.Length - 1, 1);
            if (this.txtDisplay.Text.Length == 0)
            {
                this.txtDisplay.Text = "0";
            }
            this.displayText = this.txtDisplay.Text;
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
