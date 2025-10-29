using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter score for Student 1: ");
        double score1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter score for Student 2: ");
        double score2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter score for Student 3: ");
        double score3 = Convert.ToDouble(Console.ReadLine());

        double average = (score1 + score2 + score3) / 3;
        Console.WriteLine($"Average score: {average:F2}");
    }
}
