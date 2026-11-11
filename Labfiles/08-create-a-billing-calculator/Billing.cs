namespace Billing
{
    public static class Calculator
    {
        // Add the CalculateTax and CalculateTotal methods here
        public static decimal CalculateTax(decimal subtotal, decimal taxRate = 0.08m)
        {
            return subtotal * taxRate;
        }

        public static decimal CalculateTotal(decimal subtotal, decimal tax)
        {
            return subtotal + tax;
        }
    }
}
