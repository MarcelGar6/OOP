class Media
{
    static void Main(string[] args)
    {
        double soma = 0;
        foreach(string arg in args)
        {
            double d = System.Convert.ToDouble(arg);
            soma += d;
        }
        System.Console.WriteLine(soma/args.Length);
    }
}