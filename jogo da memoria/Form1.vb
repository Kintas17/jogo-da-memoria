Public Class Form1
    Dim Jogadas(15) As Integer
    Dim Matriz(15) As Integer
    Dim Quadros() As PictureBox
    Sub Imagens(quadro)
        Dim fig As New PictureBox
        Select Case Matriz(quadro)
            Case 0 : fig.Image = My.Resources.buc1
            Case 1 : fig.Image = My.Resources.cel
            Case 2 : fig.Image = My.Resources.gsw
            Case 3 : fig.Image = My.Resources.hus
            Case 4 : fig.Image = My.Resources.lac
            Case 5 : fig.Image = My.Resources.lal
            Case 6 : fig.Image = My.Resources.net
            Case 7 : fig.Image = My.Resources.phi
        End Select
        Quadros(quadro).BackgroundImage = fig.BackgroundImage
        Jogadas(quadro) = 1
    End Sub
    Sub Inicializa()
        Dim i As Integer
        For i = 0 To 15
            Quadros(i).BackgroundImage = My.Resources.vazio
            Matriz(i) = 0
        Next
        For par = 0 To 5
            For x = 0 To 1
                Do : i = Int(Rnd() * 16)
                Loop While Matriz(i)
                Matriz(i) = par
            Next
        Next
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P12.Click, P5.Click, P7.Click, P6.Click, P4.Click, P8.Click, P13.Click, P15.Click, P14.Click, P16.Click, P9.Click, P11.Click, P10.Click, P3.Click, P2.Click
        Dim quadro As Integer
        Select Case sender.name
            Case "P1" : quadro = 0
            Case "P2" : quadro = 1
            Case "P3" : quadro = 2
            Case "P4" : quadro = 3
            Case "P5" : quadro = 4
            Case "P6" : quadro = 5
            Case "P7" : quadro = 6
            Case "P8" : quadro = 7
            Case "P9" : quadro = 8
            Case "P10" : quadro = 9
            Case "P11" : quadro = 10
            Case "P12" : quadro = 11
            Case "P13" : quadro = 12
            Case "P14" : quadro = 13
            Case "P15" : quadro = 14
            Case "P16" : quadro = 15
        End Select
        If Jogadas(quadro) = 0 Then Call Imagens(quadro)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Quadros = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16}
        Call Inicializa()
    End Sub


End Class