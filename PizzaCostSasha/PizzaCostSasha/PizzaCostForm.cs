/*
 * Created by: Sasha Malko
 * Created on: 24-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pseudocode
 * This program calculates the cost of a pizza after the user enters the diameter of the pizza. 
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

namespace PizzaCostSasha
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            // hide the subtotal and total answer labels until the user clicks on the calculate button
            this.lblASubtotal.Hide();
            this.lblATotal.Hide(); 
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double diameter, subtotal, total;

            // convert the string from the text box to a double 
            diameter = double.Parse(txtDiameter.Text);

            // calculate the cost of the pizza
            subtotal = 0.75 + 0.99 + 0.5 * diameter;
            total = (0.75 + 0.99 + 0.5 * diameter) * 1.13;

            // insert the total and subtotal into their respective labels
            this.lblASubtotal.Text = String.Format("${0:0.00}", subtotal);
            this.lblATotal.Text = String.Format("${0:0.00}", total);

            // display the subtotal and total labels with their respective answers
            this.lblASubtotal.Show();
            this.lblATotal.Show();
        }
    }
}