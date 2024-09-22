var first = Console.ReadLine();
var second = Console.ReadLine();
var ans = new int[first.Length+2,second.Length+2];
for (int i = 1; i < first.Length + 1; i++) {
    for (int j = 1; j < second.Length + 1; j++)
    {
        ans[i + 1, j + 1] = first[i - 1] == second[j - 1] ? ans[i, j] + 1 : Math.Max(ans[i + 1, j], ans[i, j + 1]);
    }
} 
Console.WriteLine(ans.Cast<int>().Max());