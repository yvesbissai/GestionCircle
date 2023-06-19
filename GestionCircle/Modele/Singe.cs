using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Singe : IAnimal
{
    public string? NameSinge { get; set; }

    public IList<Tour> Tours { get; set; }
    

    public Singe(IList<Tour> tours)
    {
        Tours = tours;
    }
    

    public void FaireUnTour(int i,string name)
    {
        Tours[i].Tourner(name);
    }
}