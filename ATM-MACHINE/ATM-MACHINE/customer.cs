using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MACHINE
{
   internal class customer
    {
        private string pin;
        private int inpin;
        private int amount;
        private double balance;
        private bool addCustomer;

        public string Pin
        {
            get
            {
                return pin;
            }

            set
            {
                pin = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public int Inpin
        {
            get
            {
                return inpin;
            }

            set
            {
                inpin = value;
            }
        }

        public customer(int p, double b)
        {
            inpin = p;
            balance = b;
        }


    }
}
