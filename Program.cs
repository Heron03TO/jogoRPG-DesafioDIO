using System;
using Jogo_rpg.src;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Knight = new Knight("Arus", 42, "Knight", 749, 72);
            Wizard wizard = new Wizard("Jennica", 42, "White Wizard", 601, 482);
            Ninja ninja = new Ninja("Wedge", 42,"Ninja", 574, 89);
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard", 385, 641);
            
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(Knight.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackWizard.Attack());
        }
    }
}