using System;

class Program
{
    static void Main(string[] args)
    {
        // Crée un tableau de couleurs
        string[] couleurs = { "rouge", "bleu", "vert", "jaune" };

        // Génère un indice aléatoire pour choisir une couleur
        Random rand = new Random();
        int indiceCouleur = rand.Next(0, couleurs.Length);
        string couleurSecrete = couleurs[indiceCouleur];

        string reponseUtilisateur; // Variable pour stocker la réponse de l'utilisateur

        // Boucle do while pour permettre plusieurs tentatives
        do
        {
            Console.WriteLine("Devinez la couleur (rouge, bleu, vert, jaune) :");
            reponseUtilisateur = Console.ReadLine();

            // Vérifie si la réponse de l'utilisateur correspond à la couleur secrète
            if (string.Equals(reponseUtilisateur, couleurSecrete, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Félicitations ! Vous avez trouvé la couleur.");
                break; // Sort de la boucle si l'utilisateur a deviné la bonne couleur
            }
            else
            {
                Console.WriteLine("Ce n'est pas la bonne couleur. Essayez encore.");
            }
        } while (true); // Continue tant que la couleur n'est pas trouvée
    }
}
