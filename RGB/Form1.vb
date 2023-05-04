Imports RGB.rgb
Public Class Form1

    Private Sub generatRBG_color_Click(sender As Object, e As EventArgs) Handles generatRBG_color.Click
        If (IsNumeric(txtBoxRed.Text) And IsNumeric(txtBoxGreen.Text) And IsNumeric(txtBoxBleu.Text)) Then
            Dim rgb_color As New rgb(txtBoxRed.Text, txtBoxGreen.Text, txtBoxBleu.Text)

            If rgb_color.in_Iterval() Then
                rgb_color.changeColor(Label_RGB.BackColor)
            Else
                If rgb_color.in_Iterval() = False Then
                    MsgBox("il doit respect l'interval des valeur; entre 0 et 255", MsgBoxStyle.MsgBoxHelp)
                Else
                    MsgBox("ERROR", MsgBoxStyle.Information)
                End If
            End If
        Else
            MsgBox("il doit saisi des nembers", MsgBoxStyle.Information)
        End If

    End Sub
End Class
