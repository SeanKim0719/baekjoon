int N = int.Parse(Console.ReadLine());
int[,] list = new int[N+1, N+1];
int blue = 0; int white = 0;

for (int i = 0; i < N; i++)
{ 
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for(int j = 0; j < N; j++)
    {
        list[i,j] = input[j];
    }
}

div(N, 0, 0);
Console.WriteLine(white);
Console.WriteLine(blue);

void div(int n, int x, int y)
{
    int count = 0;
    for(int i = x; i < x + n; i++)
    {
        for(int j = y; j < y + n; j++)
        {
            if (list[i, j] == 0) count++;
        }
    }
    if (count == n * n) white++;
    else if(count == 0) blue++;
    else
    {
        div(n / 2, x, y);
        div(n / 2, x + n / 2, y);
        div(n / 2, x, y + n / 2);
        div(n / 2, x + n / 2, y + n / 2);
    }
}