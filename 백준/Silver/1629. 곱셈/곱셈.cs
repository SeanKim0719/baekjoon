var input = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);
long a = input[0],b = input[1],c = input[2];
long ans = 1;
while (b > 0)
{
    if (b % 2 == 1)
    {
        ans = (ans * a)%c;
    }
    a = (a * a) % c;
    b /= 2;
}
Console.WriteLine(ans);