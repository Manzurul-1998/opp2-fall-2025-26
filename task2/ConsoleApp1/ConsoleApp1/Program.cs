using System;

class Program
{
    static void Main()
    {
        double originalPrice = 1500;
        double discountRate = 0.10; // 10% discount

        double discountAmount = originalPrice * discountRate;
        double finalPrice = originalPrice - discountAmount;

        Console.WriteLine($"Discount Amount: Rs. {discountAmount}");
        Console.WriteLine($"Final Price: Rs. {finalPrice}");
    }
}
