/*namespace CS;
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
}*/

/*using System;

namespace CS
{
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
}*/

/*using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Viagem V = new Viagem();
            
            Console.WriteLine("Digite a distância da viagem (KM): ");
            double distancia = double.Parse(Console.ReadLine());
            V.set_distancia(distancia);
            
            Console.WriteLine("Digite o tempo de viagem (Minutos): ");
            double tempoMinutos = double.Parse(Console.ReadLine());
            double tempoHoras = tempoMinutos / 60.0;
            V.set_tempo(tempoHoras);

            Console.WriteLine($"Distância: {V.get_distancia()} Tempo de Viagem: {V.get_tempo()}");
            Console.WriteLine($"Velocidade Média: {V.velocidade_media()}");
        }
    }
}*/

/*UMA ENTRADA DE CINEMA*/

/*UMA CONTA BANCÁRIA*/

namespace CS
{

    class Program
    {
        static Void Main()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.Readline());
            Retangulo.set_altura();

            Console.WriteLine("Digite a base do retângulo: ");
            double retangulo = double.Parse(Console.ReadLine());
            Retangulo.set_base();

            Console.WriteLine(ToString());
            Console.WriteLine("ÁREA: " {Retangulo.calc_area()} "DIAGONAL: " {Retangulo.calc_diagonal()})
        }
    }
}



