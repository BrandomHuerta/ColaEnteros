using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaEnteros
{
    public class Cola
    {
        private int[] elementos;
        private int frente, final,cantidad , max;

        public Cola(int tamaño)
        {
            elementos = new int[tamaño];
            frente = 0;
            final = -1;
            cantidad = 0;
            max = tamaño;
        }

        public bool EstaVacia()
        {
            return cantidad == 0;
        }

        public bool EstaLlena()
        {
            return cantidad == max;
        }

        public void Encolar(int valor)
        {
            if (EstaLlena())
                throw new InvalidOperationException("La cola está llena.");

            final = (final + 1) % max;
            elementos[final] = valor;
            cantidad++;
        }

        public int Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            int valor = elementos[frente];
            frente = (frente + 1) % max;
            cantidad--;
            return valor;
        }

        public int[] ObtenerElementos()
        {
            int[] resultado = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                resultado[i] = elementos[(frente + i) % max];
            }
            return resultado;
        }
    }
}
