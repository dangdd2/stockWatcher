/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Symbol]
,[ROE]
      ,[ROA]
      ,[ROIC]
      ,[EBIT]
      ,[EBITDA]
      ,[ROCE]
	  ,[GrossMargin] -- loi nhuan gop bien
	  ,[NetProfitMargin] --  hệ số biên lợi nhuận ròng
	  ,[OperatingMargin] -- he so lợi nhuận hoạt động
      ,[LFY]
      ,[Year]
      ,[Quarter]
      ,[Date]
      ,[BookValuePerShare] -- gia tri so sach
      ,[SalesPerShare]
      ,[SharesOutstanding]
      ,[MarketCapitalization] -- Von hoa
      ,[PE]
      ,[BasicPE]
      ,[DilutedPE]
      ,[PB]
      ,[PS]
      ,[EPS]
      ,[BasicEPS]
      ,[DilutedEPS]
     
      ,[EBITMargin]
      
      ,[QuickRatio]
      ,[CurrentRatio]
      ,[InterestCoverageRatio]
      ,[LongtermDebtOverEquity] -- Nợ dài hạn trên vốn chủ sở hữu
      ,[TotalDebtOverEquity] -- Tổng nợ trên vốn chủ sở hữu
      ,[TotalDebtOverAssets] -- Tổng nợ trên tài sản
      ,[PreTaxMargin] -- Hệ số biên lợi nhuận trước thuế
     
      
      ,[CurrentAssetsTurnover]
      ,[InventoryTurnover]
      ,[ReceivablesTurnover]
      ,[TotalAssetsTurnover]
      ,[ProfitFromFinancialActivitiesOverProfitBeforeTax]
      ,[SalesGrowth_MRQ]
      ,[SalesGrowth_MRQ2]
      ,[SalesGrowth_TTM]
      ,[SalesGrowth_LFY]
      ,[SalesGrowth_03Yr]
      ,[ProfitGrowth_MRQ]
      ,[ProfitGrowth_MRQ2]
      ,[ProfitGrowth_TTM]
      ,[ProfitGrowth_LFY]
      ,[ProfitGrowth_03Yr]
      ,[BasicEPSGrowth_MRQ]
      ,[BasicEPSGrowth_MRQ2]
      ,[BasicEPSGrowth_TTM]
      ,[BasicEPSGrowth_LFY]
      ,[BasicEPSGrowth_03Yr]
      ,[DilutedEPSGrowth_MRQ] -- ty suat tăn trưởng EPS pha loang 
      ,[DilutedEPSGrowth_MRQ2]
      ,[DilutedEPSGrowth_TTM]
      ,[DilutedEPSGrowth_LFY]
      ,[DilutedEPSGrowth_03Yr]
      ,[EquityGrowth_MRQ]
      ,[EquityGrowth_TTM]
      ,[EquityGrowth_03Yr]
      ,[TotalAssetsGrowth_MRQ]
      ,[TotalAssetsGrowth_MRQ2]
      ,[TotalAssetsGrowth_TTM]
      ,[TotalAssetsGrowth_LFY]
      ,[TotalAssetsGrowth_03Yr]
      ,[CharterCapitalGrowth_MRQ]
      ,[CharterCapitalGrowth_TTM]
      ,[CharterCapitalGrowth_03Yr]
      ,[StockHolderEquityGrowth_MRQ]
      ,[StockHolderEquityGrowth_TTM]
      ,[StockHolderEquityGrowth_03Yr]
      ,[EBITMargin_03YrAvg]
      ,[GrossMargin_03YrAvg]
      ,[NetProfitMargin_03YrAvg]
      ,[OperatingMargin_03YrAvg]
      ,[PreTaxMargin_03YrAvg]
      ,[ROA_03YrAvg]
      ,[ROE_03YrAvg]
      ,[ROIC_03YrAvg]
      ,[DividendInCash_03YrAvg]
      ,[DividendInShares_03YrAvg]
      ,[FreeShares]
      ,[LastDividendInCash]
      ,[LastDividendInCashRecordDate]
      ,[NextDividendInCash]
      ,[NextDividendInCashRecordDate]
      ,[LastDividendInShares]
      ,[LastDividendInSharesRecordDate]
      ,[NextDividendInShares]
      ,[NextDividendInSharesRecordDate]
      ,[CashDividend]
      ,[StockDividend]
      ,[RetentionRatio]
      ,[DividendYield]
      ,[TotalStockReturn]
      ,[CapitalGainsYield]
      ,[PayoutRatio]
      ,[LastCashDividendYear]
      ,[LastStockDividendYear]
      ,[COF]
      ,[CostToAssets]
      ,[CostToIncome]
      ,[CostToLoans]
      ,[EquityToLoans]
      ,[LAR]
      ,[LDR]
      ,[LoanlossReservesToLoans]
      ,[LoanlossReservesToNPLs]
      ,[LoansToDeposit]
      ,[NIM]
      ,[NonInterestIncomeToNetInterestIncome]
      ,[NPLs]
      ,[NPLsToLoans]
      ,[PreprovisionROA]
      ,[ProvisionChargesToLoans]
      ,[YOEA]
      ,[PC]
      ,[PT]
      ,[Cash] -- tien mat
      ,[TotalCurrentAssets]
      ,[FixedAssets] -- tai san co dinh
      ,[TotalAssets] -- tong tai san
      ,[TotalShortTermLiabilities] -- no ngan han
      ,[TotalLiabilities] -- tong no phai tra
      ,[TotalLongTermLiabilities] -- no dai han
      ,[TotalInventories] -- hang ton kho
      ,[StockHolderEquity] -- von chu so huu
      ,[GrossProfit] -- loi nhuan gop
      ,[ProfitFromFinancialActivities] -- Lợi nhuận từ hoạt động tài chính
      ,[OtherProfit] -- loi nhuann khac
      ,[NetSales] -- doanh thu thuan
      ,[ProfitAfterIncomeTaxes] -- loi nhuan truoc thue
      ,[ProfitBeforeIncomeTaxes] -- loi nhuan sau thue
      ,[IntacctLocationId]
  FROM [FireAnt].[dbo].[StockItem]
  ORDER BY NetProfitMargin DESC

 -- SELECT @@VERSION