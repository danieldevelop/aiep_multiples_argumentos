using System;
using System.Collections.Generic;
using System.Text;

namespace multiples_argumentos_csharp.includes
{
    internal class Functions
    {
        private int resultadoSuma;

        /**
         * Esta funcion o metodo, recibe n cantidad de valores numericos, es decir
         * que puede recibir 2 o más valores para para operar
         */
        public int adicion(params int[] numero)
        {
            foreach (int num in numero)
            {
                resultadoSuma += num;
            }

            return resultadoSuma;
        }

    }
}
