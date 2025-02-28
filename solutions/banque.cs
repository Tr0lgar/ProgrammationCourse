using System;

class CompteBancaire
{
    // Attributs privés
    private string _numeroCompte;
    private double _solde;

    // Constructeur
    public CompteBancaire(string numero, double montantInitial)
    {
        _numeroCompte = numero;
        if (montantInitial >= 0)
        {
            _solde = montantInitial;
        }
        else
        {
            Console.WriteLine("Le montant initial ne peut pas être négatif. Solde mis à 0.");
            _solde = 0;
        }
    }

    // Méthode pour déposer de l'argent
    public void Deposer(double montant)
    {
        if (montant > 0)
        {
            _solde += montant;
            Console.WriteLine($"Déposé : {montant} €. Nouveau solde : {_solde} €");
        }
        else
        {
            Console.WriteLine("Le montant du dépôt doit être positif.");
        }
    }

    // Propriété pour le numéro de compte
    public string NumeroCompte
    {
        get { return _numeroCompte; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _numeroCompte = value;
            }
            else
            {
                Console.WriteLine("Le numéro de compte ne peut pas être vide.");
            }
        }
    }

    // Propriété pour le solde
    public double Solde
    {
        get { return _solde; }
        private set
        {
            if (value >= 0)
            {
                _solde = value;
            }
            else
            {
                Console.WriteLine("Le solde ne peut pas être négatif.");
            }
        }
    }

    // Méthode pour retirer de l'argent
    public void Retirer(double montant)
    {
        if (montant > 0)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
                Console.WriteLine($"Retiré : {montant} €. Nouveau solde : {Solde} €");
            }
            else
            {
                Console.WriteLine("Fonds insuffisants pour effectuer ce retrait.");
            }
        }
        else
        {
            Console.WriteLine("Le montant du retrait doit être positif.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Création d'un compte bancaire
        CompteBancaire compte = new CompteBancaire("1234567890", 1000);
        
        // Dépôt d'argent
        compte.Deposer(500);
        
        // Retrait d'argent valide
        compte.Retirer(300);
        
        // Tentative de retrait avec montant supérieur au solde
        compte.Retirer(1500);
        
        // Tentative de dépôt négatif
        compte.Deposer(-50);
        
        // Tentative de retrait négatif
        compte.Retirer(-100);
        
        Console.WriteLine($"Solde final : {compte.Solde} €");
    }
}
