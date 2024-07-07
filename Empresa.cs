
public class Empresa
{
    public List<Funcionario> funcionarios;
    
    public Empresa()
    {
        funcionarios = new List<Funcionario>();
    }
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }
    public void RemoverFuncionario(int matricula)
    {
        Funcionario funcionario = funcionarios.Find(f => f.Matricula == matricula);
        if (funcionario != null)
        {
            funcionarios.Remove(funcionario);
            System.Console.WriteLine($"Funcionário com a matrícula {matricula} removido.");
        }
        else
        {
            System.Console.WriteLine($"Funcionário com a matrícula {matricula} não encontrado");
        }
    }
    public void ExibirFuncionarios()
    {
        System.Console.WriteLine("Lista de Funcionários");
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
    }
