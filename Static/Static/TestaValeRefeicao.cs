class TestaValeRefeicao
{
    static void Main()
    {
        System.Console.WriteLine(Funcionario.valeRefeicao);
        Funcionario.valeRefeicao = 362f;
        System.Console.WriteLine(Funcionario.valeRefeicao);
    }
}