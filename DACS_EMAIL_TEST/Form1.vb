Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dacs1 As New DACS.Proxy.Email(DACS.ENUMS.DMZ.STAGE_Public_DACS, "10")
        Dim dacsemail As New DACS.Email.EmailToSend
        'dacsemail.AppKey = "10"
        dacsemail.EmailBody = "JUNK TO SEND in BODY"
        dacsemail.EmailFrom = "j62bb.dacs@dla.mil"
        dacsemail.EmailTo = "Christopher.hood.ctr@dla.mil"
        dacsemail.EmailBCC = "chood@cna-consulting.com"
        dacsemail.EmailCC = "majianlord@gmail.com"
        dacsemail.EmailSubject = "This is a Test Email"
        Dim task1 As DACS.Email.EmailStatus = Dacs1.SendEmail(dacsemail)
    End Sub
End Class
