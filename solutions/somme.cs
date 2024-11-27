using System;

class Program
{
    static void Main(string[] args)
    {
        int n; // Variable pour stocker le nombre saisi par l'utilisateur

        // Boucle do while pour demander un entier positif tant que l'entrée n'est pas valide
        do
        {
            Console.WriteLine("Entrez un nombre entier positif :");
            string saisie = Console.ReadLine();

            // Vérifie si la saisie est bien un entier et si cet entier est positif
            if (int.TryParse(saisie, out n) && n > 0)
            {
                // Si la saisie est correcte, on sort de la boucle
                break;
            }
            else
            {
                // Message d'erreur si l'entrée n'est pas un entier positif
                Console.WriteLine("Erreur : Veuillez entrer un nombre entier positif.");
            }
        } while (true); // La boucle continue tant que l'utilisateur n'a pas saisi un entier positif

        // Crée une variable pour stocker la somme
        int somme = 0;

        // Utilise une boucle for pour additionner les nombres de 1 à n
        for (int i = 1; i <= n; i++)
        {
            somme += i; // Ajoute i à la somme
        }

        // Affiche le résultat (la somme des n premiers nombres)
        Console.WriteLine("La somme des " + n + " premiers nombres est : " + somme);
    }
}
