# wwave_webapp

WonderWave Min-T Control Station 4.0 is a web-based application for management of goods and sales for businesses. It supports multiple accounts, usernames, display names and different contact methods, as well as a few customization options, and uses a graphical, mouse-operated interface.

Required is a Microsoft SQL server to store data. When you download the source code, run the project inside Visual Studio and edit the "appsettings.json" file to set up the connection string for your MS SQL server. You must also create a new database titled "wwave_data", then run the following SQL query to create a new table where the users’ information and preferences will be stored:

``CREATE TABLE [dbo].[users] (
    [uname]        VARCHAR (60)  NULL,
    [dname]        VARCHAR (60)  NULL,
    [pword]        VARCHAR (60)  NULL,
    [email]        VARCHAR (MAX) NULL,
    [phnumber]     VARCHAR (MAX) NULL,
    [location]     VARCHAR (MAX) NULL,
    [contact]      VARCHAR (MAX) NULL,
    [hired]        DATE          NULL,
    [set_bgurl]    VARCHAR (MAX) NULL,
    [s_scroll]     INT           NULL,
    [s_displaynum] INT           NULL,
    [i_scroll]     INT           NULL,
    [i_displaynum] INT           NULL,
    [rowmaxindex]  INT           NULL
);``

With everything now set up, you can run the program to create your account.
