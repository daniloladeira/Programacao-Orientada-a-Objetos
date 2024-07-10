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
}