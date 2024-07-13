using System;

namespace CS
{
    class Viagem
    {
        private double distancia = 0;
        private double tempo = 0;

        public void set_distancia(double x)
        {
            if (x >= 0)
            {
                distancia = x;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void set_tempo(double x)
        {
            if (x >= 0)
            {
                tempo = x;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public double get_distancia()
        {
            return distancia;
        }

        public double get_tempo()
        {
            return tempo;
        }

        public double velocidade_media()
        {
            if (tempo == 0)
            {
                throw new DivideByZeroException("Tempo não pode ser zero ao calcular a velocidade média.");
            }
            return distancia / tempo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Viagem V = new Viagem();
            
            Console.WriteLine("Digite a distância da viagem (KM): ");
            double distancia = double.Parse(Console.ReadLine());
            V.set_distancia(distancia);
            
            Console.WriteLine("Digite o tempo de viagem (em minutos): ");
            double tempoMinutos = double.Parse(Console.ReadLine());
            double tempoHoras = tempoMinutos / 60.0;  // Convertendo minutos para horas
            V.set_tempo(tempoHoras);

            Console.WriteLine($"Distância: {V.get_distancia()} KM");
            Console.WriteLine($"Tempo de Viagem: {tempoMinutos} minutos");
            Console.WriteLine($"Velocidade Média: {V.velocidade_media()} KM/h");
        }
    }
}
