namespace Negocio;

public class pokemon
{
    protected string OutroPokemon;
    protected double Fome;
    protected double Sede;
    protected double Saude;

    public pokemon()
    {
        OutroPokemon="";
    }

    public string GetOutroPokemon()
    {
        return OutroPokemon;
    }

    public double GetFome()
    {
        return Fome;
    }

    public double GetSede()
    {
        return Sede;
    }

    public double GetSaude()
    {
        return Saude;
    }
}