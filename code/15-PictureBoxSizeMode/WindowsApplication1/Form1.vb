Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        carta.Visible = True
        carta.Location = New Point(0, 30)
        carta.SizeMode = PictureBoxSizeMode.StretchImage
        carta.Size = New Size(500, 500)
    End Sub
End Class
