using banking;

var s1 = new SavingsCOMP();

s1.AccountId = "Jacob";
s1.Description = "My Lucious Savings Account";
s1.Balance = 1000;

Console.WriteLine($"S1 Paid interest is 3$");

Console.WriteLine($"S1 Balance is {s1.Balance:C}");
