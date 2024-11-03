var n = int.Parse(Console.ReadLine());
var win = new int[1000001];
var chk = new bool[1000001];
var ans = new List<int>();
var player_card = Console.ReadLine().Split().Select(int.Parse).ToList();
foreach(var item in player_card)
{
    chk[item] = true;
}
for(int i = 0; i < n; i++)
{
    var card = player_card[i];
    for(int j = card*2; j < 1000001; j+=card)
    {
        if (chk[j]) { win[card]++; win[j]--; }
    }
}
foreach(var item in player_card)
{
    ans.Add(win[item]);
}
Console.WriteLine(string.Join(" ",ans));