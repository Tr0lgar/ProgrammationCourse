# Approfondissement des concepts de base
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
#### 1. Opérateurs arithmétiques :
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
#### 2. Opérateurs de comparaison :
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
#### 3. Opérateurs logiques :
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
