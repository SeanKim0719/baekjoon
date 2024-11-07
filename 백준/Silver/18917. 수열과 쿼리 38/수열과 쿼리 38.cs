StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
var m = int.Parse(sr.ReadLine());
var query = new List<int>();
long sum = 0, xor = 0;
while (m-- > 0)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    switch (input[0])
    {
        case 1:
            sum += input[1]; xor ^= input[1];
            break;
        case 2:
            sum -= input[1]; xor ^= input[1];
            break;
        case 3:
            sw.WriteLine(sum);
            break;
        case 4:
            sw.WriteLine(xor);
            break;
        default: break;
    }
}
sr.Close();
sw.Close();