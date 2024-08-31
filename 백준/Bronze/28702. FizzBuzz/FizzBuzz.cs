int k = 0;
int cnt = 0;
for(int i = 0; i < 3; i++)
{
    var input = Console.ReadLine();
    if (input[0] >= '0' && input[0] <= '9')
    {
        k = int.Parse(input);
        cnt = i;
    }
}
k += (3 - cnt);
if (k % 15 == 0) Console.WriteLine("FizzBuzz");
else if (k % 3 == 0) Console.WriteLine("Fizz");
else if (k % 5 == 0) Console.WriteLine("Buzz");
else Console.WriteLine(k);