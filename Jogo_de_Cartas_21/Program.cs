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

            Random random = new Random();

            int Pontuacao1 = 0;
            int Pontuacao2 = 0;

            void cartas1()
            {
                int Maquina = random.Next(13);

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

                        Pontuacao1 += 1;

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

                        Pontuacao1 += 2;

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

                    case 4:
                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@  |");
                        Console.WriteLine("|  @@@@@@           |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|           @@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@    |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("5 pontos");

                        Pontuacao1 += 5;

                        break;

                    case 5:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|    @@@@@@@@@@@@@  |");
                        Console.WriteLine("|  @@@@@@@          |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@   |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@@  |");
                        Console.WriteLine("| @@@@@@      @@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|     @@@@@@@@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("6 pontos");

                        Pontuacao1 += 6;

                        break;

                    case 6:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|          @@@@@@@  |");
                        Console.WriteLine("|         @@@@@@@   |");
                        Console.WriteLine("|        @@@@@@@    |");
                        Console.WriteLine("|       @@@@@@@     |");
                        Console.WriteLine("|      @@@@@@@      |");
                        Console.WriteLine("|    @@@@@@@        |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("7 pontos");

                        Pontuacao1 += 7;

                        break;

                    case 7:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|     @@@@@@@@@@    |");
                        Console.WriteLine("|   @@@@@@@@@@@@@@  |");
                        Console.WriteLine("|   @@@@@     @@@@  |");
                        Console.WriteLine("|    @@@@@@@@@@@@   |");
                        Console.WriteLine("|  @@@@@@     @@@@@ |");
                        Console.WriteLine("|  @@@@@@@   @@@@@@ |");
                        Console.WriteLine("|    @@@@@@@@@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("8 pontos");

                        Pontuacao1 += 8;

                        break;

                    case 8:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|    @@@@@@@@@@@@   |");
                        Console.WriteLine("|   @@@@@@@@@@@@@@  |");
                        Console.WriteLine("|  @@@@@      @@@@  |");
                        Console.WriteLine("|   @@@@@@@@@@@@@@  |");
                        Console.WriteLine("|           @@@@@@  |");
                        Console.WriteLine("|           @@@@@@  |");
                        Console.WriteLine("|           @@@@@@  |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("9 pontos");

                        Pontuacao1 += 9;

                        break;

                    case 9:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|   @@@@@   @@@@@   |");
                        Console.WriteLine("| @@@@@@@  @@@ @@@  |");
                        Console.WriteLine("|    @@@@ @@@   @@@ |");
                        Console.WriteLine("|    @@@@ @@@   @@@ |");
                        Console.WriteLine("|    @@@@ @@@   @@@ |");
                        Console.WriteLine("|    @@@@  @@@ @@@  |");
                        Console.WriteLine("|    @@@@   @@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao1 += 10;

                        break;

                    case 10:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("| @@@@@@     @@@@@@ |");
                        Console.WriteLine("| @@@@@@@   @@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@  |");
                        Console.WriteLine("|      @@@@@@@      |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao1 += 10;

                        break;

                    case 11:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|     @@@@@@@       |");
                        Console.WriteLine("|   @@@@   @@@@     |");
                        Console.WriteLine("|  @@@@     @@@@    |");
                        Console.WriteLine("|   @@@@   @@@@     |");
                        Console.WriteLine("|    @@@@@@@@@  @@  |");
                        Console.WriteLine("|         @@@  @@@  |");
                        Console.WriteLine("|          @@@@@    |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao1 += 10;

                        break;

                    case 12:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("| @@@@@@   @@@@@@@  |");
                        Console.WriteLine("| @@@@@@  @@@@@@@   |");
                        Console.WriteLine("| @@@@@@@@@@@@@     |");
                        Console.WriteLine("| @@@@@@@@@@@@      |");
                        Console.WriteLine("| @@@@@@ @@@@@@@    |");
                        Console.WriteLine("| @@@@@@   @@@@@@   |");
                        Console.WriteLine("| @@@@@@    @@@@@@@ |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao1 += 10;

                        break;
                        
                }

            }

            

            void cartas2()
            {
                int Maquina = random.Next(13);

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

                        Pontuacao2 += 1;

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

                        Pontuacao2 += 2;

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

                        Pontuacao2 += 3;

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

                        Pontuacao2 += 4;

                        break;

                    case 4:
                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@  |");
                        Console.WriteLine("|  @@@@@@           |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@   |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|           @@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@    |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("5 pontos");

                        Pontuacao2 += 5;

                        break;

                    case 5:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|    @@@@@@@@@@@@@  |");
                        Console.WriteLine("|  @@@@@@@          |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@   |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@@  |");
                        Console.WriteLine("| @@@@@@      @@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|     @@@@@@@@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("6 pontos");

                        Pontuacao2 += 6;

                        break;

                    case 6:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("| @@@@@@@@@@@@@@@@@ |");
                        Console.WriteLine("|          @@@@@@@  |");
                        Console.WriteLine("|         @@@@@@@   |");
                        Console.WriteLine("|        @@@@@@@    |");
                        Console.WriteLine("|       @@@@@@@     |");
                        Console.WriteLine("|      @@@@@@@      |");
                        Console.WriteLine("|    @@@@@@@        |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("7 pontos");

                        Pontuacao2 += 7;

                        break;

                    case 7:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|     @@@@@@@@@@    |");
                        Console.WriteLine("|   @@@@@@@@@@@@@@  |");
                        Console.WriteLine("|   @@@@@     @@@@  |");
                        Console.WriteLine("|    @@@@@@@@@@@@   |");
                        Console.WriteLine("|  @@@@@@     @@@@@ |");
                        Console.WriteLine("|  @@@@@@@   @@@@@@ |");
                        Console.WriteLine("|    @@@@@@@@@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("8 pontos");

                        Pontuacao2 += 8;

                        break;

                    case 8:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|    @@@@@@@@@@@@   |");
                        Console.WriteLine("|   @@@@@@@@@@@@@@  |");
                        Console.WriteLine("|  @@@@@      @@@@  |");
                        Console.WriteLine("|   @@@@@@@@@@@@@@  |");
                        Console.WriteLine("|           @@@@@@  |");
                        Console.WriteLine("|           @@@@@@  |");
                        Console.WriteLine("|           @@@@@@  |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("9 pontos");

                        Pontuacao2 += 9;

                        break;

                    case 9:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|   @@@@@   @@@@@   |");
                        Console.WriteLine("| @@@@@@@  @@@ @@@  |");
                        Console.WriteLine("|    @@@@ @@@   @@@ |");
                        Console.WriteLine("|    @@@@ @@@   @@@ |");
                        Console.WriteLine("|    @@@@ @@@   @@@ |");
                        Console.WriteLine("|    @@@@  @@@ @@@  |");
                        Console.WriteLine("|    @@@@   @@@@@   |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao2 += 10;

                        break;

                    case 10:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("|            @@@@@@ |");
                        Console.WriteLine("| @@@@@@     @@@@@@ |");
                        Console.WriteLine("| @@@@@@@   @@@@@@@ |");
                        Console.WriteLine("|  @@@@@@@@@@@@@@@  |");
                        Console.WriteLine("|      @@@@@@@      |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao2 += 10;

                        break;

                    case 11:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("|     @@@@@@@       |");
                        Console.WriteLine("|   @@@@   @@@@     |");
                        Console.WriteLine("|  @@@@     @@@@    |");
                        Console.WriteLine("|   @@@@   @@@@     |");
                        Console.WriteLine("|    @@@@@@@@@  @@  |");
                        Console.WriteLine("|         @@@  @@@  |");
                        Console.WriteLine("|          @@@@@    |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao2 += 10;

                        break;

                    case 12:

                        Console.WriteLine(" ___________________");
                        Console.WriteLine("|                   |");
                        Console.WriteLine("| @@@@@@   @@@@@@@  |");
                        Console.WriteLine("| @@@@@@  @@@@@@@   |");
                        Console.WriteLine("| @@@@@@@@@@@@@     |");
                        Console.WriteLine("| @@@@@@@@@@@@      |");
                        Console.WriteLine("| @@@@@@ @@@@@@@    |");
                        Console.WriteLine("| @@@@@@   @@@@@@   |");
                        Console.WriteLine("| @@@@@@    @@@@@@@ |");
                        Console.WriteLine("|___________________|");
                        Console.WriteLine("10 pontos");

                        Pontuacao2 += 10;

                        break;

                }

            }

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
            string Iniciar = Console.ReadLine().ToUpper();

            while (Iniciar == "S")
            {

                

                Console.WriteLine("");
                Console.WriteLine("||Jogador 1||");

                for (int i = 0; i < 2; i++)
                {
                    cartas1();
                }

                Console.WriteLine("");
                Console.WriteLine("||Jogador 2||");

                for(int i = 0; i < 2; i++)
                {
                    cartas2();
                }
               
                Console.WriteLine("");
                Console.WriteLine("||Jogador 1||");
                Console.WriteLine("Você possui " + Pontuacao1 + " pontos.");
                Console.WriteLine("Deseja pegar mais cartas (Sim = S / Não = N): ");
                string mais_carta = Console.ReadLine().ToUpper();

                while (mais_carta == "S")
                {
                    cartas1();

                    Console.WriteLine("||Jogador 1||");
                    Console.WriteLine("Você possui " + Pontuacao1 + " pontos");
                    Console.WriteLine("Deseja pegar mais cartas (Sim = S / Não = N): ");
                    mais_carta = Console.ReadLine().ToUpper();

                    if (Pontuacao1 > 21)
                    {
                        mais_carta = "N";

                        Console.WriteLine("");
                        Console.WriteLine("||Jogador 1||");
                        Console.WriteLine("Você ||PERDEU|| por fazer mais de 21 pontos");
                        Console.WriteLine("Com " + Pontuacao2 + " pontos ||Jogador 2 VENCEU||");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("||Jogador 2||");
                Console.WriteLine("Você possui " + Pontuacao1 + " pontos.");
                Console.WriteLine("Deseja pegar mais cartas (Sim = S / Não = N): ");
                mais_carta = Console.ReadLine().ToUpper();

                while(mais_carta == "S")
                {
                    cartas2();

                    Console.WriteLine("||Jogador 2||");
                    Console.WriteLine("Você possui " + Pontuacao2 + " pontos");
                    Console.WriteLine("Deseja pegar mais cartas (Sim = S / Não = N): ");
                    mais_carta = Console.ReadLine().ToUpper();

                    if (Pontuacao2 > 21)
                    {
                        mais_carta = "N";

                        Console.WriteLine("");
                        Console.WriteLine("||Jogador 2||");
                        Console.WriteLine("Você ||PERDEU|| por fazer mais de 21 pontos");
                        Console.WriteLine("Com " + Pontuacao1 + " pontos ||Jogador 1 VENCEU||");
                    }
                }



                if (Pontuacao1 > 21)
                {
                    
                }

                Console.WriteLine("Deseja continuar jogando (Sim = S / Não = N): ");
                Iniciar = Console.ReadLine().ToUpper();

            }

        }
    }
}
