class Triangle
{
    static void Main(string[] args)
    {
        string line = "*";
        for (int counter = 1; counter <= 10; counter++)
        {
           System.Console.WriteLine(line);
            line += "*";
        }
    }
}