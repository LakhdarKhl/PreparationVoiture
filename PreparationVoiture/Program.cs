using System;

namespace PreparationVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            int Voiture = 1;
            int Moto = 2;
            int Sortir = 5;

            Console.Write("---Bienvenue sur notre préparateur de voiture" + "\n" + "\n");
            Console.Write("Veuillez sélectionner un type de véhicule suivie de la touche ENTRER" +
                    "\n" + "\n" + "1 Voiture" + "\n" + "2 Moto " + "\n" + "5 Sortir" + "\n");

            int OptionVehicule = Convert.ToInt32(Console.ReadLine());

            while (OptionVehicule != Voiture && OptionVehicule != Sortir)
            {
                Console.Clear();
                Console.Write("Option non existante !" + "\n" + "veuillez choisir une option marquée" + "\n");
                Console.Write("Veuillez sélectionner un type de véhicule suivie de la touche ENTRER" +
                    "\n" + "\n" + "1 Voiture" + "\n" +  "2 Moto " + "\n" + "5 Sortir" + "\n");
                OptionVehicule = Convert.ToInt32(Console.ReadLine());
            }

            if (OptionVehicule == Voiture)
            {
                Console.Clear();
                Console.Write("-Vous avez choisi une voiture !" + "\n" + "\n");

                // Créer une instance de la classe Véhicule ou VoitureCustom selon les besoins
                Console.Write("Entrez le modèle de la voiture : ");
                string modele = Console.ReadLine();

                Console.Write("Entrez la motorisation de la voiture : ");
                string motorisation = Console.ReadLine();

                Console.Write("Entrez la couleur de la voiture : ");
                string couleur = Console.ReadLine();

                Console.Write("Voulez-vous y ajouter un kit de customisation ? (Oui/Non) : ");
                string reponseKit = Console.ReadLine();
                string kitCustomisation = (reponseKit.ToLower() == "oui" ? "Kit Sport" : "Rien");

                Véhicule vehicule;

                if (OptionVehicule == Moto) 
                
                { 
                    Console.Clear();
                    Console.Write("Entrez le modèle de la belle Moto :");
                    modele = Console.ReadLine();

                    Console.Write("Entrez la motorisation de la Moto : ");
                    motorisation = Console.ReadLine();

                    Console.Write("Entrez la couleur de la Moto : ");
                    couleur = Console.ReadLine();

                    Console.Write("Voulez-vous y ajouter un kit de customisation ? (Oui/Non) : ");
                    reponseKit = Console.ReadLine();
                    kitCustomisation = (reponseKit.ToLower() == "oui" ? "Kit Sport" : "Rien");

                    Véhicule moto;

                }

                if (kitCustomisation == "Rien")
                {
                    vehicule = new Véhicule(modele, motorisation, couleur);
                }
                else
                {
                    vehicule = new VoitureCustom(modele, motorisation, couleur, kitCustomisation);
                }

                Console.WriteLine("\nRécapitulatif du véhicule : ");
                vehicule.AfficherDetail();
            }

            Console.ReadLine();
        }
    }
}
