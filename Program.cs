using System.Security.AccessControl;
using System.Xml.Schema;

namespace JogodaAdivinhacaoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Bem Vindo ao Jogo da Adivinhação**********");
            double pontos = 1000;
            int nivel;
            int totaldetentativas;

            double chute;

            Console.WriteLine("Escolha o nível de dificuldade: ");
            Console.WriteLine(" (1) Fácil (2) Médio (3) Difícil");
            Console.Write("Escolha: ");

            nivel = Convert.ToInt32(Console.ReadLine());

           if (nivel == 1)
           {
                totaldetentativas = 20;

           }
           else if (nivel == 2)
           {
                totaldetentativas = 15;
           }
           else
           {
                totaldetentativas = 6;
           }
            
            Random random = new Random();
            int numeroGrande = random.Next();
            int numerosecreto = numeroGrande % 20;
            
            Console.WriteLine("O número secreto é " +  numerosecreto);

            

            for (int i = 1; i < totaldetentativas; i++)
            {
                Console.Clear();

                Console.WriteLine("Tentativa {0} de {1}", i, totaldetentativas);
                
                Console.Write("Qual o seu chute?");
                chute = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("O seu chute foi: " + chute);
                int numeroChute = Convert.ToInt32(chute);

                bool acertou = numeroChute == numerosecreto;
                if (acertou)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                    break;
                }
                else
                {
                    bool maior = numeroChute > numerosecreto;

                    if (maior)
                    {
                        Console.WriteLine("Você errou, seu chute foi maior que o número secreto.");
                    }
                    else   
                    {
                        Console.WriteLine("Você errou, seu chute foi menor que o número secreto.");
                    }

                  
                }
                double pontosPerdidos = Math.Abs(chute - numerosecreto) / 2.0;
                pontos = pontos - pontosPerdidos;
            
                Console.WriteLine("Você fez" + pontos + "pontos!");
                Console.ReadLine();
            
            }
            

               
                    




        }
    }
}