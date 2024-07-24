class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string sizes = Console.ReadLine();
        string bundles = Console.ReadLine();
        int[] size = new int[6];
        int[] bun = new int[2];
        int T;
        int P;
        int cnt = 0;

        for(int i = 0; i < 6; i++)
        {
            string[] change = sizes.Split();
            size[i] = int.Parse(change[i]);
        }

        for(int i = 0; i < 2; i++)
        {
            string[] change = bundles.Split();
            bun[i] = int.Parse(change[i]);
        }

        T = bun[0]; P = bun[1];

        for(int i = 0;i < 6; i++)
        {
            while (size[i] > 0)
            {
                size[i] -= T;
                cnt++;
            }
        }
        Console.WriteLine(cnt);
        Console.WriteLine("{0} {1}",N/P, N%P);
    }
}