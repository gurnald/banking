using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking;
internal class Account {

    public string AccountId { get; set; } = String.Empty; // unqie id
    public decimal Balance { get; set; } = 0; // account balance
    public string Description { get; set; } = String.Empty; // information

    public bool Deposit(decimal Amount) {
        if (Amount <= 0) {
              Console.WriteLine($"Amount cannot be zero or negative");
            return false;
        }
        Balance += Amount; // Balance = Balance + Amount;
        return true;
    }

    public bool Withdraw(decimal Amount) {

        if (Amount <= 0) {
            Console.WriteLine($"Amount cannot be zero or negative");
            return false;
        }

            if (Amount > Balance) {
            Console.WriteLine($"Insufficient Funds!");
            return false;
        } 

        Balance -= Amount; // balance = Balance - Amount;
        return true;
    
    }

    public bool Transfer(decimal Amount, Account ToAccount) {
        if (Amount <= 0) {
            Console.WriteLine($"Amount cannot be zero or negative");
            return false;
        }
        var success = Withdraw(Amount);
        if (!success) {
            return false;
        }
        ToAccount.Deposit(Amount);
        return true;
    
    /* if(Withdraw(Amont)) {
     * ToAccount.Deposit(Amount);
     * return true;
     * }
     * return false;
     */

    }
}
