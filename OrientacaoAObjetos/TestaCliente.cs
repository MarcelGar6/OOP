class TestaCliente
{
    static void Main(string[] args)
    {
        Cliente c1 = new Cliente();
        c1.nome = "Marcel Garcez";
        c1.codigo = 1;

        Cliente c2 = new Cliente();
        c2.nome = "Paula Moreira";
        c2.codigo = 2;

        System.Console.WriteLine("Dados do primeiro cliente");
        System.Console.WriteLine("Nome: " + c1.nome);
        System.Console.WriteLine("Codigo: " + c1.codigo);

        System.Console.WriteLine("-------------------------------------");

        System.Console.WriteLine("Dados do segundo cliente");
        System.Console.WriteLine("Nome: " + c2.nome);
        System.Console.WriteLine("Codigo: " + c2.codigo);
    }
}