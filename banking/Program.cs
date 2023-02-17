using banking;
using banking.Exceptions;

var s1 = new Savings();

s1.AccountId = "Jacob";
s1.Description = "My Lucious Savings Account";
s1.Balance = 1000;

try {
    s1.Withdraw(10000);
    s1.Deposit(-1000);
} catch (InsufficientFundsException ex) {
    
    Console.WriteLine(ex.Message);
} 
  catch(Exception ex) {



}


//Console.WriteLine($"S1 Paid interest is 3$");
Console.WriteLine($"S1 Balance is {s1.Balance:C}");

