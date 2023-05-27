using System;

namespace SalarioLiqu
{
  public class Program
  {
    public static void Main(string [] args)
    {
    Funcionario func = new Funcionario ();

    Console.WriteLine("Digite seu nome : ");
    func.Nome = Console.ReadLine();

    Console.WriteLine("Digite seu salario :");
    func.SalarioBruto = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o valor do imposto:");
    func.Imposto = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine($"Funcionario :{func}");

    Console.WriteLine("Digite o valor da porcetagem de aumento");
    double porcetagem=Convert.ToDouble(Console.ReadLine());

    func.AumentarSalario(porcetagem);

    Console.WriteLine($"Dados Atualizados : {func}");

    

    }
  }
}
