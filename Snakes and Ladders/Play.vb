Public Class Play

    Public Avatar1 As Single = 0
    Public Avatar2 As Single = 0
    Private Sub m_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pic1.Enabled = False
        pic2.Enabled = False
        pic3.Enabled = False
        pic4.Enabled = False
        pic5.Enabled = False
        pic6.Enabled = False
    End Sub

    Private Sub btnStart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If rbtnDual.Checked And rbtnEasy.Checked Then
            Me.Hide()
            easyDual.Show()
        ElseIf rbtnDual.Checked And rbtnAverage.Checked Then
            Me.Hide()
            averageDual.show()
        ElseIf rbtnDual.Checked And rbtnHard.Checked Then
            Me.Hide()
            hardDual.show()
        Else
            MsgBox("Please select among the difficulty levels to start game.")
        End If
    End Sub

    Private Sub rbtnSingle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnSingle.CheckedChanged
        txtPlayer1.Enabled = True
        txtPlayer2.Enabled() = False

        pic1.Enabled = True
        pic2.Enabled = True
        pic3.Enabled = True
        pic4.Enabled = False
        pic5.Enabled = False
        pic6.Enabled = False
    End Sub

    Private Sub rbtnDual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDual.CheckedChanged
        txtPlayer1.Enabled() = True
        txtPlayer2.Enabled() = True

        pic1.Enabled = True
        pic2.Enabled = True
        pic3.Enabled = True
        pic4.Enabled = True
        pic5.Enabled = True
        pic6.Enabled = True
    End Sub

    '-----------------------------------------------------

    Public Sub pic1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic1.MouseClick
        picAvatar2.Visible = False
        picAvatar1.Visible = True

        lblAvatarChosen.Visible = True
        lblAvatarChosen.Text = "You have chosen Mindy as your avatar."
        picAvatar1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p1.jpg")
        Avatar1 = 1
    End Sub

    Public Sub pic2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic2.MouseClick
        picAvatar2.Visible = False
        picAvatar1.Visible = True

        lblAvatarChosen.Visible = True
        lblAvatarChosen.Text = "You have chosen Claire as your avatar."
        picAvatar1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p2.jpg")
        Avatar1 = 2
    End Sub

    Public Sub pic3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic3.MouseClick
        picAvatar2.Visible = False
        picAvatar1.Visible = True

        lblAvatarChosen.Visible = True
        lblAvatarChosen.Text = "You have chosen Chloe as your avatar."
        picAvatar1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p3.jpg")
        Avatar1 = 3
    End Sub

    Public Sub pic4_MouseClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic4.MouseClick
        picAvatar1.Visible = False
        picAvatar2.Visible = True

        lblAvatarChosen.Visible = True
        lblAvatarChosen.Text = "You have chosen Jasper as your avatar."
        picAvatar2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p4.jpg")
        Avatar2 = 4
    End Sub

    Public Sub pic5_MouseClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic5.MouseClick
        picAvatar1.Visible = False
        picAvatar2.Visible = True

        lblAvatarChosen.Visible = True
        lblAvatarChosen.Text = "You have chosen Paul as your avatar."
        picAvatar2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p5.jpg")
        Avatar2 = 5
    End Sub

    Public Sub pic6_MouseClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic6.MouseClick
        picAvatar1.Visible = False
        picAvatar2.Visible = True

        lblAvatarChosen.Visible = True
        lblAvatarChosen.Text = "You have chosen Dylan as your avatar."
        picAvatar2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p6.jpg")
        Avatar2 = 6
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnInstruc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstruc.Click
        gbInstruct.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gbInstruct.Visible = False
    End Sub
End Class