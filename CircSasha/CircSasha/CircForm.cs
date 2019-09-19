using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircSasha
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();
            // hide the circumference and answer labels until the user clicks on the calculate button
            this.lblCircumference.Hide();
            this.lblAnswer.Hide();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double radius, circumference;

            // convert the string from the text box to a double
            radius = double.Parse(txtRadius.Text);

            // calculate the circumference
            circumference = Math.PI * Math.Pow(radius, 2);

            // insert the circumference into its respective label
            this.lblAnswer.Text = Convert.ToString(circumference) + "cm";

            // display the circumference and answer labels 
            this.lblCircumference.Show();
            this.lblAnswer.Show();
        }
    }
}
