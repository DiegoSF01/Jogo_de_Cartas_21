using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Cartas_21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("  @@@@@@@@@@@@@          @@@@@@@@@@@  ");
            Console.WriteLine(" @@@@@@  @@@@@@@@    @@@@@@@@@@@@@@@  ");
            Console.WriteLine("            @@@@@@         @@@@@@@@@  ");
            Console.WriteLine("         @@@@@@@@          @@@@@@@@@  ");
            Console.WriteLine("       @@@@@@@@            @@@@@@@@@  ");
            Console.WriteLine("  @@@@@@@@@@@@@@@@         @@@@@@@@@  ");
            Console.WriteLine(" @@@@@@@@@@@@@@@@@         @@@@@@@@@  ");

            Console.WriteLine("");

            Console.WriteLine("Vamos Iniciar!");
            Console.WriteLine("Regras:");
            Console.WriteLine("1- 21 é um jogo onde se deve jogar com 2 jogadores");
            Console.WriteLine("2- Os 2 jogadores receberam 2 cartas no começo");
            Console.WriteLine("3- Como o nome do jogo já diz o seu objetivo é fazer 21 pontos");
            Console.WriteLine("4- Se fizer mais do 21 pontos você perde!");
            Console.WriteLine("5- Ganha quem chegar mais perto de fazer 21 pontos");
            Console.WriteLine("6- Você pode escolher pegar mais cartas ou não");
            Console.WriteLine("7- O número da sua carta equivale a pontuação daquela carta");
            Console.WriteLine("8- As cartas |J|, |Q| e |K| valem 10, já |A| vale 1");
            Console.WriteLine("9- para saber sua pontuação é so somar as cartas que você possui");

            Console.WriteLine("Vamos Iniciar [Sim = S / Não = N]: ");
            string Iniciar = Console.ReadLine();

            while (Iniciar == "S")
            {

                int Pontuacao1 = 0;
                int Pontuacao2 = 0;

                Console.WriteLine("");

                Console.WriteLine("||Jogador 1||");

                Random random = new Random();
                int Maquina = random.Next(12);

                switch (Maquina)
                {

                    case 0:
                        Console.WriteLine(" ___________________ ");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|       @@@@@       |");
                        Console.WriteLine("|      @@@@@@@      |");
                        Console.WriteLine("|     @@@@ @@@@     |");
                        Console.WriteLine("|    @@@@   @@@@    |");
                        Console.WriteLine("|   @@@@@@@@@@@@@   |");
                        Console.WriteLine("|  @@@@@     @@@@@  |");
                        Console.WriteLine("| @@@@@@     @@@@@@ |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("1 ponto");

                        break;

                    case 1:
                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@    |");
                        Console.WriteLine("| @@@@@@@ @@@@@@@@  |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|         @@@@@@@@  |");
                        Console.WriteLine("|       @@@@@@@@    |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("2 pontos");

                        Pontuacao1 +=2;

                        break;

                    case 2:
                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@   |");
                        Console.WriteLine("|       @@@@@@@     |");
                        Console.WriteLine("|     @@@@@@@@@@@@  |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|    @@@@@@@@@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("3 pontos");

                        Pontuacao1 += 3;

                        break;

                    case 3:
                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|        @@@@@@@    |");
                        Console.WriteLine("|      @@@@@@@@@    |");
                        Console.WriteLine("|    @@@@@ @@@@@    |");
                        Console.WriteLine("|  @@@@    @@@@@    |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|         @@@@@@    |");
                        Console.WriteLine("|         @@@@@@    |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("4 pontos");

                        Pontuacao1 += 4;

                        break;

                }

                

            }

        }
    }
}
