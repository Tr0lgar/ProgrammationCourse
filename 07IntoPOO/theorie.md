# Introduction à la Programmation Orientée Objet (POO)

## Sommaire
- [1. Qu’est-ce que la Programmation Orientée Objet ?](#1-quest-ce-que-la-programmation-orientée-objet-)
- [2. Pourquoi utiliser la POO ?](#2-pourquoi-utiliser-la-poo-)
- [3. Concepts de base : Objets, Classes et Attributs](#3-concepts-de-base--objets-classes-et-attributs)
- [4. Les Piliers de la POO](#4-les-piliers-de-la-poo)
- [5. Comparaisons pratiques et analogies](#5-comparaisons-pratiques-et-analogies)
- [6. Résumé](#6-résumé)

## 1. Qu’est-ce que la Programmation Orientée Objet ?
La **programmation orientée objet (POO)** est un paradigme de programmation qui organise le code autour de "**choses**" appelées **objets**, plutôt que de simples fonctions et données. Ces objets représentent des éléments du monde réel ou abstrait, comme une voiture, une banque, un utilisateur, ou même une idée.  
**Exemple simple :**  
Imagine une voiture. Une voiture a :  
- **Des caractéristiques** comme la couleur, le modèle, ou la vitesse maximale. (Ce sont les **attributs**.)
- **Des actions** qu'elle peut effectuer, comme démarrer ou freiner. (Ce sont les **méthodes**.)
  
La POO permet de représenter ce type de structure dans un programme informatique.

## 2. Pourquoi utiliser la POO ? 
### Avantages principaux :
- **Organisation claire** : Le code est structuré autour d’objets. Chaque objet est indépendant et responsable de ses propres actions. Cela rend le programme plus lisible et logique.
- **Réutilisation** : Grâce aux concepts comme l’héritage, on peut réutiliser des morceaux de code, ce qui évite les répétitions inutiles.
- **Maintenance** : Les programmes orientés objet sont plus faciles à modifier. Si un bug apparaît, il est souvent isolé dans un seul objet.
- **Modélisation du monde réel** : La POO imite la façon dont nous comprenons le monde autour de nous. Cela facilite l’analyse et le développement de solutions. (C'est paradoxale car en général on comprend rien à la POO...)

**Exemple pratique :**  
Imagine que tu développes un jeu vidéo. Chaque perso (héro, ennemi) peut être représenté comme un objet. Chaque perso peut avoir des **attributs** (pv, nom) et des **actions** (attaquer, défendre). Ces objets sont séparés, ce qui rend le développement du jeu plus flexible.

## 3. Concepts de base : Objets, Classes et Attributs
### Qu'est-ce-qu'un objet ?
Un **objet** est une entité identifiable dans un programme. C’est une instance d’une **classe** (voir plus bas). Un objet possède des :  
- **Attributs (propriétés)** : Les caractéristiques ou informations de l’objet.
- **Méthodes (comportements)** : Ce que l’objet peut faire.

**Exemple :**  
Un **objet** `voiture` peut avoir :
- **Attributs** : couleur = "blanc", marque = "Tesla".
- **Méthodes**: `démarrer()`, `freiner()`, `exploser()`.

### Qu'est-ce qu'une classe ?
Une **classe** est comme un **plan** ou une **recette** pour créer des objets. C’est une structure qui décrit ce qu’un objet de ce type doit contenir. 

**Analogie :**  
Une **classe** est comme un **moule à gâteau**. Tu peux créer plusieurs gâteaux identiques (les objets) à partir du même moule.  

**Exemple :**
```txt
Classe : Animal
- Attributs : couleur, taille, poids
- Méthodes : manger(), dormir(), courir()
```

### Différence entre Attributs et Méthodes
- Les **attributs** sont des données, des caractéristiques (comme un nom ou une couleur).
- Les **méthodes** sont des actions ou des fonctions associées à l’objet.

**Analogie :**  
Une **lampe** a des attributs (*couleur*, *taille*) et des méthodes (`allumer()`, `éteindre()`).

## 4. Les Piliers de la POO
La POO repose sur 4 concepts, appelés les **piliers de la POO**.  
Nous allons les introduire ici mais nous les verrons en détail plus tard.
###  Encapsulation
L’**encapsulation** consiste à protéger les données (attributs) d’un objet. On limite leur accès direct, et on passe par des méthodes spéciales pour les modifier.

**Analogie :**  
Dans une banque, tu ne peux pas prendre directement de l’argent dans un coffre (les attributs). Tu dois passer par un guichetier ou un distributeur (les méthodes).

### Héritage
L’**héritage** permet à une classe de **réutiliser** ou hériter des attributs et méthodes d’une autre classe.

**Analogie :**  
Imagine une classe `Animal`. Une classe `Chien` et une classe `Chat` peuvent hériter de `Animal`, car ce sont aussi des animaux. Ils partageront des caractéristiques communes (ex. respirer) mais pourront aussi avoir leurs propres spécificités (ex. aboyer pour un chien).

**Exemple :**  
```txt
Classe : Animal
- Attributs : (...)
- Méthodes : respirer(), manger()

Class : Chien
hérite de Animal
- Attributs : race, couleur, taille (+ attributs de Animal)
- Méthodes : aboyer() (+ méthodes de Animal)
```

### Polymorphisme
Le **polymorphisme** permet à des objets d’un même type (ou hérités d’une même classe) d’avoir des comportements différents pour une même action.

**Analogie :**  
Imagine une méthode `parler()` pour des animaux :
- Pour un chien, `parler()` signifie aboyer.
- Pour un chat, `parler()` signifie miauler.

### Abstraction
L’**abstraction** consiste à cacher les détails complexes d’un système, pour ne montrer que l’essentiel.

**Exemple :**  
Quand tu utilises une voiture, tu ne vois pas tout le fonctionnement interne du moteur. Tu utilises des commandes simples comme le volant ou les pédales.

## 5. Comparaisons pratiques et analogies
- **Classes et Objets** : Une classe est comme une recette, et un objet est comme un gâteau fait avec cette recette.
- **Encapsulation** : C’est comme une boîte qui protège son contenu, et où on accède aux objets via des boutons à l’extérieur.
- **Héritage** : C’est comme une famille. Les enfants héritent de traits communs (cheveux, yeux) tout en ayant des traits propres.
- **Polymorphisme** : C’est comme un smartphone. Une seule interface (écran tactile) peut effectuer des actions différentes (appeler, écrire un SMS, jouer).

## 6. Résumé
- La POO organise le code autour des objets.
- Les objets ont des **attributs** et des **méthodes**.
- Les 4 piliers de la POO sont : **Encapsulation**, **Héritage**, **Polymorphisme**, **Abstraction**.
- La POO aide à modéliser des problèmes complexes de manière logique, en rapprochant le code de la réalité.
