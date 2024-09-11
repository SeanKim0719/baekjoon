var n = int.Parse(Console.ReadLine());
var card = new PriorityQueue<int,int>();
int ans = 0;
while (n-- > 0)
{
    var input = int.Parse(Console.ReadLine());
    card.Enqueue(input, input);
}
while (card.Count > 1)
{
    int temp = card.Dequeue() + card.Dequeue();
    ans += temp;
    card.Enqueue(temp,temp);
}
Console.WriteLine(ans);