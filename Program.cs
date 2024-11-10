using System;


namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start(6);
            Console.Clear();
            Menu();
        }

        static void Menu()
        {

            Console.WriteLine("Segundo => 10s = 10 segundos");
            Console.WriteLine("Minuto => 1m = 1 minuto");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();     //ToLower converte os dados para minusculo

            // Extrai o último caractere da string 'data' usando o método Substring e converte para char.
            // Substring(posição inicial, quantidade) permite pegar uma parte da string.    
            // Aqui, usamos a posição inicial 'data.Length - 1' e pegamos 1 caractere para obter o tipo.
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
            Start(time);
            Menu();
        }


        static void Start(int type)
        {
            int currenttype = 0;

            while (type != currenttype)
            {
                Console.Clear();

                currenttype++;

                Console.WriteLine(currenttype);
                Thread.Sleep(1000);     //pausa o sistema por determinado parametro
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);


        }
    }
}