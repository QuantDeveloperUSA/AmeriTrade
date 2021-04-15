using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriTrade.API
{
    public class ResponseAPI
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
        public int expires_in { get; set; }
        public int refresh_token_expires_in { get; set; }
        public string token_type { get; set; }
        public string error { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class InitialBalances
    {
        public int accruedInterest { get; set; }
        public int availableFundsNonMarginableTrade { get; set; }
        public int bondValue { get; set; }
        public int buyingPower { get; set; }
        public int cashBalance { get; set; }
        public int cashAvailableForTrading { get; set; }
        public int cashReceipts { get; set; }
        public int dayTradingBuyingPower { get; set; }
        public int dayTradingBuyingPowerCall { get; set; }
        public int dayTradingEquityCall { get; set; }
        public int equity { get; set; }
        public int equityPercentage { get; set; }
        public int liquidationValue { get; set; }
        public int longMarginValue { get; set; }
        public int longOptionMarketValue { get; set; }
        public int longStockValue { get; set; }
        public int maintenanceCall { get; set; }
        public int maintenanceRequirement { get; set; }
        public int margin { get; set; }
        public int marginEquity { get; set; }
        public int moneyMarketFund { get; set; }
        public int mutualFundValue { get; set; }
        public int regTCall { get; set; }
        public int shortMarginValue { get; set; }
        public int shortOptionMarketValue { get; set; }
        public int shortStockValue { get; set; }
        public int totalCash { get; set; }
        public bool isInCall { get; set; }
        public int pendingDeposits { get; set; }
        public int marginBalance { get; set; }
        public int shortBalance { get; set; }
        public int accountValue { get; set; }
    }

    public class CurrentBalances
    {
        public int accruedInterest { get; set; }
        public int cashBalance { get; set; }
        public int cashReceipts { get; set; }
        public int longOptionMarketValue { get; set; }
        public int liquidationValue { get; set; }
        public int longMarketValue { get; set; }
        public int moneyMarketFund { get; set; }
        public int savings { get; set; }
        public int shortMarketValue { get; set; }
        public int pendingDeposits { get; set; }
        public int availableFunds { get; set; }
        public int availableFundsNonMarginableTrade { get; set; }
        public int buyingPower { get; set; }
        public int buyingPowerNonMarginableTrade { get; set; }
        public int dayTradingBuyingPower { get; set; }
        public int equity { get; set; }
        public int equityPercentage { get; set; }
        public int longMarginValue { get; set; }
        public int maintenanceCall { get; set; }
        public int maintenanceRequirement { get; set; }
        public int marginBalance { get; set; }
        public int regTCall { get; set; }
        public int shortBalance { get; set; }
        public int shortMarginValue { get; set; }
        public int shortOptionMarketValue { get; set; }
        public int sma { get; set; }
        public int mutualFundValue { get; set; }
        public int bondValue { get; set; }
    }

    public class ProjectedBalances
    {
        public int availableFunds { get; set; }
        public int availableFundsNonMarginableTrade { get; set; }
        public int buyingPower { get; set; }
        public int dayTradingBuyingPower { get; set; }
        public int dayTradingBuyingPowerCall { get; set; }
        public int maintenanceCall { get; set; }
        public int regTCall { get; set; }
        public bool isInCall { get; set; }
        public int stockBuyingPower { get; set; }
    }

    public class SecuritiesAccount
    {
        public string type { get; set; }
        public string accountId { get; set; }
        public int roundTrips { get; set; }
        public bool isDayTrader { get; set; }
        public bool isClosingOnlyRestricted { get; set; }
        public InitialBalances initialBalances { get; set; }
        public CurrentBalances currentBalances { get; set; }
        public ProjectedBalances projectedBalances { get; set; }
    }

    public class Accounts
    {
        public SecuritiesAccount securitiesAccount { get; set; }
    }
}
