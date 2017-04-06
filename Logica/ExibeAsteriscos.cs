class ExibeAsteriscos
{
    static void Main(string[] args)
    {
        int counter;
        for (counter = 1; counter <= 100; counter++)
        {
            if(counter % 2 == 1)
            System.Console.WriteLine("*");
            else
            System.Console.WriteLine("**");
        }
    }
}