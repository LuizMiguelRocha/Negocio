using POU64;

namespace Negocio;

public class pokemon
{
    protected string OutroPokemon;
    protected double Fome;
    protected double Sede;
    protected double Saude;

    protected bool Morto;

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
        {
            Fome = 0;
            Morto = true;    
        }    
    }

       public void SetSede(double s)
    {
        if (s <= 1 && s >= 0)
          Sede = s;
        else if (s > 1)
            Sede = 1;
        else
        {
            Sede = 0;
            Morto = true;
        }
    }

       public void SetSaude(double a)
    {
        if (a <= 1 && a >= 0)
          Saude = a;
        else if (a > 1)
            Saude = 1;
        else
        {
            Saude = 0;
            Morto = true;
        }        
    }

    public bool GetMorto()
    {
        return Morto;
    }

}