StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    arr[i] = int.Parse(sr.ReadLine());
}
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++) 
{
    sw.WriteLine(arr[i]);
}
sw.Close();
sr.Close();