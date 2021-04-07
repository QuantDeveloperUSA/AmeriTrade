using System.Xml.Serialization;

namespace AmeriTrade.API.Models
{
    [XmlRoot("quote", Namespace = "")]
    public class FundQuote
    {
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("nav")]
        public float Nav { get; set; }

        [XmlElement("change")]
        public float Change { get; set; }

        [XmlElement("real-time")]
        public bool IsRealTime { get; set; }
    }
}
