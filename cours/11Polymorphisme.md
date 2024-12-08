---
layout: cours
title: Polymorphisme
order: 11  # Ordre de tri
---

# Le Polymorphisme

**Précision avant de commencer :**  
Dans ce cours, **pour des raisons de simplicité**, nous allons écrire **les classes et le programme principal (`Main`) dans le même fichier**. Cependant, dans un contexte professionnel ou pour des projets plus complexes, il est recommandé de **séparer chaque classe dans des fichiers distincts**. Cela permet d'avoir un code plus clair, mieux organisé et facile à maintenir.

---

## 📚 Sommaire
1. [Introduction au polymorphisme](#1️⃣-introduction-au-polymorphisme)
2. [Concepts essentiels](#2️⃣-concepts-essentiels)
3. [Polymorphisme via l'héritage](#3️⃣-polymorphisme-via-lhéritage)
4. [Virtual / Override](#4️⃣-virtual--override)
5. [Abstract / Override](#5️⃣-abstract--override)
6. [Appel à la classe de base](#6️⃣-appel-à-la-classe-de-base)
7. [La méthode ToString()](#7️⃣-la-méthode-tostring)
8. [Exemple complet](#8️⃣-exemple-complet)
9. [Exercice](#9️⃣-exercice)

---

## 1️⃣ Introduction au polymorphisme
Le mot **polymorphisme** signifie **"plusieurs formes"**. En POO, cela permet d'utiliser des objets de classes différentes via une **même interface** (la classe de base), ce qui rend le code **plus flexible et réutilisable**.

<br>

## 2️⃣ Concepts essentiels

### ⚙️ **Héritage**
- **Concept** : Une classe dérivée hérite des membres publics et protégés d'une classe de base.  
- **Syntaxe UML** : Représenté par une flèche avec un triangle pointant vers la classe parente.

#### Exemple :
```csharp
class Animal
{
    public void Manger() 
    {
        Console.WriteLine("L'animal mange.");
    }
}

class Chien : Animal 
{
    public void Aboyer() 
    {
        Console.WriteLine("Le chien aboie.");
    }
}
```

### 🔄 Redéfinition
- **Concept** : Une classe enfant peut redéfinir (remplacer) une méthode de la classe parent.
- **Mots-clés utilisés** : `virtual`, `override` ou `abstract` (nous verrons la différence plus tard).

### 🚀 Différence entre surcharge et redéfinition

|Surcharge                      |Polymorphisme / Redéfinition                   |
|-------------------------------|-----------------------------------------------|
|Même classe                    |Hiérarchie de classes                          |
|Différente signature           |Même signature                                 |
|Utilise `params`, `ref`, etc.  |Utilise `virtual`, `override` et `abstract`    |

<br>

## 3️⃣ Polymorphisme via l'héritage
Grâce au **polymorphisme dynamique**, on peut stocker des objets de différentes classes dans des variables du type de la classe de base.
Cela permet d'écrire du **code générique** qui peut s'adapter à plusieurs classes.

#### Exemple :
```csharp
Animal monAnimal;

monAnimal = new Chien();
monAnimal.Parler(); // "Le chien aboie."

monAnimal = new Chat();
monAnimal.Parler(); // "Le chat miaule."
```
Dans ce cas, **le type dynamique** de `monAnimal` (Chien ou Chat) détermine quelle méthode **Parler()** est appelée.

<br>

## 4️⃣ Virtual / Override

### Virtual
- Une méthode de la classe parente peut être marquée **virtual**.
- Cela signifie qu'elle peut être **redéfinie** dans une classe dérivée.

### Override
- La méthode redéfinie dans la classe enfant doit être marquée avec **override**.
- La signature de la méthode doit être **exactement la même** que celle de la classe parente.

#### Exemple
```csharp
class Animal
{
    public virtual void Parler()
    {
        Console.WriteLine("L'animal fait un bruit.");
    }
}

class Chien : Animal
{
    public override void Parler()
    {
        Console.WriteLine("Le chien aboie.");
    }
}
```

<br>

## 5️⃣ Abstract / Override

### Classe abstract
- Une classe abstraite ne peut pas être **instanciée**.
- Elle contient souvent des méthodes **abstract**, c'est-à-dire **sans corps**.
- Une méthode **abstract** doit être obligatoirement redéfinie par les classes dérivées.

#### Exemple :
```csharp
abstract class Animal
{
    public abstract void Parler();
}

class Chat : Animal
{
    public override void Parler()
    {
        Console.WriteLine("Le chat miaule.");
    }
}
```

<br>

## 6️⃣ Appel à la classe de base
Il est possible de **réutiliser le comportement de la classe parent** lors de la redéfinition.

### base.
- Appelle une méthode de la casse parent.

### base()
- Appelle le **constructeur parent** depuis le constructeur de la classe dérivée.

#### Exemple :
```csharp
class Animal
{
    public virtual void Parler()
    {
        Console.WriteLine("L'animal fait un bruit.");
    }
}

class Chien : Animal
{
    public override void Parler()
    {
        base.Parler();
        Console.WriteLine("Le chien aboie.");
    }
}
```

<br>

## 7️⃣ La méthode ToString()
Chaque classe C# hérite de la classe **Object**, et donc de sa méthode **ToString()**.  
Cette méthode peut être **redéfinie** pour afficher des informations personnalisées.

#### Exemple :
```csharp
class Personne 
{
    public string Nom { get; set; }
    public override string ToString() 
    {
        return $"Nom : {Nom}";
    }
}
```

<br>

## 8️⃣ Exemple complet
Imaginons une application de **dessin géométrique** avec des formes :  
`Figure` (classe de base) -> `Rectangle` et `Cercle` (classes dérivées).
```csharp
abstract class Figure 
{
    public abstract void Dessiner();
}

class Rectangle : Figure 
{
    public override void Dessiner() 
    {
        Console.WriteLine("Je dessine un rectangle.");
    }
}

class Cercle : Figure 
{
    public override void Dessiner() 
    {
        Console.WriteLine("Je dessine un cercle.");
    }
}

class Program 
{
    static void Main() 
    {
        List<Figure> figures = new List<Figure> 
        {
            new Rectangle(),
            new Cercle()
        };

        foreach (Figure figure in figures) 
        {
            figure.Dessiner();
        }
    }
}
```
**Question** : Sans aller voir au dessus (si possible)
- Est-ce que tu peux créer une instance de `Figure` ? Pourquoi ?
- Pourquoi la méthode `Dessiner()` de la classe `Figure` est marquée avec `abstract` ? 
- Pourquoi les méthodes `Dessiner()` des classes `Rectangle` et `Cercle` sont marquée avec `Override` ?

*Si tu sais répondre à ces questions sans regarder la théorie, tu as tout compris :)*

<br>

## 9️⃣ Exercice

### Énoncé
1. Créez une classe **abstraite** `Instrument` avec une méthode `Jouer()`.
2. Créez des classes dérivées : `Guitare` et `Piano`, qui **redéfinissent** la méthode `Jouer()`.
3. Créez une liste d'objets de type `Instrument` contenant une `Guitare` et un `Piano`.
4. Parcourez la liste et appelez `Jouer()` sur chaque instrument.

