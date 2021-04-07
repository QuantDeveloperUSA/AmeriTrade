using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AmeriTrade.API.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<XDocument> GetXmlAsync(this HttpClient http, string requestUri)
        {
            using (var stream = await http.GetStreamAsync(requestUri))
            {
                return XDocument.Load(stream);
            }
        }
    }
}
