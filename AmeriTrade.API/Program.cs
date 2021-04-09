using System;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace AmeriTrade.API
{
    public class Program
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

            switch (opcao)
            {
                case 1:
                    var psi = new ProcessStartInfo("C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe");
                    psi.Arguments = $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={autenticacao.uri}%3A%2F%2F{autenticacao.host}%3A{autenticacao.port}&client_id={autenticacao.clientId}%40AMER.OAUTHAP";
                    Process.Start(psi);
                    break;
                case 2:
                    Teste(autenticacao.clientId);
                    break;
                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }

        public static void Teste(string clientId)
        {
            var url = "https://api.tdameritrade.com/v1/oauth2/token";
            string dadosPost = "grant_type=refresh_token";

            dadosPost += "&refresh_token=6I9LkWI74n946zX0UXWQcZn%2BAyyXcSjNj44bTZ6I4NI2CuNQARs8cntFjnnBdU1wFSu9SqxELkNHULxQz4poGJmYUh%2FGd7nzW5Hxx3RkASo8EiUrN4sOnQvFg5%2ForPry6xfFYAt1q0Fe25JAWlorMN56CyrbTNh%2BCAfHH6STQX0O%2F1jwP4lZbhDchNsj3dyljv13xL2%2BfsK66ajRCTjyVu16paqMt%2B2zkP%2FXn14ED6XPpimF%2BV6KorvA9GEDXMlpZQzOdR1mTdUX4Tl6PabM3fhUqmnCa6IK0C9KvnEYcyyBcJL27pGtCszd1DDWHj0Gkk8XCtlbFwj%2FQVcMcDoaqUPeHR20M%2FydG64xF9bIDL04yE%2FELbJSTxtI0oYiYAVwSiEA1H4phP63jDbQEFLJ2WA0T9Atee97i3rkda9ohgz8pTvlE7%2BluKY8cJD100MQuG4LYrgoVi%2FJHHvlWEgWOIICfB9KF1sEIE%2FII%2FScLM4%2F1T0pDy%2FHi9kctfF4P%2FM6Y%2F5d8RqQ0yj%2FG1v05BVjqphCilHVYmkioX2dyAnTfLZE7Z%2Feu5%2B1ZulNEUgXXA5W5jEYAsBjkZ7halqFKkzpQ%2FjCW2mzuNoh2qj4btxq%2FtlXcADlDJ7FaszQDtWRgJ%2F2GGvqedtehGJzDDsljHo9LuiQEDU%2BNQf5lnxSlp551y2LnnRv4Um3h3QIPirtPbVUGGTdcRJlf1F2ayHEWfsWoNM5CfDXF46RxFG7GfO7F8TWubtWfMIDEDV%2BaQiFGsGgFuem%2FFEFnFCcSUzb4v9oytsdjKawyrZieRsFL6Vr6NdsuaDM5Ytgp40bF%2FNcV0hiyRJKb4%2F7v%2BoyY9taQDn1qm8LN%2FHbWtMHsBsTleTy%2Fyi2mgEpSOvS4BPt1NbCJVLVBUkojmqanGg%3D212FD3x19z9sWBHDJACbC00B75E";
            dadosPost += $"clientId={clientId}@AMER.OAUTHAP";

            var dados = Encoding.UTF8.GetBytes(dadosPost);

            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "POST";
            requisicaoWeb.ContentType = "application/x-www-form-urlencoded";
            requisicaoWeb.ContentLength = dados.Length;
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";

            var resposta = requisicaoWeb.GetResponse();

        }
    }
}
