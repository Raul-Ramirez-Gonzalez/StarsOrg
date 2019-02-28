Imports System.Data.SqlClient
Module modDB
    'connection string
    'database objects
    Public objSQLConn As SqlConnection
    Public objSQLCommand As SqlCommand
    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\Raul\Desktop\Visual Studio\STARSOrg\STARSDB.mdf;Integrated Security=True"
End Module
