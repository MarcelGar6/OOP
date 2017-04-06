class TestaTurma
{
    static void Main(string[] args)
    {
        Turma t1 = new Turma();
        t1.periodo = "Noturno";
        t1.serie = "Oitavo ano C";
        t1.sigla = "8C";
        t1.tipoDeEnsingo = "Regular";
        Turma t2 = new Turma();
        t2.periodo = "Diurno";
        t2.serie = "Segundo ano A";
        t2.sigla = "2C";
        t2.tipoDeEnsingo = "EJA";

        System.Console.WriteLine("Dados da primeira turma");
        System.Console.WriteLine("Periodo: " + t1.periodo);
        System.Console.WriteLine("Série: " + t1.serie);
        System.Console.WriteLine("Sigla: " + t1.sigla);
        System.Console.WriteLine("Tipo de ensingo: " + t1.tipoDeEnsingo);

        System.Console.WriteLine("----------------------------------------------------------------");

        System.Console.WriteLine("Dados do segundo funcionario");
        System.Console.WriteLine("Periodo: " + t2.periodo);
        System.Console.WriteLine("Série: " + t2.serie);
        System.Console.WriteLine("Sigla: " + t2.sigla);
        System.Console.WriteLine("Tipo de ensingo: " + t2.tipoDeEnsingo);
    }

}