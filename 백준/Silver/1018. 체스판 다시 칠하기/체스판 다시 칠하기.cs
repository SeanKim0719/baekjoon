using System.Text;

var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
(int N, int M) = (input[0], input[1]);
string[] chess = new string[N];
string case_1 = "WBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBW";
string case_2 = "BWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWBBWBWBWBWWBWBWBWB";
int Min = 64;

for (int i = 0; i < N; i++)
{
    chess[i] = Console.ReadLine();
}

for(int i = 0; i <= N - 8; i++)
{
    for(int j = 0; j <= M - 8; j++)
    {
        int[] cnt = {0,0};
        string board = Get_board(chess, i, j);
        for(int k = 0; k < board.Length; k++)
        {
            if (board[k] != case_1[k])
            {
                cnt[0]++;
            }
        }
        for (int k = 0; k < board.Length; k++)
        {
            if (board[k] != case_2[k])
            {
                cnt[1]++;
            }
        }
        if(Min > cnt.Min())
        {
            Min = cnt.Min();
        }
    }
}

Console.WriteLine(Min);
static string Get_board(string[] strings,int x, int y)
{
    StringBuilder sb = new StringBuilder();
    for(int i = x; x + 8 > i ; i++)
    {
        for(int j = y; y + 8 > j; j++)
        {
            sb.Append(strings[i][j]);
        }
    }
    return sb.ToString();
}