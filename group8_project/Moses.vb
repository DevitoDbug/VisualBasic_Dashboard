Public Class Moses
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Count, Number As Integer
        Dim Correct As Boolean
        Dim Guess As String

        Number = 0

        Randomize()
        Number = Int(Rnd() * 100) + 1 ' select the random number to be guessed
        Correct = False
        Count = 1

        Do While Count < 11 And Correct = False ' give user 10 guesses

            Guess = InputBox("Enter Your Guess", "Attemp " & Count)
            If Val(Guess) = Number Then ' if guess is correct

                Correct = True

            Else 'if guess is incorrect
                If Guess < Number Then
                    MsgBox("To Low", vbExclamation, "Attemp " & Count)
                Else
                    If Guess > Number Then
                        MsgBox("To High", vbExclamation, "Attempt " & Count)
                    End If

                End If

                Count = Count + 1

            End If

        Loop

        MsgBox("The Number Was " & Number)
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class