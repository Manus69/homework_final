
class StringFilter
{
    public static string[] filter(string[] strs, int limit)
    {
        return strs.Where(x => x.Length <= limit).ToArray();
    }
}

class Input
{
    private static string[] _default_input = {"0", "zero", "1", "one", "2", "two", "3", "three"};
    public static string[] get(string[] args)
    {
        return args.Length == 0 ? _default_input : args;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(String.Join(" ", StringFilter.filter(Input.get(args), 3)));
    }

}
