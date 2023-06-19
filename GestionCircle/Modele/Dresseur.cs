using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Dresseur : IDresseur
{
    
    public IAnimal? Singe { get; set; }

    public Dresseur(IAnimal singe)
    {
        Singe = singe;
    }

    public string NameDresseur { get; set; }

    public void DemandeAuSigneFaireTour(int i,string name)
    {
        Singe?.FaireUnTour(i,this.NameDresseur);
    }
}