using System;
using System.Security.Principal;


class Program
{
    static void Main(string[] args)
    {
        string s;
        while((s = Console.ReadLine()) != "0 0 0")
        {
            string[] lines = s.Split(' ');
            int[] line = new int[3];
            for (int i = 0; i < 3; i++)
            {
                line[i] = int.Parse(lines[i]);
            }
            Array.Sort(line);
            if ((line[2] * line[2]) == (line[1]*line[1]) + (line[0] * line[0]))
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("wrong"); 
            }
        }
    }
}
