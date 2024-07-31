int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int N = input[0];
int M = input[1];
int max = 0;
for (int i = 0; i < N-2; i++)
{
    for (int j = i+1; j < N-1; j++)
    {
        for(int k = j+1; k < N; k++)
        {
            int sum = 0;
            sum = nums[i] + nums[j] + nums[k];
            if (sum <= M && sum > max)
            {
                max = sum;
            }
        }
    }
}
Console.WriteLine(max);