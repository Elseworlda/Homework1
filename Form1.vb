Public Class frmNumbers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstructions1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.ControlBox = False
        lblFrench.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Visible = True
        lblFrench.Text = "trois"
    End Sub

    Private Sub OneButton_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Visible = True
        lblFrench.Text = "un"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub TwoButton_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Visible = True
        lblFrench.Text = "deux"
    End Sub

    Private Sub FourButton_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Visible = True
        lblFrench.Text = "quatre"
    End Sub

    Private Sub FiveButton_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Visible = True
        lblFrench.Text = "cinq"
    End Sub
End Class
