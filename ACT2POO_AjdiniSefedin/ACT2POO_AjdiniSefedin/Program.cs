// See https://aka.ms/new-console-template for more information
using ACT2POO_AjdiniSefedin;

    string reset = "";
do
{
    Console.WriteLine("Bienvenu dans ce programme sur le cercle !");
    Console.WriteLine("Tapez un rayon pour votre cercle.");
    double rayon = double.Parse(Console.ReadLine());

    Cercle cercle1 = new Cercle(rayon);
    Console.WriteLine(cercle1.AfficherCaracteristiques());

    Console.WriteLine("Avec un cercle de rayon diminué de moitié : ");

    Console.WriteLine("-----------------------------------------------");

    Console.WriteLine(cercle1.AfficherCaracteristiquesDivise2());

    Console.WriteLine("Un autre cercle ? (Taper sur espace)");
    reset = Console.ReadLine();
} while (reset == " ");


