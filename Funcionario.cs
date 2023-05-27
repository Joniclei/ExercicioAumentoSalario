namespace SalarioLiqu
{
  public class Funcionario
  {
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido (){
      return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcetagem)
    {
      SalarioBruto  = SalarioBruto + (SalarioBruto * porcetagem/100);
    }

    public override string ToString()
    {
      return ($"{Nome},{SalarioLiquido().ToString("C")}");
    }




  }
}
