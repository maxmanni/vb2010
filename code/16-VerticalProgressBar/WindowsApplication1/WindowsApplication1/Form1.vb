Public Class Form1
    Dim p
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p As New MyVerticalProgress() ' New MyVerticalProgress()
        p.Visible = True
        p.Size = New Size(20, 200)
        p.Location = New Point(0, 0)
        p.Value = 50

        Me.Controls.Add(p)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class
