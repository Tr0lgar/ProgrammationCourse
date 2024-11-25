using System;

class Program
{
    static void Main(string[] args)
    {
        // Création du premier objet Animal
        Animal chien = new Animal("Buddy", "Chien", 5);
        chien.AfficherCaracterisitiques();
        chien.Manger();
        chien.Dormir();
        chien.SeDeplacer();

        Console.WriteLine(); // Ligne vide pour séparer les deux animaux

        // Création du deuxième objet Animal
        Animal chat = new Animal("Mimi", "Chat", 3);
        chat.AfficherCaracterisitiques();
        chat.Manger();
        chat.Dormir();
        chat.SeDeplacer();
    }
}

public class Animal
{
    // Attributs
    public string Nom;    // Nom de l'animal
    public string Espèce; // Espèce de l'animal
    public int Age;       // Âge de l'animal

    // Constructeur
    public Animal(string nom, string espece, int age)
    {
        Nom = nom;
        Espèce = espece;
        Age = age;
    }

    // Méthodes
    public void Manger()
    {
        Console.WriteLine($"{Nom} est en train de manger.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nom} est en train de dormir.");
    }

    public void SeDeplacer()
    {
        Console.WriteLine($"{Nom} se déplace.");
    }

    public void AfficherCaracterisitiques()
    {
        Console.WriteLine($"Nom : {Nom}, Espèce : {Espèce}, Âge : {Age} ans");
    }
}
