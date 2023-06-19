namespace GestionCircle.Interface;

public interface IDresseur
{
    public string NameDresseur { get; set; }
    public void DemandeAuSigneFaireTour(int i,string name);
}