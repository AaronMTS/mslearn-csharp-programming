// Bring in the Billing namespace
using Calc = Billing.Calculator;

// Set up the order
Console.Write("Enter subtotal: ");
decimal subtotal;
while (!decimal.TryParse(Console.ReadLine(), out subtotal))
{
    Console.Write("Invalid input. Please try again: ");
}

// Calculate tax and total
decimal tax = Calc.CalculateTax(subtotal);
decimal total = Calc.CalculateTotal(subtotal, tax);

// Print the receipt
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax:      {tax:C}");
Console.WriteLine($"Total:    {total:C}\n");

decimal outOfStateSubtotal = 50m;
decimal outOfStateTax = Calc.CalculateTax(subtotal: outOfStateSubtotal, taxRate: 0.05m);
decimal outOfStateTotal = Calc.CalculateTotal(subtotal: outOfStateSubtotal, tax: outOfStateTax);

Console.WriteLine($"Out-of-state Subtotal: {outOfStateSubtotal:C}");
Console.WriteLine($"Out-of-state Tax:      {outOfStateTax:C}");
Console.WriteLine($"Out-of-state Total:    {outOfStateTotal:C}");