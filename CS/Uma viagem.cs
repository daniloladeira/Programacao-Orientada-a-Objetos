class Viagem
{
    private double distancia = 0;
    private double tempo = 0;

    public void set_distancia(double x)
    {
        if (x >= 0) x = 0; else throw new ArgumentOutOfRangeException();
    }
    
}