var n = int.Parse(Console.ReadLine());
var col = new bool[n];
var dia_1 = new bool[2*n];
var dia_2 = new bool[2*n];
var ans = 0;
dfs(0);
Console.WriteLine(ans); 
void dfs(int row)
{
    if (row == n) { ans++; return; }
    for (int i = 0; i < n; i++)
    {
        if (col[i] || dia_1[row+i] || dia_2[row-i+n-1]) continue;
        col[i] = true; dia_1[row+i] = true; dia_2[row-i+n-1] = true;
        dfs(row + 1);
        col[i] = false; dia_1[row+i] = false; dia_2[row-i+n-1] = false;
    }
}