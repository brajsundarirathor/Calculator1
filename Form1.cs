using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double previousNumber = -1;
        double nextNumber = -1;
        double result = 0;
        string OperationFlag = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum1_click(object sender, EventArgs e)     // For button NUmber 1
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "1";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "1";
            }
            if (txtOutput.Text.Length == 12)      // for checking the range of length
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum2_click(object sender, EventArgs e)   // for number 2
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "2";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "2";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum3_click(object sender, EventArgs e)   // for number 3
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "3";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "3";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum4_click(object sender, EventArgs e)   // for number 4
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "4";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "4";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum5_click(object sender, EventArgs e)   // for number 5
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "5";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "5";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum6_click(object sender, EventArgs e)   // for number 6
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "6";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "6";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum7_click(object sender, EventArgs e)    // for number 7
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "7";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "7";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum8_click(object sender, EventArgs e)   // for number 8
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "8";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "8";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum9_click(object sender, EventArgs e)    // for number 9
        {
            if (txtOutput.Text == "0" && txtOutput.Text != null)
            {
                txtOutput.Text = "9";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "9";
            }
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnNum0_click(object sender, EventArgs e)    // for number 0
        {
            txtOutput.Text = txtOutput.Text + "0";
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnBack_click(object sender, EventArgs e)    // for Back button 
        {
            txtOutput.Text = (txtOutput.Text.Length > 0) ? txtOutput.Text.Substring(0, txtOutput.Text.Length - 1) : "0";
            if (txtOutput.Text == "")
            {
                txtOutput.Text = "0";
            }
        }

        private void btnClear_click(object sender, EventArgs e)   // for Clear button
        {
            txtOutput.Clear();
            previousNumber = -1;
            txtOutput.Text = "0";
            lblHistroy.Text = "";
        }

        private void txtOutput_Changed(object sender, EventArgs e)    // for  output textbox 
        {
            if (txtOutput.Text.Length == 12)
            {
                MessageBox.Show("You Reach to Maximum Number of Length !!");
            }
            if (txtOutput.Text.Length > 12)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, 12);
            }
        }

        private void btnDot_click(object sender, EventArgs e)    // for Dot button
        {
            if(btnDot.Text == ".")
            {
                if (!txtOutput.Text.Contains("."))
                {
                    txtOutput.Text = txtOutput.Text + ".";
                }
            }
            else
            {
                txtOutput.Text = txtOutput.Text = txtOutput.Text + ".";
            }
        }

        private void btnAdd_click(object sender, EventArgs e)    // for Addition button
        {
            OperationFlag = "A";
            lblHistroy.Text = txtOutput.Text + "+";
            previousNumber = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnSub_click(object sender, EventArgs e)   // for Subtraction button
        {
            OperationFlag = "S";
            lblHistroy.Text = txtOutput.Text + "-";
            previousNumber = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnMult_click(object sender, EventArgs e)    // for Multiply button
        {
            OperationFlag = "M";
            lblHistroy.Text = txtOutput.Text + "x";
            previousNumber = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnDiv_click(object sender, EventArgs e)    // for Division button
        {
            OperationFlag = "D";
            lblHistroy.Text = txtOutput.Text + "/";
            previousNumber = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnPow_click(object sender, EventArgs e)   // for Power button
        {            
            lblHistroy.Text = txtOutput.Text + "pow";
            previousNumber = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "0";
            result = Math.Pow(previousNumber, 2);
            txtOutput.Text = Convert.ToString(result);
            previousNumber = result;
        }

        private void btnSqrt_Click(object sender, EventArgs e)   // for Sqrt button
        {
            lblHistroy.Text = txtOutput.Text + "sqrt";
            previousNumber = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = "0";
            result = Math.Sqrt(previousNumber);
            txtOutput.Text = Convert.ToString(result);
            previousNumber = result;
        }

        private void btnEqual_click(object sender, EventArgs e)   // for Equal button
        {
            nextNumber = Convert.ToDouble(txtOutput.Text);
            if (previousNumber > -1)
            {
                switch (OperationFlag)
                {
                    case "A":       // for + operation
                        lblHistroy.Text += txtOutput.Text + "=";
                        result = previousNumber + nextNumber;
                        txtOutput.Text = Convert.ToString(result);
                        previousNumber = result;
                        break;
                    case "S":      // for - operation
                        lblHistroy.Text += txtOutput.Text + "=";
                        result = previousNumber - nextNumber;
                        txtOutput.Text = Convert.ToString(result);
                        previousNumber = result;
                        break;
                    case "M":     // for * operation
                        lblHistroy.Text += txtOutput.Text + "=";
                        result = previousNumber * nextNumber;
                        txtOutput.Text = Convert.ToString(result);
                        previousNumber = result;
                        break;
                    case "D":    // for / operation
                        if (nextNumber != 0)
                        {
                            lblHistroy.Text += txtOutput.Text + "=";
                            result = previousNumber / nextNumber;
                            txtOutput.Text = Convert.ToString(result);
                            previousNumber = result;
                        }
                        else
                        {
                            txtOutput.Text = "Can't Divide by Zero";
                        }
                        break;                  
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Number !!");
            }
        }      
    }
}
