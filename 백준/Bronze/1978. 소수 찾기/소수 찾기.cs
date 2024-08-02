var N = Console.ReadLine();
var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int cnt = 0;
foreach (var n in nums) 
{ 
    if(Prime(n)) cnt++;
}

Console.WriteLine(cnt);

static bool Prime(int num)
{
    if ((num & 1) == 0)
    {
        return num == 2;
    }
    for (int i = 3; (i * i) <= num; i += 2)
    {
        if ((num % i) == 0)
        {
            return false;
        }
    }
    return num != 1;
}