class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;
        int num = 1;
        while (N > cnt)
        {
            string str_num = num.ToString();
            num++;
            if (str_num.Contains("666"))
            {
                cnt++;
            }
        }
        num--;
        Console.WriteLine(num);
    }
}