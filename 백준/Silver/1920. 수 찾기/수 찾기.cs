StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
var A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int M = int.Parse(sr.ReadLine());
var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Array.Sort(A);
foreach(var target in input)
{
    sw.WriteLine(Array.BinarySearch(A,target) >= 0? "1" : "0");
}

sr.Close();
sw.Close();