using System;

class ClsPropertyA
{
    public void AddNums(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void subNums(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public void mulNums(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    public static string SayHi(string name)
    {
        return "hi " + name;
    }
    static void Main(string[] args)
    {
        ClsPropertyA p = new ClsPropertyA();
        p.AddNums(21,32);//access
        p.subNums(10,5);
        p.mulNums(3, 4);
        string str = ClsPropertyA.SayHi("js");//
        Console.WriteLine(str);
        Console.ReadKey();
    }
}