var n = int.Parse(Console.ReadLine());
var liq = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
int l = 0, r = n-1;
int min = liq[l] + liq[r];
var ans = (liq[l], liq[r]);
while (l < r)
{
    int sum = liq[l] + liq[r];
    if (sum == 0) { ans = (liq[l], liq[r]); break; }
    if (Math.Abs(sum) < Math.Abs(min)) { ans = (liq[l], liq[r]); min = sum; }
    if(sum < 0) { l++; }
    else { r--; }
}
Console.WriteLine($"{ans.Item1} {ans.Item2}");