// See https://aka.ms/new-console-template for more information
using ACT2POO3_AjdiniSefedin;

string reset = "";
do
{
    Console.WriteLine("Bienvenu dans notre concepteur de sandwich!");
    Console.WriteLine("");
    for (int i = 0; i < 5; i++)
    {
        sandwich sandwichAleatoire = new sandwich();
        Console.WriteLine("voici votre sandiwch : " + sandwichAleatoire.ComposeSandwich());
        Console.WriteLine("");
    }

    Console.WriteLine("Un autre cercle ? (Taper sur espace)");
    reset = Console.ReadLine();
    Console.Clear();
} while (reset == " ");
