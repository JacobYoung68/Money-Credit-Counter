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



        private void img1p_Click(object sender, EventArgs e)
        {
            total++;
            updateTotal();

        }

        private void img2p_Click(object sender, EventArgs e)
        {
            total = total + 2;
            updateTotal();
        }

        private void img5p_Click(object sender, EventArgs e)
        {
            total = total + 5;
            updateTotal();
        }

        private void img10p_Click(object sender, EventArgs e)
        {
            total = total + 10;
            updateTotal();
        }

        private void img20p_Click(object sender, EventArgs e)
        {
            total = total + 20;
            updateTotal();
        }

        private void img50p_Click(object sender, EventArgs e)
        {
            total = total + 50;
            updateTotal();
        }

        private void img100p_Click(object sender, EventArgs e)
        {
            total = total + 100;
            updateTotal();
        }

        private void img200p_Click(object sender, EventArgs e)
        {
            total = total + 200;
            updateTotal();
        }
        private void updateTotal()
        {
            lblTotalPence.Text = (total.ToString() + "p");
            lblTotalPoundsandPence.Text = ("£" + (Convert.ToDouble(total) / 100).ToString());
        }

        private void btn_Click(object sender, EventArgs e)
        {
            total = 0;
            updateTotal();
        }
    }
}
