var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(bin(input[0], input[1]));
static int bin(int n, int k)
{
    if (n == k || k == 0)
    {
        return 1;
    }
    else
    {
        return bin(n - 1, k - 1) + bin(n - 1, k);
    }
}