class Triangles
{
    static void Main(string[] args)
    {
        string line = "*";
        for (int counter = 1; counter <= 16; counter++)
        {
            System.Console.WriteLine(line);
            line += "*";
            if (counter % 4 == 0)
                line = "*";
        }
    }
}