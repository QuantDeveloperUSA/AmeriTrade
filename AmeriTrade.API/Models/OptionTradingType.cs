using System.Runtime.Serialization;

namespace AmeriTrade.API.Models
{
    /// <summary>
    /// Option trading type enumeration.
    /// </summary>
    public enum OptionTradingType
    {
        None,
        Long,
        Covered,
        Spread,
        Full
    }
}
