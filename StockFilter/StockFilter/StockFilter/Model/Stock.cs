﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFilter
{
    public class IntraDayQuotes
    {

        public int ID { get; set; }
        public string Symbol { get; set; }
        public string Date { get; set; }
        public float Price { get; set; }
        public float Volume { get; set; }
        public float TotalVolume { get; set; }
        public string Side { get; set; }
    }


    public class StockItem
    {
        public string Symbol { get; set; }
        public int LFY { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public string Date { get; set; }
        public float BookValuePerShare { get; set; }
        public float SalesPerShare { get; set; }
        public float SharesOutstanding { get; set; }
        public float MarketCapitalization { get; set; }
        public float PE { get; set; }
        public float BasicPE { get; set; }
        public float DilutedPE { get; set; }
        public float PB { get; set; }
        public float PS { get; set; }
        public float EPS { get; set; }
        public float BasicEPS { get; set; }
        public float DilutedEPS { get; set; }
        public float GrossMargin { get; set; }
        public float EBITMargin { get; set; }
        public float OperatingMargin { get; set; }
        public float QuickRatio { get; set; }
        public float CurrentRatio { get; set; }
        public float InterestCoverageRatio { get; set; }
        public float LongtermDebtOverEquity { get; set; }
        public float TotalDebtOverEquity { get; set; }
        public float TotalDebtOverAssets { get; set; }
        public float PreTaxMargin { get; set; }
        public float NetProfitMargin { get; set; }
        public float ROE { get; set; }
        public float ROA { get; set; }
        public float ROIC { get; set; }
        public float EBIT { get; set; }
        public float EBITDA { get; set; }
        public float ROCE { get; set; }
        public float CurrentAssetsTurnover { get; set; }
        public float InventoryTurnover { get; set; }
        public float ReceivablesTurnover { get; set; }
        public float TotalAssetsTurnover { get; set; }
        public float ProfitFromFinancialActivitiesOverProfitBeforeTax { get; set; }
        public float SalesGrowth_MRQ { get; set; }
        public float SalesGrowth_MRQ2 { get; set; }
        public float SalesGrowth_TTM { get; set; }
        public float SalesGrowth_LFY { get; set; }
        public float SalesGrowth_03Yr { get; set; }
        public float ProfitGrowth_MRQ { get; set; }
        public float ProfitGrowth_MRQ2 { get; set; }
        public float ProfitGrowth_TTM { get; set; }
        public float ProfitGrowth_LFY { get; set; }
        public float ProfitGrowth_03Yr { get; set; }
        public float BasicEPSGrowth_MRQ { get; set; }
        public float BasicEPSGrowth_MRQ2 { get; set; }
        public float BasicEPSGrowth_TTM { get; set; }
        public float BasicEPSGrowth_LFY { get; set; }
        public float BasicEPSGrowth_03Yr { get; set; }
        public float DilutedEPSGrowth_MRQ { get; set; }
        public float DilutedEPSGrowth_MRQ2 { get; set; }
        public float DilutedEPSGrowth_TTM { get; set; }
        public float DilutedEPSGrowth_LFY { get; set; }
        public float DilutedEPSGrowth_03Yr { get; set; }
        public float EquityGrowth_MRQ { get; set; }
        public float EquityGrowth_TTM { get; set; }
        public float EquityGrowth_03Yr { get; set; }
        public float TotalAssetsGrowth_MRQ { get; set; }
        public float TotalAssetsGrowth_MRQ2 { get; set; }
        public float TotalAssetsGrowth_TTM { get; set; }
        public float TotalAssetsGrowth_LFY { get; set; }
        public float TotalAssetsGrowth_03Yr { get; set; }
        public float CharterCapitalGrowth_MRQ { get; set; }
        public float CharterCapitalGrowth_TTM { get; set; }
        public float CharterCapitalGrowth_03Yr { get; set; }
        public float StockHolderEquityGrowth_MRQ { get; set; }
        public float StockHolderEquityGrowth_TTM { get; set; }
        public float StockHolderEquityGrowth_03Yr { get; set; }
        public float EBITMargin_03YrAvg { get; set; }
        public float GrossMargin_03YrAvg { get; set; }
        public float NetProfitMargin_03YrAvg { get; set; }
        public float OperatingMargin_03YrAvg { get; set; }
        public float PreTaxMargin_03YrAvg { get; set; }
        public float ROA_03YrAvg { get; set; }
        public float ROE_03YrAvg { get; set; }
        public float ROIC_03YrAvg { get; set; }
        public float DividendInCash_03YrAvg { get; set; }
        public float DividendInShares_03YrAvg { get; set; }
        public float FreeShares { get; set; }
        public float LastDividendInCash { get; set; }
        public string LastDividendInCashRecordDate { get; set; }
        public object NextDividendInCash { get; set; }
        public object NextDividendInCashRecordDate { get; set; }
        public float LastDividendInShares { get; set; }
        public string LastDividendInSharesRecordDate { get; set; }
        public object NextDividendInShares { get; set; }
        public object NextDividendInSharesRecordDate { get; set; }
        public object CashDividend { get; set; }
        public object StockDividend { get; set; }
        public object RetentionRatio { get; set; }
        public object DividendYield { get; set; }
        public object TotalStockReturn { get; set; }
        public object CapitalGainsYield { get; set; }
        public object PayoutRatio { get; set; }
        public object LastCashDividendYear { get; set; }
        public object LastStockDividendYear { get; set; }
        public object COF { get; set; }
        public object CostToAssets { get; set; }
        public object CostToIncome { get; set; }
        public object CostToLoans { get; set; }
        public object EquityToLoans { get; set; }
        public object LAR { get; set; }
        public object LDR { get; set; }
        public object LoanlossReservesToLoans { get; set; }
        public object LoanlossReservesToNPLs { get; set; }
        public object LoansToDeposit { get; set; }
        public object NIM { get; set; }
        public object NonInterestIncomeToNetInterestIncome { get; set; }
        public object NPLs { get; set; }
        public object NPLsToLoans { get; set; }
        public object PreprovisionROA { get; set; }
        public object ProvisionChargesToLoans { get; set; }
        public object YOEA { get; set; }
        public object PC { get; set; }
        public object PT { get; set; }
        public float Cash { get; set; }
        public float TotalCurrentAssets { get; set; }
        public float FixedAssets { get; set; }
        public float TotalAssets { get; set; }
        public float TotalShortTermLiabilities { get; set; }
        public float TotalLiabilities { get; set; }
        public float TotalLongTermLiabilities { get; set; }
        public float TotalInventories { get; set; }
        public float StockHolderEquity { get; set; }
        public float GrossProfit { get; set; }
        public float ProfitFromFinancialActivities { get; set; }
        public float OtherProfit { get; set; }
        public float NetSales { get; set; }
        public float ProfitAfterIncomeTaxes { get; set; }
        public float ProfitBeforeIncomeTaxes { get; set; }
    }

}
