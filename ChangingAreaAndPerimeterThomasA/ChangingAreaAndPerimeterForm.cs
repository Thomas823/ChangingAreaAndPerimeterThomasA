/*
 * Created by: Thomas Aubin
 * Created on: 5 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Changing Area And Perimeter
 * This program allows for user input to calculate the area and perimeter of a rectangle or square
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

namespace ChangingAreaAndPerimeterThomasA
{
    public partial class frmChangingAreaAndPerimeter : Form
    {
        // Create variables
        double length, width, area, perimeter;

        public frmChangingAreaAndPerimeter()
        {
            InitializeComponent();

            // Hide area and perimeter prompts
            lblPerimeterPrompt.Hide();
            lblAreaPrompt.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   
            // Get length and width from text boxes
            length = double.Parse(txtLengthInput.Text);
            width = double.Parse(txtWidthInput.Text);

            // Calculate area and perimeter
            area = length * width;
            perimeter = (2 * length) + (2 * width);

            // Update answers in labels
            lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";
            lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " meters";

            // Show area and perimeter prompts
            lblPerimeterPrompt.Show();
            lblAreaPrompt.Show();
        }
    }
}