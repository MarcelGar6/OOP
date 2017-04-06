class TestaContaEAgencia
{
    static void Main(string[] args)
    {
        Agencia a = new Agencia(1324);
        Conta c = new Conta(a);

        c.numero = 123;
        c.saldo = 1000.0;
        c.limite = 500;

        System.Console.WriteLine("Dados da agência");
        System.Console.WriteLine("Número: " + a.numero);

        System.Console.WriteLine("-------------------------------------------------");

        System.Console.WriteLine("Dados da conta");
        System.Console.WriteLine("Número: " + c.numero);
        System.Console.WriteLine("Saldo: " + c.saldo);
        System.Console.WriteLine("Limite: " + c.limite);

        System.Console.WriteLine("-------------------------------------------------");

        c.agencia = a;

        System.Console.WriteLine("Dados da agência obtidos através da conta");
        System.Console.WriteLine(c.agencia.numero);
    }
}