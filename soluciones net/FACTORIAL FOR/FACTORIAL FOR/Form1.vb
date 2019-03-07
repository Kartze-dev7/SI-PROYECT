Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Now
        Label8.Text = TimeOfDay
        Label5.Text = Format(Now(), ("dddd dd 'de' MMMM 'del' yyyy") & Chr(10) & Chr(10) & Format(Now(), "hh:mm:ss"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("adios")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num, x As Single
        Dim fact As Double
        num = Val(TextBox1.Text)
        fact = num
        For x = fact - 1 To 1 Step -1
            fact = fact * x
        Next x
        TextBox2.Text = fact
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num, x As Single
        Dim fact, a As Double
        num = Val(TextBox1.Text)
        fact = num
        For x = fact - 1 To 1 Step -1
            a = x + 1
            ListBox1.Items.Add(a & " * " & x)
        Next x
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num, c As Single
        Dim fact, b As Double
        num = Val(TextBox1.Text)
        fact = num
        For c = 1 To fact - 1 Step 1
            b = c + 1
            ListBox2.Items.Add(c & " * " & b)
        Next c
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class
