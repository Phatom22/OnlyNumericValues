Public Class Form1
    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        Dim num As Integer


        If IsNumeric(txtNum.Text) = True Then
            num = txtNum.Text
        Else
            MsgBox("INVALID! ENTER A NUMBER")
            Exit Sub
        End If
        MsgBox(num)

    End Sub
End Class
