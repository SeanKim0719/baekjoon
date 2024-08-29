var tile = new int[1001];
tile[1] = 1; tile[2] = 2;
for(int i = 3; i < 1001; i++)
{
    tile[i] = (tile[i - 1] + tile[i - 2])%10007;
}
Console.WriteLine(tile[int.Parse(Console.ReadLine())]);