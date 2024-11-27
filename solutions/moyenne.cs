using System;
using System.Collections.Generic;
using System.Linq;

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

            try
            {
                int note = int.Parse(saisie);

                if (note < 0 || note > 20)
                {
                    Console.WriteLine("Erreur : la note doit être entre 0 et 20.");
                    continue;
                }

                notes.Add(note);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
            }
        }

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
