Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Now
        Label8.Text = Format(Now(), ("dddd dd 'de' MMMM 'del' yyyy") & Chr(10) & Chr(10) & Format(Now(), "hh:mm:ss"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("adios")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Single
        Dim fact As Double
        num = Val(TextBox1.Text)
        fact = num
omega:
        num -= 1
        If num = 0 Then
            TextBox2.Text = fact
        Else
            fact = fact * num
            GoTo omega
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num As Single
        Dim fact, prev As Double
        num = Val(TextBox1.Text)
        fact = num
alfa:
        If num = 1 Then
            TextBox2.Text = fact
        Else
            prev = num - 1
            ListBox1.Items.Add(fact & "*" & prev)
            num -= 1
            fact -= 1
            GoTo alfa
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num, a As Single
        Dim fact, sig As Double
        num = Val(TextBox1.Text)
        fact = num
        a = 1
GAMMA:
        If a = fact Then
            TextBox2.Text = fact
        Else
            sig = a + 1
            ListBox2.Items.Add(a & " * " & sig)
            a += 1
            GoTo GAMMA
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
