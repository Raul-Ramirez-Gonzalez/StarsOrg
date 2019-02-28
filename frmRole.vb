Imports System.Data.SqlClient
Public Class frmRole
    Private objRoles As CRoles
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
#Region "Click events"
    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()

    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
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

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs) Handles tsbRoles.Click
        'nothing to do here
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

#Region "TextBoxes"
    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtDesc.GotFocus, txtRole.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub
    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtRole.LostFocus, txtDesc.LostFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll()
    End Sub

#End Region

    Private Sub frmRole_Load(sender As Object, e As EventArgs) Handles Me.Load
        objRoles = New CRoles
    End Sub
    Private Sub LoadRoles()
        Dim objReader As SqlDataReader
        lstRoles.Items.Clear()
        Try
            objReader = objRoles.GetAllRoles
            Do While objReader.Read
                lstRoles.Items.Add(objReader.Item("RoleID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            'could have cdb throw the error and trap it
        End Try
        blnReloading = False
    End Sub

    Private Sub frmRole_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'when its the active form
        ClearScreenControls(Me)
        LoadRoles()
        grpEdit.Enabled = False

    End Sub

    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRoles.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstRoles.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objRoles.GetRoleByRoleID(lstRoles.SelectedItem.ToString)
            With objRoles.CurrentObject
                txtRole.Text = .RoleID
                txtDesc.Text = .RoleDescription
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
            txtRole.Clear()
            txtDesc.Clear()
            lstRoles.SelectedIndex = -1
            grpRoles.Enabled = False
            grpEdit.Enabled = True
            objRoles.CreateNewRole()
            txtRole.Focus()

        Else
            grpRoles.Enabled = True
            grpEdit.Enabled = False
            objRoles.CurrentObject.IsNewRole = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'first do validation
        If Not ValidateTextBoxLenght(txtRole, errp) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objRoles.CurrentObject
            .RoleID = txtRole.Text
            .RoleDescription = txtDesc.Text

        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRoles.Save
            If intResult = -1 Then 'id not unique
                MessageBox.Show("RoleID must be unique, unable to save record", "database error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("unable to save role record" & ex.ToString, "Databse error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        'new role is created ON 136
        blnReloading = True
        LoadRoles()
        chkNew.Checked = False
        grpRoles.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        chkNew.Checked = False
        errp.Clear()
        If lstRoles.SelectedIndex <> -1 Then
            LoadSelectedRecord() 'releoad what was selected in case user had messed up
        Else 'disable the dit area -nothing was currenltyt selected
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objRoles.CurrentObject.IsNewRole = False
        grpRoles.Enabled = True

    End Sub


End Class