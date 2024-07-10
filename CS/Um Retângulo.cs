class Retangulo
{
    private double _base = 0;
    private double _altura = 0;

    public void set_base(double x)
    {
        if ( x >= 0)
        {
            _base = x;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public void set_altura(double x)
    {
        if ( x >= 0)
        {
            _altura = x;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public double get_base()
    {
        return _base;
    }

    public double get_altura()
    {
        return _altura;
    }

    public double calc_area()
    {
        return _base * _altura;
    }

    public double calc_diagonal()
    {
        return Math.Sqrt(_altura*_altura + _base*_base)
    }

    public override string ToString()
    {
        return $"Retângulo com Base = { _base }, Altura = { _altura }"
    }
{

