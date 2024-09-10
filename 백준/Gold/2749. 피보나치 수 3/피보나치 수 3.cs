const int mod = 1000000;
var n = long.Parse(Console.ReadLine());
var fibo = new long[2, 2] { { 1, 1 },{ 1, 0 } };
var def = new long[2, 2] { { 1, 0 },{ 0, 1 } };
if (n == 0 || n == 1)
{
    Console.WriteLine(n);
}
else
{
    n--;
    while (n > 0)
    {
        if (n % 2 == 1)
        {
            def = mult(def, fibo);
        }
        fibo = mult(fibo, fibo);
        n /= 2;
    }
    Console.WriteLine(def[0, 0]);
}

static long[,] mult(long[,] x, long[,] y)
{
    long first = (x[0, 0] * y[0, 0] + x[0, 1] * y[1, 0])%mod;
    long second = (x[0, 0] * y[0, 1] + x[0, 1] * y[1, 1])%mod;
    long third = (x[1, 0] * y[0, 0] + x[1, 1] * y[1, 0]) %mod;
    long fourth = (x[1, 0] * y[0, 1] + x[1, 1] * y[1, 1]) %mod;
    x[0,0] = first; x[0,1] = second; x[1,0] = third; x[1,1] = fourth;
    return x;
}