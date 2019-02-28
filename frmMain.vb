Public Class frmMain
    Private RoleInfo As frmRole
    Private CourseInfo As frmCourse
    Private SemesterInfo As frmSemester


    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvents.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRoles.MouseEnter, tsbRsvp.MouseEnter, tsbTutor.MouseEnter, tsbSemester.MouseEnter
        'we need to do this because we put the right Grahic image in the backgroundimgae property isntead of image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvents.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRoles.MouseLeave, tsbRsvp.MouseLeave, tsbTutor.MouseLeave, tsbSemester.MouseLeave
        'we need to do this because we put the right prahic image in the backgroundimgae property isntead of imae property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub PerfomNextAction()
        'get hte next action selected n the cgild form and then click of the toolstrip button
        Select Case intNextAction
            Case ACTION_COURSE
                tsbCourse.PerformClick()
            Case ACTION_EVENT
                tsbEvents.PerformClick()
            Case ACTION_HELP
                tsbHelp.PerformClick()
            Case ACTION_HOME
                tsbHome.PerformClick()
            Case ACTION_LOGOUT
                tsbLogOut.PerformClick()
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_ROLE
                tsbRoles.PerformClick()
            Case ACTION_RSVP
                tsbRsvp.PerformClick()
            Case ACTION_SEMESTER
                tsbSemester.PerformClick()
            Case ACTION_TUTOR
                tsbTutor.PerformClick()
            Case Else
                'DO NOTHING
        End Select
    End Sub

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs) Handles tsbRoles.Click
        Me.Hide()
        RoleInfo.ShowDialog() 'cant do anyhting til they close it
        Me.Show()
        PerfomNextAction()
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        Me.Hide()
        CourseInfo.ShowDialog() 'cant do anything til they close
        Me.Show()
        PerfomNextAction()
        'tsbCourse.PerformClick()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        Me.Hide()
        SemesterInfo.ShowDialog() 'cant do anything til they close
        Me.Show()
        PerfomNextAction()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'instantiate everything here 
        'insratiate a form object for each form in the application
        myDB = New CDB
        RoleInfo = New frmRole
        CourseInfo = New frmCourse
        SemesterInfo = New frmSemester
        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("Unable to open database. Connection String" & gstrConn, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndProgram()
        End Try

    End Sub
    Private Sub EndProgram()
        'close each form except main
        Dim f As Form
        Me.Cursor = Cursors.WaitCursor
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
        'close database connection
        If Not objSQLConn Is Nothing Then
            objSQLConn.Close()
            objSQLConn.Dispose()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        EndProgram()
        Application.Exit()
    End Sub


End Class
