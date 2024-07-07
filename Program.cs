public class Program
{
    public static void Main()
    {
        Empresa empresa = new Empresa();
        bool sair = false;
        while (!sair)
        {
            System.Console.WriteLine("Menu:");
            System.Console.WriteLine("1 - Adicionar Funcionário de tempo integral");
            System.Console.WriteLine("2 - Adicionar Funcionário de Meio Período");
            System.Console.WriteLine("3 - Remover Funcionário");
            System.Console.WriteLine("4 - Exibir Informações de Todos os funcionários");
            System.Console.WriteLine("5 - Adicionar Projetos a um funcionário");
            System.Console.WriteLine("6 - Sair");
            System.Console.Write("Escolha uma opção: ");

            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        System.Console.WriteLine("Nome do funcionário: ");
                        string nomeFuncionarioIntegral = Console.ReadLine();
                        System.Console.WriteLine("Matrícula do funcionário: ");
                        int matriculaFuncionarioIntegral = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Salário Mensal: ");
                        double salarioMensal = Convert.ToDouble(Console.ReadLine());
                        FuncionarioTempoIntegral funcionarioIntegral = new FuncionarioTempoIntegral(nomeFuncionarioIntegral, matriculaFuncionarioIntegral, salarioMensal);
                        empresa.AdicionarFuncionario(funcionarioIntegral);
                        break;

                    case 2:
                        System.Console.WriteLine("Nome do funcionario:");
                        string nomeFuncionarioMeio = Console.ReadLine();
                        System.Console.WriteLine("Matrícula do Funcionário:");
                        int matriculaFuncionarioMeio = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Salário por hora:");
                        double salarioHora = Convert.ToDouble(Console.ReadLine());
                        System.Console.WriteLine("Horas trabalhadas");
                        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
                        FuncionarioMeioPeriodo funcionarioMeioPeriodo = new FuncionarioMeioPeriodo(nomeFuncionarioMeio, matriculaFuncionarioMeio,salarioHora, horasTrabalhadas);
                        empresa.AdicionarFuncionario(funcionarioMeioPeriodo);
                        break;
                    case 3:
                    System.Console.WriteLine("Matrícula a remover:");
                    int matriculaRemover = Convert.ToInt32(Console.ReadLine());
                    empresa.RemoverFuncionario(matriculaRemover);
                    break;
                    case 4:
                    empresa.ExibirFuncionarios();
                    break;
                    case 5:
                    System.Console.WriteLine("Matricula do funcionário: ");
                    int matriculaProjeto = Convert.ToInt32(Console.ReadLine());
                    Funcionario funcionarioProjeto = empresa.funcionarios.Find(f => f.Matricula == matriculaProjeto);
                    if (funcionarioProjeto != null)
                    {
                        System.Console.WriteLine("Numero de projetos a adicionar:");
                        int numProjetos = Convert.ToInt32(Console.ReadLine());
                        List<string> projetos = new List<string>();
                        for (int i = 0; i < numProjetos; i++)
                        {
                            System.Console.WriteLine($"Nome do projeto {i + 1}:");
                            string nomeProjeto = Console.ReadLine();
                            projetos.Add(nomeProjeto);
                        }
                        funcionarioProjeto.AdicionarProjeto(projetos);
                        System.Console.WriteLine("Projetos Adicionados.");
                    }
                    else
                    {
                        System.Console.WriteLine($"matrícula {matriculaProjeto} não encontrada");
                    }
                    break;
                    case 6:
                    sair = true;
                    break;
                    default: 
                    System.Console.WriteLine("Opção Inválida");
                    break;
                
                        
                    
                }
            }
        }
    }
}
