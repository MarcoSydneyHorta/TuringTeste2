using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite os dados separados por vírgula: ");
            string opus = Console.ReadLine();
            string[] sem = opus.Split(",");
            int tam = sem.Length;
            int[] dados = new int[tam];

            for ( int i = 0; i < tam; i++)
            {
                dados[i] = int.Parse(sem[i]);
            }
            //int[] dados = { 1, 3, 2, 3, 5, 0 };


            int saida = Conta.Resultado(dados);
            Console.Write("Soma = " + saida +  " - " + dados[1]);
            Console.Read();

        }
    }
}
