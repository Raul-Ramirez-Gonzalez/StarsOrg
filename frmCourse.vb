Imports System.Data.SqlClient
Public Class frmCourse
    Private objCourses As CCourses
    Private blnClearing As Boolean
    Private blnReloading As Boolean

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvents.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRoles.MouseEnter, tsbRsvp.MouseEnter, tsbTutor.MouseEnter, tsbSemester.MouseEnter
        'we need to do this because we put the right prahic image in the backgroundimgae property isntead of imae property
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
#Region "Click Events"
    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()

    End Sub

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs) Handles tsbRoles.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub
    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        'nothing to do here
    End Sub

    Private Sub tsbEvents_Click(sender As Object, e As EventArgs) Handles tsbEvents.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub


    Private Sub tsbRsvp_Click(sender As Object, e As EventArgs) Handles tsbRsvp.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub


#End Region

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles Me.Load
        objCourses = New CCourses
    End Sub
    Private Sub LoadCourses()
        Dim objReader As SqlDataReader
        lstCourses.Items.Clear()
        Try
            objReader = objCourses.GetAllCourses 'finish get all courses
            Do While objReader.Read
                lstCourses.Items.Add(objReader.Item("CourseID")) 'change role id
            Loop
            objReader.Close()
        Catch ex As Exception
            'could have cdb throw the error and trap it
        End Try
        blnReloading = False
    End Sub

    Private Sub frmCourse_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'when its the active form
        ClearScreenControls(Me)
        LoadCourses()
        grpEditC.Enabled = False
    End Sub

    Private Sub lstCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourses.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstCourses.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEditC.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objCourses.GetCourseByCourseID(lstCourses.SelectedItem.ToString)
            With objCourses.CurrentObject
                txtCourse.Text = .CourseID
                txtName.Text = .CourseName
            End With
        Catch ex As Exception
            MessageBox.Show("Error laoding selected record" & ex.ToString, "program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub

        End If
        If chkNew.Checked Then
            txtCourse.Clear()
            txtName.Clear()
            lstCourses.SelectedIndex = -1
            grpCourses.Enabled = False
            grpEditC.Enabled = True
            objCourses.CreateNewRole()
            txtCourse.Focus()

        Else
            grpCourses.Enabled = True
            grpEditC.Enabled = False
            objCourses.CurrentObject.IsNewCourse = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'first do validation
        If Not ValidateTextBoxLenght(txtCourse, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objCourses.CurrentObject
            .CourseID = txtCourse.Text
            .CourseName = txtName.Text

        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objCourses.Save
            If intResult = -1 Then 'id not unique
                MessageBox.Show("RoleID must be unique, unable to save record", "database error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("unable to save role record" & ex.ToString, "Databse error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        'new role is created ON 136
        blnReloading = True
        LoadCourses()
        chkNew.Checked = False
        grpCourses.Enabled = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        chkNew.Checked = False
        errP.Clear()
        If lstCourses.SelectedIndex <> -1 Then
            LoadSelectedRecord() 'releoad what was selected in case user had messed up
        Else 'disable the dit area -nothing was currenltyt selected
            grpEditC.Enabled = False
        End If
        blnClearing = False
        objCourses.CurrentObject.IsNewCourse = False
        grpCourses.Enabled = True

    End Sub
End Class