var n = int.Parse(Console.ReadLine());
var chessboard = new List<List<int>>();
for (int i = 0; i < n; i++) { chessboard.Add(Console.ReadLine().Split().Select(int.Parse).ToList()); }
var dia_1 = new bool[2 * n];
var dia_2 = new bool[2 * n];
var max_black = 0;
var max_white = 0;
dfs(0,0,0,true);
dfs(0,1,0,false);
Console.WriteLine(max_black + max_white);
void dfs(int x, int y, int cnt,bool black)
{
    if (y >= n) 
    {
        x++; 
        if (y % 2 == 0) y = 1;
        else y = 0; 
    }
    if (x == n)
    {
        if (black) max_black = Math.Max(max_black, cnt);
        else max_white = Math.Max(max_white, cnt);
        return;
    }
    if (chessboard[x][y] == 1 && !dia_1[x + y] && !dia_2[x - y + n - 1])
    {
        dia_1[x + y] = true; dia_2[x - y + n - 1] = true;
        dfs(x, y + 2,cnt+1,black);
        dia_1[x + y] = false; dia_2[x - y + n - 1] = false;
    }
    dfs(x, y + 2,cnt,black);
}