using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Accrobatie : Tour
{
    public string Nom{get; set; }
    public Accrobatie(string nom)
    {
        Nom = nom;
    }
    public override void Tourner(string name)
    {
        Console.WriteLine($"Accrobatie : {Nom} du singe de {name}");
    }
}