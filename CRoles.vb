Imports System.Data.SqlClient
Public Class CRoles
    'represents the ROLE table and its associated businees rules
    Private _Role As CRole

    'constructor
    Public Sub New()
        'insatntiate the Crole object 
        'constructor
        _Role = New CRole
    End Sub
    Public ReadOnly Property CurrentObject() As CRole
        Get
            Return _Role
        End Get
    End Property

    Public Sub Clear()
        _Role = New CRole
    End Sub
    Public Sub CreateNewRole()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Role.IsNewRole = True
    End Sub
    Public Function Save() As Integer
        Return _Role.Save
    End Function

    Public Function GetAllRoles() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("dbo.sp_getAllRoles", Nothing)
        Return objDR
    End Function

    Public Function GetRoleByRoleID(strID As String) As CRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("roleID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getRoleByRoleID", params))
        Return _Role
    End Function
    Public Function FillObject(objDR As SqlDataReader) As CRole
        If objDR.Read Then
            With _Role
                .RoleID = objDR.Item("RoleID") 'how to get a column.in the stored procedure
                .RoleDescription = objDR.Item("RoleDescription")
            End With
        Else
            'did not get the matching role record
        End If

        objDR.Close()
        Return _Role
    End Function
End Class
