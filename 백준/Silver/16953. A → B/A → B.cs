var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int a = input[0], b = input[1];
int cnt = 1;
while(b > a)
{
    if (b % 2 == 0) { b /= 2; cnt++; }
    else if (b % 10 == 1) { b /= 10; cnt++; }
    else break;
}
Console.WriteLine((a==b)? cnt:-1);