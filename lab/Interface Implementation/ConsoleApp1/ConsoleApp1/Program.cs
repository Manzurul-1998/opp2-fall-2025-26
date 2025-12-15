using System;

interface IPrintable
{
    void Print();
}

interface ISerializable
{
    void Serialize();
}

class Report : IPrintable, ISerializable
{
    public void Print()
    {
        Console.WriteLine("Printing data...");
    }

    public void Serialize()
    {
        Console.WriteLine("Serializing data...");
    }
}

class Program
{
    static void Main()
    {
        Report r1 = new Report();
        r1.Print();
        r1.Serialize();
    }
}