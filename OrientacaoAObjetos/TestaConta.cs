﻿class TestaConta
{
    static void Main(string[] args)
    {
        Agencia a = new Agencia(123);
        Conta c1 = new Conta(a);
        c1.numero = 1234;
        c1.saldo = 1000;
        c1.limite = 500;

        Conta c2 = new Conta(a);
        c2.numero = 5678;
        c2.saldo = 2000;
        c2.limite = 250;

        System.Console.WriteLine("Dados da primeira conta");
        System.Console.WriteLine("Número: " + c1.numero);
        System.Console.WriteLine("Saldo: " + c1.saldo);
        System.Console.WriteLine("Limite: " + c1.limite);

        System.Console.WriteLine("--------------------------------------------------");

        System.Console.WriteLine("Dados da segunda conta");
        System.Console.WriteLine("Número: " + c2.numero);
        System.Console.WriteLine("Saldo: " + c2.saldo);
        System.Console.WriteLine("Limite: " + c2.limite);
    }

}