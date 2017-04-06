class TestaFuncionario
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.nome = "Madruga";
        f1.salario = 2000;

        Funcionario f2 = new Funcionario();
        f2.nome = "Barriga";
        f2.salario = 10000;

        System.Console.WriteLine("Dados do primeiro funcionario");
        System.Console.WriteLine("Nome: " + f1.nome);
        System.Console.WriteLine("Salário: " + f1.salario);

        System.Console.WriteLine("----------------------------------------------------------------");

        System.Console.WriteLine("Dados do segundo funcionario");
        System.Console.WriteLine("Nome: " + f2.nome);
        System.Console.WriteLine("Salário: " + f2.salario);
    }
}