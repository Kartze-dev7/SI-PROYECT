Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Now
        Label8.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("adios")
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c, lim As Single
        a = 0
        b = 1
        lim = Val(TextBox1.Text)
        For c = 0 To c >= lim Step 1
            c = a + b
            TextBox2.Text = c
            ListBox1.Items.Add(a & "+" & b & "=" & c)
            a = b
            b = c
        Next c
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b, c, lim As Single
        a = 0
        b = 1
        lim = Val(TextBox1.Text)
        c = a + b
        If c >= lim Then
            ListBox1.Items.Add(a & "+" & b & "=" & c)
            a = b
            b = c
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

