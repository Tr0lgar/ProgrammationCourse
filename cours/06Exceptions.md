---
layout: cours
title: Exceptions
order: 6  # Ordre de tri
---

# Gestion des Exceptions avec `try`...`catch`

## 1. Introduction aux Exceptions
Les exceptions sont des erreurs qui se produisent pendant l'exécution d’un programme. Elles interrompent le flux normal du programme et, si elles ne sont pas gérées, elles provoquent un arrêt brutal du programme avec un message d’erreur. En gérant les exceptions, on peut **réagir à ces erreurs** et éviter que le programme ne se bloque de manière imprévisible.
### Pourquoi gérer les exceptions ?
- **Éviter les plantages** : Plutôt que de laisser le programme s'arrêter brutalement, on peut gérer les erreurs et afficher des messages utiles.
- **Améliorer l'expérience utilisateur** : Fournir des messages clairs permet aux utilisateurs de comprendre pourquoi une opération a échoué.
- **Garantir la stabilité** : En capturant les erreurs, on peut décider de continuer l’exécution, de passer à une autre opération, ou de réessayer.

## 2. Utilisation de `try`...`catch`
Le bloc `try`...`catch` permet de **tester un bloc de code** et **de réagir aux erreurs** s’il en survient une.
### Syntaxe de base
```csharp
try
{
    // Code qui pourrait générer une exception
}
catch (ExceptionType ex)
{
    // Code pour gérer l'exception
}
```
- `try` : Entoure le code qui pourrait générer une exception.
- `catch` : Capture l'exception si elle se produit. On peut spécifier le type d’exception à capturer, ou utiliser `Exception` pour capturer toutes les exceptions.
- `ex` : La variable qui contient les informations de l'exception (par exemple, le message d’erreur).

### Exemple simple
Imaginons un programme uqi divise un nombre par un autre. Si on essaie de diviser par zéro, une exception se produit :
```csharp
try
{
    int a = 10;
    int b = 0;
    int result = a / b; // Cela va générer une exception de type DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erreur : Division par zéro impossible.");
}
```
Dans cet exemple :
- Le programme essaie d'exécuter `a / b`.
- Comme `b` vaut 0, une `DivideByZeroException` est lancée.
- Le `catch` capture l'exception et affiche un message sans arrêter le programme.

## 3. Différents types d'Exceptions
C# fournit plusieurs types d'exceptions pour gérer différents types d'erreurs. Voici quelques exemples :
- `DivideByZeroException` : Division par zéro.
- `FormatException` : Format incorrect (exemple : essayer de convertir une chaîne en nombre alors qu’elle contient des lettres).
- `IndexOutOfRangeException` : Tentative d'accès à un index de tableau qui n'existe pas.
- `NullReferenceException` : Tentative d'utiliser une référence null.

### Exemple
```csharp
try
{
    Console.Write("Entrez un nombre : ");
    int nombre = int.Parse(Console.ReadLine()); // Peut générer une FormatException

    int[] tableau = { 1, 2, 3 };
    Console.WriteLine(tableau[nombre]); // Peut générer une IndexOutOfRangeException
}
catch (FormatException ex)
{
    Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Erreur : L'index est en dehors des limites du tableau.");
}
catch (Exception ex)
{
    Console.WriteLine("Une erreur inattendue est survenue : " + ex.Message);
}
```
Ici :
- Si l'utilisateur entre un texte au lieu d'un nombre, une `FormatException` est levée.
- Si le nombre est en dehors des limites du tableau, une `IndexOutOfRangeException` est levée.
- Si une autre erreur survient, elle est capturée par le bloc `catch` générique.

## 4. Utiliser `finally`
Le bloc `finally` peut être ajouté après les blocs `try` et `catch`. Le code dans le `finally` s'exécute **toujours**, que l'exception soit levée ou non. Cela est utile pour **libérer des ressources**, comme fermer un fichier ou une connexion.

### Exemple avec `finally` :
```csharp
try
{
    // Code qui pourrait générer une exception
}
catch (Exception ex)
{
    Console.WriteLine("Erreur : " + ex.Message);
}
finally
{
    Console.WriteLine("Le bloc finally s'exécute toujours.");
}
```

## 5. Relever des Exceptions Personnalisées avec `throw`
Il est possible de lever (ou relancer) une exception pour signaler une erreur spécifique dans une fonction. On utilise alors le mot-clé `throw`.
### Exemple de levée d'une exception :
```csharp
static void Diviser(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Le dénominateur ne peut pas être zéro.");
    }

    Console.WriteLine(a / b);
}

try
{
    Diviser(10, 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erreur capturée : " + ex.Message);
}
```

## 6. Résumé
- `try` : Teste un bloc de code qui pourrait générer une exception.
- `catch` : Capture et gère l'exception si elle survient.
- `finally` : S'exécute dans tous les cas pour libérer les ressources, qu'une exception soit levée ou non.
- `throw` : Permet de relancer une exception, éventuellement avec un message personnalisé.

## 7. Exercice : Gestion des Erreurs dans une liste de Notes
Écris un programme qui permet à l'utilisateur d'ajouter des notes dans une liste. Le programme doit :
1. Demander à l’utilisateur de saisir des notes (entre 0 et 20) jusqu’à ce que l’utilisateur décide de stopper.
2. Valider que chaque entrée est bien un nombre et qu’il se situe entre 0 et 20. Si ce n'est pas le cas, une exception doit être gérée.
3. Afficher la liste des notes à la fin, ainsi que la moyenne des notes valides.

### Consignes 
- Le programme doit utiliser `try`...`catch` pour gérer les erreurs d'entrée :
    - Si l’utilisateur entre une valeur non numérique (comme "abc"), afficher un message d'erreur indiquant que l’entrée est incorrecte.
    - Si l’utilisateur entre une note en dehors de la plage 0-20, afficher un message d’erreur spécifique.
- Fin du programme : l’utilisateur peut taper "fin" à tout moment pour arrêter la saisie et afficher les résultats.

### Code de base
Voici un point de départ pour l'exercice :
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> notes = new List<int>();
        string saisie;
        
        Console.WriteLine("Saisissez des notes (entre 0 et 20). Tapez 'fin' pour arrêter.");

        while (true)
        {
            Console.Write("Entrez une note : ");
            saisie = Console.ReadLine();

            if (saisie.ToLower() == "fin")
            {
                break;
            }

            // TODO: Il faudra ajouter un try...catch ici pour gérer les erreurs
            int note = int.Parse(saisie); // Convertit la saisie en entier
            
            // Vérifie que la note est dans la plage correcte
            if (note < 0 || note > 20)
            {
                Console.WriteLine("Erreur : la note doit être entre 0 et 20.");
                continue;
            }

            notes.Add(note); // Ajoute la note à la liste
        }

        // Calcul et affichage de la moyenne
        if (notes.Count > 0)
        {
            double moyenne = (double)notes.Sum() / notes.Count;
            Console.WriteLine("\nListe des notes : " + string.Join(", ", notes));
            Console.WriteLine("Moyenne des notes : " + moyenne);
        }
        else
        {
            Console.WriteLine("Aucune note n'a été ajoutée.");
        }
    }
}
```
### Indications supplémentaires :
- **Encadrer le bloc `int note = int.Parse(saisie);`** avec un `try...catch`pour gérer les erreurs de saisie.
- **Ajouter un message d'erreur** si la saisie n'est pas un nombre.
- **Ignorer la note si elle est hors de la plage 0-20**, mais sans arrêter le programme.

### Solution
[Télécharger la solution](../solutions/moyenne.cs)