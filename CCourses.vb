Imports System.Data.SqlClient
Public Class CCourses
    'represents the ROLE table and its associated businees rules
    Private _Course As CCourse

    'constructor
    Public Sub New()
        'insatntiate the Crole object 
        'constructor
        _Course = New CCourse
    End Sub
    Public ReadOnly Property CurrentObject() As CCourse
        Get
            Return _Course
        End Get
    End Property

    Public Sub Clear()
        _Course = New CCourse
    End Sub
    Public Sub CreateNewRole()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Course.IsNewCourse = True
    End Sub
    Public Function Save() As Integer
        Return _Course.Save
    End Function
    Public Function GetAllCourses() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("dbo.sp_getAllCourses", Nothing) 'made get all course names
        Return objDR
    End Function

    Public Function GetCourseByCourseID(strID As String) As CCourse
        Dim params As New ArrayList
        params.Add(New SqlParameter("courseID", strID)) 'MAde?
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getCourseByCourseID", params)) 'ADDed courseby id
        Return _Course
    End Function
    Public Function FillObject(objDR As SqlDataReader) As CCourse
        If objDR.Read Then
            With _Course
                .CourseID = objDR.Item("CourseID") 'IN THE COURSE TABLE
                .CourseName = objDR.Item("CourseName") 'IN THE COURSE TABLE
            End With
        Else
            'did not get the matching course record
        End If

        objDR.Close()
        Return _Course
    End Function
End Class
