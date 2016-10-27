using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Jonathan Coppola
// Coppola_1
// Due Date 09/30/2016
// Descritpion: Indiviual Assignment #1

namespace Coppola_1
{
    public partial class carlsCalendarsOrderForm : Form
    {
        public carlsCalendarsOrderForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // constants to help with calculations
            const decimal Sales_Tax = 0.07m;
            const decimal Small_Cost = 11.95m;
            const decimal Large_Cost = 19.95m;
            const decimal Flip_Cost = 9.95m;
            const decimal Blotter_Cost = 12.95m;

            try
            {
                // prevent unassigned variable errors
                decimal small = 0, large = 0, flip = 0, blotter = 0;

                //trasition from entry into usable calculation data
                if (smallEntryBox.Text != "")
                    small = decimal.Parse(smallEntryBox.Text);
                if (largeEntryBox.Text != "")
                    large = decimal.Parse(largeEntryBox.Text);
                if (flipEntryBox.Text != "")
                    flip = decimal.Parse(flipEntryBox.Text);
                if(blotterEntryBox.Text != "")
                    blotter = decimal.Parse(blotterEntryBox.Text);

                //calculations
                decimal Small_Total_Cost = small * Small_Cost;
                decimal Large_Total_Cost = large * Large_Cost;
                decimal Flip_Total_Cost = flip * Flip_Cost;
                decimal Blotter_Total_Cost = blotter * Blotter_Cost;
                decimal Total_Number = small + large + flip + blotter;
                decimal Subtotal = Small_Total_Cost + Large_Total_Cost + Flip_Total_Cost + Blotter_Total_Cost;
                decimal Sales_Tax_Total = Subtotal * Sales_Tax;
                decimal Order_Total = Sales_Tax_Total + Subtotal;

                //transition from calculations to output label entries 
                totalOutputLabel.Text = Total_Number.ToString("n");
                subtotalOutputLabel.Text = Subtotal.ToString("c");
                salesTaxOutputLabel.Text = Sales_Tax_Total.ToString("c");
                orderTotalOutputLabel.Text = Order_Total.ToString("c");

                // putting focus on clear
                clearButton.Focus();
            }

            catch
            {
                // display error message
                MessageBox.Show("You have input an incorrect value into one of the data entries. Please re-enter and try again");
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clearing of all data entry boxs and all outout labels
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneTextBox.Clear();
            dateEntryBox.Clear();
            smallEntryBox.Clear();
            largeEntryBox.Clear();
            flipEntryBox.Clear();
            blotterEntryBox.Clear();
            totalOutputLabel.Text = "";
            subtotalOutputLabel.Text = "";
            salesTaxOutputLabel.Text = "";
            orderTotalOutputLabel.Text = "";

            // putting focus on first name text box
            firstNameTextBox.Focus();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // providing help message when help button is clicked
            MessageBox.Show("Thank you for clicking the help button. This from is to help you calculate the"
                + " total number of calendars needed for each order. It also calculates the subtotal, sales tax, and order total" +
                " for each order. Please input the customers name and phone number in the customer information section and then enter" +
                " the order informartion including date and number of each type of calendar requested. The form will do all the calculations"
                + " for you. Hope this has helped");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // closes the program
            this.Close();
        }

      
    }
}

