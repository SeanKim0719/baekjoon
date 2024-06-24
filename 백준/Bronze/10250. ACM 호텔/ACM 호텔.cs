using System;

class Program
{
   static void Main(string[] args)
    {
        int TestCase = int.Parse(Console.ReadLine());
        for(int i = 0; i < TestCase; i++)
        {
            string Input = Console.ReadLine();
            string[] Num = Input.Split(' ');
            int height = int.Parse(Num[0]);
            int length = int.Parse(Num[1]);
            int Cos_num = int.Parse(Num[2]);
            int Backword = 1;

            while(Cos_num > height)
            {
                Cos_num -= height;
                Backword++;
            }

            Console.WriteLine((Cos_num * 100) + Backword);
        }
    }
}