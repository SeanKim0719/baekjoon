StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var str = sr.ReadLine();
var pattern = sr.ReadLine();
var ans = KMP(str, pattern, Get_Pat(pattern, pattern.Length));
sw.WriteLine(ans.Item1);
sw.WriteLine(string.Join(" ",ans.Item2));
sr.Close();
sw.Close();
static int[] Get_Pat(string pattern,int size)
{
    var pat = new int[size];
    int i = 1, j = 0;
    while (i < pattern.Length)
    {
        if (pattern[i] == pattern[j])
        {
            pat[i] = j + 1;
            i++; j++;
        }
        else if (j > 0) { j = pat[j - 1]; }
        else { pat[i] = 0; i++; }
    }
    return pat;
}

static (int, List<int>) KMP(string text,string pattern,int[] pat)
{
    int n = text.Length, m = pattern.Length;
    int i = 0, j = 0;
    var cnt = (0,new List<int>());
    while (i < n)
    {
        if (text[i] == pattern[j])
        {
            if (j == m - 1)
            { 
                cnt.Item1++;
                cnt.Item2.Add(i-j+1);
                j = pat[j]; 
                i++; 
            }
            else { i++; j++; }
        }
        else
        {
            if (j > 0) { j = pat[j - 1]; }
            else { i++; }
        }
    }
    return cnt;
}