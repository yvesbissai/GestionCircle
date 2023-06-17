using GestionCircle.Interface;

namespace GestionCircle.Modele;

public class Spectateur : ISpectateur
{
    public string NameSpectateur { get; set; }

    public Spectateur(string name)
    {
        NameSpectateur = name;
    }
    public void Applaudir()
    {
        Console.WriteLine($"{NameSpectateur} applaudit ");
    }

    public void Siffler()
    {
        Console.WriteLine($"{NameSpectateur} siffle");
    }
}