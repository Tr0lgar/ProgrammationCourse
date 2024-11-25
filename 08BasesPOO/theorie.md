# Les bases de la POO
Dans ce cours, nous allons traduire les concepts abstraits de la programmation orientée objet (POO) en code concret en utilisant le langage C#. Tu vas apprendre à créer des classes et des objets, et à comprendre leur rôle dans la construction de programmes modulaires, robustes et évolutifs.

## Sommaire
- [Objectifs](#objectifs)
- [1. Classe et Objet : Rappel](#1-classe-et-objet--rappel)
- [2. Créer une Classe en C#](#2-créer-une-classe-en-c)
- [3. Créer et Utiliser un Objet](#3-créer-et-utiliser-un-objet)
- [4. Ajouter un constructeur](#4-ajouter-un-constructeur)
- [5. Exercice pratique](#5-exercice-pratique)
- [Résumé](#résumé)


<hr>

## Objectifs
1. Comprendre ce qu’est une classe et un objet.
2. Apprendre à créer une classe en C#.
3. Apprendre à instancier un objet à partir d’une classe.
4. Manipuler les attributs (propriétés) et les méthodes (comportements) d’un objet.

<hr>

## 1. Classe et Objet : Rappel
Dans la POO, **une classe** est comme une *recette* ou un *plan* : elle définit ce que sont les objets qui en découlent. Par exemple, la classe *Voiture* peut représenter les caractéristiques et les comportements généraux d'une voiture, mais une *voiture spécifique* (comme votre voiture) est un objet de cette classe.
- **Classe** : Définition de la structure et des comportements.
- **Objet** : Une instance (ou un exemplaire) d'une classe, avec des données spécifiques.

**Exemple :**
```txt
Class : Voiture

Attributs : marque, modèle, couleur
Méthodes : accélérer, freiner, exploser
```
Avec cette classe, nous pouvons créer un objet Voiture qui sera une Tesla "Model S" rouge, capable d'accélérer, de freiner et surtout d'exploser car c'est une Tesla

<br>

## 2. Créer une Classe en C#
Voici comment créer une classe de base en C# :
```csharp
public class Voiture
{
    // Attributs (ou propriétés)
    public string Marque; // La marque de la voiture
    public string Modele; // Le modèle de la voiture
    public string Couleur; // La couleur de la voiture

    // Méthodes (ou comportements)
    public void Accelerer()
    {
        Console.WriteLine("La voiture accélère !");
    }

    public void Freiner()
    {
        Console.WriteLine("La voiture freine !");
    }

    public void Exploser()
    {
        Console.WriteLine("Bienvenue chez Tesla !");
    }
}
```
### Explications :

- Les attributs (ex. `Marque`) définissent les caractéristiques de l'objet.
- Les méthodes (ex. `Freiner`) définissent les actions qu'un objet peut efFreiner

<br>

## 3. Créer et Utiliser un Objet
Pour utiliser une classe, on crée un objet (instance de la classe).
### Exemple : Instanciation et manipulation d’un objet
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Création d'un objet de la classe Voiture
        Voiture maVoiture = new Voiture();

        // Initialisation des attributs
        maVoiture.Marque = "Tesla";
        maVoiture.Modele = "Model S";
        maVoiture.Couleur = "Rouge";

        // Utilisation des méthodes
        Console.WriteLine($"Ma voiture est une {maVoiture.Marque} {maVoiture.Modele} de couleur {maVoiture.Couleur}.");
        maVoiture.Accelerer();
        maVoiture.Freiner();
        maVoiture.Exploser();
    }
}
```
#### Résultat attendu :
```txt
Ma voiture est une Tesla Model S de couleur Rouge.
La voiture accélère !
La voiture freine !
Bienvenue chez Testla !
```

<br>

## 4. Ajouter un constructeur
Un constructeur permet d'initialiser (créer) un objet avec des valeurs par défaut.
### Exemple avec un constructeur :
```csharp
public class Voiture
{
    // Attributs
    public string Marque;
    public string Modele;
    public string Couleur;

    // Constructeur
    public Voiture(string marque, string modele, string couleur)
    {
        Marque = marque;
        Modele = modele;
        Couleur = couleur;
    }

    // Méthodes
    public void Demarrer()
    {
        Console.WriteLine("La voiture démarre !");
    }
}
```
### Instanciation avec le constructeur
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Création d'un objet en utilisant le constructeur
        Voiture maVoiture = new Voiture("Tesla", "Model X", "Bleu");

        // Utilisation des attributs et méthodes
        Console.WriteLine($"Ma voiture est une {maVoiture.Marque} {maVoiture.Modele} de couleur {maVoiture.Couleur}.");
        maVoiture.Demarrer();
    }
}
```
**Avantage** : Le constructeur simplifie l'initialisation des objets.

<br>

## 5. Exercice pratique
Crée un classe "Animal" avec les attributs suivants :
- **Nom** (string) : Le nom de l’animal.
- **Espece** (string) : L’espèce de l’animal.
- **Age** (int) : L’âge de l’animal.

Ajoute les méthodes suivantes :
- **Manger()** : Affiche un message du type "L'animal mange."
- **Dormir()** : Affiche "L'animal dort."
- **SeDeplacer()** : Affiche "L'animal se déplace."

Dans le programme principal (`Main`) :
1. Crée 2 objets "Animal" avec des caractéristiques différentes.
2. Affiche leurs caractéristiques.
3. Fais-les effectuer différentes actions avec leurs méthodes.

### Code de départ :
```csharp
class Program
{
    static void Main(string[] args)
    {
        // TODO : Créer et manipuler des objets de type "Animal"
    }
}

public class Animal
{
    // TODO : Définir les attributs, le constructeur, et les méthodes
}
```
#### Petit tips :
Les méthodes d'objet ne servent pas uniquement à faire faire une "action" à l'objet. Par exemple, tu dois afficher les caractéristiques de tes 2 animaux, ce serait sympa de pouvoir faire `MonAnimal01.AfficherCaractéristiques()` tu ne penses pas ?
Tu peux comparer une méthode d'objet à une fonction (comme par exemple `Additionner(n1, n2)`) mais qui est propre à l'objet.

### Solution
[Télécharger la solution](animal.cs)

<br>

## Résumé
- Une **classe** est une définition générale, et un **objet** est une instance spécifique de cette classe.
- Les **attributs** stockent les données d’un objet, et les **méthodes** définissent ses actions.
- Un **constructeur** facilite l'initialisation des objets.

<hr>
🚀 Dans le prochain cours, nous explorerons des concepts plus avancés comme les propriétés, l'encapsulation, et les modificateurs d'accès (public, private, etc.).