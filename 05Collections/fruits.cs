using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>();
        bool continuer = true;
        string choice ;

        while (continuer)
        {
            showMenu();
            
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Entrez le fruit à ajouter : ");
                    fruits.Add(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Entrez le fruit à enlever : ");
                    string fruit = Console.ReadLine();
                    bool delete = fruits.RemoveAll(fruits => fruits.Equals(fruit, StringComparison.OrdinalIgnoreCase)) > 0;
                    if (delete)
                    {
                        Console.WriteLine($"Le fruit '{fruit}' a bien été enlevé.");
                    }
                    else
                    {
                        Console.WriteLine($"Le fruit '{fruit}' n'a pas été trouvé dans la liste.");
                    }
                    break;
                case "3":
                    if (fruits.Count() > 0)
                    {
                        showList(fruits);
                    }
                    else
                    {
                        Console.WriteLine("La liste est vide.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Entrez le fruit à rechercher : ");
                    string fruitToSearch = Console.ReadLine();
                    bool found = fruits.Exists(fruits => fruits.Equals(fruitToSearch, StringComparison.OrdinalIgnoreCase));
                    if (found)
                    {
                        Console.WriteLine($"Le fruit {fruitToSearch} a été trouvé dans la liste");
                    }
                    else
                    {
                        Console.WriteLine($"Le fruit n'est pas dans la liste.");
                    }
                    break;
                case "5":
                    if (fruits.Count() <= 0)
                    {
                        Console.WriteLine("La liste est déjà vide.");
                    }
                    else
                    {
                        fruits.Clear();
                        Console.WriteLine("La liste est maintenant vide.");
                    }
                    break;
                case "6":
                    continuer = false;
                    break;
            }
        } 
    }
    private static void showMenu()
    {
        Console.WriteLine("\nMenu");
        Console.WriteLine("1. Ajouter un fruit");
        Console.WriteLine("2. Supprimer un fruit");
        Console.WriteLine("3. Afficher la liste");
        Console.WriteLine("4. Rechercher un fruit");
        Console.WriteLine("5. Supprimer toute la liste");
        Console.WriteLine("6. Sortir");
    }

    public static void showList(List<string> list)
    {
        foreach (string name in list)
        {
            Console.WriteLine($"- {name}");
        }
    }
    
}
