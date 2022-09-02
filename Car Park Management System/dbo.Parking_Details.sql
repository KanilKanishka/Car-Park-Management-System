CREATE TABLE [dbo].[Parking_Details] (
    [Vehicle_Number] VARCHAR (50) NOT NULL,
    [Vehicle_Type]   VARCHAR (50) NOT NULL,
    [Time_IN]        DATETIME     NOT NULL,
    [Time_OUT]       DATETIME    NULL,
    [Status]         CHAR (10)    NULL,
    CONSTRAINT [PK_Parking_Details] PRIMARY KEY CLUSTERED ([Vehicle_Number] ASC)
);

