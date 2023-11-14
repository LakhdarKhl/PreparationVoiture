using System;

class Véhicule
{
    public string Modele { get; set; }
    public string Motorisation { get; set; }
    public string Couleur { get; set; }

    public Véhicule(string modele, string motorisation, string couleur)
    {
        Modele = modele;
        Motorisation = motorisation;
        Couleur = couleur;
    }

    public virtual void AfficherDetail()
    {
        Console.WriteLine($"Véhicule {Modele} de couleur {Motorisation} ayant pour motorisation {Motorisation}");
    }
}

class VoitureCustom : Véhicule
{
    public string KitCustomisation { get; set; }

    public VoitureCustom(string modele, string motorisation, string couleur, string kitCustomisation)
        : base(modele, motorisation, couleur)
    {
        KitCustomisation = kitCustomisation;
    }

    public override void AfficherDetail()
    {
        base.AfficherDetail();
        Console.WriteLine($"Avec le kit de customisation : {KitCustomisation}");
    }
}
