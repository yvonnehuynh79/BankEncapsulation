using BankEncapsulation;

  

        
var instance = new BankAccount();

Console.WriteLine($"how much would you like to deposit");
double userInput = double.Parse(Console.ReadLine());

instance.Deposit(userInput);
Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"How much would you like to withdraw?");
double amount = double.Parse(Console.ReadLine());

instance.Withdraw(amount);
Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"Your balance is now : ${instance.GetBalance()}");
Console.WriteLine();








/*bankAccount.GetBalance();
bankAccount.Withdraw();*/






