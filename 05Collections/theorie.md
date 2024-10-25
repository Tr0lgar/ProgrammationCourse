# Les Collections

## Sommaire : 
- [1. Introduction](#1-introduction)
- [2. Les types de Collections](#2-les-types-de-collections)
- [3. Focus sur les Listes (List&lt;T&gt;)](#3-focus-sur-les-listes-listt)

## 1. Introduction
Les collections en C# sont des structures de données qui permettent de stocker et de gérer un ensemble d'éléments, de manière **dynamique et plus flexible qu'un tableau classique**. Contrairement aux tableaux, les collections peuvent changer de taille dynamiquement (ajouter ou supprimer des éléments facilement) et fournissent des méthodes pratiques pour manipuler les données.

### Pourquoi utiliser des Collections ?
- **Flexibilité** : Les collections peuvent redimensionner automatiquement en fonction des ajouts ou suppressions d'éléments.
- **Méthodes utilitaires** : Elles fournissent des méthodes pour rechercher, trier, ajouter, et supprimer des éléments.
- **Types variés** : Plusieurs types de collections sont disponibles pour répondre à des besoins spécifiques.

## 2. Les types de Collections
Voici une liste non exhaustive des collections les plus couramment utilisées :
1. **List&lt;T&gt;** : Ine liste générique qui permet de stocker des éléments de n'importe que type.
2. **Dictionary<TKey, TValue>** : Une collection qui associe des clés à des valeurs, comme un dictionnaire.
3. **Queue&lt;T&gt;** : Une file d'attente (FIFO - Premier Entré, Premier Sorti).
4. **Stack&lt;T&gt;** : Une pile (LIFO - Dernier Entré, Premier Sorti).
5. **HashSet&lt;T&gt;** : Une collection de valeurs uniques, sans doublons.
6. **LinkedList&lt;T&gt;** : Une liste chaînée où les éléments sont reliés entre eux par des liens.

### Exemple basique d'utilisation de ces différentes Collections : 
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Liste
        List<int> listeEntiers = new List<int> { 1, 2, 3 };
        listeEntiers.Add(4); // Ajout d'un élément

        // Dictionnaire
        Dictionary<string, int> agePersonnes = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 }
        };
        agePersonnes["Charlie"] = 35; // Ajout d'une nouvelle entrée

        // Queue
        Queue<string> fileAttente = new Queue<string>();
        fileAttente.Enqueue("Personne1");
        fileAttente.Enqueue("Personne2");
        fileAttente.Dequeue(); // Retire "Personne1"

        // Stack
        Stack<double> pile = new Stack<double>();
        pile.Push(1.5);
        pile.Push(2.5);
        pile.Pop(); // Retire 2.5

        // HashSet
        HashSet<string> ensemble = new HashSet<string> { "pomme", "banane" };
        ensemble.Add("cerise");
        ensemble.Add("pomme"); // Ignoré car "pomme" existe déjà

        // LinkedList
        LinkedList<int> listeChainee = new LinkedList<int>();
        listeChainee.AddLast(10);
        listeChainee.AddFirst(5);
    }
}
```

## 3. Focus sur les Listes (List&lt;T&gt;)
Les listes sont l'une des collections les plus utilisées en C#. Elles permettent de stocker un ensemble d'éléments d'un type spécifique (grâce au `<T>0`, le type générique) et sont capables de se redimensionner dynamiquement.

### Déclaration et Initialisation d'une List
Pour créer une liste, il faut spécifier le type d'éléments qu'elle va contenir. Par exemple :
```csharp
List<int> nombres = new List<int>(); // Liste vide
List<string> noms = new List<string> { "Alice", "Bob", "Charlie" }; // Liste initialisée avec des éléments
```
### Méthodes Utiles pour manipuler une List
1. Ajouter un élément : `add`
```csharp
nombres.Add(10); // nombres étant la liste créée plus tôt
```
2. Ajouter plusieurs éléments `AddRange`
```csharp
nombres.AddRange(new List<int> { 20, 30, 40 });
```
3. Accéder à un éléments par son index :
```csharp
int premierNombre = nombres[0]; // Accède au premier élément
```
4. Insérer un éléments à une position précise : `Insert`
```csharp
nombres.Insert(1, 15); // Insère 15 à l'index 1
```
5. Supprimer un élément : `Remove`
```csharp
nombres.Remove(10); // Supprime la première occurrence de 10
```
6. Supprimer à une position précise : `RemoveAt`
```csharp
nombres.RemoveAt(0); // Supprime l'élément à l'index 0
```
7. Rechercher un élément : `Contains`
```csharp
bool contient20 = nombres.Contains(20); // Vérifie si 20 est présent dans la liste
```
8. Parcourir la liste :
```csharp
foreach (int nombre in nombres)
{
    Console.WriteLine(nombre);
}
```

### Exemple de manipulation
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Création d'une liste de nombres
        List<int> nombres = new List<int> { 5, 10, 15, 20 };

        // Ajout de nouveaux éléments
        nombres.Add(25);
        nombres.AddRange(new List<int> { 30, 35 });

        // Affichage des éléments
        Console.WriteLine("Les éléments de la liste :");
        foreach (int nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        // Suppression d'un élément
        nombres.Remove(10);

        // Vérification de la présence d'un élément
        if (nombres.Contains(20))
        {
            Console.WriteLine("La liste contient le nombre 20.");
        }

        // Nombre d'éléments dans la liste
        Console.WriteLine("Nombre d'éléments dans la liste : " + nombres.Count);
    }
}
```
#### Questions :
- Dans la boucle  `foreach`, combien d'éléments vont être affichés ?
- Est-ce que le programme va afficher `La liste contient le nombre 20` ? Que ce passerait-il si on modifiait `if (nombres.Contains(20))` par `if (nombres.Contains(10))` ?
- Combien d'éléments vont être affichés à la fin du programme ?

### Comparaison avec un Tableau
- Les **tableaux** ont une taille fixe une fois créés, alors que les **listes** peuvent être redimensionnées.
- Les listes offrent des **méthodes pratiques** pour ajouter, supprimer et rechercher des éléments.
- Les listes sont plus adaptées lorsque vous avez besoin d'une structure de données dont la taille peut varier.

## 4. *Suite*
*Le contenu de cette page peut être potentiellement modifié pour faire le focus d'autres collections*