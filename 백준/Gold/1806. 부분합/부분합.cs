var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int N = input[0]; int S = input[1];
var arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int l = 0; int r = 0; int sum = 0;
List<int> len = new List<int>();
while(r <= arr.Length && l < arr.Length)
{
    if (r == arr.Length)
    {
        sum -= arr[l];
        l++;
    }
    else 
    {
        if (sum < S)
        {
            sum += arr[r];
            r++;
        }
        else
        {
            sum -= arr[l];
            l++;
        }
    }
    if (sum >= S)
    {
        len.Add(r - l);
    }
}

Console.WriteLine(len.Count != 0 ? len.Min() : "0");