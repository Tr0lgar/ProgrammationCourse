---
layout: cours
title: Encapsulation
order: 9  # Ordre de tri
---

# Encapsulation
**Précision avant de commencer :**
Dans ce cours, **pour des raisons de simplicité**, nous allons écrire **les classes et le programme principal (`Main`) dans le même fichier**. Cependant, dans un contexte professionnel ou pour des projets plus complexes, il est recommandé de **séparer chaque classe dans des fichiers distincts** afin de rendre le code plus clair, plus maintenable, et faciliter sa réutilisation. Cela vous permettra aussi de mieux organiser votre projet et de collaborer efficacement en équipe.

## Sommaire
- [Objectif](#objectif)
- [1. Introduction à l'Encapsulation](#1-introduction-à-lencapsulation)
- [2. Pourquoi l'Encapsulation est-elle importante ?](#2-pourquoi-lencapsulation-est-elle-importante-)
- [3. Déclaration d’Attributs Privés et Accès via Getters et Setters](#3-déclaration-dattributs-privés-et-accès-via-getters-et-setters)
- [4. Utilisation Simplifiée avec les Propriétés](#4-utilisation-simplifiée-avec-les-propriétés)
- [5. Résumé](#5-résumé)
- [6. Exercice](#6-exercice)

---

## Objectif
Comprendre l’importance de l’encapsulation, apprendre à protéger les données d’une classe en utilisant des attributs privés et les manipuler à travers des méthodes publiques comme les *getters* et *setters*.

## 1. Introduction à l'Encapsulation
L’encapsulation est un **principe fondamental** de la Programmation Orientée Objet qui consiste à **protéger les données** d’une classe en les rendant inaccessibles directement de l’extérieur. L'objectif est de **contrôler l'accès et la modification des données** pour éviter des comportements imprévisibles ou des erreurs dans le programme.

Imagine une boîte de sécurité avec des documents sensibles. Toi seul as la clef pour ouvrir cette boite et consulter ou modifier son contenu. Cette clef représente les méthodes *set* et *get* qui permettent de consulter et modifier les données de manière sécurisée.

<br>

## 2. Pourquoi l'Encapsulation est-elle importante ?
- **Protection des données** : Empêche des modifications imprévues.
- **Contrôle d’accès** : On peut définir qui a le droit de lire ou modifier les attributs.
- **Facilité de maintenance** : Les règles de validation peuvent être centralisées dans les méthodes de la classe.
- **Cohérence des données** : L’intégrité des données est assurée par des mécanismes de contrôle (comme les vérifications dans les *setters*).

## 3. Déclaration d’Attributs Privés et Accès via Getters et Setters
En C#, les attributs sont généralement déclarés comme **privés** (`private`), et on utilise des méthodes **publiques** (`public`) pour y accéder.  
**Exemple sans encapsulation :**
```csharp
class Personne
{
    public string Nom;
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {
        Personne p = new Personne();
        p.Nom = "Alice";
        p.Age = -5; // Cette valeur est incohérente
        Console.WriteLine($"Nom : {p.Nom}, Âge : {p.Age}");
    }
}
```
👉 **Problème** : L’utilisateur peut assigner une valeur incohérente (`Age = -5`), car les données ne sont pas protégées.

**Solution :** Protéger les données avec des **getters** et **setters**
```csharp
class Personne
{
    private string nom;
    private int age;

    // Getter pour Nom
    public string GetNom()
    {
        return nom;
    }

    // Setter pour Nom
    public void SetNom(string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            nom = value;
        }
        else
        {
            Console.WriteLine("Le nom ne peut pas être vide.");
        }
    }

    // Getter pour Age
    public int GetAge()
    {
        return age;
    }

    // Setter pour Age
    public void SetAge(int value)
    {
        if (value >= 0)
        {
            age = value;
        }
        else
        {
            Console.WriteLine("L'âge ne peut pas être négatif.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personne p = new Personne();
        p.SetNom("Alice");
        p.SetAge(30);
        Console.WriteLine($"Nom : {p.GetNom()}, Âge : {p.GetAge()}");

        // Tentative d'assignation incorrecte
        p.SetAge(-5); // Message d'erreur : L'âge ne peut pas être négatif.
    }
}
```

## 4. Utilisation Simplifiée avec les Propriétés
C# propose une syntaxe plus simple pour l’encapsulation à l’aide de **propriétés** (`properties`), combinant les avantages des *getters* et *setters* dans une seule déclaration.  
**Exemple avec propriétés :**
```csharp
class Personne
{
    private string nom;
    private int age;

    // Propriété pour Nom
    public string Nom
    {
        get { return nom; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nom = value;
            }
            else
            {
                Console.WriteLine("Le nom ne peut pas être vide.");
            }
        }
    }

    // Propriété pour Age
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("L'âge ne peut pas être négatif.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personne p = new Personne();
        p.Nom = "Bob";  // Utilise la propriété avec validation
        p.Age = 25;
        Console.WriteLine($"Nom : {p.Nom}, Âge : {p.Age}");

        p.Age = -10;  // Déclenche un message d'erreur
    }
}
```

## 5. Résumé
- **L’encapsulation protège les données** d'une classe en limitant leur accès direct.
- Les **attributs privés** sont accessibles via des **getters** et **setters**, ou encore mieux via des **propriétés**.
- Elle permet de **contrôler la cohérence** des données en validant les entrées et protège l’intégrité du système.

## 6. Exercice
### Objectif : 
Créer une classe `CompteBancaire` avec les attributs privés suivants :
- `numeroCompte` (chaîne de caractères)
- `solde` (double)

### Consignes :
1. Utilisez des **propriétés** pour accéder et modifier ces attributs.
2. Le solde ne peut jamais être négatif.
3. Affichez le solde après chaque dépôt ou retrait.
4. Ajoutez une méthode `Deposer` et une méthode `Retirer` qui respectent cette règle.

### Solution :  
[Télécharger la solution](../solutions/banque.cs)