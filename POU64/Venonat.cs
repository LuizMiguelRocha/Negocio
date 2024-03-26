namespace POU64;

public class Venonat
{
    public int fome;
    public int sede;
    public int tristeza;

    public Venonat()
    {
        fome=0;
        sede=0;
        tristeza=0;
    }

    public void SetFome(int f)
    {
        if (f > 1)
           fome = 1;
        if (f < 0)
           fome = 0;      
    }

    public int GetFome()
    {
        return fome;
    }
}