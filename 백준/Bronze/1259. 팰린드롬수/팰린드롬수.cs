using System;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if(int.Parse(input) == 0)
            {
                break;
            }
            char[] reverse = input.ToArray();
            Array.Reverse(reverse);
            string comp = new string(reverse);

            if (input == comp)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        
    }
}

