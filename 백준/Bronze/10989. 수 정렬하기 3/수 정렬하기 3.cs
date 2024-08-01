StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
int[] count = new int [10000];
for(int i = 0;i < count.Count(); i++)
{
    count[i] = 0;
}

for(int i = 0; i < N; i++)
{
    int input = int.Parse(sr.ReadLine());
    count[input-1]++;
}

for(int i = 0; i<count.Count(); i++)
{
    while (count[i] > 0)
    {
        sw.WriteLine(i+1);
        count[i]--;
    }
}

sr.Close();
sw.Close();