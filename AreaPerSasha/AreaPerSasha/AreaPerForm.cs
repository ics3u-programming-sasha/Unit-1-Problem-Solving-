/*
 * Created by: Sasha Malko
 * Created on: 17-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Changing Area and Perimeter
 * This program gets the length and width from the user and then calculates the area and perimeter of a rectangle. 
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

namespace AreaPerSasha
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();
            // hide the perimeter and answer labels until the user clicks on the calculate button
            this.lblAPerimeter.Hide();
            this.lblAArea.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, perimeter, area;

            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // calculate the area and the perimeter
            area = length * width;
            perimeter = length + length + width + width;

            // insert the perimeter and area into their respective labels
            this.lblAArea.Text = Convert.ToString(area) + " squared meters";
            this.lblAPerimeter.Text = Convert.ToString(perimeter) + " meters";

            // display the perimeter and area labels with their respective answers  
            this.lblAPerimeter.Show();
            this.lblAArea.Show();
        }
    }
}