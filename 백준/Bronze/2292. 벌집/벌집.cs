int input = int.Parse(Console.ReadLine());
int cnt = 1;
int depth = 1;
while (input > 1)
{
    input -= (depth * 6);
    depth++;
    cnt++;
}
Console.WriteLine(cnt);