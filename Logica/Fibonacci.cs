class Fibonacci
{
    static void Main(string[] args)
    {
        int temp,a,b;
        a = 0;
        b = 1;

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);

        for (int counter = 1; counter <= 28; counter++)
        {
            temp = a + b;
            System.Console.WriteLine(temp);
            a = b;
            b = temp;
        }

    }

}
