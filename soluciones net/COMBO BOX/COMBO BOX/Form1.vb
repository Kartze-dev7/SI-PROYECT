Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("adios")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "rojo" Then
            TextBox1.ForeColor = System.Drawing.Color.Red
            TextBox2.BackColor = System.Drawing.Color.Blue
        ElseIf ComboBox1.Text = "azul" Then
            TextBox1.ForeColor = System.Drawing.Color.Green
            TextBox2.BackColor = System.Drawing.Color.Yellow
        ElseIf ComboBox1.Text = "amarillo" Then
            TextBox1.ForeColor = System.Drawing.Color.Beige
            TextBox1.BackColor = System.Drawing.Color.Aqua
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Sans" Then
            TextBox1.Font = New Font("Sans Serif", 20, FontStyle.Italic)
        ElseIf ComboBox2.Text = "Comic" Then
            TextBox1.Font = New Font("Comic Sans MS", 20, FontStyle.Strikeout)
        ElseIf ComboBox2.Text = "Tahoma" Then
            TextBox1.Font = New Font("Tahoma", 20, FontStyle.Regular)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = Now
        Label8.Text = TimeOfDay
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "FOTO1" Then
            PictureBox1.Image = Image.FromFile("D:\HORARIO\TAREAS\fondo 4.jpg")
        ElseIf ComboBox3.Text = "FOTO2" Then
            PictureBox1.Image = Image.FromFile("D:\HORARIO\TAREAS\fondo 5.jpg")
        ElseIf ComboBox3.Text = "FOTO3" Then
            PictureBox1.Image = Image.FromFile("D:\HORARIO\TAREAS\fondo 3.jpg")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
