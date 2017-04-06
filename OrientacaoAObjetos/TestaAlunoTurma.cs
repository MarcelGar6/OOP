class TestaAlunoTurma
{
    static void Main(string[] args)
    {
        Aluno a = new Aluno();
        Turma t = new Turma();

        a.nome = "Marcel";
        a.rg = "4556965730";
        a.dataDeNascimento = "20/01/1986";

        t.periodo = "Noturno";
        t.serie = "7º ano A";
        t.sigla = "7A";
        t.tipoDeEnsingo = "EJA";

        System.Console.WriteLine("Dados do Aluno: ");
        System.Console.WriteLine("Nome: " + a.nome);
        System.Console.WriteLine("RG: " + a.rg);
        System.Console.WriteLine("Data de nascimento: " + a.dataDeNascimento);

        System.Console.WriteLine("---------------------------------------------------------");

        System.Console.WriteLine("Dados da turma: ");
        System.Console.WriteLine("Periodo: " + t.periodo);
        System.Console.WriteLine("Série: " + t.serie);
        System.Console.WriteLine("Sigla: " + t.sigla);
        System.Console.WriteLine("Tipo de ensino: " + t.tipoDeEnsingo);

        a.turma = t;

        System.Console.WriteLine("Dados do aluno obtidos através da turma: ");
        System.Console.WriteLine(a.turma.periodo);
        System.Console.WriteLine(a.turma.serie);
        System.Console.WriteLine(a.turma.sigla);
        System.Console.WriteLine(a.turma.tipoDeEnsingo);
    }

}