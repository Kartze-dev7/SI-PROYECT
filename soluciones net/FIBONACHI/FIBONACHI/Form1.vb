Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Now
        Label8.Text = Format(Now(), ("dddd dd 'de' MMMM 'del' yyyy") & Chr(10) & Chr(10) & Format(Now(), "hh:mm:ss"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("adios")
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, lim As Single
        Dim c As Double
        a = 0
        b = 1
        lim = Val(TextBox1.Text)
Uno:
        c = a + b
        If c = lim Then
        Else
            ListBox1.Items.Add(c)
            a = b
            b = c
            GoTo Uno
        End If
        TextBox2.Text = c
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
