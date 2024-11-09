var read=()=>Console.ReadLine();
var n = int.Parse(read());
var n_list = read().Split().Select(int.Parse).ToList();
var m = int.Parse(read());
var m_list = read().Split().Select(int.Parse).ToList();
var dic = new Dictionary<int,int>();
foreach (var x in n_list)
{
    if (!dic.TryAdd(x,1)) dic[x]++;
}
Console.WriteLine(string.Join(" ",m_list.Select(x => dic.ContainsKey(x) ? dic[x]:0)));