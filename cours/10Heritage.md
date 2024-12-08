---
layout: cours
title: Heritage
order: 10  # Ordre de tri
---

# L'Héritage
**Précision avant de commencer :**
Dans ce cours, **pour des raisons de simplicité**, nous allons écrire **les classes et le programme principal (`Main`) dans le même fichier**. Cependant, dans un contexte professionnel ou pour des projets plus complexes, il est recommandé de **séparer chaque classe dans des fichiers distincts** afin de rendre le code plus clair, plus maintenable, et faciliter sa réutilisation. Cela vous permettra aussi de mieux organiser votre projet et de collaborer efficacement en équipe.

## Sommaire
1. [Introduction à l'héritage](#1️⃣-introduction-à-lhéritage)
2. [Pourquoi utiliser l'héritage ?](#2️⃣-pourquoi-utiliser-lhéritage-)
3. [Concepts clés](#3️⃣-concepts-clés)
4. [Modificateurs d'accès et héritage](#4️⃣-modificateurs-daccès-et-héritage)
5. [Opérateurs `is` et `as`](#5️⃣-opérateurs-is-et-as)
6. [Exemple concret](#6️⃣-exemple-concret)
7. [Exercice](#7️⃣-exercice)

---

## 1️⃣ Introduction à l'Héritage
L'héritage est l'un des concepts fondamentaux de la **programmation orientée objet (POO)**.  
Il permet de **réutiliser le code** existant en créant de nouvelles classes qui héritent des membres (propriétés et méthodes) d'une classe parent.

La relation d'héritage est souvent appelée une relation **"est un(e)"**. Par exemple :
- Un **étudiant** est une **personne**.
- Une **voiture** est un **véhicule**.
- Un **chien** est un **animal**.

<br>

## 2️⃣ Pourquoi utiliser l'Héritage ?
1. **Réutilisation du code** : Ne pas réécrire ce qui existe déjà (principe DRY - Don't Repeat Yourself).  
2. **Extensibilité** : Ajouter ou redéfinir des fonctionnalités sans modifier le code de la classe de base.  
3. **Clarté et logique** : Structurer les classes de manière hiérarchique et intuitive.  
4. **Polymorphisme** : Possibilité de manipuler des objets de différentes classes via le type de la classe de base.

<br>

## 3️⃣ Concepts clés
### Classe de base (Parent)
La classe de base est celle qui **fournit des propriétés et méthodes** à ses classes dérivées.
#### Exemple :
```csharp
class Personne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public void SePresenter()
    {
        Console.WriteLine($"Je suis {Prenom} {Nom}.");
    }
}
```
### Classe dérivée (Enfant)
Une classe dérivée **hérite des membres publics et protégés** de la classe de base.  
Elle peut également **ajouter ses propres propriétés ou méthodes**.

#### Exemple :
```csharp
class Etudiant : Personne
{
    public int Matricule { get; set; }

    public void Etudier()
    {
        Console.WriteLine($"{Prenom} étudie avec le matricule {Matricule}.");
    }
}
```

### Comment instancier une classe dérivée ?
```csharp
Etudiant etu = new Etudiant();
etu.Nom = "Dupont";
etu.Prenom = "Alice";
etu.Matricule = 12345;

etu.SePresenter(); // Appelle la méthode de la classe parent
etu.Etudier();     // Appelle la méthode de la classe enfant
```
**Sortie** :
```txt
Je suis Alice Dupont.
Alice étudie avec le matricule 12345.
```

<br>

## 4️⃣ Modificateurs d'accès et héritage
Les modificateurs d'accès contrôlent **la visibilité des membres** des classes parentes et enfants.

|Modificateur           |Classe         |Sous-classe (enfant)           |Extérieur (autre classe)           |
|-----------------------|---------------|-------------------------------|-----------------------------------|
|public                 |✅ Visible     |✅ Visible                     |✅ Visible                         |
|protected              |✅ Visible     |✅ Visible                     |❌ Non visible                     |
|private                |✅ Visible     |❌ Non visible                 |❌ Non visible                     |

<br>

## 5️⃣ Opérateurs `is` et `as`
Ces opérateurs permettent de **tester et convertir des objets** dans le cadre de l'héritage.

### L'opérateur `is`
Permet de vérifier si un objet est d'un certain type.  
**Syntaxe** :
```csharp
if (objet is Etudiant)
{
    Console.WriteLine("C'est un étudiant.");
}
```

### L'opérateur `as`
Permet de **convertir** un objet d'un type vers un autre.  
Si la conversion échoue, in renvoie `null` au lieu de lever une erreur.  
**Syntaxe** :
```csharp
Personne p = new Etudiant();
Etudiant etu = p as Etudiant; // essaie de convertir Personne en Etudiant
if (etu != null)
{
    etu.Etudier();
}
```

<br>

## 6️⃣ Exemple concret
Créer une application de gestion de personnes et d'étudiants.

### Classe de base : Personne
```csharp
class Personne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public void SePresenter()
    {
        Console.WriteLine($"Je suis {Prenom} {Nom}.");
    }
}
```

### Classe dérivée : Etudiant
```csharp
class Etudiant : Personne
{
    public int Matricule { get; set; }

    public void Etudier()
    {
        Console.WriteLine($"{Prenom} étudie avec le matricule {Matricule}.");
    }
}
```

### Utilisation dans Main
```csharp
Personne p1 = new Personne { Prenom = "Paul", Nom = "Martin" };
Etudiant etu1 = new Etudiant { Prenom = "Alice", Nom = "Dupont", Matricule = 12345 };

p1.SePresenter();
etu1.SePresenter();
etu1.Etudier();

// Utilisation de l'opérateur "is"
if (etu1 is Personne)
{
    Console.WriteLine("Un étudiant est aussi une personne.");
}

// Utilisation de l'opérateur "as"
Personne p2 = new Etudiant { Prenom = "Luc", Nom = "Durand" };
Etudiant etu2 = p2 as Etudiant;
if (etu2 != null)
{
    etu2.Etudier();
}
```

**Sortie** :
```txt
Je suis Paul Martin.
Je suis Alice Dupont.
Alice étudie avec le matricule 12345.
Un étudiant est aussi une personne.
Luc étudie avec le matricule 0.
```

<br>

## 7️⃣ Exercice
### Énoncé :
1. Créez une classe `Personne` avec les propriétés `Nom`, `Prenom`, et la méthode `SePresenter()`.
2. Créez une classe `Etudiant` qui hérite de `Personne`, avec une propriété supplémentaire `Matricule` et la méthode `Etudier()`.
3. Instanciez un étudiant, affichez ses informations avec `SePresenter()` et `Etudier()`.
4. Testez l'opérateur `is` et `as` sur des objets `Personne` et `Etudiant`.

---

## Résumé
- **Héritage** : permet de **réutiliser le code** via la relation "est un(e)".
- **Modificateurs d'accès** : `public`, `protected`, et `private` contrôlent l'accès aux membres des classes.
- **Opérateurs `is` et `as`** : permettent de tester et convertir des objets d'une hiérarchie.
