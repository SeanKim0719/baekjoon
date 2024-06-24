using System;

class Program
{
   static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string a_str = a.ToString();
        string b_str = b.ToString();
        string c_str = c.ToString();
        int com = int.Parse(a_str + b_str);
        Console.WriteLine(a + b - c);
        Console.WriteLine(com - c);
    }
}