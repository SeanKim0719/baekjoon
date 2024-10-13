var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0], k = input[1];
var bag = new int[n + 1, k + 1];
var items = new List<(int weight, int value)>() { (0, 0) };
for(int i = 1; i <= n; i++)
{
    var item = Console.ReadLine().Split().Select(int.Parse).ToList();
    items.Add((item[0],item[1]));
}
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= k; j++)
    {
        if (items[i].weight > j)
        {
            bag[i, j] = bag[i-1, j];
        }
        else
        {
            bag[i, j] = Math.Max(bag[i-1,j],bag[i-1, j - items[i].weight] + items[i].value);
        }
    }
}
Console.WriteLine(bag[n,k]);