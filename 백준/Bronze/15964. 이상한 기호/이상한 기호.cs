var input = Console.ReadLine().Split().Select(int.Parse).ToList();
Console.WriteLine((input[0] + input[1])*(input[0]-input[1]));