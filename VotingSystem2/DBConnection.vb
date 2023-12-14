Imports System.Data.OleDb

Module DBConnection
    Public Function strconnection() As OleDbConnection
        Return New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")
    End Function
    Public strcon As OleDbConnection = strconnection()
End Module
