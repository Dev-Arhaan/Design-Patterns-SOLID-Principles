// OOP principles:-

// Encapsulation: bundling of data and behaviour ===>> classes and functions
using ConsoleApp1.src.oop;

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.getBalance());
bankAccount.Deposit(1000);
System.Console.WriteLine(bankAccount.getBalance());
bankAccount.Withdraw(500);
System.Console.WriteLine(bankAccount.getBalance());

