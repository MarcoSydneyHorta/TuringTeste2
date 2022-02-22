using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Conta
    {
        
        public static int Resultado(int[] entrada)
        {

            int index = 0;
            int tam = entrada.Length;
            int elem = 0;
            int soma = 0;
            int contador = 0;

            for (int i = 0;i < tam; i++)
            {
                elem = entrada[i];
                for (int j = 0; j < tam; j++)
                {
                    if (j != i)
                    {
                        if ((entrada[j] != 0) & (elem != 0))
                        {
                            soma = elem + entrada[j];
                            index = Array.IndexOf(entrada, soma);
                            if (index > -1) contador++;
                        }
                    }
                }
            }
            entrada[1] = contador;
            return entrada[1];
        }
    }
}
