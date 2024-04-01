namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convertendo o array do Alfabeto de letra para número, utilizando o ToCharArray
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoArray = alfabeto.ToCharArray();

            //Entrada do usuário
            string entradaUsuario;

            //Variaveis para mudar a entrada do usuário para maiúsculo
            string upperCaseEntradaUsuario;
            char upperCaseEntradaUsuarioChar;
            
            //Declaração das linhas para montar o diamante
            int linhas = 0;

            //Opção para manter o While e fazer as perguntas no fim do While
            bool opcaoValida = false;
            string fecharBotao;
            
            bool fecharPrograma = false;

            while (fecharPrograma == false)
            {
                //Questionamos qual a Letra final escolhida para o Diamante
                Console.WriteLine("Digite uma Letra do alfabeto (Diferente de A): ");
                entradaUsuario = Console.ReadLine();
                upperCaseEntradaUsuario = entradaUsuario.ToUpper();
                upperCaseEntradaUsuarioChar = char.Parse(upperCaseEntradaUsuario);

                Console.WriteLine("");

                //Para garantir mudamos o Array do alfabeto para maiúsculo
                for (int i = 1; i < alfabetoArray.Length; i++)
                {
                    if (alfabetoArray[i] == upperCaseEntradaUsuarioChar)
                    {
                        linhas = i;
                    }
                }

                //Montando a parte de cima do diamante
                for (int i = 0; i <= linhas - 1 / 2; i++)
                {
                    for (int j = 1; j <= linhas - i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(alfabetoArray[i]);

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    if (i == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(alfabetoArray[i]);
                        Console.WriteLine("");
                    }
                }

                //Montando a parte de baixo do diamante
                for (int i = linhas - 2 / 2; i >= 0; i--)
                {
                    for (int j = 1; j <= linhas - i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(alfabetoArray[i]);

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    if (i == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(alfabetoArray[i]);
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine("");

                opcaoValida = false;

                //While com o Menu para encerrar ou continuar com o programa
                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso queira criar novo Diamante de Letra com outra letra, digite '1' e aperte ENTER.");
                    Console.WriteLine("Caso queira encerrar o programa, digite '0' e aperte ENTER.");
                    fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharPrograma = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Opcao inválida, verifique o número informado.");
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}