var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0], m = input[1];
var arr = new List<List<int>>();
for(int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
}
for(int i = 0; i < n; i++)
{
    var arr_input = Console.ReadLine().Split().Select(int.Parse).ToList();
    for(int j = 0; j < m; j++)
    {
        arr[i][j] += arr_input[j];
    }
}
foreach (var a in arr)
{
    Console.WriteLine(string.Join(" ",a));
}