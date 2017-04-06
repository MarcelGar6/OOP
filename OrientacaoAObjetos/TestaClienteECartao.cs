class TestaClienteECartao
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        CartaoDeCredito cdc = new CartaoDeCredito(111111);

        c.codigo = 123;
        c.nome = "Marcel Garcez";

        cdc.numero = 123456;
        cdc.dataDeValidade = "20/01/2017";

        System.Console.WriteLine("Dados do Cliente");
        System.Console.WriteLine("Nome: " + c.nome);
        System.Console.WriteLine("Código: " + c.codigo);

        System.Console.WriteLine("-------------------------------------------------------------");

        System.Console.WriteLine("Dados do Cartão");
        System.Console.WriteLine("Número: " + cdc.numero);
        System.Console.WriteLine("Data de validade: " + cdc.dataDeValidade);

        System.Console.WriteLine("-------------------------------------------------------------");

        cdc.cliente = c;

        System.Console.WriteLine("Dados do cliente obtidos através do cartão");
        System.Console.WriteLine(cdc.cliente.nome);
        System.Console.WriteLine(cdc.cliente.codigo);
    }
}