---
layout: cours
title: Tableaux
order: 4  # Ordre de tri
---

# Les Tableaux

## Sommaire
1. [Introduction](#1️⃣-introduction)
2. [Déclaration d'un Tableau](#2️⃣-déclaration-dun-tableau)
3. [Initialisation d'un tableau](#3️⃣-initialisation-dun-tableau)
4. [Accès aux Éléménts d'un Tableau](#4️⃣-accès-aux-éléments-dun-tableau)
5. [Parcourir un Tableau](#5️⃣-parcourir-un-tableau)
6. [Tableaux Multidimensionnels](#6️⃣-tableaux-multidimensionnelss)
7. [Tableau Jagged](#7️⃣-tableau-jagged)
8. [Résumé](#8️⃣-résumé)
9. [Exercice](#9️⃣-exercicee)

---

## 1️⃣ Introduction
Un **tableau** est une structure de données qui permet de stocker une collection de valeurs du même type. On peut le voir comme une **boite à compartiments**, où chaque compartiment contient un élément de la même nature (par exemple une série de chiffres, de mots, etc.).
Imaginez une étagère avec des cases numérotées. Chaque case peut contenir un objet, comme un livre. Si l'étagère peut contenir 10 livres, chaque case (numérotée de 0 à 9) correspond à un emplacement où un livre (une valeur) peut être stocké.
Dans un tableau, chaque emplacement s'appelle un **indice**.

<br>

## 2️⃣ Déclaration d'un Tableau
Pour déclarer un tableau en C#, il faut :
1. **Indiquer le type des éléments** : par exemple, `int`, `double`, etc.
2. **Utiliser des crochets** `[]` pour indiquer qu'il s'agit d'un tableau.
3. **Donner un nom au tableau**.
4. **Indiquer la taille du tableau** (le nombre d'éléments qu'il peut contenir).

```csharp
// Déclare un tableau pouvant contenir jusqu'à 5 entiers
int[] nombres = new int[5]; 
```

<br>

## 3️⃣ Initialisation d'un Tableau
Un tableau peut être initialisé lors de sa déclaration, c'est-à-dire qu'on peut donner des valeurs initiales aux éléments.
```csharp
// Un tableau de 5 entiers initialisé avec des valeurs
int[] nombres = { 2, 4, 6, 8, 10 }; 
```

<br>

## 4️⃣ Accès aux Éléments d'un Tableau
Les éléments d'un tableau sont accessibles via leur **indice**. En C#, comme beaucoup d'autres langages comme Java, les indices commencent toujours à 0. Le premier élément est donc à l'indice `0`, le deuxième à l'indice `1`, et ainsi de suite.
```csharp
int premierNombre = nombres[0]; // Accède au premier élément (valeur : 2)
nombres[2] = 12; // Modifie le troisième élément (6 devient 12)
```
#### Attention : Indice hors limites
Si vous essayez d'accéder à un indice qui n'existe pas, vous obtiendrez une erreur. Par exemple, accéder à `nombres[5]` alors que le tableau contient seulement 5 éléments (`0` à `4`) provoquera une erreur.

<br>

## 5️⃣ Parcourir un Tableau
Les **boucles** permettent de parcourir facilement les éléments d'un tableau. Par exemple, la boucle `for` :
```csharp
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]); // Affiche chaque élément du tableau
}
```
- `nombre.Length` : renvoie la taille du tableau (le nombre d'éléments)
- La boucle parcourt le tableau en utilisant l'indice `i`, qui va de `0` à `nombre.Length - 1`.

<br>

## 6️⃣ Tableaux Multidimensionnels
Un **tableau multidimensionnel** est un tableau contenant d'autres tableaux. Il est utilisé pour stocker des données sous forme de grille, comme un **tableau à deux dimensions** (tableau de tableaux).

### Tableau à deux dimensions
Un **Tableau à deux dimensions** est un tableau où chaque élément du tableau est un autre tableau et où chaque sous-tableau a la même taille.

```csharp
int[,] matrice = new int[3, 2]; // Un tableau de 3 lignes et 2 colonnes

// Initialisation d'un tableau à deux dimensions
int[,] matrice = {
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};
```

### Accès aux éléments
Pour accéder aux éléments d'un tableau multidimensionnel, il faut spécifier les **indices** de chaque dimension.
```csharp
// Accède à l'élément en ligne 1, colonne 0 (valeur : 3)
int valeur = matrice[1, 0];
```
### Parcourir un tableau 2D
Pour parcourir un tableau 2D, on utilise généralement des **boucles imbriquées**. Une boucle permet de parcourir les **lignes** du tableau, tandis que la boucle imbriquée (à l'intérieur de la première) permet de parcourir les **colonnes** de chaque ligne.
```csharp
for (int i = 0; i < matrice.GetLength(0); i++) // Parcourt les lignes
{
    for (int j = 0; j < matrice.GetLength(1); j++) // Parcourt les colonnes
    {
        Console.Write(tableau[i, j] + "\t"); // Affiche l'élément à la position [i, j]
    }
    Console.WriteLine(); // Passe à la ligne suivante après avoir affiché toutes les colonnes
}
```
#### Explications
- `tableau.GetLength(0)` : Renvoie le nombre de lignes du tableau. Dans cet exemple, il y a 3 lignes (`0`, `1`, `2`).
- `tableau.GetLength(1)` : Renvoie le nombre de colonnes du tableau. Dans cet exemple, il y a 2 colonnes (`0`, `1`).
- Les deux boucles permettent d'accéder à chaque élément du tableau en utilisant les indices `[i, j]`, où `i` représente la ligne actuelle et `j` représente la colonne actuelle.
- `Console.Write(tableau[i, j] + "\t")` : Affiche l'élément à la position `[i, j]` avec un tabulateur (`\t`) pour espacer les valeurs.
- `Console.WriteLine()` : Permet de passer à la ligne suivante après avoir parcouru toutes les colonnes d'une ligne.

<br>

## 7️⃣ Tableau Jagged
Les **tableaux jagged** sont des tableaux dont les éléments sont eux-mêmes des tableaux, mais chaque sous-tableau peut avoir une taille différente.
```csharp
int[][] jaggedArray = new int[3][]; // Tableau de 3 tableaux
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };
```

### Accès aux éléments
```csharp
// Accède au premier élément (0) du deuxième tableau (1) (valeur : 4)
int valeur = jaggedArray[1][0];
```

<br>

## 8️⃣ Résumé
- Les tableaux sont des structures de données qui permettent de stocker plusieurs valeurs du même type.
- Les indices commencent à `0`, et la taille du tableau doit être spécifiée lors de sa création.
- On peut parcourir les tableaux à l'aide de boucles.
- Les tableaux multidimensionnels permettent de créer des grilles, tandis que les tableaux jagged permettent des tailles de sous-tableaux variables.

<br>

## 9️⃣ Exercice
### Énoncé :
1. Créez un tableau de 10 entiers. Demandez à l'utilisateur de saisir les valeurs de ce tableau.
2. Afficher la somme de tous les éléments du tableau.
3. Afficher le plus grand élément du tableau
4. Créer un tableau de 5x5 (deux dimensions) et initialisez-le avec des valeurs croissantes (de 1 à 25).
5. Affichez les éléments de ce tableau sous forme de grille.

### Code de départ :
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Étape 1 : Créer un tableau de 10 entiers et demander les valeurs à l'utilisateur
        // TODO:
        

        // Étape 2 : Calculer la somme des éléments du tableau
        int somme = 0;
        // TODO: 
        Console.WriteLine("La somme des éléments est : " + somme);

        // Étape 3 : Trouver le plus grand élément
        int max = tableau[0];
        // TODO:
        Console.WriteLine("Le plus grand élément est : " + max);

        // Étape 4 : Créer un tableau de 5x5 et le remplir avec des valeurs de 1 à 25
        //TODO: 

        // Étape 5 : Afficher le tableau 5x5 sous forme de grille
        Console.WriteLine("Tableau 5x5 :");
        // TODO:
    }
}
```
### Indices :
- **Tableau de 10 entiers** : Initialise d'abord ton tableau. Ensuite, tu sais que tu dois demander tableau.Length fois la valeur pour tableau[i], parcours ton tableau et demande quelle valeur tu dois ajouter (n'oublie pas de parser tes entrées).
- **Somme des éléments** : Parcours ton tableau et additionne la valeur de tableau[i] à ta variable somme. *Astuce : `somme += valeur` revient à faire `somme = somme + valeur`*.
- **Le plus grand nombre** : compare chaque valeur de ton tableau avec ta variable `max`, si c'est plus grand, ta variable `max` doit changer. 
- **Tableau 5x5** : Commence par initialiser ton tableau 2D, et initialise une variable compteur à 1. Ensuite, parcours ton tableau 2D (qui dit 2 dimensions dit boucles imbriquées) et donne la valeur de ton compteur à `tableau[i][j]`. N'oublie pas d'incrémenter ton compteur juste après.

### Solution
[Télécharger la solution](../solutions/exTableau.cs)