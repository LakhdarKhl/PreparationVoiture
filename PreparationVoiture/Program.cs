using System;

class Voiture
{
    //Propriété de ttes les voitures
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

class VoitureCustom : Voiture
{
    public string KitCustomisation { get; set; }

    public VoitureCustom(string modele, string motorisation, string couleur, string kitCustomisation) : base(modele, motorisation, couleur)
    {
        //attention a maj K et lowercase k
        KitCustomisation = kitCustomisation;
    }

    public override void AfficherDetail()
    {
        base.AfficherDetail();
        Console.WriteLine($"Avec le kit de customisation : {KitCustomisation}");
    }

    class Program
    {
        static void Main()
        {
            //on va demander les détails du modèle, motorisation, coueleur et le kit
            Console.Write("Entrez le modèle de la voiture :");
            string modele = Console.ReadLine();

            Console.Write("Entrez la motorisation de la voiture :");
            string motorisation = Console.ReadLine();

            Console.Write("Entrez la couleur de la voiture :");
            string couleur = Console.ReadLine();

            Console.Write("Voulez-vous y ajouter un kit de customisation ? (Oui/Non) : ");
            string reponseKit= Console.ReadLine();
            string kitCustomisation = (reponseKit.ToLower()  == "oui" ? "Kit Sport" : "Rien");

            Voiture voiture;
            if (kitCustomisation == "Aucun")
            {
                voiture = new Voiture(modele,motorisation, couleur);
            }
            else
            {
                voiture = new VoitureCustom(modele,motorisation, couleur, kitCustomisation);
            }

            Console.WriteLine("\nRécapitulatif de la voiture : ");
            voiture.AfficherDetail();

            Console.ReadLine();
        }
    }
}