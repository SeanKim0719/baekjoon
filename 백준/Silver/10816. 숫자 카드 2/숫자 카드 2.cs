var read=()=>Console.ReadLine();
var n = int.Parse(read());
var n_list = read().Split().Select(int.Parse).ToList();
var m = int.Parse(read());
var m_list = read().Split().Select(int.Parse).ToList();
var dic = new Dictionary<int,int>();
var ans = new List<int>();
foreach (var x in n_list)
{
    if (dic.ContainsKey(x)) dic[x]++;
    else dic.Add(x,1);
}
foreach(var y in m_list)
{
    if (dic.ContainsKey(y)) ans.Add(dic[y]);
    else ans.Add(0);
}
Console.WriteLine(string.Join(" ",ans));