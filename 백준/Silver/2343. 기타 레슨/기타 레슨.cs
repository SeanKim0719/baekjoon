var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
var blue = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m=input[1];
int l = blue.Max(), r = blue.Sum(), mid;
while(l <= r)
{ 
    mid = (l + r) / 2;
    int sum = 0, cnt = 1;
    for (int i = 0; i < blue.Length; i++)
    {
        if(sum + blue[i] > mid)
        {
            cnt++; sum = blue[i];
        }
        else {
            sum += blue[i];
        }
    }
    if (sum > mid) { cnt++; }
    if(cnt <= m) { r = mid - 1; }
    else { l = mid + 1; }
}
Console.WriteLine(l);