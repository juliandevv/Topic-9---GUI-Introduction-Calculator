using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___GUI_Introduction_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Visible = true;
        }

        string sign;
        double result;
        double num1, num2;
        Boolean err;
       

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string num1 = input1.Text;
            lblNumber1.Text = num1.ToString();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {
            lblHeader.Location = new Point(ClientSize.Width / 2, 9);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblNumber1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumber2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            string num2 = input2.Text;
            lblNumber2.Text = num2.ToString();
        }

        private void lblOperator_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            error.Clear();
            sign = comboBox1.Text;
            if (sign == "sqrt")
            {
                lblNumber2.Visible = false;
                input2.Visible = false;
                lblNumber1.Visible = true;
                input1.Visible = true;
                num2 = 0;
                input2.Text = "0";
            }

            else if (sign == "sin")
            {
                lblNumber1.Visible = false;
                input1.Visible = false;
                lblNumber2.Visible = true;
                input2.Visible = true;
                num1 = 0;
                input1.Text = "0";
            }

            else if (sign == "cos")
            {
                lblNumber1.Visible = false;
                input1.Visible = false;
                lblNumber2.Visible = true;
                input2.Visible = true;
                num1 = 0;
                input1.Text = "0";
            }

            else
            {
                lblNumber1.Visible = true;
                input1.Visible = true;
                lblNumber2.Visible = true;
                input2.Visible = true;
            }

            lblOperator.Text = sign;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
               num1 = Convert.ToDouble(input1.Text);
            } 

            catch (FormatException)
            {
                num1 = 0;
                error.SetError(input1, "That is not an integer!");
                err = true;
            }

            try
            {
                num2 = Convert.ToDouble(input2.Text);
            }
            
            catch (FormatException)
            {
                num2 = 0;
                error.SetError(input2, "That is not an integer!");
                err = true;
            }


            if (sign == "+")
            {
                result = (num1 + num2);
            }

            else if (sign == "-")
            {
                result = (num1 - num2);
            }

            else if (sign == "*")
            {
                result = (num1 * num2);
            }

            else if (sign == "/")
            {
                result = (num1 / num2);
            }

            else if (sign == "avg")
            {
                result = ((num1 + num2) / 2);
            }

            else if (sign == "sqrt")
            {
                result = (Math.Sqrt(num1));
            }

            else if (sign == "sin")
            {
                result = (Math.Sin(num2));
            }

            else if (sign == "cos")
            {
                result = (Math.Cos(num2));
            }

            else
            {
                error.SetError(comboBox1, "No operator selected!");
            }

            if (err == true)
            {
                lblResult.Text = "error!";
                err = false;
            }

            else
            {
                result = Math.Round(result, 2);
                lblResult.Text = "= " + result.ToString();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblNumber1_MouseHover(object sender, EventArgs e)
        {
            number1Tip.Visible = true;
        }

        private void lblNumber2_MouseHover(object sender, EventArgs e)
        {
            number2Tip.Visible = true;
        }

        private void lblNumber1_MouseLeave(object sender, EventArgs e)
        {
            number1Tip.Visible = false;
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            error.Clear();
            lblNumber2.Text = input2.Text;
        }

        private void lblNumber1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            lblNumber1.Text = input1.Text;
            error.Clear();
        }

        private void lblNumber2_MouseLeave(object sender, EventArgs e)
        {
            number2Tip.Visible = false;
        }
    }
}
