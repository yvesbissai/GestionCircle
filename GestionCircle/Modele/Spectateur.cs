using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Spectateur : ISpectateur
{
    public string? NameSpectateur { get; set; }

    public Spectateur()
    {
        
    }

    public string NameSpetateur { get; set; }

    public void Applaudir()
    {
        Console.WriteLine($"le spectateur {NameSpectateur} applaudit pendant le tour d'accrobatie");
    }

    public void Siffler()
    {
        Console.WriteLine($"le spectateur {NameSpectateur} siffle pendant le tour de musique");
    }
}