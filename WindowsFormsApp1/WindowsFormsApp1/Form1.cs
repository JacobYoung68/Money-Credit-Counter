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
        int total = 0;
        int [] cointotals = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void updateTotal()
        {
            txtNoOfCredits.Text = (total / Convert.ToDouble(txtCostPerCredit.Text)).ToString();
            txtTotalPence.Text = (total.ToString() + "p");
            txtTotalPoundsandPence.Text = ("£" + (Convert.ToDouble(total) / 100).ToString());
            
        }

        private bool checkcredit()
        {
            if (txtCostPerCredit.Text == 0.ToString())
            {
                return false;
            }
            else if (txtCostPerCredit.Text == "")
            {
                return false;
            } else
            {
                return true;
            }
        }


        private void img1p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total++;
                cointotals[0] = cointotals[0] + 1;
                lblTotal1p.Text = cointotals[0].ToString();
                updateTotal();
                
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }            
        }

        private void img2p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 2;
                cointotals[1] = cointotals[1] + 1;
                lblTotal2p.Text = cointotals[1].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void img5p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 5;
                cointotals[2] = cointotals[2] + 1;
                lblTotal5p.Text = cointotals[2].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void img10p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 10;
                cointotals[3] = cointotals[3] + 1;
                lblTotal10p.Text = cointotals[3].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void img20p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 20;
                cointotals[4] = cointotals[4] + 1;
                lblTotal20p.Text = cointotals[4].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void img50p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 50;
                cointotals[5] = cointotals[5] + 1;
                lblTotal50p.Text = cointotals[5].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void img100p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 100;
                cointotals[6] = cointotals[6] + 1;
                lblTotal100p.Text = cointotals[6].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void img200p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 200;
                cointotals[7] = cointotals[7] + 1;
                lblTotal200p.Text = cointotals[7].ToString();
                updateTotal();
            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = 0;
            updateTotal();
        }
    }
}
