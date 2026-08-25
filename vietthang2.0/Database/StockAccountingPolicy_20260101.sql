/*
    Inventory accounting policy effective from 01/01/2026

    Old period: material 6111, product 632x, WIP 6311
    New period: material 152,  product 155,  WIP 154

    This deployment script changes procedure definitions only. It does not
    migrate, recalculate or update historical accounting data.

    The script is intentionally based on exact text patches. If a production
    procedure differs from the reviewed 25/08/2026 definitions, deployment is
    stopped and rolled back for manual review.
*/

SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    CREATE TABLE #ProcedurePatch
    (
        ObjectName sysname NOT NULL,
        FindText nvarchar(max) NOT NULL,
        ReplaceText nvarchar(max) NOT NULL
    );

    /* Inventory/reconciliation procedures receive a date directly. */
    INSERT #ProcedurePatch VALUES
    (N'usp_AccountStockOpening_InventoryMaterial',
     N'set @MaterialAccount = ''6111''',
     N'set @MaterialAccount = case when @EndDate >= ''20260101'' then ''152'' else ''6111'' end'),
    (N'usp_AccountStockOpening_InventoryProduct',
     N'set @ProductAccount = ''632''',
     N'set @ProductAccount = case when @EndDate >= ''20260101'' then ''155'' else ''632'' end');

    /* Cost selection for stock-out transactions. Reports never combine eras. */
    INSERT #ProcedurePatch VALUES
    (N'usp_AccountTransactionDetails_Select_Sum_CostAmount_X21',
     N'set @ProductAccount=''63211''',
     N'set @ProductAccount=case when @StartDate >= ''20260101'' then ''155'' else ''63211'' end'),
    (N'usp_AccountTransactionDetails_Select_Sum_CostAmount_X21',
     N'set @ProductAccount=''63212''',
     N'set @ProductAccount=case when @StartDate >= ''20260101'' then ''155'' else ''63212'' end'),
    (N'usp_AccountTransactionDetails_Select_Sum_CostAmount_X21',
     N'set @ProductAccount=''63213''',
     N'set @ProductAccount=case when @StartDate >= ''20260101'' then ''155'' else ''63213'' end'),
    (N'usp_AccountTransactionDetails_Select_Sum_CostAmount_X21',
     N'set @ProductAccount=''611''',
     N'set @ProductAccount=case when @StartDate >= ''20260101'' then ''152'' else ''611'' end');

    /* Existing report parameters remain unchanged; only branch recognition is extended. */
    INSERT #ProcedurePatch VALUES
    (N'usp_AccountTransactionStocks_ReportAmount',
     N'if(len(@PrefixAccountCode) >= 4 and left(@PrefixAccountCode,4) = ''6111'')',
     N'if(left(@PrefixAccountCode,4) = ''6111'' or left(@PrefixAccountCode,3) = ''152'')'),
    (N'usp_AccountTransactionStocks_ReportAmount',
     N'if(len(@PrefixAccountCode) >= 3 and left(@PrefixAccountCode,3) = ''632'')',
     N'if(left(@PrefixAccountCode,3) = ''632'' or left(@PrefixAccountCode,3) = ''155'')'),
    (N'usp_AccountTransactionStocks_ReportQuantity',
     N'if(len(@PrefixAccountCode) >= 4 and left(@PrefixAccountCode,4) = ''6111'')',
     N'if(left(@PrefixAccountCode,4) = ''6111'' or left(@PrefixAccountCode,3) = ''152'')'),
    (N'usp_AccountTransactionStocks_ReportQuantity',
     N'if(len(@PrefixAccountCode) >= 3 and left(@PrefixAccountCode,3) = ''632'')',
     N'if(left(@PrefixAccountCode,3) = ''632'' or left(@PrefixAccountCode,3) = ''155'')'),
    (N'usp_AccountTransactionStocks_ReportDetailQuantity',
     N'where left(AccountCode,3)=''632'' and TKDU=''''',
     N'where (left(AccountCode,3)=''632'' or left(AccountCode,3)=''155'') and TKDU=''''') ,
    (N'usp_AccountTransactionStocks_ReportDetailQuantity',
     N'if left(@PrefixAccountCode,3)=''632''',
     N'if left(@PrefixAccountCode,3) in (''632'',''155'')');

    /* Procedures that update prices derive their account from the selected period. */
    INSERT #ProcedurePatch VALUES
    (N'usp_AccountTransactionStocks_Update_OutStock_CostPrice',
     N'set @MaterialAccount = ''6111''',
     N'set @MaterialAccount = case when @StartDate >= ''20260101'' then ''152'' else ''6111'' end'),
    (N'usp_AccountTransactionStocks_Update_OutStock_CostPrice_Product',
     N'set @ProductAccount = ''6321''',
     N'set @ProductAccount = case when @StartDate >= ''20260101'' then ''155'' else ''6321'' end'),
    (N'usp_CalculateMaterialOutStockPrice',
     N'	select @StartDate=StartDate, @EndDate=EndDate from Periods where PeriodCode=@PeriodCode',
     N'	select @StartDate=StartDate, @EndDate=EndDate from Periods where PeriodCode=@PeriodCode
	set @MaterialAccount = case when @StartDate >= ''20260101'' then ''152'' else ''6111'' end'),
    (N'usp_CalculateProductOutStockPrice',
     N'	select @StartDate=StartDate, @EndDate=EndDate from Periods where PeriodCode=@PeriodCode',
     N'	select @StartDate=StartDate, @EndDate=EndDate from Periods where PeriodCode=@PeriodCode
	set @ProductAccount = case when @StartDate >= ''20260101'' then ''155'' else ''632'' end'),
    (N'usp_ProductCostFormulas_Update_CostPrice',
     N'set @MaterialAccount = ''6111''',
     N'set @MaterialAccount = case when exists(select 1 from Periods where PeriodCode=@PeriodCode and StartDate >= ''20260101'') then ''152'' else ''6111'' end');

    /* Production-cost report: 6311/632 before 2026, 154/155 from 2026. */
    INSERT #ProcedurePatch VALUES
    (N'usp_GiathanhNew',
     N'and d.DebitAccountCode=''6311'' and left(d.CreditAccountCode,3)<>''632''',
     N'and d.DebitAccountCode=case when @FromDate >= ''20260101'' then ''154'' else ''6311'' end
and left(d.CreditAccountCode,3)<>case when @FromDate >= ''20260101'' then ''155'' else ''632'' end');

    DECLARE @ObjectName sysname;
    DECLARE @Definition nvarchar(max);
    DECLARE @FindText nvarchar(max);
    DECLARE @ReplaceText nvarchar(max);
    DECLARE @AnsiNulls bit;
    DECLARE @QuotedIdentifier bit;

    DECLARE ProcedureCursor CURSOR LOCAL FAST_FORWARD FOR
        SELECT DISTINCT ObjectName FROM #ProcedurePatch ORDER BY ObjectName;

    OPEN ProcedureCursor;
    FETCH NEXT FROM ProcedureCursor INTO @ObjectName;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @Definition = OBJECT_DEFINITION(OBJECT_ID(N'dbo.' + @ObjectName)),
               @AnsiNulls = CONVERT(bit, OBJECTPROPERTYEX(OBJECT_ID(N'dbo.' + @ObjectName), 'ExecIsAnsiNullsOn')),
               @QuotedIdentifier = CONVERT(bit, OBJECTPROPERTYEX(OBJECT_ID(N'dbo.' + @ObjectName), 'ExecIsQuotedIdentOn'));

        IF @Definition IS NULL
            RAISERROR(N'Không tìm thấy Stored Procedure dbo.%s.', 16, 1, @ObjectName);

        DECLARE PatchCursor CURSOR LOCAL FAST_FORWARD FOR
            SELECT FindText, ReplaceText FROM #ProcedurePatch WHERE ObjectName = @ObjectName;

        OPEN PatchCursor;
        FETCH NEXT FROM PatchCursor INTO @FindText, @ReplaceText;
        WHILE @@FETCH_STATUS = 0
        BEGIN
            IF CHARINDEX(@FindText, @Definition) = 0
                RAISERROR(N'dbo.%s khác với phiên bản đã kiểm tra; dừng để tránh sửa sai.', 16, 1, @ObjectName);
            SET @Definition = REPLACE(@Definition, @FindText, @ReplaceText);
            FETCH NEXT FROM PatchCursor INTO @FindText, @ReplaceText;
        END
        CLOSE PatchCursor;
        DEALLOCATE PatchCursor;

        SET @Definition = REPLACE(@Definition, N'CREATE PROCEDURE', N'ALTER PROCEDURE');
        SET @Definition = REPLACE(@Definition, N'CREATE procedure', N'ALTER procedure');
        SET @Definition = REPLACE(@Definition, N'CREATE PROC', N'ALTER PROC');
        SET @Definition = REPLACE(@Definition, N'CREATE proc', N'ALTER proc');
        SET @Definition = REPLACE(@Definition, N'create procedure', N'alter procedure');
        SET @Definition = REPLACE(@Definition, N'create proc', N'alter proc');

        IF @AnsiNulls = 1 SET ANSI_NULLS ON ELSE SET ANSI_NULLS OFF;
        IF @QuotedIdentifier = 1 SET QUOTED_IDENTIFIER ON ELSE SET QUOTED_IDENTIFIER OFF;
        EXEC sys.sp_executesql @Definition;

        FETCH NEXT FROM ProcedureCursor INTO @ObjectName;
    END
    CLOSE ProcedureCursor;
    DEALLOCATE ProcedureCursor;

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF CURSOR_STATUS('local', 'PatchCursor') >= 0 CLOSE PatchCursor;
    IF CURSOR_STATUS('local', 'PatchCursor') >= -1 DEALLOCATE PatchCursor;
    IF CURSOR_STATUS('local', 'ProcedureCursor') >= 0 CLOSE ProcedureCursor;
    IF CURSOR_STATUS('local', 'ProcedureCursor') >= -1 DEALLOCATE ProcedureCursor;
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
    RAISERROR(@ErrorMessage, 16, 1);
END CATCH;

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO
