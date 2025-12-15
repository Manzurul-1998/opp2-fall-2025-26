using System;

interface IStudent
{
    void DisplayInfo();
}

class Student : IStudent
{
    private string name;
    private string id;
    private double[] marks = new double[3];

    public Student(string name, string id)
    {
        this.name = name;
        this.id = id;
    }

    public double this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, ID: {id}");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Mark {i}: {marks[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Student st = new Student("Akib", "22");
        st[0] = 95.5;
        st[1] = 90;
        st[2] = 80;

        st.DisplayInfo();
    }

}