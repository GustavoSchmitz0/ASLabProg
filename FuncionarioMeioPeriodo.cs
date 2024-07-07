public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double SalarioHora;
    private double HorasTrabalhadas;

    public FuncionarioMeioPeriodo (string Nome, int Matricula, double salarioHora, double horasTrabalhadas) : base(Nome, Matricula)
    {
        SalarioHora = salarioHora;
        HorasTrabalhadas = horasTrabalhadas;
    }
    public override double CalcularSalario()
    {
        return SalarioHora * HorasTrabalhadas;
    }
    public override void ExibirInformacoes()
    {
        System.Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário por hora: {SalarioHora}, Horas Trabalhadas: {HorasTrabalhadas}, Salário Total: {CalcularSalario()}");
    }
    public double CalcularBonus()
    {
        return 0.05 * CalcularSalario();
    }


}