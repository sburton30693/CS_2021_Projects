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
 * Personal Hello Form
 */

namespace Personal_Hello
{
    public partial class Hello_Form : Form
    {
        public Hello_Form()
        {
            InitializeComponent();
        }

        private void ClickHere_Button_Click(object sender, EventArgs e)
        {
            //Display messageboxes
            MessageBox.Show("Hello, World!");
            MessageBox.Show("Hello, Spencer!");
        }

        private void Hello_Form_Load(object sender, EventArgs e)
        {
            //Load Background Image
            this.BackgroundImage = Image.FromFile("background.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
