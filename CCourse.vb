Imports System.Data.SqlClient
Public Class CCourse
    'represents a single recrod in the ROLE table
    Private _mstrCourseID As String 'role id
    Private _mstrCourseName As String 'role descrption
    Private _isNewCourse As Boolean 'newrole
    'constructor
    Public Sub New()
        _mstrCourseID = ""
        _mstrCourseName = ""
    End Sub
#Region "Exposed Prperties"
    Public Property CourseID As String
        Get
            Return _mstrCourseID
        End Get
        Set(strVal As String)
            _mstrCourseID = strVal
        End Set
    End Property
    Public Property CourseName As String
        Get
            Return _mstrCourseName
        End Get
        Set(strVal As String)
            _mstrCourseName = strVal
        End Set
    End Property

    Public Property IsNewCourse As Boolean
        Get
            Return _isNewCourse
        End Get
        Set(bnlVal As Boolean)
            _isNewCourse = bnlVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this propertys code will create the params for the stored procedure to savea record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("courseID", _mstrCourseID))
            params.Add(New SqlParameter("courseName", _mstrCourseName)) 'in the sp_saveCourse
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'returns -1 if the ID already exist and we cannot create a new record,maked dupliated
        If IsNewCourse Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("courseID", _mstrCourseID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckCourseIDExists", params) 'sp_CheckifcourseID exits
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new role, or it is new and has unique ID, the do the save(upadte or insert)
        Return myDB.ExecSP("sp_saveCourse", GetSaveParameters()) 'make a sp_saveCourse
    End Function
End Class

