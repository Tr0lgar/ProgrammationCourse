# Approfondissement des concepts de base
## Sommaire
- [1. Variables et Opérateurs](#1-variables-et-operateurs)
- [2. Conditions (if/else, switch)](#2-conditions-if-else-switch)
- [3. Boucles (`for`, `while`, `do while`)](#3-boucle-for-while-do-while)
- [4. Exercices pratiques](#4-exercices-pratiques)

## 1. Variables et Opérateurs
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

## 2. Conditions (if/else, switch)
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
## 3. Boucles (`for`, `while`, `do while`)
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
Les boucles imbriquées permettent d'exécuter une boucle à l'inérieur d'une autre boucle.
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
Ce code génère un triangle de charactères `*`.

## 4. Exercices Pratiques :
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
