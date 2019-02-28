Imports System.Data.SqlClient
Public Class CSemester
    'represents a single recrod in the ROLE table
    Private _mstrSemesterID As String 'role id
    Private _mstrSemesterDescription As String 'sem descrption
    Private _isNewSemester As Boolean 'newSem
    'constructor
    Public Sub New()
        _mstrSemesterID = ""
        _mstrSemesterDescription = ""
    End Sub
#Region "Exposed Prperties"
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property SemesterDescription As String
        Get
            Return _mstrSemesterDescription
        End Get
        Set(strVal As String)
            _mstrSemesterDescription = strVal
        End Set
    End Property

    Public Property IsNewSemester As Boolean
        Get
            Return _isNewSemester
        End Get
        Set(bnlVal As Boolean)
            _isNewSemester = bnlVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this propertys code will create the params for the stored procedure to savea record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            params.Add(New SqlParameter("semesterDescription", _mstrSemesterDescription)) 'in the sp_save
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'returns -1 if the ID already exist and we cannot create a new record,maked dupliated
        If IsNewSemester Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckSemesterIDExists", params) 'sp_CheckifID exits
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new role, or it is new and has unique ID, the do the save(upadte or insert)
        Return myDB.ExecSP("sp_saveSemester", GetSaveParameters()) 'make a sp_saveSem
    End Function
    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("dbo.sp_getALLSemesters", Nothing) ' to use in the report viewer
    End Function
End Class
