namespace DesignPatterns.Creational.AbstractFactory
{
    // Concrete Product
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
