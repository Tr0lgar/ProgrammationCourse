    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Génère un nombre aléatoire entre 1 et 100
            Random rand = new Random();
            int nombreSecret = rand.Next(1, 101);
            
            int nombreDevine = 0; // Stocke le nombre deviné par l'utilisateur
            int nombreEssais = 0; // Variable pour compter le nombre de tentatives

            Console.WriteLine("Bienvenue dans le jeu de devine le nombre !");
            Console.WriteLine("J'ai choisi un nombre entre 1 et 100. Essayez de le deviner.");

            // Boucle do while pour continuer tant que l'utilisateur n'a pas deviné le nombre
            do
            {
                Console.Write("Entrez votre devinette : ");
                string saisie = Console.ReadLine(); // Stocke l'entrée utilisateur

                // Essaye de convertir la saisie en entier
                // Si la conversion échoue, affiche un message d'erreur et demande une nouvelle saisie
                if (!int.TryParse(saisie, out nombreDevine) || nombreDevine < 1 || nombreDevine > 100)
                {
                    Console.WriteLine("Erreur : Veuillez entrer un nombre entier entre 1 et 100.");
                    continue; // Passe à l'itération suivante de la boucle
                }

                nombreEssais++; // Incrémente le nombre d'essais

                // Vérifie si le nombre deviné est plus grand, plus petit ou égal au nombre secret
                if (nombreDevine < nombreSecret)
                {
                    Console.WriteLine("Trop petit ! Essayez encore.");
                }
                else if (nombreDevine > nombreSecret)
                {
                    Console.WriteLine("Trop grand ! Essayez encore.");
                }
                else
                {
                    Console.WriteLine($"Félicitations ! Vous avez deviné le nombre {nombreSecret} en {nombreEssais} essais.");
                }

            } while (nombreDevine != nombreSecret); // Continue jusqu'à ce que l'utilisateur trouve le nombre
        }
    }
