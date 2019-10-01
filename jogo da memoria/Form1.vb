Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.BackgroundImage = imagem(0)
    End Sub
    Function imagem(i)
        Select Case i
            Case 0
                Return My.Resources.Resources.buc1
            Case 1
                Return My.Resources.Resources.cel
            Case 2
                Return My.Resources.Resources.gsw
            Case 3
                Return My.Resources.Resources.hus
            Case 4
                Return My.Resources.Resources.lac
            Case 5
                Return My.Resources.Resources.lal
            Case 6
                Return My.Resources.Resources.net
            Case 7
                Return My.Resources.Resources.phi
        End Select
    End Function
End Class