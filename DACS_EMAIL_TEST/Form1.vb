Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dacs1 As New DACS.Proxy.Email(DACS.ENUMS.DMZ.PROD_Public_DACS, "FLSKFJHALDFKJHASDF")
        Dim dacsemail As New DACS.Email.EmailToSend
        dacsemail.AppKey = "sdagfsdgasdg"
        dacsemail.EmailBody = "JUNK TO SEND in BODY"
        dacsemail.EmailFrom = "j62bb.dacs@dla.mil"
        dacsemail.EmailTo = "Christopher.hood.ctr@dla.mil"
        dacsemail.EmailBCC = "chood@cna-consulting.com"
        dacsemail.EmailCC = "majianlord@gmail.com"
        dacsemail.EmailSubject = "This is a Test Email"
        Dim task1 As Task(Of DACS.Email.EmailStatus) = Dacs1.SendEmailAsync(dacsemail)
    End Sub
End Class
