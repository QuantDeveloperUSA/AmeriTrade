using System.Xml.Serialization;

namespace AmeriTrade.API.Models
{
    public enum PositionType
    {
        [XmlEnum("LONG")]
        Long,

        [XmlEnum("SHORT")]
        Short
    }
}
