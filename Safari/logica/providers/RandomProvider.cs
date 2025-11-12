using Safari.services.interfaces;
using System;



namespace Safari.services.providers
{
    //clase que implementa la interfaz IRandomProvider para generar números aleatorios
    internal class RandomProvider : IRandomProvider
    {
        private Random random;
        //constructor que inicializa la instancia de Random con una semilla basada en el tiempo actual
        public RandomProvider()
        {
            int seed = Environment.TickCount;
            random = new Random(seed);
        }
        //método que devuelve un número aleatorio entre min (inclusive) y max (exclusive)
        public int nextRandom(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
