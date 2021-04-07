using System.Xml.Serialization;

namespace AmeriTrade.API.Models
{
    [XmlRoot("quote", Namespace = "")]
    public class ErrorQuote
    {
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("error")]
        public string ErrorMessage { get; set; }
    }
}
