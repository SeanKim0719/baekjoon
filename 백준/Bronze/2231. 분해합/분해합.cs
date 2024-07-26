class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int num = 1;
        int sum;
        bool exist = false;
        while (N > num)
        {
            int cnt = num;
            sum = cnt;
            while (cnt > 10)
            { 
                sum += cnt % 10;
                cnt = cnt / 10;
            }
            sum += cnt;
            if(N == sum)
            {
                exist = true;
                break;
            }
            num++;
        }
        if (!exist)
        {
            Console.WriteLine("0");
        }
        else { Console.WriteLine(num); }
    }
}
