namespace GestionCircle.Interface;

public interface ISpectateur
{
    public string NameSpectateur { get; set; }
    public void Applaudir();
    public void Siffler();

}