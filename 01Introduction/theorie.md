# Introduction à la programmation (C#)
## Sommaire :
- [1. Qu'est-ce que la programmation ?](#1-quest-ce-que-la-programmation-)
- [2. Les concepts de base de la programmation](#2-les-concepts-de-base-de-la-programmation)
    - [Variables et types de données](#variables-et-types-de-données)
    - [Instructions et séquences](#instructions-et-séquences)
    - [Conditions if/else](#conditions-ifelse)
    - [Boucles (for, while, do while, etc.)](#boucles-for-while-do-while-etc)
    - [Différence entre `while` et `do while` :](#différence-entre-while-et-do-while-)
- [3. Premier programme : "Hello, World !"](#3-premier-programme--hello-world-)
- [4. Quelques bonnes pratiques pour débuter](#4-quelques-bonnes-pratiques-pour-débuter)
- [5. Exercice : Crée un jeu "Devine le nombre"](#5-exercice--crée-un-jeu-devine-le-nombre)
    
## 1. Qu'est-ce que la programmation ?
Explication : La programmation, c'est l'art de donner des instructions à un ordinateur pour qu'il accomplisse des tâches. Cela se fait en écrivant du code dans un langage de programmation, qui est une sorte de langage spécial que les humains utilisent pour communiquer avec les machines. Quand on écrit un programme, on crée une suite d'instructions que l'ordinateur va suivre.
### Exemple simple :
- Une recette de cuisine c'est une suite d'étapes à réaliser pour obtenir un plat. Un programme c'est une liste d'étapes pour que l'ordinateur réalise une tâche, comme afficher un message ou résoudre un calcul.

## 2. Les concepts de base de la programmation
### Variables et types de données
- Une variable est un espace mémoire où l'on stocke des informations que le programme peut utiliser. chaque variable a un nom et un type de données (par exemple, un nombre, un texte, etc.)
- Il y a plusieurs manières de nommer ses variables, mais la plus répendue est le camelCase : Cela consiste à écrire le premier mot du nom tout en minuscule et de coller et commencer les autres mots par une majuscule. Exemple : `maNouvelleVariable`

### Exemple en C# :
```csharp
int age = 21; // Variable de type entier (int)
string name = Mathieu; // Variable de type chaine de carctères (string)
double temperature = 18.5; // Variable de type décimale (double)
```
- Il existes plusieurs types de variables en fonction de l'utilité de cette dernière. Chaque type possède une taille et une plage de valeur.
  
| Type            | Taille (en bits) | Plage de valeurs                                | Exemple                  |
|-----------------|------------------|-------------------------------------------------|--------------------------|
| `byte`          | 8                | 0 à 255                                          | 100                       |
| `sbyte`         | 8                | -128 à 127                                       | -50                       |
| `short`         | 16               | -32 768 à 32 767                                 | -12345                    |
| `ushort`        | 16               | 0 à 65 535                                       | 12345                     |
| `int`           | 32               | -2 147 483 648 à 2 147 483 647                   | 100000                    |
| `uint`          | 32               | 0 à 4 294 967 295                                | 300000                    |
| `long`          | 64               | -9 223 372 036 854 775 808 à 9 223 372 036 854 775 807 | 10000000000              |
| `ulong`         | 64               | 0 à 18 446 744 073 709 551 615                   | 10000000000               |
| `float`         | 32               | ±1.5 × 10^−45 à ±3.4 × 10^38 (précision : 6-9 chiffres) | 3.14159f                  |
| `double`        | 64               | ±5.0 × 10^−324 à ±1.7 × 10^308 (précision : 15-17 chiffres) | 3.14159265359             |
| `decimal`       | 128              | ±1.0 × 10^−28 à ±7.9 × 10^28 (précision : 28-29 chiffres) | 3.14159265358979323846m   |
| `bool`          | 8                | `true` ou `false`                                | `true`                    |
| `char`          | 16               | Caractères Unicode (0 à 65 535)                  | 'A'                       |
| `string`        | Variable         | Séquence de caractères                           | "Bonjour, monde !"        |

- Les types `int`, `long`, etc. sont utilisés pour les nombres entiers (sans virgule). Les types `float`, `double`, et `decimal` sont utilisés pour les nombres à virgule, avec différentes précisions.

### Instructions et séquences
- Un programme est composé d'instructions, et celles-ci sont exécutées les unes après les autres. Une instructions peut être une affectation de variable, un affichage, etc.

### Exemple en C# :
```csharp
Console.WriteLine("Bonjour Mathieu !"); // Affiche un message
age = age + 1; // Incrémente la variable age de 1
```
### Conditions if/else
- Les conditions permettent de faire un choix dans le programme. On peut dire à l'ordinateur de faire une chose ou une autre selon la situation.

### Exemple en C# :
```csharp
if (age >= 18) // Si la variable age est plus grande ou = à 18, on affiche le message "Vous êtes majeur."
{
    Console.WriteLine("Vous êtes majeur.");
}
else // Dans le cas contraire, on affiche le message "Vous êtes mineur."
{
    Console.WriteLine("Vous êtes mineur.");
}
```

### Boucles (for, while, do while, etc.)
- Les boucles permettent de répéter une série d'instructions plusieurs fois, ce qui est utile quand on doit exécuter la même tâche à plusieurs reprises.

### Exemple de boucle `for` en C# :
Une boucle `for` est utile quand on sait à l'avance combien de fois on veut répéter une action. Voici un exemple :
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ceci est la répétition numéro " + i);
}
```
- **Question** : Quel sera le dernier chiffre affiché ? *(vérifie ta réponse en copiant et en exécutant le code sur ton ordi)*
### Exemple de boucle `while` en C# :
La boucle `while` est utilisée lorsque le nombre d'itérations n'est pas connu à l'avance. Elle continue de s'exécuter tant qu'une condition donnée est vraie. La condition est vérifiée avant l'exécution du corps de la boucle, ce qui signifie qu'il est possible que la boucle ne s'exécute jamais si la condition est fausse dès le départ.
Voici un exemple :
```csharp
int compteur = 0;
while (compteur < 5)
{
    Console.WriteLine("Ceci est l'itération numéro " + compteur);
    compteur++;
}
```
Dans cet exemple, la boucle s'exécute tant que la variable `compteur` est inférieure à 5. À chaque itération, le programme affiche le message, puis incrémente la valeur de `compteur` de 1.
- **Question** : Que se passe-t-il si la variable `compteur` est initialisée à 5 au lieu de 0 ? *(vérifie ta réponse en copiant et en exécutant le code sur ton ordi)*

### Exemple de boucle `do while` en C# :
La boucle `do while` est similaire à la boucle `while`, mais avec une différence importante : le corps de la boucle est exécuté au moins une fois, quelle que soit la condition, car la condition est vérifiée après l'exécution du corps.
Voici un exemple :
```csharp
int compteur = 0;
do
{
    Console.WriteLine("Ceci est l'itération numéro " + compteur);
    compteur++;
} while (compteur < 5);
```
Dans cet exemple, la boucle `do while` exécute d'abord le corps de la boucle (affiche le message et incrémente le compteur), puis vérifie la condition `compteur < 5`. Tant que cette condition est vraie, la boucle continue de s'exécuter.
- **Question** : Que se passe-t-il si la variable `compteur` est initialisée à 5 avant la boucle `do while` ? Combien de fois le message sera-t-il affiché ? *(vérifie ta réponse en copiant et en exécutant le code sur ton ordi)*

### Différence entre `while` et `do while` :
- Boucle `while` :  La condition est vérifiée avant l'exécution du corps de la boucle. Si la condition est fausse dès le départ, le corps de la boucle ne sera jamais exécuté.
- Boucle `do while` : Le corps de la boucle est exécuté au moins une fois, car la condition est vérifiée après l'exécution du corps.
Ces différences permettent de choisir la boucle la plus adaptée selon le contexte. Utilise la boucle `while` si tu souhaites vérifier la condition avant chaque itération, et la boucle `do while` si tu veux que le corps soit exécuté au moins une fois, même si la condition est fausse dès le début.

## 3. Premier programme : "Hello, World !"
Le programme "Hello, World !" est souvent le premier programme écrit par les débutants. Il permet de comprendre comment fonctionne l'affichage à l'écran.
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```
### Explication du code :
- `using System;` : Indique que l'on utilise les fonctionnalités de base de C#
- `class Program` : Définit une classe nommées `Program`. Une classe, c'est un peu comme une boîte qui peut contenir des choses : des données et des instructions pour les manipuler.
- `static void Main(string[] args)` : La méthode `Main` est le point d'entrée du programme.
- `Console.WriteLine("Hello, World !");` : Affiche le texte à l'écran. Console est une classe et WriteLine() une méthode appartenant à cette classe.

## 4. Quelques bonnes pratiques pour débuter
- Utiliser des noms de variables clairs et explicites : Cela rend le code plus facile à comprendre
- Commenter le code : Ajouter des commentaires pour expliquer ce que fait le code.
- Tester le code régulièrement ; Ne pas attendre d'avoir écrit tout le programme pour tester.

## 5. Exercice : Crée un jeu "Devine le nombre"

### Enoncé :
Dans cet exercice, tu vas créer un petit jeu où l'utilisateur doit deviner un nombre secret. Le programme va choisir un nombre aléatoire entre 1 et 100, et l'utilisateur devra essayer de le deviner. À chaque tentative, le programme dira si le nombre est plus grand ou plus petit que le nombre à deviner. Le jeu continue jusqu'à ce que l'utilisateur trouve le bon nombre. Une fois le nombre deviné, le programme affichera le nombre de tentatives effectuées.

### Instructions :
1. Crée une variable pour stocker le nombre aléatoire, que le programme génère entre 1 et 100.
2. Demande à l'utilisateur de deviner le nombre. Si le nombre deviné est incorrect, indique si le nombre secret est plus grand ou plus petit.
3. Continue de demander à l'utilisateur de deviner jusqu'à ce qu'il trouve le bon nombre.
4. Lorsque le nombre est trouvé, affiche un message de félicitations et le nombre de tentatives nécessaires pour deviner le nombre.
Utilise `Console.ReadLine()` pour lire l'entrée de l'utilisateur. **Attention**, l'entrée de l'utilisateur ne sera pas considérée comme un nombre mais comme une chaine de caractères, il fauddra penser à la transformer ;).

### Code de départ :
Voici un début de code pour te mettre sur la bonne voie :

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Génère un nombre aléatoire entre 1 et 100
        Random rand = new Random();
        int nombreSecret = rand.Next(1, 101);
        
        int nombreDevine = 0; // Stocke le nombre deviné par l'utilisateur
        // Crée une variable (int ou double ?) nombreEssais = 0 pour compter le nombre de tentatives

        Console.WriteLine("Bienvenue dans le jeu de devine le nombre !");
        Console.WriteLine("J'ai choisi un nombre entre 1 et 100. Essayez de le deviner.");

        // Boucle pour les tentatives
        // A toi de compléter la suite
    }
}
```
### Indices :
- Quelle boucle ? Tu ne connais pas le nombre d'itérations dont tu as besoin, ce n'est donc pas une boucle `for`. Fais le bon choix entre `while` et `do while` ;).
- Stocke l'entrée utilisateur dans une variable `string` et transforme-là en utilisant `int32.Parse()` (idéalement ce serait mieux d'utiliser int.TryParse(), pour pouvoir vérifier si l'entrée est valide ou pas).
- Pour vérifier si le nombre deviné est plus grand ou plus petit que le nombre secret, utilise une condition `if/else`.
- N'oublie pas d'incrémenter (+1) la variable `nombreEssais` à chaque tentative.

### Solution :
[Télécharger la solution .cs](devineLeNombre.cs)