class TestaAluno
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        a1.nome = "Marcel Garcez";
        a1.rg = "45.596.573-0";
        a1.dataDeNascimento = "20/01/1986";
        Aluno a2 = new Aluno();        
        a2.nome = "Paula Garcez";        
        a2.rg = "00.000.000-0";        
        a2.dataDeNascimento = "28/06/1983";

        System.Console.WriteLine("Dados do primeiro aluno");
        System.Console.WriteLine("Nome: " + a1.nome);
        System.Console.WriteLine("RG: " + a1.rg);
        System.Console.WriteLine("Data de Nascinento: " + a1.dataDeNascimento);

        System.Console.WriteLine("----------------------------------------------------------------");

        System.Console.WriteLine("Dados do segundo aluno");
        System.Console.WriteLine("Nome: " + a2.nome);
        System.Console.WriteLine("RG: " + a2.rg);
        System.Console.WriteLine("Data de Nascinento: " + a2.dataDeNascimento);
    }   
}