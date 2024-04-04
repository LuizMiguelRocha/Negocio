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

       public void SetFome(double f)
    {
        if (f <= 1 && f >= 0)
          Fome = f;
        else if (f > 1)
            Fome = 1;
        else
            Fome = 0;    
    }

}