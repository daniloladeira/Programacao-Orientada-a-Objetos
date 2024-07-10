class Circulo{
    private double raio = 0;

    public void set_raio(double x){
        if (x >= 0) raio = x;
        else throw new ArgumentOutOfRangeException();
    }

    public double get_raio(){
        return raio;
    }

    public double calc_area(){
        return Math.PI*raio*Math.Pow(raio, 2);
    }

    public double calc_circ(){
        return 2*Math.PI*raio;
    }
}