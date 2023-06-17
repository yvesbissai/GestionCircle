using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Accrobatie : ITour
{
    public string Nom{get; set; }
    public Accrobatie(string nom)
    {
        Nom = nom;
    }
    public void Tourner(string? name)
    {
        Console.WriteLine($"{Nom} de {name}");
    }
}