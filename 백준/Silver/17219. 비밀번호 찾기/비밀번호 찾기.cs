StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = input[0]; int M = input[1];
Dictionary<string,string> id = new Dictionary<string,string>();
for(int i = 0; i < N; i++)
{
    var ID = sr.ReadLine().Split();
    id.Add(ID[0], ID[1]);
}
for(int i = 0;i < M; i++)
{
    string site = sr.ReadLine();
    sw.WriteLine(id[site]);
}
sr.Close();
sw.Close();