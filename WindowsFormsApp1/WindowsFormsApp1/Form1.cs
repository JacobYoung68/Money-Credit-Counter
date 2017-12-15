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
        public Form1()
        {
            InitializeComponent();
        }

        private void updateTotal()
        {
            txtTotalPence.Text = (total.ToString() + "p");
            txtTotalPoundsandPence.Text = ("£" + (Convert.ToDouble(total) / 100).ToString());
        }

        private bool checkcredit()
        {
            if (txtCostPerCredit.Text == 0.ToString())
            {
                return true;
            }
            else if (txtCostPerCredit.Text == "")
            {
                return true;
            } else
            {
                return false;
            }
        }


        private void img1p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total++;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }            
        }

        private void img2p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 2;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void img5p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 5;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void img10p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 10;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void img20p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 20;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void img50p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 50;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void img100p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 100;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void img200p_Click(object sender, EventArgs e)
        {
            if (checkcredit() == true)
            {
                total = total + 200;
                updateTotal();
            }
            else
            {
                MessageBox.Show("Please Enter the Cost per Credit");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = 0;
            updateTotal();
        }
    }
}
