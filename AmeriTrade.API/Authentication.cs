using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace AmeriTrade.API
{
    public class Authentication
    {
        public string uri { get; set; }
        public string host { get; set; }
        public string port { get; set; }
        public string clientId { get; set; }
    }
}
