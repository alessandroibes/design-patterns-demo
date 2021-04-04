namespace DesignPatterns.Creational.AbstractFactory
{
    // Abstract Product
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public Porte Porte { get; set; }

        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }
    }
}
