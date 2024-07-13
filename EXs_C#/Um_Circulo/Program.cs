using System;

namespace CS
{
    class Circulo
    {
        private double raio = 0;

        public void set_raio(double x)
        {
            if (x >= 0)
                raio = x;
            else
                throw new ArgumentOutOfRangeException();
        }

        public double get_raio()
        {
            return raio;
        }

        public double calc_area()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public double calc_circ()
        {
            return 2 * Math.PI * raio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            c.set_raio(raio);
            Console.WriteLine($"Raio: {c.get_raio()}");
            Console.WriteLine($"Área: {c.calc_area()}");
            Console.WriteLine($"Circunferência: {c.calc_circ()}");
        }
    }
}
