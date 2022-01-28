using System;
using Desafio_POO.src.Entities;

namespace dotnet___POO
{
    class program
    {

        static void Main(string[] args)
        {
           Knight Arus = new Knight("Arus", 42, "Knight", 749, 72);
           Ninja Wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
           WhiteWizard Jennica = new WhiteWizard("Jennica", 42, "White Wizard", 601, 482);
           BlackWizard Topapa = new BlackWizard("Topapa", 42, "Black Wizard", 385, 641);

            Console.WriteLine(Arus.Attack(1));
            Console.WriteLine(Arus.Attack(7));
            Console.WriteLine(Wedge.Attack(1));
             Console.WriteLine(Wedge.Attack(7));
            Console.WriteLine(Jennica.Attack(1));
            Console.WriteLine(Jennica.Attack(7));
             Console.WriteLine(Topapa.Attack(1));
            Console.WriteLine(Topapa.Attack(7));

    }


}
}