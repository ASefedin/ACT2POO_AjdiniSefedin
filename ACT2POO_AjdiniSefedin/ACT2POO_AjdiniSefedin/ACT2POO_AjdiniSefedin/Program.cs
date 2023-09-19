// See https://aka.ms/new-console-template for more information
using ACT2POO_AjdiniSefedin;

Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenu dans ce programme sur le cercle !");
Console.WriteLine("Tapez un rayon pour votre cercle", out rayon);
double rayon = double.Parse(Console.ReadLine());

Cercle Cercle1 = new Cercle(rayon, perimetre, aire);
Console.WriteLine("Avec un ceercle de rayon diminué de moitié : ");
Console.WriteLine("-----------------------------------------------");

Console.WriteLine("Le cercle de ", rayon/2 , "a un perimetre de ", perimetre/2 , "et une aire de ", aire/2);

