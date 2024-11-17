StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var read = () => sr.ReadLine().Split().Select(int.Parse).ToList();
var input = read();
int n = input[0], m = input[1], k = input[2];
var cards = read();
var versus = read();
var root = Enumerable.Range(0, m + 1).ToList();
cards = cards.OrderBy(x => x).ToList();
foreach (var card in versus)
{
    int idx = cards.BinarySearch(card);
    if (idx < 0) idx = ~idx-1;
    idx = Find(idx+1);
    sw.WriteLine(cards[idx]);
    Union(idx, idx+1);
}
sr.Close();
sw.Close();
int Find(int x)
{
    if (x == root[x]) return x;
    return root[x] = Find(root[x]);
}
void Union(int x, int y)
{
    x = Find(x); y = Find(y);
    if (x != y) root[x] = y;
}