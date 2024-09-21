var t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    var dis = distance(input[0], input[1], input[3], input[4]);
    var rad_plus = (input[2]+input[5])*(input[2]+input[5]);
    var rad_minus = (input[2]-input[5])*(input[2]-input[5]);
    if (dis == 0)
    {
        if (input[2] == input[5]) { Console.WriteLine(-1); }
        else { Console.WriteLine(0); }
    }
    else
    {
        if (rad_plus == dis) { Console.WriteLine(1); }
        else if (rad_minus == dis) { Console.WriteLine(1); }
        else if (rad_plus < dis) { Console.WriteLine(0); }
        else if (rad_minus > dis) { Console.WriteLine(0); }
        else { Console.WriteLine(2); }
    }
}
static int distance(int x1,int y1,int x2, int y2)
{
    return (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
}