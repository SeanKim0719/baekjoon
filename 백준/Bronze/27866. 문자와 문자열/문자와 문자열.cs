using System;

class Soultion
{
    static string InPut = Console.ReadLine();
    static string Num = Console.ReadLine();
    int Change = Convert.ToInt32(Num);
    public void  OutPut()
    {
        Console.WriteLine(InPut[Change - 1]);
    }
}

class Program
{
   static void Main(string[] args)
    {
        Soultion soultion = new Soultion();
        soultion.OutPut();
    }
}