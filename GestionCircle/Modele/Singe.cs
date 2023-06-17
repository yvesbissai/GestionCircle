using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Singe : IAnimal
{
    public string? NameSinge { get; set; }

    public Singe(string? name)
    {
        NameSinge = name;
    }
    public IList<ITour> Tours { get; set; }

    public Singe(IList<ITour> tours, ITour tour1, ITour tour2)
    {
        Tours = tours;
        Tours.Add(tour1);
        Tours.Add(tour2);

    }

    public void FaireUnTour()
    {
        var rand = new Random();
        var index = rand.Next(2);
        Tours[index].Tourner(NameSinge);

    }
}