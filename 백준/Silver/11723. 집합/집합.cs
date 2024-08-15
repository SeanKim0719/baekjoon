StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = new int[20];
int N = int.Parse(sr.ReadLine());
for(int i = 0; i < N; i++) {
    var com = sr.ReadLine().Split();
    if (com[0] == "add") add(int.Parse(com[1]), arr);
    else if (com[0] == "remove") remove(int.Parse(com[1]), arr);
    else if (com[0] == "check") sw.WriteLine(check(int.Parse(com[1]), arr));
    else if (com[0] == "toggle") toggle(int.Parse(com[1]), arr);
    else if (com[0] == "all") all(arr);
    else if (com[0] == "empty") empty(arr);
}
sr.Close();
sw.Close();
static void add(int i, int[] arr)
{
    if (arr[i-1] == 0) arr[i - 1] = 1;
}
static void remove(int i, int[] arr)
{
    if (arr[i-1] == 1) arr[i - 1] = 0;
}
static int check(int i, int[] arr)
{
    if (arr[i-1] == 1) return 1;
    else return 0;
}
static void toggle(int i, int[] arr)
{
    if(arr[i-1] == 0) arr[i - 1] = 1;
    else arr[i-1] = 0;
}
static void all(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = 1;
}
static void empty(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = 0;
}