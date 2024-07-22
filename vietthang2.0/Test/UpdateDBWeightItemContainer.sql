if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WeightItemContainers]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[WeightItemContainers]
GO

CREATE TABLE [dbo].[WeightItemContainers] (
	[WeightContainerID] [uniqueidentifier] NOT NULL ,
	[StockCode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[ItemCode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[WeightCode] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[EmployeeID] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[TransactionID] [uniqueidentifier] NULL ,
	[WeightDate] [smalldatetime] NOT NULL ,
	[IsReceive] [bit] NOT NULL ,
	[Description] [nvarchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Quantity] [decimal](18, 0) NOT NULL ,
	[WrappingWeight] [decimal](18, 2) NOT NULL ,
	[WrappingType] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ItemWeight] [decimal](18, 2) NOT NULL ,
	[PTVanChuyen] [nvarchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[PTTrungChuyen] [nvarchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DVVanChuyen] [nvarchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TransactionTypeCode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[KhoGiaoNhan] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DVGiao] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[DVNhan] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Weight1] [decimal](18, 2) NULL ,
	[WeightTime1] [datetime] NULL ,
	[Weight2] [decimal](18, 2) NULL ,
	[WeightTime2] [datetime] NULL ,
	[StockLocationCode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[UserCreated] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DateCreated] [datetime] NOT NULL ,
	[UserUpdated] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[DateUpdated] [datetime] NOT NULL ,
	[ServerCreated] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO
//////////////////////////////////////////


BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.WeightItemContainers
	DROP CONSTRAINT FK_WeightItemContainers_StockTransactions
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.WeightItemContainers WITH NOCHECK ADD CONSTRAINT
	FK_WeightItemContainers_StockTransactions FOREIGN KEY
	(
	TransactionID
	) REFERENCES dbo.StockTransactions
	(
	TransactionID
	)
GO
ALTER TABLE dbo.WeightItemContainers
	NOCHECK CONSTRAINT FK_WeightItemContainers_StockTransactions
GO
COMMIT

////////////////////////////////////


BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT FK_STOCKTRA_REF_STOCKSIN
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT FK_STOCKTRA_REF_STOCKSOUT
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT FK_STOCKTRA_REFERENCE_TRANSTYP
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF_StockTransactions_DateCreated
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF_StockTransactions_DateUpdated
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF__StockTran__Shift__39E294A9
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF__StockTran__GetBy__3AD6B8E2
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF__StockTran__Statu__3BCADD1B
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF_StockTransactions_DepartmentStatus
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF__StockTran__Creat__3CBF0154
GO
ALTER TABLE dbo.StockTransactions
	DROP CONSTRAINT DF_StockTransactions_ServerCreated
GO
CREATE TABLE dbo.Tmp_StockTransactions
	(
	TransactionID uniqueidentifier NOT NULL,
	TransactionTypeCode varchar(10) NULL,
	InStock varchar(10) NULL,
	OutStock varchar(10) NULL,
	TransactionNo varchar(20) NULL,
	TransactionDate smalldatetime NULL,
	Description nvarchar(200) NULL,
	UserCreated varchar(20) NULL,
	DateCreated datetime NULL,
	UserUpdated varchar(20) NULL,
	DateUpdated datetime NULL,
	Shift tinyint NULL,
	GetByWeightItems bit NULL,
	GetByWeightItemContainer bit NULL,
	ForDepartment tinyint NULL,
	Status tinyint NULL,
	DepartmentStatus tinyint NULL,
	CreatedType tinyint NULL,
	GenType tinyint NULL,
	GenID uniqueidentifier NULL,
	KhoGiaoNhan varchar(10) NULL,
	DVGiao varchar(10) NULL,
	SoHD varchar(20) NULL,
	DVNhan varchar(10) NULL,
	SoDH varchar(20) NULL,
	DonviVC varchar(10) NULL,
	PTVC nvarchar(100) NULL,
	CTKemtheo nvarchar(100) NULL,
	SoHoaDon varchar(20) NULL,
	Nguoigiaonhan nvarchar(50) NULL,
	ServerCreated varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF_StockTransactions_DateCreated DEFAULT (getdate()) FOR DateCreated
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF_StockTransactions_DateUpdated DEFAULT (getdate()) FOR DateUpdated
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF__StockTran__Shift__39E294A9 DEFAULT (1) FOR Shift
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF__StockTran__GetBy__3AD6B8E2 DEFAULT (0) FOR GetByWeightItems
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF__StockTran__Statu__3BCADD1B DEFAULT (0) FOR Status
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF_StockTransactions_DepartmentStatus DEFAULT (1) FOR DepartmentStatus
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF__StockTran__Creat__3CBF0154 DEFAULT (0) FOR CreatedType
GO
ALTER TABLE dbo.Tmp_StockTransactions ADD CONSTRAINT
	DF_StockTransactions_ServerCreated DEFAULT ('SADEC') FOR ServerCreated
GO
IF EXISTS(SELECT * FROM dbo.StockTransactions)
	 EXEC('INSERT INTO dbo.Tmp_StockTransactions (TransactionID, TransactionTypeCode, InStock, OutStock, TransactionNo, TransactionDate, Description, UserCreated, DateCreated, UserUpdated, DateUpdated, Shift, GetByWeightItems, ForDepartment, Status, DepartmentStatus, CreatedType, GenType, GenID, KhoGiaoNhan, DVGiao, SoHD, DVNhan, SoDH, DonviVC, PTVC, CTKemtheo, SoHoaDon, Nguoigiaonhan, ServerCreated)
		SELECT TransactionID, TransactionTypeCode, InStock, OutStock, TransactionNo, TransactionDate, Description, UserCreated, DateCreated, UserUpdated, DateUpdated, Shift, GetByWeightItems, ForDepartment, Status, DepartmentStatus, CreatedType, GenType, GenID, KhoGiaoNhan, DVGiao, SoHD, DVNhan, SoDH, DonviVC, PTVC, CTKemtheo, SoHoaDon, Nguoigiaonhan, ServerCreated FROM dbo.StockTransactions TABLOCKX')
GO
ALTER TABLE dbo.AccountStocks
	DROP CONSTRAINT FK_AccountStocks_StockTransactions
GO
ALTER TABLE dbo.WeightItems
	DROP CONSTRAINT FK_WEIGHTIT_FK_WEIGHT_STOCKTRA
GO
ALTER TABLE dbo.StockTransactionDetails
	DROP CONSTRAINT FK_STTRADET_REFERENCE_STOCKTRA
GO
ALTER TABLE dbo.StockTransactionSumDetails
	DROP CONSTRAINT FK_STOCKTRA_REFERENCE_STOCKTRA
GO
DROP TABLE dbo.StockTransactions
GO
EXECUTE sp_rename N'dbo.Tmp_StockTransactions', N'StockTransactions', 'OBJECT'
GO
ALTER TABLE dbo.StockTransactions ADD CONSTRAINT
	PK_STOCKTRANSACTIONS PRIMARY KEY CLUSTERED 
	(
	TransactionID
	) ON [PRIMARY]

GO
ALTER TABLE dbo.StockTransactions WITH NOCHECK ADD CONSTRAINT
	FK_STOCKTRA_REFERENCE_TRANSTYP FOREIGN KEY
	(
	TransactionTypeCode
	) REFERENCES dbo.TransactionTypes
	(
	TransactionTypeCode
	) ON UPDATE CASCADE
	
GO
ALTER TABLE dbo.StockTransactions WITH NOCHECK ADD CONSTRAINT
	FK_STOCKTRA_REF_STOCKSIN FOREIGN KEY
	(
	InStock
	) REFERENCES dbo.Stocks
	(
	StockCode
	)
GO
ALTER TABLE dbo.StockTransactions WITH NOCHECK ADD CONSTRAINT
	FK_STOCKTRA_REF_STOCKSOUT FOREIGN KEY
	(
	OutStock
	) REFERENCES dbo.Stocks
	(
	StockCode
	)
GO
CREATE TRIGGER trg_StockTransactions_Deleted ON dbo.StockTransactions 
After DELETE 
AS
insert into DeletedRows (TableName, GuidKey)
select 'StockTransactions',TransactionID from deleted where ServerCreated=dbo.fn_ServerCreated()
GO
CREATE TRIGGER trg_StockTransactions_CheckClosed ON dbo.StockTransactions 
FOR INSERT, UPDATE, DELETE
AS
if exists (select * from PeriodCloseds where ModuleCode='Stock') begin
	declare @LimitDate datetime
	select @LimitDate=EndDate from Periods 
	where PeriodCode=(select top 1 PeriodCode from PeriodCloseds where ModuleCode='Stock' order by PeriodCode desc)

	if exists(select TransactionDate from inserted where TransactionDate<=@LimitDate) begin
		RAISERROR('Kho da khoa so',16,1) WITH SETERROR 
		return
	end
	if exists(select TransactionDate from deleted where TransactionDate<=@LimitDate) begin
		raiserror('Kho da khoa so',16,1) with SETERROR
		return
	end
end
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.StockTransactionSumDetails WITH NOCHECK ADD CONSTRAINT
	FK_STOCKTRA_REFERENCE_STOCKTRA FOREIGN KEY
	(
	TransactionID
	) REFERENCES dbo.StockTransactions
	(
	TransactionID
	) ON DELETE CASCADE
	
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.StockTransactionDetails WITH NOCHECK ADD CONSTRAINT
	FK_STTRADET_REFERENCE_STOCKTRA FOREIGN KEY
	(
	TransactionID
	) REFERENCES dbo.StockTransactions
	(
	TransactionID
	) ON DELETE CASCADE
	
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.WeightItems WITH NOCHECK ADD CONSTRAINT
	FK_WEIGHTIT_FK_WEIGHT_STOCKTRA FOREIGN KEY
	(
	TransactionID
	) REFERENCES dbo.StockTransactions
	(
	TransactionID
	)
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.AccountStocks WITH NOCHECK ADD CONSTRAINT
	FK_AccountStocks_StockTransactions FOREIGN KEY
	(
	StockTransactionID
	) REFERENCES dbo.StockTransactions
	(
	TransactionID
	)
GO
COMMIT
///////////////////////////////////////////////////////////////////////////




BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.WeightItemContainers WITH NOCHECK ADD CONSTRAINT
	FK_WeightItemContainers_Stocks FOREIGN KEY
	(
	StockCode
	) REFERENCES dbo.Stocks
	(
	StockCode
	) ON UPDATE CASCADE
	
GO
ALTER TABLE dbo.WeightItemContainers WITH NOCHECK ADD CONSTRAINT
	FK_WeightItemContainers_Items FOREIGN KEY
	(
	ItemCode
	) REFERENCES dbo.Items
	(
	ItemCode
	) ON UPDATE CASCADE
	
GO
ALTER TABLE dbo.WeightItemContainers WITH NOCHECK ADD CONSTRAINT
	FK_WeightItemContainers_Employees FOREIGN KEY
	(
	EmployeeID
	) REFERENCES dbo.Employees
	(
	EmployeeID
	)
GO
ALTER TABLE dbo.WeightItemContainers WITH NOCHECK ADD CONSTRAINT
	FK_WeightItemContainers_TransactionTypes FOREIGN KEY
	(
	TransactionTypeCode
	) REFERENCES dbo.TransactionTypes
	(
	TransactionTypeCode
	) ON UPDATE CASCADE
	
GO
COMMIT
