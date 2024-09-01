var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var trees = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0], m = input[1];
long sum = 0;
int l = 1, r = trees.Max(), mid;
while (l<=r)
{
    mid = (l + r) / 2;
    sum = 0;
    foreach(var t in trees)
    {
        if(t > mid) { sum += t - mid; }
    }
    if(sum >= m) l = mid + 1;
    else r = mid - 1;
}
Console.WriteLine(r);