CREATE TABLE [dbo].[tbl_Stores] (
    [storeId]      INT           NOT NULL,
    [storeName]    VARCHAR (50)  NOT NULL,
    [storeAddress] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_tbl_Stores] PRIMARY KEY CLUSTERED ([storeId] ASC)
);

