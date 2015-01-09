﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipApp
{
    class Account
    {
        public string AccountNumber { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

        public void GetDeposit(double amount)
        {
            Balance += amount;
        }

        public void GetWithdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
