using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Spencer Burton
 * 9/27/2021
 * Calculator Form
 */


namespace Calculator
{
    public partial class Calculator_Form : Form
    {
        String output;
        double operand_1;
        double operand_2;
        String op;
        bool calc_done;

        public Calculator_Form()
        {
            InitializeComponent();
        }

        private void Calculator_Form_Load(object sender, EventArgs e)
        {
            //Set output to zero to start with
            output = "0";
            Output_TextBox.Text = output;
            calc_done = false;

            //Set the text and click event of the buttons
            Button_0.Text = "0";
            Button_1.Text = "1";
            Button_2.Text = "2";
            Button_3.Text = "3";
            Button_4.Text = "4";
            Button_5.Text = "5";
            Button_6.Text = "6";
            Button_7.Text = "7";
            Button_8.Text = "8";
            Button_9.Text = "9";

            EventHandler num_click_event = new EventHandler(this.Number_Button_Click);
            Button_0.Click += num_click_event;
            Button_1.Click += num_click_event;
            Button_2.Click += num_click_event;
            Button_3.Click += num_click_event;
            Button_4.Click += num_click_event;
            Button_5.Click += num_click_event;
            Button_6.Click += num_click_event;
            Button_7.Click += num_click_event;
            Button_8.Click += num_click_event;
            Button_9.Click += num_click_event;

            //Add click events to operator buttons
            EventHandler op_click_event = new EventHandler(this.Operator_Button_Click);
            Add_Button.Click += op_click_event;
            Minus_Button.Click += op_click_event;
            Multiply_Button.Click += op_click_event;
            Divide_Button.Click += op_click_event;
        }

        private void Equal_Button_Click(object sender, EventArgs e)
        {
            //Try to Parse the second operand
            try
            {
                operand_2 = Double.Parse(output);
            }
            catch(OverflowException ee)
            {
                //If it overflows clear everything
                MessageBox.Show("Overflow Error: " + ee.Message, "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Button_Click(sender, e);
                return;
            }

            //Check what operator is being used and do the operator
            double answer = 0;
            
            if(op == "+")
            {
                answer = operand_1 + operand_2;
            }
            else if(op == "-")
            {
                answer = operand_1 - operand_2;
            }
            else if(op == "x")
            {
                answer = operand_1 * operand_2;
            }
            else if(op == "/")
            {
                //Prevent and report divide by zeroes
                if(operand_2 != 0)
                {
                    answer = operand_1 / operand_2;
                }
                else
                {
                    MessageBox.Show("Divide by Zero Error", "Arithmetic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                //No operator selected yet, reset operand 2 and return
                operand_2 = 0;
                return;
            }

            //Show output in textbox
            output = answer.ToString();
            Output_TextBox.Text = output;

            //Clear operands and operator
            operand_1 = 0;
            operand_2 = 0;
            op = "";

            calc_done = true;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            //Clear output to a 0
            output = "0";
            Output_TextBox.Text = output;

            //Clear operands and operators
            operand_1 = 0;
            operand_2 = 0;
            op = "";
        }

        private void Operator_Button_Click(object sender, EventArgs e)
        {
            //Try to Parse the first operand
            try
            {
                operand_1 = Double.Parse(output);
            }
            catch (OverflowException ee)
            {
                //If it overflows clear everything
                MessageBox.Show("Overflow Error: " + ee.Message, "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Button_Click(sender, e);
                return;
            }

            //Set the operator based on what button called it
            op = (sender as Button).Text;

            //Clear the output to 0
            output = "0";
            Output_TextBox.Text = output;
        }

        private void Number_Button_Click(object sender, EventArgs e)
        {
            //Check if output is zero and if so, remove it
            if(output == "0" || output == "-0")
            {
                //Remove the zero
                output = output.Replace("0", "");
            }

            //Check if output is result of a calculation, if so reset output
            if(calc_done)
            {
                output = "";
                calc_done = false;
            }

            //Get the text on the button, which is the number, and add it to the output text
            output += (sender as Button).Text;
            Output_TextBox.Text = output;
        }

        private void Dot_Button_Click(object sender, EventArgs e)
        {
            //If the current output is the result of a calculation, set to zero
            if(calc_done)
            {
                output = "0";
                calc_done = false;
            }
            
            //Check if there is a dot in the output text already
            if(!output.Contains("."))
            {
                //If not add one
                output += ".";
            }

            Output_TextBox.Text = output;
        }

        private void Negate_Button_Click(object sender, EventArgs e)
        {
            //Change the sign at the beginning of the output based on what sign is already there
            bool negative = output.StartsWith("-");

            if(negative)
            {
                output = output.Remove(0, 1);
            } 
            else
            {
                output = "-" + output;
            }

            Output_TextBox.Text = output;
        }
    }
}