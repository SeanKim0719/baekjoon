var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m  = input[1];
var lines = new List<(int bundle, int piece)>();
int ans = 0;
for(int i = 0; i < m; i++)
{
    var line = Console.ReadLine().Split().Select(int.Parse).ToList();
    lines.Add((line[0],line[1]));
}
int min_piece = lines.OrderBy(x => x.piece).First().piece;
int min_bundle = lines.OrderBy(x => x.bundle).First().bundle;
if(min_piece*6 < min_bundle) { min_bundle = min_piece * 6; }
while (n > 6)
{
    ans += min_bundle;
    n -= 6;
}
ans = min_bundle < min_piece * n ? ans += min_bundle : ans += min_piece * n;
Console.WriteLine(ans);