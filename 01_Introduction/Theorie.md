# Sommaire
1. [Qu'est-ce que la programmation ?](#quest-ce-que-la-programmation-)
2. [Les concepts de base de la programmation](#les-concepts-de-base-de-la-programmation)
  
## 1. Qu'est-ce que la programmation ?
Explication : La programmation, c'est l'art de donner des instructions à un ordinateur pour qu'il accomplisse des tâches. Cela se fait en écrivant du code dans un langage de programmation, qui est une sorte de langage spécial que les humains utilisent pour communiquer avec les machines. Quand on écrit un programme, on crée une suite d'instructions que l'ordinateur va suivre.
### Exemple simple :
- Une recette de cuisine c'est une suite d'étapes à réaliser pour obtenir un plat. Un programme c'est une liste d'étapes pour que l'ordinateur réalise une tâche, comme afficher un message ou résoudre un calcul.

## 2. Les concepts de base de la programmation
### Variables et types de données
- une variable est un espace mémoire où l'on stocke des informations que le programme peut utiliser. chaque variable a un nom et un type de données (par exemple, un nombre, un texte, etc.)
### Exemple en C# :
```C#
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
