using System;

namespace CS  // Corrigido: Removido ponto e vírgula após o nome do namespace
{
    class Triangulo
    {
        private double b = 0;
        private double h = 0;

        public void set_base(double v)
        {
            if (v >= 0)
                b = v;
            else
                throw new ArgumentOutOfRangeException(); // Corrigido: Comentário reformulado

        }

        public void set_altura(double v)
        {
            if (v >= 0)
                h = v;
            else
                throw new ArgumentOutOfRangeException(); // Corrigido: Comentário reformulado
        }

        public double get_base()
        {
            return b;
        }

        public double get_altura()
        {
            return h;
        }

        public double calc_area()
        {
            return b * h / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Console.WriteLine("Digite o valor da base: ");
            x.set_base(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor da altura: ");
            x.set_altura(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Um triângulo de base {x.get_base()} e altura {x.get_altura()}");
            Console.WriteLine($"tem área = {x.calc_area()}");
        }
    }
}
