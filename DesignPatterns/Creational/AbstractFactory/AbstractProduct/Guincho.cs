namespace DesignPatterns.Creational.AbstractFactory
{
    // Abstract Product
    public abstract class Guincho
    {
        public Porte Porte { get; set; }

        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }
}
