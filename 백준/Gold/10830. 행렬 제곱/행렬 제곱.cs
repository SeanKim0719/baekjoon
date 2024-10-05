using System.Numerics;
const int Div = 1000;
var input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
int n = (int)input[0];
long m = input[1];
var matrix = new List<List<int>>();
var ele = Enumerable.Range(0,n).Select(i=>Enumerable.Range(0,n).Select(j => i == j?1:0).ToList()).ToList();
for(int i = 0; i < n; i++)
{
    matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
}
while (m > 0)
{
    if(m%2 == 1)
    {
        ele = sqr(ele, matrix);
    }
    matrix = sqr(matrix, matrix);
    m /= 2;
}
foreach (var row in ele)
{
    Console.WriteLine(string.Join(" ", row));
}
List<List<int>> sqr(List<List<int>> x,List<List<int>> y)
{
    int n = x.Count;
    var result = new List<List<int>>();
    for(int i = 0; i<n; i++)
    {
        result.Add(Enumerable.Range(0, n).Select(k => Enumerable.Range(0, n).Select(j => (x[i][j] * y[j][k])).Sum()%Div).ToList());
    }
    return result;
}