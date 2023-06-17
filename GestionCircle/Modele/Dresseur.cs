using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Dresseur : IDresseur
{
    public string NameDresseur { get; set; }
    public IAnimal Singe { get; set; }

    public Dresseur(IAnimal singe, string name)
    {
        Singe = singe;
        NameDresseur = name;
    }
    
    public void DemandeAuSigneFaireTour()
    {
        Singe.FaireUnTour();
    }
}