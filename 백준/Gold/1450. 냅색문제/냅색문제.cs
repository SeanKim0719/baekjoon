var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0], c = input[1];
var items = Console.ReadLine().Split().Select(int.Parse).ToArray();
int mid = items.Length / 2;
var items_left = items[0..mid];
var items_right = items[mid..items.Length];
var sums_left = new List<long>() { 0 };
var sums_right = new List<long>() { 0 };
long ans = 0;
foreach (var num in items_left)
{
    var new_sums = new List<long>();
    foreach (var sum in sums_left)
    {
        if (sum + num <= c) { new_sums.Add(num + sum); }
    }
    sums_left.AddRange(new_sums);
}
foreach (var num in items_right)
{
    var new_sums = new List<long>();
    foreach (var sum in sums_right)
    {
        if (sum + num <= c) { new_sums.Add(num + sum); }
    }
    sums_right.AddRange(new_sums);
}
sums_right.Sort();
foreach (var sum in sums_left)
{
    long remaining = c - sum;
    var point = sums_right.BinarySearch(remaining);
    if (point < 0) { point = ~point; }
    else { while (point < sums_right.Count && sums_right[point] == remaining) { point++; } }
    ans += point;
}
Console.WriteLine(ans);