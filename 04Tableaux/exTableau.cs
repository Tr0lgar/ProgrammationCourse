using System;

class Program
{
    static void Main(string[] args)
    {
        // Étape 1 : Créer un tableau de 10 entiers et demander les valeurs à l'utilisateur
        int[] tableau = new int[10];
        for (int i = 0; i < tableau.Length; i++)
        {
            Console.Write("Entrez un entier pour l'élément " + i + " : ");
            tableau[i] = int.Parse(Console.ReadLine());
        }

        // Étape 2 : Calculer la somme des éléments du tableau
        int somme = 0;
        foreach (int valeur in tableau)
        {
            somme += valeur;
        }
        Console.WriteLine("La somme des éléments est : " + somme);

        // Étape 3 : Trouver le plus grand élément
        int max = tableau[0];
        foreach (int valeur in tableau)
        {
            if (valeur > max)
            {
                max = valeur;
            }
        }
        Console.WriteLine("Le plus grand élément est : " + max);

        // Étape 4 : Créer un tableau de 5x5 et le remplir avec des valeurs de 1 à 25
        int[,] tableau2D = new int[5, 5];
        int compteur = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                tableau2D[i, j] = compteur++;
            }
        }

        // Étape 5 : Afficher le tableau 5x5 sous forme de grille
        Console.WriteLine("Tableau 5x5 :");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(tableau2D[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
