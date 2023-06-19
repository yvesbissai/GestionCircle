using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Musique : Tour
{
    public string Nom { get; set; }
    public Musique(string nom)
    {
        Nom = nom;
    }
    public override void Tourner(string name)
    {
        Console.WriteLine($"Musique : {Nom} du singe de {name}");
    }
}