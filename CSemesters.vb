Imports System.Data.SqlClient
Public Class CSemesters
    'represents the ROLE table and its associated businees rules
    Private _Semester As CSemester

    'constructor
    Public Sub New()
        'insatntiate the Crole object 
        'constructor
        _Semester = New CSemester
    End Sub
    Public ReadOnly Property CurrentObject() As CSemester
        Get
            Return _Semester
        End Get
    End Property

    Public Sub Clear()
        _Semester = New CSemester
    End Sub
    Public Sub CreateNewRole()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Semester.IsNewSemester = True
    End Sub
    Public Function Save() As Integer
        Return _Semester.Save
    End Function
    Public Function GetAllCourses() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("dbo.sp_getAllSemesters", Nothing) 'made get all sem names
        Return objDR
    End Function

    Public Function GetSemesterBySemesterID(strID As String) As CSemester
        Dim params As New ArrayList
        params.Add(New SqlParameter("semesterID", strID)) 'MAde?
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getSemesterBySemesterID", params)) 'ADD semby id
        Return _Semester
    End Function
    Public Function FillObject(objDR As SqlDataReader) As CSemester
        If objDR.Read Then
            With _Semester
                .SemesterID = objDR.Item("SemesterID") 'IN THE sem TABLE
                .SemesterDescription = objDR.Item("SemesterDescription") 'IN THE sem TABLE
            End With
        Else
            'did not get the matching course record
        End If

        objDR.Close()
        Return _Semester
    End Function
End Class
