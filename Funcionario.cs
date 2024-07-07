public abstract class Funcionario
{
    public string Nome;
    public int Matricula;

    public List<string> Projetos = new List<string>();

    public Funcionario(string Nome, int Matricula)
    {
        this.Nome = Nome;
        this.Matricula = Matricula;
    }
    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }
        public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
}