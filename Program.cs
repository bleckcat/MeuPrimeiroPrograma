using System;

namespace howtoC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Meu primeiro programa";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Oi, tudo bem? \nQual seu nome?");

            string userName = Console.ReadLine();

            Console.WriteLine(userName + "!!! Que nome lindo, o meu é... qual meu nome?");
            Console.WriteLine("Bem não importa, qual é sua cor favorita?");

            string userColor = Console.ReadLine();

            Console.WriteLine("Que legal eu amo " + userColor + ", a minha cor favorita é verde, igual os códigos do matrix.\nAliás, qual seu filme favorito?");

            string userFilm = Console.ReadLine();

            Console.WriteLine("Bem diferenciado, gostei.\nMas toda essa conversa está me dando vontade de contar uma história, você me ajuda?");
            Console.WriteLine("Digite 'S' para aceitar ou 'N' para negar");

            string userHistResp = Console.ReadLine();
            string upUserHistResp = userHistResp.ToUpper();

            if (upUserHistResp == "S")
            {
                Console.WriteLine("Uhuuu!!! Legal, então vamos lá!");
                Console.WriteLine("Um guerreiro entra em uma taverna e vê um amigo próximo chamado...");
                string userHistName = Console.ReadLine();

                Console.WriteLine("-Grita o guerreiro, assutando o amigo que derramou toda sua...");
                string userHistDrink = Console.ReadLine();

                Console.WriteLine("no chão, bravo com o amigo, " + userHistName + ", apenas pediu que ele desse para ele...");
                string userHistRespDrink = Console.ReadLine();

                Console.WriteLine("Antes de mesmo de ele dar " + userHistRespDrink + " para o amigo, um dragão apareceu e cospiu...");
                string userHistDragon = Console.ReadLine();

                Console.WriteLine("Levando a taverna abaixo. Fim!!!");
                Console.WriteLine("Foi muito divertido brincar com você, tchau tchau :3");
            }
            else
            {
                Console.WriteLine("Hm... prefere fazer uma conta de multiplicação simples então?");
                Console.WriteLine("Digite 'S' para aceitar ou 'N' para negar");

                string userMathResp = Console.ReadLine();
                string upUserMathResp = userMathResp.ToUpper();

                if (upUserMathResp == "S")
                {
                    double num01, num02;

                    Console.WriteLine("Uhuuu!!! Legal, então vamos lá!");

                    Console.Write("Primeiro, digite um número: ");
                    num01 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Agora nosso próximo número: ");
                    num02 = Convert.ToDouble(Console.ReadLine());

                    double resultMath = num01 * num02;

                    Console.WriteLine("E o seu resultado é " + resultMath);
                    Console.WriteLine("Você gosta de contas, não gosta " + userName + "?");

                    Console.WriteLine("Quer pegar a média de 3 valores comigo?");
                    Console.WriteLine("Digite 'S' para aceitar ou 'N' para negar");

                    string userAverageResp = Console.ReadLine();
                    string upUserAverageResp = userAverageResp.ToUpper();

                    if (upUserAverageResp == "S")
                    {
                        double ave01, ave02, ave03;

                        Console.WriteLine("Isso aí, esse é o espírito!!!");

                        Console.Write("Agora de novo, digite um número: ");
                        ave01 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("O noso segundo número: ");
                        ave02 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("E o nosso ultimo número: ");
                        ave03 = Convert.ToDouble(Console.ReadLine());

                        double resultAverage = (ave01 + ave02 + ave03) / 3;

                        Console.WriteLine("E a nossa média entre eles é de " + resultAverage);
                        Console.WriteLine("Foi muito divertido brincar com você, tchau tchau :3");
                    }
                    else
                    {
                        Console.WriteLine("Entendo, até mais!");
                    }
                }
                else
                {
                    Console.WriteLine("Entendo, até mais!");
                }
            }

            Console.ReadKey();
        }
    }
}
