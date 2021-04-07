﻿using System.Xml.Serialization;

namespace AmeriTrade.API.Models
{
    [XmlRoot("quote", Namespace = "")]
    public class IndexQuote
    {
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("open")]
        public float Open { get; set; }

        [XmlElement("high")]
        public float High { get; set; }

        [XmlElement("low")]
        public float Low { get; set; }

        [XmlElement("last")]
        public float Last { get; set; }

        [XmlElement("close")]
        public float Close { get; set; }

        [XmlElement("year-high")]
        public float YearHigh { get; set; }

        [XmlElement("year-low")]
        public float YearLow { get; set; }

        [XmlElement("real-time")]
        public bool IsRealTime { get; set; }
    }
}
