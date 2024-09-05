var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int l = 0, r = 0;
var odd = new Queue<int>();
var lens = new List<int>();
while(r < arr.Length)
{
    if (arr[r] % 2 != 0)
    {
        odd.Enqueue(r);
        r++;
    }
    else { r++; }
    if(odd.Count == input[1]+1)
    {
        lens.Add(r-l-odd.Count());
        l = odd.Dequeue()+1;
    }
}
lens.Add(r-l-odd.Count());
Console.WriteLine(lens.Max());