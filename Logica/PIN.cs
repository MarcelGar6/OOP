class PIN
{
    static void Main(string[] args)
    {
        int counter;
        for (counter = 1; counter <= 100; counter++)
        {
            if (counter % 4 == 0)
                System.Console.WriteLine("PIN");
            else
                System.Console.WriteLine(counter);
        }
    }
}