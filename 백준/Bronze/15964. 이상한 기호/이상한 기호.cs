var input = Console.ReadLine().Split().Select(long.Parse).ToList();
Console.WriteLine((input[0] + input[1])*(input[0]-input[1]));