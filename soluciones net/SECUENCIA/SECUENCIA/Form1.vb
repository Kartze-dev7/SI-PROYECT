Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("adios")
        Exit
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Now
        Label8.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X, lim As Single
        lim = Val(TextBox1.Text)
Uno:
        X += 1
        If X > lim Then
        Else
            ListBox1.Items.Add(X)
            GoTo Uno
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim X, lim As Single
        lim = Val(TextBox1.Text)
        X = Val(TextBox1.Text)
dos:
        X -= 1
        If X! = 0 Then
        Else
            ListBox1.Items.Add(X)
            GoTo dos
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num, par As Single
        num = Val(TextBox1.Text)
        par = 0
alfa:
        If par >= num Then
        Else
            ListBox2.Items.Add(par)
            par += 2
            GoTo alfa
        End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num, impar As Single
        num = Val(TextBox1.Text)
        impar = 1
beta:
        If impar >= num Then
        Else
            ListBox3.Items.Add(impar)
            impar += 2
            GoTo beta
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub
End Class

