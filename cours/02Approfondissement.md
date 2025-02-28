---
layout: cours
title: Approfondissement
order: 2  # Ordre de tri
---

# Approfondissement des concepts de base
## Sommaire
1. [Variables et Opérateurs](#1️⃣-variables-et-opérateurs)
2. [Conditions (if/else, switch)](#2️⃣-conditions-ifelse-switch)
3. [Boucles (for, while, do while)](#3️⃣-boucles-for-while-do-while3-boucles-for-while-do-while)
4. [Exercices pratiques](#4️⃣-exercices-pratiques-4-exercices-prat)

---

## 1️⃣ Variables et Opérateurs
Les variables sont utilisées pour stocker des données et les manipuler. Nous allons approfondir les différents types de variables et les opérateurs couramment utilisés.

### Types de Variables
Les variables peuvent stocker différents types de données. Voici un rappel des types de données les plus courants :
- `int` : Nombre entier (ex. 42)
- `double` : Nombre à virgule flottante (ex. 3.14)
- `bool` : Valeur booléenne (true ou false)
- `char` : Caractère unique (ex. 'A')
- `string` : Chaîne de caractères (ex. "Bonjour")

### Opérateurs
Les opérateurs permettent de manipuler les variables de différentes manières. Voici les catégories principales d'opérateurs :
#### Opérateurs arithmétiques :
- `+` : Addition
- `-` : Soustraction
- `*` : Multiplication
- `/` : Division
- `%` : Modulo (reste de la division)

```csharp
int a = 10;
int b = 3;
int somme = a + b; // 13
int produit = a * b; // 30
int reste = a % b; // 1
```

#### Opérateurs de comparaison :
- `==` : Égalité
- `!=` : Différent
- `>` : Supérieur
- `<` : Inférieur
- `>=` : Supérieur ou égal
- `<=` : Inférieur ou égal

```csharp
int x = 5;
int y = 10;
bool estEgal = (x == y); // false
bool estPlusGrand = (x > y); // false
```

#### Opérateurs logiques :
- `&&` : AND logique
- `||` : OR logique
- `!` : NOT logique

```csharp
bool a = true;
bool b = false;
bool resultat = a && b; // false
bool inversion = !a; // false
```

<br>

## 2️⃣ Conditions (if/else, switch)
Les structures conditionnelles permettent d'exécuter du code différemment en fonction de certaines conditions.
### Structure `if/else`
La structure `if/else` permet de prendre des décision en fonction de l'évaluation d'une expression booléenne.
```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Vous êtes majeur.");
}
else if (age == 17)
{
    Console.WriteLine("Vous serez majeur l'année prochaine.");
}
else
{
    Console.WriteLine("Vous êtes mineur.");
}
```
### Structure `switch`
La structure `switch` est une alternative aux instructions `if/else` lorsque l'on doit comparer une même variable à plusieurs valeurs.
```csharp
char grade = 'B';

switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent !");
        break; // Super impotant, ne pas oublier le break;
    case 'B':
        Console.WriteLine("Très bien !");
        break;
    case 'C':
        Console.WriteLine("Bien.");
        break;
    case 'D':
        Console.WriteLine("Passable.");
        break;
    default:
        Console.WriteLine("Échec.");
        break;
}
```

<br>

## 3️⃣ Boucles (for, while, do while)
Les boucles permettent de répéter des instructions. Les boucles imbriquées et les conditions complexes permettent de créer des logiques plus sophistiquées.
### Boucle `for`
La boucle `for` est souvent utilisée lorsque le nombre d'itérations est connu à l'avance.
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Itération : " + i);
}
```
### Boucle `while`
La boucle `while` s'exécute tant que la condition est vraie.
```csharp
int compteur = 0;

while (compteur < 5)
{
    Console.WriteLine("Compteur : " + compteur);
    compteur++;
}
```
### Boucle `do while`
La boucle `do while` s'exécute au moins une fois, car la condition est vérifiée après l'exécution du bloc.
```csharp
int compteur = 0;

do
{
    Console.WriteLine("Compteur : " + compteur);
    compteur++;
} while (compteur < 5);
```

### Boucles Imbriquées et Conditions Complexes 
Les boucles imbriquées permettent d'exécuter une boucle à l'intérieur d'une autre boucle.
```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```
Ce code génère un triangle de caractères `*`.

<br>

## 4️⃣ Exercices Pratiques :
### Exercice 1 : Calculer la somme des n premiers nombres
```csharp
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

        // À toi de compléter : Utilise une boucle pour additionner les nombres de 1 à n
        // ...

        // Affiche le résultat (à faire après avoir calculé la somme)
        Console.WriteLine("La somme des " + n + " premiers nombres est : " + somme);
    }
}
```
#### Explications : 
- **Boucle `do while`** : permet de garantir que l'utilisateur saisit au moins un nombre. Si la saisie n'est pas valide (pas un entier ou un entier non positif), la boucle continue.
- **Validation de l'entrée** : La vérification se fait avec `inc.TryParse` pour essayer de convertir la saisie en entier (`n`), puis on vérifie que `n > 0`. Si les deux condition sont remplies, on sort de la boucle avec `break;`.

### Exercice 2 : Trouve la couleur
```csharp
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

        Console.WriteLine("Devinez la couleur (rouge, bleu, vert, jaune) :");
        string reponseUtilisateur = Console.ReadLine();

        // À toi de compléter : Compare la réponse de l'utilisateur avec la couleur secrète
        // Utilise StringComparison.OrdinalIgnoreCase pour ignorer la casse (majuscules/minuscules)
        // Par exemple : "Rouge" et "rouge" seront considérés comme identiques
        // (Voir explications supplémentaires plus bas)

        // Syntaxe : if (string.Equals(reponseUtilisateur, couleurSecrete, StringComparison.OrdinalIgnoreCase))
        // Cela permet de comparer les deux chaînes de caractères sans tenir compte des majuscules et minuscules

        // Si l'utilisateur a trouvé, affiche un message de félicitations
        // Sinon, indique que ce n'est pas la bonne couleur

        // Astuce : Pour donner plusieurs chances à l'utilisateur de deviner, utilise une boucle do while
        // Continue à demander tant que l'utilisateur n'a pas trouvé la bonne couleur
    }
}
```
#### Explications supplémentaires :
- **StringComparison.OrdinalIgnoreCase** :  Cet argument est utilisé pour comparer deux chaînes de caractères en ignorant la casse, c'est-à-dire que "Rouge" et "rouge" seront considérés comme identiques. La comparaison devient donc insensible aux majuscules et minuscules. Voici un exemple de son utilisation :

```csharp
if (string.Equals("Rouge", "rouge", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Les deux chaînes sont identiques !");
}
```
Dans cet exemple, le programme considère que "Rouge" et "rouge" sont égaux grâce à `StringComparison.OrdinalIgnoreCase`.

- **Boucle `do while`** : Tu peux entourer la saisie de l'utilisateur et la vérification de la réponse avec une boucle `do while` pour que le programme continue à demander une réponse tant que l'utilisateur n'a pas trouvé la bonne couleur. Cela permet de répéter les essais jusqu'à ce que la couleur correcte soit devinée.

### Solutions :
- [Télécharger la solution de l'exercice 1](../solutions/somme.cs)
- [Télécharger la solution de l'exercice 2](../solutions/devineLaCouleur.cs)
