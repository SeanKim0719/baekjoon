StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int K = input[0]; int N = input[1];
List<uint> lens = new List<uint>();

for (int i = 0; i < K; i++)
{
    lens.Add(uint.Parse(sr.ReadLine()));
}

uint l = 1; uint r = lens.Max();
while (l <= r)
{
    uint sum = 0;
    uint mid = (l + r) / 2;
    foreach (uint len in lens)
    {
        sum += len / mid;
    }
    if(sum >= N)
    {
        l = mid + 1;
    }
    else
    {
        r = mid - 1;
    }
}
Console.WriteLine(r);
sr.Close();