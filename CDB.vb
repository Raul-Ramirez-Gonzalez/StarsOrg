Imports System.Data.SqlClient
Public Class CDB

    Public Function OpenDB() As Boolean
        objSQLCommand = New SqlCommand 'instantiate the command object
        Dim blnResult As Boolean
        If objSQLConn Is Nothing Then 'we need to instatntiate the connection object
            Try
                objSQLConn = New SqlConnection(gstrConn)
                objSQLConn.Open()
                blnResult = True
            Catch exOpenConnError As Exception
                MessageBox.Show("cannot open database: " & exOpenConnError.ToString, "connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False
                'you shuould log this error
            End Try
        Else
            If objSQLConn.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        End If
        Return blnResult
    End Function
    Public Sub CloseDB()
        Try
            objSQLConn.Close()
        Catch ex As Exception
            MessageBox.Show("cannot close database: " & ex.ToString, "closing error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Public Function GetDataAdapterBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        objSQLCommand = New SqlCommand(strSP, objSQLConn)
        Dim sqlDA As SqlDataAdapter
        objSQLCommand.CommandType = CommandType.StoredProcedure 'return data
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            sqlDA = New SqlDataAdapter(objSQLCommand)
            Return sqlDA   'Retrun this data
        Catch ex As Exception
            MessageBox.Show("error getting data adapter: " & ex.ToString, "database error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return Nothing
    End Function
    Public Function GetDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        If Not OpenDB() Then
            'error log this
            Return Nothing
        End If
        objSQLCommand = New SqlCommand(strSP, objSQLConn)
        objSQLCommand.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            Return objSQLCommand.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("error getting data reader: " & ex.ToString, "database error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return Nothing
    End Function
    Public Function ExecSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If
        objSQLCommand = New SqlCommand(strSP, objSQLConn)
        objSQLCommand.CommandType = CommandType.StoredProcedure 'we added this
        Try
            If Not params Is Nothing Then
                For Each p As SqlParameter In params
                    objSQLCommand.Parameters.Add(p)
                Next
            End If
            Return objSQLCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("error executing sp: " & ex.ToString, "database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    Public Function GetSingleValueFromSP(ByVal strSP As String, ByRef params As ArrayList) As String
        Dim sqlDR As SqlDataReader = GetDataReaderBySP(strSP, params)
        Dim strResult As String
        If Not sqlDR Is Nothing Then 'we got the data reader
            If sqlDR.Read Then 'we have some data
                strResult = sqlDR.GetValue(0).ToString
                sqlDR.Close()
                Return strResult
            Else
                Return "-1"
            End If
        End If
        Return "-2" 'failed to connect or even get a data reader
    End Function
End Class
