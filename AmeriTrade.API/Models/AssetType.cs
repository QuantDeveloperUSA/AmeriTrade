using System.ComponentModel;
using System.Xml.Serialization;

namespace AmeriTrade.API.Models
{
    public enum AssetType
    {
        [XmlEnum("")]
        Unknown,

        [XmlEnum("E")]
        EquityOrETF,

        [XmlEnum("F")]
        MutualFund,

        [XmlEnum("O")]
        Option,

        [XmlEnum("B")]
        Bond,

        [XmlEnum("I")]
        Index
    }
}
