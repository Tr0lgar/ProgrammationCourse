---
layout: cours
title: Fonctions
order: 3  # Ordre de tri
---

# Les Fonctions (ou Méthodes)

## Sommaire
- [1. Introduction aux Fonctions](#1-introduction-aux-fonctions)
- [2. Déclaration d'une Fonction](#2-déclaration-dune-fonction)
- [3. Appel d'une fonction](#3-appel-dune-fonction)
- [4. Les fonctions avec un type de retour `void`](#4-les-fonctions-avec-un-type-de-retour-void)
- [5. Différence entre Paramètres et Arguments](#5-différence-entre-paramètres-et-arguments)
- [6. Les Fonctions surchargées](#6-les-fonctions-surchargées)
- [7. Exercice récapitulatif](#7-exercice-récapitulatif)

## 1. Introduction aux Fonctions
Les **fonctions** (ou **Méthodes**, ça signifie la même chose) sont des blocs de code réutilisables qui accomplissent une tâche spécifique. On peut les comparer à des *"recettes de cuisine"* :une fois que la recette est définie, on peut la réutiliser autant de fois qu'on le souhaite sans devoir la réécrire à chaque fois.

### Pourquoi utiliser des Fonctions ?
- **Organisation du code** : Permet de  diviser un programmes en petites parties gérables.
- **Réutilisation** : Une même fonction peut être appelée plusieurs fois, ce qui évite la répétition du code.
- **Lisibilité** : Le code est plus facile à comprendre, car il est divisé en parties logiques.
- **Maintenance** : Les modifications peuvent être faites à un seul endroit, sans avoir à changer le code partout.

## 2. Déclaration d'une Fonction
Pour créer une fonction, il faut :
1. **Définir le type de retour** : Ce que la fonction va renvoyer après son exécution (par exemple, un `int`, un `string`, etc.). Si elle ne renvoie rien, on utilise le mot-clé `void`.
2. **Donner un nom à la fonction** : Le nom doit être explicite sur ce que fait la fonction.
3. **Spécifier les paramètres *(facultatif)*** : Ce sont les informations que la fonction **peut** recevoir pour effectuer sa tâche.
4. **Écrire le corps de la fonction** : Le code à exécuter à chaque appel de la fonction.

### Exemple de fonction simple
```csharp
// Cette fonction prend 2 nombres entiers en paramètres et renvoie leur somme.
int Addition(int a, int b)
{
    return a + b; // Retourne la somme des deux nombres
}
```
### Explication
- `int` : Le type de retour. Ici, la fonction renvoie un entier (`int`).
- `Addition` : Le nom de la fonction.
- `int a`, `int b` : Les paramètres de la fonction. Ce sont les "ingrédients" que la fonction utilise pour faire son travail.
- `return` : Utilisé pour renvoyer le résultat de la fonction. **Attention**, si le type dde retour de la fonction est `void`, il n'y a pas d'instruction `return` car elle ne retourne rien.

## 3. Appel d'une fonction
Pour utiliser une fonction, il suffit de l'**appeler** en utilisant son nom, et de fournir les paramètres nécessaires.
### Exemple
```csharp
int Resultat = Addition(5, 3);
Console.WriteLine("Le résultat est : " + resultat); // Affiche : Le résultat est : 8
```
Dans cet exemple, la fonction `Addition` est appelée avec les arguments `5` et `3`, et elle renvoie `8`, qui est ensuite stockée dans la variable `Resultat`.

## 4. Les fonctions avec un type de retour `void`
Lorsque vous ne voulez pas que la fonction renvoie une valeur, on peut utiliser le mot-clé void. Ces fonctions effectuent une action, mais ne "donnent" pas de résultat.
### Exemple
```csharp
// Fonction qui affiche un message de bienvenue
void AfficherBienvenue()
{
    Console.WriteLine("Bienvenue dans le programme !");
}

// Appel de la fonction
AfficherBienvenue(); // Affiche : Bienvenue dans le programme !
```
Dans cet exemple, la fonction `AfficherBienvenue` ne renvoie rien, elle se contente d'afficher un message.

## 5. Différence entre Paramètres et Arguments
- Les **paramètres** sont les variables définies dans la déclaration de la fonction, et les **arguments** sont les valeurs que l'on passe à ces paramètres lorsqu'on appelle la fonction.

### Comparaison avec la cuisine
Imaginons que nous avons une recette de gâteau (la fonction) qui demande des œufs et du sucre (les paramètres). Quand on prépare le gâteau, on utilise 2 œufs et 100g de sucre spécifiques (les arguments).

## 6. Les Fonctions surchargées
Les **fonctions surchargées** permettent de définir plusieurs fonctions avec le même nom, mais avec des paramètres différents. C'est comme avoir plusieurs recettes pour différents types de gâteaux, mais avec des ingrédients variés.
### Exemple
```csharp
// Addition de deux entiers
int Addition(int a, int b)
{
    return a + b;
}

// Addition de trois entiers
int Addition(int a, int b, int c)
{
    return a + b + c;
}

// Utilisation des deux fonctions
int somme1 = Addition(2, 3);      // Appelle la première fonction
int somme2 = Addition(2, 3, 4);   // Appelle la seconde fonction
```

## 7. Exercice récapitulatif
### Énoncé :
Dans cet exercice, vous allez créer un petit programme de calculatrice qui permet à l'utilisateur d'effectuer des opérations de base : addition, soustraction, multiplication et division. Chaque opération sera implémentée sous forme de fonction.
Modifiez le code en réalisant les tâches marquées d'un `TODO`
1. **Créer une fonction pour chaque opération** :
    - Créer une fonction `Addition` qui prend en **paramètres** deux nombres et **retourne** leur somme.
    - Créer une fonction `Soustraction` qui prend en **paramètres** deux nombres et **retourne** leur différence.
    - Créer une fonction `Multiplication` qui prend en **paramètres** deux nombres et **retourne** leur produit.
    - Créer une fonction `Division` qui prend en **paramètres** deux nombres et **retourne** leur quotient.
2. **Fonction AfficherMenu** : Créer une fonction `AfficherMenu` qui affiche un menu avec les options disponibles (addition, soustraction, multiplication, division, quitter). Attention, cette fonction ne sert **qu'à afficher quelque chose**, elle ne retourne rien.
3. **Fonction ChoisirOption** : Créer une fonction `ChoisirOption` qui demande à l'utilisateur de choisir une option du menu (en entrant un nombre de 1 à 5). Cette fonction retourne le choix de l'utilisateur sous forme d'entier et ne prend aucun paramètre.
4. **Fonction LireNombre** : Créer une fonction `LireNombre` qui demande à l'utilisateur de saisir un nombre. Elle prend en paramètre `string message` et affiche le `message`, puis transforme la saisie en `double`. Elle retourne le nombre saisi sous forme de `double`.
5. **Boucle principale** : 
   - Afficher menu
   - Lire le choix de l'utilisateur
   - En fonction du choix, appeler la fonction correspondante (addition, soustraction, etc.)
   - Continuer à demander une opération tant que l'utilisateur ne choisit pas de quitter.

### Exemple de sortie :
```
Menu :
1. Addition
2. Soustraction
3. Multiplication
4. Division
5. Quitter

Choisissez une option : 1
Entrez le premier nombre : 5
Entrez le deuxième nombre : 3
Le résultat de l'addition est : 8

Menu :
1. Addition
2. Soustraction
3. Multiplication
4. Division
5. Quitter

Choisissez une option : 5
Au revoir !
```
### Code de départ :
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int choix;

        do
        {
            // TODO: Afficher le menu grace à la fonction AfficherMenu
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
    static int, double ou void? AfficherMenu()
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
```
### Solution
[Télécharger la solution](../solutions/calculatrice.cs)
