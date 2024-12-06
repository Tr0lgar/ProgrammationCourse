---
layout: cours
title: Heritage
order: 10  # Ordre de tri
---

# L'Héritage
**Précision avant de commencer :**
Dans ce cours, **pour des raisons de simplicité**, nous allons écrire **les classes et le programme principal (`Main`) dans le même fichier**. Cependant, dans un contexte professionnel ou pour des projets plus complexes, il est recommandé de **séparer chaque classe dans des fichiers distincts** afin de rendre le code plus clair, plus maintenable, et faciliter sa réutilisation. Cela vous permettra aussi de mieux organiser votre projet et de collaborer efficacement en équipe.

## Sommaire


---

## 1. Introduction à l'Héritage
L’héritage est l’un des concepts fondamentaux de la programmation orientée objet (POO). Il permet de créer des classes basées sur d’autres classes, en réutilisant les propriétés et méthodes existantes tout en y ajoutant des fonctionnalités supplémentaires.

Imaginez une hiérarchie dans la vie réelle : une **voiture** est un type de **véhicule**, un **cercle** est une **forme géométrique**, ou encore un **chien** est un **animal**. En POO, l’héritage vous permet de représenter ces relations.

<br>

## 2. Pourquoi utiliser l'Héritage ?
1. **Réutilisation du code** : Éviter de réécrire du code identique pour des classes qui peuvent avoir des comportements similaires.
2. **Extension des fonctionnalités** : Ajouter ou modifier des comportements sans affecter la classe de base.
3. **Hiérarchisation logique** : Modéliser des relations "est un(e) entre les classes. 

<br>

## 3. Concepts clés
### Classe de base (Parent)
Une classe qui fournit des propriétés et méthodes à d'autres classes.
#### Exemple :
```csharp
class Animal
{
    public string Nom { get; set; }

    public void Manger()
    {
        Console.WriteLine($"{Nom} est en train de manger.");
    }
}
```
### Classe dérivée (Enfant)
Une classe qui hérite de la classe de base. Elle possède les membres de la classe de base et peut ajouter ses propres membres ou remplacer ceux de la classe parent (surcharge).
#### Exemple :
```csharp
class Chien : Animal // : Animal signifie "hérite de la classe Animal" et donc de ses comportements
{
    public void Aboyer()
    {
        Console.WriteLine($"{Nom} aboie !");
    }
}
```
### Accès aux membres de la class de base 
Les classes dérivées peuvent utiliser les propriétés et méthodes publiques de la classe de base.
```csharp
Chien monChien = new Chien();
monChien.Nom = "Rex";
monChien.Manger(); // Appelle une méthode de la classe Animal
monChien.Aboyer(); // Appelle une méthode de la classe Chien
```

<br>

## 4. Héritage et Modificateurs d'accès
Les modificateurs d'accès définissent les membres accessibles dans les classes dérivées :
- **public** : Accessible partout.
- **protected** : Accessible dans la classe de base et ses classes dérivées.
- **private** : Accessible uniquement dans la classe où le membre est défini.
```csharp
class Animal
{
    protected string Espece { get; set; }
}
class Chat : Animal
{
    public void AfficherEspece()
    {
        Console.WriteLine($"Ceci est un {Espece}.");
    }
}
```

<br>

## 5. Exemple concret
Création d'une hiérarchisation de classes :
1. Classe de base : **Vehicule**
2. Classe dérivée : **Voiture**
3. Classe dérivée : **Moto**
```csharp
/*
* Ici les 3 classes sont représentées dans le même fichier.
* Dans un cadre professionnel, chaque classe sera 
* représentée dans un fichier à part.
*/
class Vehicule
{
    public string Modele { get; set; }
    public void Demarrer()
    {
        Console.WriteLine($"{Modele} démarre.");
    }
}

class Voiture : Vehicule
{
    public int NombrePortes { get; set; }
}

class Moto : Vehicule
{
    public bool AUnSidecar { get; set; }
}
```
### Utilisation :
```csharp
Voiture maVoiture = new Voiture { Modele = "Tesla", NombrePortes = 4 };
maVoiture.Demarrer();
Console.WriteLine($"Ma voiture a {maVoiture.NombrePortes} portes.");

Moto maMoto = new Moto { Modele = "Harley", AUnSidecar = true };
maMoto.Demarrer();
Console.WriteLine($"Ma moto a un sidecar : {maMoto.AUnSidecar}");
```

<br>

## 6. La surcharge de Méthodes (override)
La surcharge permet à une classe dérive de **remplacer** une méthode définie dans la classe de base.
C'est utile lorsqu'on veut adapter le comportement d'une méthode héritée pour qu'elle soit spécifique
à la class dérivée.
### Comment fonctionne la surcharge en C# ?
- La méthode de la classe de base doit être déclarée avec le mot clé `virtual`
- La classe dérivée doit utiliser le mot-clé `override` pour indiquer qu'elle remplace cette méthode.

```csharp
class Vehicule
{
    public string Modele { get; set; }
    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Modèle : {Modele}");
    }
}

class Moto : Vehicule
{
    public string NombreDeRoues { get; set; }
    public override void AfficherInfos()
    {
        // On surcharge pour inclure plus d'informations
        Console.WriteLine($"Modèle : {Modele}, Nombre de roues : {NombreDeRoues}");
    }
}
```

<br>

## 7. Exercice
### Énoncé :
1. Créer un nouveau projet console
2. Dans un nouveau fichier, créer une classe `Personne` avec les propriétés `Nom` et `Prenom`, et une méthode virtuelle `AfficherInfos()` qui affiche ces informations.
3. Dans un nouveau fichier, créer une classe dérivée `Etudiant` qui hérite de `Personne`, ajoute la propriété `NumeroEtudiant`, et surcharge la méthode `AfficherInfos()` pour inclure cette nouvelle propriété.
4. Dans la méthode `Main`, instancier un objet `Etudiant`, définir ses propriétés, et appeler `AfficherInfos()` pour vérifier le résultat.