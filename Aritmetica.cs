using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna o resultado da soma de dois números</returns>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Operação de Multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
