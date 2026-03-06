using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM_MACHINE
{
    public partial class frmAtm : Form
    {
        customer Data;
        string input;
        int amount;
        double newBalance;
        string pin;
        List<customer> CustomerInfo;
        public frmAtm()
        {
            InitializeComponent();
        }

        private void frmAtm_Load(object sender, EventArgs e)
        {
            CustomerInfo = new List<customer>();
            Data = new customer(1101, 30000.00);

            //CustomerInfo.Add(1101, 30000.00);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnEEE_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == Data.Inpin.ToString())
            {
                MessageBox.Show("Successfully Logged in");
               /* btnBalance.Enabled = true;
                btnWithdraw.Enabled = true;
                btnWithdrawR.Enabled = true;
                btnConfirm.Enabled = true;
                btnDeny.Enabled = true;*/
            }

            else
            {
                MessageBox.Show("Invalid Pin☠️☠");
                return;
            }


        }

        private void btnCcc_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            
                txtDisplay.Text = "Current Balance is " + Data.Balance.ToString() + " MWK";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = "Enter amount you wish to withdraw";
        }

        private void btnWithdrawR_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            amount = Data.Amount;
            amount = Int32.Parse(txtDisplay.Text);

            if (amount <= Data.Balance)
            {
                newBalance = Data.Balance - amount;
                MessageBox.Show("Transaction successful");
                MessageBox.Show($"Remaining Balnce is {newBalance} MKW ");
            }

            else
            {
                MessageBox.Show("Oops! You Have Insufficient Funds🙆🙆‍🙆");
                return;
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are sure you want to quit!");
            btnDeny.Enabled = false;
            return;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            /*btnBalance.Enabled = false;
            btnWithdraw.Enabled = false;
            btnWithdrawR.Enabled = false;
            btnConfirm.Enabled = false;
            btnDeny.Enabled = false;*/
        }
    }
}
