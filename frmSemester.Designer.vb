<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRoles = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvents = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRsvp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.grpSemesters = New System.Windows.Forms.GroupBox()
        Me.lstSemesters = New System.Windows.Forms.ListBox()
        Me.grpEditSem = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSemDesc = New System.Windows.Forms.TextBox()
        Me.txtSemID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.grpSemesters.SuspendLayout()
        Me.grpEditSem.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator9, Me.tsbHome, Me.ToolStripSeparator5, Me.tsbMember, Me.ToolStripSeparator4, Me.tsbRoles, Me.ToolStripSeparator3, Me.tsbEvents, Me.ToolStripSeparator2, Me.tsbRsvp, Me.ToolStripSeparator6, Me.tsbCourse, Me.ToolStripSeparator10, Me.tsbSemester, Me.tsbLogOut, Me.ToolStripSeparator7, Me.tsbHelp, Me.ToolStripSeparator8, Me.ToolStripSeparator1, Me.tsbTutor})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(836, 50)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRoles
        '
        Me.tsbRoles.AutoSize = False
        Me.tsbRoles.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRoles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRoles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRoles.Name = "tsbRoles"
        Me.tsbRoles.Size = New System.Drawing.Size(48, 48)
        Me.tsbRoles.Text = "ROLES"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvents
        '
        Me.tsbEvents.AutoSize = False
        Me.tsbEvents.BackgroundImage = Global.STARSOrg.My.Resources.Resources.events
        Me.tsbEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvents.Name = "tsbEvents"
        Me.tsbEvents.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvents.Text = "EVENTS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRsvp
        '
        Me.tsbRsvp.AutoSize = False
        Me.tsbRsvp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRsvp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRsvp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRsvp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRsvp.Name = "tsbRsvp"
        Me.tsbRsvp.Size = New System.Drawing.Size(48, 48)
        Me.tsbRsvp.Text = "RSVP"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSOrg.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSES"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOGOUT"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(729, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Semesters"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.chkNew)
        Me.grpNew.Location = New System.Drawing.Point(45, 149)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(263, 65)
        Me.grpNew.TabIndex = 10
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "New Semester"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(7, 22)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(150, 21)
        Me.chkNew.TabIndex = 0
        Me.chkNew.Text = "Add New Semester"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'grpSemesters
        '
        Me.grpSemesters.Controls.Add(Me.lstSemesters)
        Me.grpSemesters.Location = New System.Drawing.Point(45, 236)
        Me.grpSemesters.Name = "grpSemesters"
        Me.grpSemesters.Size = New System.Drawing.Size(263, 170)
        Me.grpSemesters.TabIndex = 11
        Me.grpSemesters.TabStop = False
        Me.grpSemesters.Text = "Semesters"
        '
        'lstSemesters
        '
        Me.lstSemesters.FormattingEnabled = True
        Me.lstSemesters.ItemHeight = 16
        Me.lstSemesters.Location = New System.Drawing.Point(7, 21)
        Me.lstSemesters.Name = "lstSemesters"
        Me.lstSemesters.Size = New System.Drawing.Size(242, 132)
        Me.lstSemesters.TabIndex = 0
        '
        'grpEditSem
        '
        Me.grpEditSem.Controls.Add(Me.btnCancel)
        Me.grpEditSem.Controls.Add(Me.btnSave)
        Me.grpEditSem.Controls.Add(Me.txtSemDesc)
        Me.grpEditSem.Controls.Add(Me.txtSemID)
        Me.grpEditSem.Controls.Add(Me.Label3)
        Me.grpEditSem.Controls.Add(Me.Label2)
        Me.grpEditSem.Location = New System.Drawing.Point(500, 153)
        Me.grpEditSem.Name = "grpEditSem"
        Me.grpEditSem.Size = New System.Drawing.Size(294, 253)
        Me.grpEditSem.TabIndex = 12
        Me.grpEditSem.TabStop = False
        Me.grpEditSem.Text = "Edit Courses"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(213, 216)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(56, 216)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 31)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSemDesc
        '
        Me.txtSemDesc.Location = New System.Drawing.Point(116, 73)
        Me.txtSemDesc.MaxLength = 100
        Me.txtSemDesc.Multiline = True
        Me.txtSemDesc.Name = "txtSemDesc"
        Me.txtSemDesc.Size = New System.Drawing.Size(172, 117)
        Me.txtSemDesc.TabIndex = 3
        '
        'txtSemID
        '
        Me.txtSemID.Location = New System.Drawing.Point(116, 28)
        Me.txtSemID.Name = "txtSemID"
        Me.txtSemID.Size = New System.Drawing.Size(172, 22)
        Me.txtSemID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Semester Desc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Semester ID"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 476)
        Me.Controls.Add(Me.grpEditSem)
        Me.Controls.Add(Me.grpSemesters)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSemester"
        Me.Text = "frmSemester"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.grpSemesters.ResumeLayout(False)
        Me.grpEditSem.ResumeLayout(False)
        Me.grpEditSem.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRoles As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbEvents As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbRsvp As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents grpSemesters As GroupBox
    Friend WithEvents lstSemesters As ListBox
    Friend WithEvents grpEditSem As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSemDesc As TextBox
    Friend WithEvents txtSemID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents errP As ErrorProvider
End Class
