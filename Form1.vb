Public Class Form1
    Dim Fn As Integer
    Dim Sn As Integer
    Dim tot As Integer
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Fn = txtFirstNumber.Text
        Sn = txtSecondNumber.Text
        tot = Fn + Sn

        txtTotal.Text = tot

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFirstNumber.Text = ""
        txtSecondNumber.Text = ""
        txtTotal.Text = ""
        txtFirstNumber.Focus()

    End Sub
End Class
