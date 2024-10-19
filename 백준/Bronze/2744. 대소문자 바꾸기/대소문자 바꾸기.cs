var input = Console.ReadLine().Select(x=> char.IsLower(x)? char.ToUpper(x):char.ToLower(x));
Console.WriteLine(string.Join("",input));