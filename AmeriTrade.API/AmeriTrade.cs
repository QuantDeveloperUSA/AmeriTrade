using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AmeriTrade.API
{
    public class AmeriTrade
    {
        public string retornarUrlAutenticacao(Authentication autenticacao)
        {
            return $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={autenticacao.uri}%3A%2F%2F{autenticacao.host}%3A{autenticacao.port}&client_id={autenticacao.clientId}%40AMER.OAUTHAP";
        }

        public ResponseAPI AutenticarUsuario(string code,Authentication autenticacao)
        {
            var urlEnvio = $"{autenticacao.uri}://{autenticacao.host}:{autenticacao.port}";

            string url = string.Format("https://api.tdameritrade.com/v1/oauth2/token");
            RestClient client = new RestClient(url);
            RestRequest postRequest = new RestRequest(Method.POST);
            postRequest.AddHeader("cache-control", "no-cache");
            postRequest.AddHeader("content-type", "application/x-www-form-urlencoded");
            postRequest.AddParameter("application/x-www-form-urlencoded", $"grant_type=authorization_code&access_type=offline&code={code}&client_id={autenticacao.clientId}@AMER.OAUTHAP&redirect_uri={urlEnvio}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(postRequest);

            ResponseAPI respostaAPI = JsonConvert.DeserializeObject<ResponseAPI>(response.Content);


            return respostaAPI;
        }

        public List<Accounts>GetAccounts()
        {
            //JsonConvert.DeserializeObject<List<Accounts>>();
            throw new Exception();
        }
    }
}
