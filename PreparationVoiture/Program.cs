using System;

class Voiture
{
    public string Modele { get; set; }
    public string Motorisation { get; set; }
    public string Couleur { get; set; }


    //ici je fais le constructeur
    public Voiture (string modele, string motorisation, string couleur)
    {
        this.Modele = modele;
        this.Motorisation = motorisation;
        this.Couleur = couleur;
    }
    
    //methode d'afficahge de détail de la voiture
    public virtual void AfficherDetail()
    {
        Console.WriteLine($"Voiture {Modele} de couleur {Motorisation} ayant pour motorisation {Motorisation}");
    }
}