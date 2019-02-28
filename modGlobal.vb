Module modGlobal
    'contains all variableas constants,procedures and functions thta need to be asccesed in more than one form
#Region "Screen Cosntants"
    Public Const ACTION_NONE = 0
    Public Const ACTION_HOME = 1
    Public Const ACTION_MEMBER = 2
    Public Const ACTION_ROLE = 3
    Public Const ACTION_EVENT = 4
    Public Const ACTION_RSVP = 5
    Public Const ACTION_COURSE = 6
    Public Const ACTION_SEMESTER = 7
    Public Const ACTION_HELP = 8
    Public Const ACTION_TUTOR = 9
    Public Const ACTION_LOGOUT = 10
#End Region
    Public intNextAction As Integer
    Public myDB As CDB
    'public role as Security

End Module
