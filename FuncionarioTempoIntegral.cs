public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double SalarioMensal;

    public FuncionarioTempoIntegral(string Nome, int Matricula, double salarioMensal): base(Nome, Matricula)
    {
        SalarioMensal = salarioMensal;
    }
    public override double CalcularSalario()
    {
        return SalarioMensal;
    }
    public override void ExibirInformacoes()
    {
        System.Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula} Salario Mensal: {SalarioMensal}");
    }
    public double CalcularBonus()
    {
        return 0.1 * SalarioMensal; // 10% do mensal
    }
}
