class TestaMetodosFuncionario
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();
        f.nome = "Marcel Garcez";
        f.salario = 1537.00f;

        System.Console.WriteLine(f.ConsultaSalario());
        f.AumentaSalario(100f);
        System.Console.WriteLine("O salário do funcionário " + f.nome + " com aumento de 100 reais é de: " + f.salario);
    }
}