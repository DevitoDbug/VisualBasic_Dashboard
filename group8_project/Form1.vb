Public Class Form1

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        notif.Visible = False
        names.Visible = True
        nameNotif.Visible = False
    End Sub

    Private Sub names_MouseLeave(sender As Object, e As EventArgs) Handles names.MouseLeave
        names.Visible = False
        notif.Visible = False

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        names.Visible = False
        Guna2NotificationPaint1.Visible = False
        notif.Visible = True
    End Sub

    Private Sub notification_MouseLeave(sender As Object, e As EventArgs) Handles notif.MouseLeave
        notif.Visible = False
    End Sub

    Private Sub names_MouseEnter(sender As Object, e As EventArgs) Handles names.MouseEnter
        names.Visible = True

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        names.Visible = True

    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave
        names.Visible = False
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub Guna2Button1_MouseEnter(sender As Object, e As EventArgs) Handles Guna2CircleButton2.MouseEnter, Guna2CircleButton1.MouseEnter, Guna2Button1.MouseEnter
        notif.Visible = False
        names.Visible = False

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        Moses.Show()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.Hide()
        StarWars.Show()
    End Sub


End Class
