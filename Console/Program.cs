using System;

class Program
{
    static void Main(string[] args)
    {
        int choix;

        do
        {
            AfficherMenu();
            choix = ChoisirOption();

            if (choix >= 1 && choix <= 4) // Si l'utilisateur choisit une opération
            {
                double nombre1 = // TODO: Appeler la fonction LireNombre et passer en argument le message "Entrez le premier nombre :"
                double nombre2 = // TODO

                double resultat = 0;
                switch (choix)
                {
                    case 1:
                        resultat = Addition(nombre1, nombre2);
                        Console.WriteLine("Le résultat de l'addition est : " + resultat);
                        break;
                    case 2:
                        // TODO: Gérer la soustraction
                    case 3:
                        // TODO: Gérer la multiplication
                    case 4:
                        // TODO: Gérer la division. Attention à la division par zéro
                }
            }
            else if (choix != 5)
            {
                Console.WriteLine("Veuillez choisir une option valide.");
            }

        } while (choix != 5); // Continue tant que l'utilisateur ne choisit pas de quitter

        Console.WriteLine("Au revoir !");
    }

    // Fonction pour afficher le menu
    // TODO: Choisit le bon type de retour
    static int, double ou void ? AfficherMenu()
    {
        Console.WriteLine("\nMenu :");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Soustraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Quitter");
    }

    // Fonction pour choisir une option
    static int ChoisirOption()
    {
        Console.Write("Choisissez une option : ");
        int choix;
        // TODO: Utiliser TryParse pour transformer l'entrée en int
        // TODO: retourner choix
    }

    // Fonction pour lire un nombre
    static double LireNombre(string message)
    {
        Console.Write(message);
        double nombre;
        // TODO: transformer la saisie en double grace à double.TryParse()
        return nombre;
    }

    // Fonction pour l'addition
    static double Addition(double a, double b)
    {
        return a + b;
    }

    // TODO: Fonction pour la soustraction
    

    // TODO: Fonction pour la multiplication
    

    // TODO: Fonction pour la division
    
}
