namespace Negocio;

public class pokemon
{
    protected string OutroPokemon;
    protected double Fome;

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
}