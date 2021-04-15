using System;
using System.Diagnostics;
using AmeriTrade.API;
using Newtonsoft.Json;

namespace AmeriTrade.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var autenticacao = new Authentication
            {
                uri = "http",
                host = "localhost",
                port = "5000",
                clientId = "TOIRPVL3CGASXGCPVSGKVFTRQN67ZYE5"
            };

            Console.Write("Digite uma opção: ");
            var opcao = Convert.ToInt32(Console.ReadLine());

            AmeriTrade.API.AmeriTrade ameritrade = new AmeriTrade.API.AmeriTrade();

            switch (opcao)
            {
                case 1:
                    var psi = new ProcessStartInfo("C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe");
                    
                    psi.Arguments = ameritrade.retornarUrlAutenticacao(autenticacao);
                    
                    Process.Start(psi);

                    break;
                case 2:
                    Console.WriteLine("Informe o código gerado pela URL do navegador: ");

                    var codigoUrl = Console.ReadLine();
                    var resposta = ameritrade.AutenticarUsuario(codigoUrl,autenticacao);

                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.access_token);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.refresh_token);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.scope);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.expires_in);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.refresh_token_expires_in);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.token_type);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(resposta.error);

                    Console.ReadKey();

                    break;
                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}
