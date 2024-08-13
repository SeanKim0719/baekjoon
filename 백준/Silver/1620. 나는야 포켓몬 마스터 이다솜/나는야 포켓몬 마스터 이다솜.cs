StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = input[0]; int M = input[1];
Dictionary<int, string> poke = new Dictionary<int, string>();
Dictionary<string,int> rev_poke = new Dictionary<string,int>();
for (int i = 1; i <= N; i++)
{
    var pokemon = sr.ReadLine();
    poke.Add(i, pokemon);
    rev_poke.Add(pokemon, i);
}
for (int i = 0; i < M; i++)
{
    var quiz = sr.ReadLine();
    if (quiz[0] < 'A')
    {
        sw.WriteLine(poke[int.Parse(quiz)]);
    }
    else
    {
        sw.WriteLine(rev_poke[quiz]);
    }
}
sr.Close();
sw.Close();