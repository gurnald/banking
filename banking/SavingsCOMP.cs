﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking;
internal class SavingsCOMP {

    private Account account = new Account(); 

    public decimal InterestRate { get; set; } = 0.12m;

    public string AccountId {
        get {
            return account.AccountId;
        }
        set {
            account.AccountId = value;
        }
    }
    public string Description {
        get {
            return account.Description;
        }
        set {
            account.Description = value;
        }

    }

    public decimal Balance {
        get {
            return account.Balance;
        }
        set {
            account.Balance = value;
        }

    }

    public bool Deposit(decimal Amount) {
        return account.Deposit(Amount);
    }
    public bool Withdraw(decimal Amount) {
        return account.Withdraw(Amount);
    }
    public bool Transfer(decimal Amount, SavingsCOMP ToAccount) {
        return account.Transfer(Amount, ToAccount.account);
    }
}
// Inheritance and Compositions do the same things for the most part. 