// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using GestionCircle.Interface;
using GestionCircle.Modele;

/*
var path = "../../../config.txt";
string[] data = System.IO.File.ReadAllLines(path);

var spectateurClasse = data[0];
var dresseurClasse = data[1];
var singeClasse = data[2];

Type typeSpectateur = Type.GetType(spectateurClasse) ?? throw new ArgumentNullException("Type.GetType(spectateurClasse)");
ISpectateur? spectateur = (ISpectateur)Activator.CreateInstance(typeSpectateur);

Console.WriteLine($"un spectateur croise deux Dresseurs ");
*/

var services = new ServiceCollection();

services.AddSingleton<ISpectateur, Spectateur>();
services.AddTransient<IDresseur,Dresseur>();
services.AddTransient<IAnimal, Singe>();
services.AddSingleton<IList<Tour>, List<Tour>>();

IServiceProvider provider = services.BuildServiceProvider();


IDresseur? dresseur = provider.GetService<IDresseur>();
dresseur.NameDresseur = "Alfred";

IDresseur? dresseur2 = provider.GetService<IDresseur>();
dresseur2.NameDresseur = "john";
ISpectateur? spectateur = provider.GetService<ISpectateur>();
spectateur.NameSpectateur = "yves";
IList<Tour>? tours = provider.GetService<IList<Tour>>();

Musique musique = new("l'été indien");
Accrobatie accrobatie = new("marche sur les mains");
Musique musique2 = new Musique("chant de noél");
Accrobatie accrobatie2 = new Accrobatie("roulade avant plus peroulé");
tours.Add(musique);
tours.Add(accrobatie);
tours.Add(accrobatie2);
tours.Add(musique2);

Console.WriteLine($"un spectateur: {spectateur.NameSpectateur} croise deux dresseurs : {dresseur.NameDresseur} et {dresseur2.NameDresseur}");

Console.WriteLine($"{dresseur.NameDresseur} demande a son singe d'éxécuter tous ses tours");
for (var i = 0; i < 4; i++)
{
    dresseur.DemandeAuSigneFaireTour(i,dresseur.NameDresseur);
    if (tours[i].GetType().ToString() == "GestionCircle.Modele.Accrobatie")
    {
        spectateur.Applaudir();
    }
    else
    {
        spectateur.Siffler();
    }
    
    
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"{dresseur2.NameDresseur} demande a son singe d'éxécuter tous ses tours");

for (var i = 0; i < 4; i++)
{
    dresseur2.DemandeAuSigneFaireTour(i, dresseur.NameDresseur);
    if (tours[i].GetType().ToString() == "GestionCircle.Modele.Accrobatie")
    {
        spectateur.Applaudir();
    }
    else
    {
        spectateur.Siffler();
    }
    
    
}







    








