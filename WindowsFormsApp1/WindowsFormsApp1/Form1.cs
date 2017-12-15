using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        int total = 0;                              // Global variable for total pennies  
        int [] cointotals = new int[8];             // array to hold the values of each coin 

        public Form1()
        {
            InitializeComponent();
        }

        private void updateTotal() // update the credit total, pence total and £&pence total
        {
            txtNoOfCredits.Text = (total / Convert.ToDouble(txtCostPerCredit.Text)).ToString(); //divide the total pence by the converted double text inside of txtcostpercredit to get the cost per credit and place that inside the text of the txtbox
            txtTotalPence.Text = (total.ToString() + "p");
            txtTotalPoundsandPence.Text = ("£" + (Convert.ToDouble(total) / 100).ToString());
            
        }

        private bool checkcredit() // Checks to see if the cost per credit textbox is empty or is equal to 0, this will throw up an error since you cannot divide by 0
        {
            if (txtCostPerCredit.Text == 0.ToString())  // checks if cost per credit is = 0
            {
                return false;   
            }
            else if (txtCostPerCredit.Text == "")       // checks if cost per credit is blank
            {
                return false;
            } else                                      // if it's not blank or = 0, then it must be a valid number and returns true
            {
                return true;
            }
        }


        private void img1p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total++;                                        // total pence increased by value of coin: 1
                cointotals[0] = cointotals[0] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal1p.Text = cointotals[0].ToString();     // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total

            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }            
        }

        private void img2p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 2;                              // total pence increased by value of coin: 2
                cointotals[1] = cointotals[1] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal2p.Text = cointotals[1].ToString();     // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void img5p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 5;                              // total pence increased by value of coin: 5
                cointotals[2] = cointotals[2] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal5p.Text = cointotals[2].ToString();     // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void img10p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 10;                             // total pence increased by value of coin: 10
                cointotals[3] = cointotals[3] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal10p.Text = cointotals[3].ToString();    // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void img20p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 20;                             // total pence increased by value of coin: 20
                cointotals[4] = cointotals[4] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal20p.Text = cointotals[4].ToString();    // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void img50p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 50;                             // total pence increased by value of coin: 50
                cointotals[5] = cointotals[5] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal50p.Text = cointotals[5].ToString();    // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void img100p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 100;                            // total pence increased by value of coin:
                cointotals[6] = cointotals[6] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal100p.Text = cointotals[6].ToString();   // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void img200p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 200;                            // total pence increased by value of coin: 200
                cointotals[7] = cointotals[7] + 1;              // increase the value of how many times this coin has been pressed by 1 in the array for this total
                lblTotal200p.Text = cointotals[7].ToString();   // updates the label for this coin to show how many times its been pressed for this total
                updateTotal();                                  // update the credit total, pence total and £&pence total
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");   // error message if the user has not yet set the cost per credit
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = 0;
            for (int i = 0; i < 8; i++)     // for loop runs through positions 0 - 7 using i, in the cointotals array to reset the labels containing the number of each coin used.
            {
                cointotals[i] = 0;          // value in array position i in cointotals is changed to 0
            }
            var labels = new List<Label> {lblTotal1p,lblTotal2p,lblTotal5p,lblTotal10p,lblTotal20p,lblTotal50p,lblTotal100p,lblTotal200p}; // allows placement of lbl in a list to use later to change the text of each one in a loop
            foreach (var label in labels)   // loop through all items in the list
            {
                label.Text = 0.ToString();  // set all the values back to 0
            }
            updateTotal();                  // update the credit total, pence total and £&pence total
        }
    }
}
