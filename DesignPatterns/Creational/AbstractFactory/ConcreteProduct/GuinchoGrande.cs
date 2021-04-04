using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Concrete Product
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Grande - Modelo " + veiculo.Modelo);
        }
    }
}
