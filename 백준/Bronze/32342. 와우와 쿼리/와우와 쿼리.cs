const string pattern = "WOW";
var q = int.Parse(Console.ReadLine());
for(int i = 0; i < q; i++)
{
    var input = Console.ReadLine();
    Console.WriteLine(KMP(input,pattern,Get_Pat(pattern,pattern.Length)));
}
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

static int KMP(string text,string pattern,int[] pat)
{
    int n = text.Length, m = pattern.Length;
    int i = 0, j = 0;
    int cnt = 0;
    while (i < n)
    {
        if (text[i] == pattern[j])
        {
            if (j == m - 1) { cnt++; j = pat[j]; i++; }
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