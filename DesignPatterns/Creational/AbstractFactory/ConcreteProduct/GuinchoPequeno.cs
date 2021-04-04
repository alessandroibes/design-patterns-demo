using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Concrete Product
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Processo de socorro
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }
}
