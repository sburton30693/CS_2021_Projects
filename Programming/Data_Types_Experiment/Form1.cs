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
 * 10/7/2021
 * Data Types Activity
 */


namespace Data_Types_Experiment
{
    public partial class DataType_Form : Form
    {
        public DataType_Form()
        {
            InitializeComponent();
        }

        private void NumericButton_Click(object sender, EventArgs e)
        {
            //Create and initialize numeric data types
            int myInt = 500;
            double myDouble = 0.00012;
            decimal myDecimal = 0.000000000000005252M;
            float myFloat = 151525.1095820F;

            //Print them to messageboxes
            MessageBox.Show("myInt: " + myInt.ToString());
            MessageBox.Show("myDouble: " + myDouble.ToString());
            MessageBox.Show("myDecimal: " + myDecimal.ToString());
            MessageBox.Show("myFloat: " + myFloat.ToString());
        }

        private void BoolButton_Click(object sender, EventArgs e)
        {
            //Intialize bool variable
            bool myBool = false;

            //Print to messagebox
            MessageBox.Show("myBool: " + myBool.ToString());
        }

        private void ConstantButton_Click(object sender, EventArgs e)
        {
            //Create constant data
            const double PI = 3.14159;
            const int myConstInt = -99800;

            //Print constant data
            MessageBox.Show("PI: " + PI.ToString());
            MessageBox.Show("myConstInt: " + myConstInt.ToString());
        }

        private void StringButton_Click(object sender, EventArgs e)
        {
            //Create char and string variables
            char myChar = 'g';
            string myString = "lemon";

            //Print values
            MessageBox.Show("myChar: " + myChar);
            MessageBox.Show("myString: " + myString);
        }
    }
}
