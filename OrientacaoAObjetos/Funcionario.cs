class Funcionario
{
    public string nome;
    public double salario;

    public void AumentaSalario(double valor)
    {
        this.salario += valor;
    }

    public string ConsultaSalario()
    {
        return "Nome: " + nome + "\nSalario: " + salario;
    }
}