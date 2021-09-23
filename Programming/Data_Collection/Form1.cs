/* 
 * Spencer Burton
 * 9/23/2021
 * Data Collection Form
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Collection
{
    public partial class Data_Collection_Form : Form
    {
        String[] data = new String[30];

        public Data_Collection_Form()
        {
            InitializeComponent();
        }

        private void Data_Collection_Form_Load(object sender, EventArgs e)
        {
            //Ask whether they want to proceed and warn about stealing data
            DialogResult result = MessageBox.Show("We are about to steal your data!\nDo you still want to proceed?", "Identity Theft Ahead", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If they say no, load it anyway
            if(result.ToString() == "No")
            {
                MessageBox.Show("Why?\nWell fill it out anyway!", "Nice Try", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            //Collect the data again
            First_Name_TextBox_TextChanged(sender, e);

            //Compile all the data into a string
            String all_data = "";

            foreach(String value in data)
            {
                all_data = String.Format("{0}\n{1}", all_data, value);
            }

            //Show all the data collected in a message box then close after they click OK
            MessageBox.Show(String.Format("Thank you for you data {0} {1}!\n\nHere is what we collected: {2}", data[0], data[1], all_data));
            this.Close();
        }

        private void First_Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            //Get all the data again
            data[0]  = First_Name_TextBox.Text;
            data[1]  = Last_Name_TextBox.Text;
            data[2]  = Age_TextBox.Text;
            data[3]  = Address_TextBox.Text;
            data[4]  = SS_Number_TextBox.Text;
            data[5]  = CC_Number_TextBox.Text;
            data[6]  = Expiration_TextBox.Text;
            data[7]  = License_Number_TextBox.Text;
            data[8]  = Eye_Color_TextBox.Text;
            data[9]  = Hair_Color_TextBox.Text;
            data[10] = Height_TextBox.Text;
            data[11] = Weight_TextBox.Text;
            data[12] = Phone_Number_TextBox.Text;
            data[13] = Person_Email_TextBox.Text;
            data[14] = Work_Email_TextBox.Text;
            data[15] = Job_Title_TextBox.Text;
            data[16] = Bone_Density_TextBox.Text;
            data[17] = BMI_TextBox.Text;
            data[18] = Father_Name_TextBox.Text;
            data[19] = Mother_Name_TextBox.Text;
            data[20] = Mother_Maiden_Name_TextBox.Text;
            data[21] = Sibling_Num_TextBox.Text;
            data[22] = Fav_Fruit_TextBox.Text;
            data[23] = Best_Friend_First_Name_TextBox.Text;
            data[24] = Best_Friend_Last_Name_TextBox.Text;
            data[25] = Body_PH_TextBox.Text;
            data[26] = Scapula_Curv_TextBox.Text;
            data[27] = Savings_Account_Balance_TextBox.Text;
            data[28] = Eye_Number_TextBox.Text;
            data[29] = Lat_Long_Coords_TextBox.Text;
        }
    }
}
