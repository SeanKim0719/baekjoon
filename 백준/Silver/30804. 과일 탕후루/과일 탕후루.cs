int N = int.Parse(Console.ReadLine());
var fruits = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int start = 0; int end = 1;
int length = 1;
Queue<int> type = new Queue<int>();
type.Enqueue(fruits[start]);
List<int> lengths = new List<int>();
while(end < fruits.Length)
{
    if (type.Count <= 2)
    {
        if (type.Contains(fruits[end]))
        {
            end++; length++;
            lengths.Add(end - start);
        }
        else if(!type.Contains(fruits[end]))
        {
            type.Enqueue(fruits[end]);
            if (type.Count <= 2) { end++; length++;}
            else { lengths.Add(end-start); start = end - 1; }
        }
    }
    else
    {
        if (fruits[start] == fruits[end - 1])
        {
            start--;
        }
        else
        {
            start++;
            type.Clear();
            type.Enqueue(fruits[start]);
            type.Enqueue(fruits[end]);
            length = end - start + 1;
        }
    }
}
if (lengths.Count() == 0) { lengths.Add(length); }
Console.WriteLine(lengths.Max());