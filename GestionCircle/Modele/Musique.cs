using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Musique : ITour
{
    public string Nom { get; set; }
    public Musique(string nom)
    {
        Nom = nom;
    }
    public void Tourner(string? name)
    {
        Console.WriteLine($"Musique : {Nom} du {name}");
    }
}