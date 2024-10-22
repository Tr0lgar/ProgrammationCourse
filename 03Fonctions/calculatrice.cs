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
                double nombre1 = LireNombre("Entrez le premier nombre : ");
                double nombre2 = LireNombre("Entrez le deuxième nombre : ");

                double resultat = 0;
                switch (choix)
                {
                    case 1:
                        resultat = Addition(nombre1, nombre2);
                        Console.WriteLine("Le résultat de l'addition est : " + resultat);
                        break;
                    case 2:
                        resultat = Soustraction(nombre1, nombre2);
                        Console.WriteLine("Le résultat de la soustraction est : " + resultat);
                        break;
                    case 3:
                        resultat = Multiplication(nombre1, nombre2);
                        Console.WriteLine("Le résultat de la multiplication est : " + resultat);
                        break;
                    case 4:
                        if (nombre2 != 0)
                        {
                            resultat = Division(nombre1, nombre2);
                            Console.WriteLine("Le résultat de la division est : " + resultat);
                        }
                        else
                        {
                            Console.WriteLine("Erreur : Division par zéro !");
                        }
                        break;
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
    static void AfficherMenu()
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
        int.TryParse(Console.ReadLine(), out choix);
        return choix;
    }

    // Fonction pour lire un nombre
    static double LireNombre(string message)
    {
        Console.Write(message);
        double nombre;
        while (!double.TryParse(Console.ReadLine(), out nombre))
        {
            Console.WriteLine("Veuillez entrer un nombre valide.");
            Console.Write(message);
        }
        return nombre;
    }

    // Fonction pour l'addition
    static double Addition(double a, double b)
    {
        return a + b;
    }

    // Fonction pour la soustraction
    static double Soustraction(double a, double b)
    {
        return a - b;
    }

    // Fonction pour la multiplication
    static double Multiplication(double a, double b)
    {
        return a * b;
    }

    // Fonction pour la division
    static double Division(double a, double b)
    {
        return a / b;
    }
}
