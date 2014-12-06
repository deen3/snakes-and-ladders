Public Class averageDual
    Dim Rand As New Random
    Dim Tim As Single = 0
    Dim Result As Single = 0
    Dim Player1 As Single = 0
    Dim Player2 As Single = 0
    'Even, player ones turn, Odd, palyer twos turn
    Dim whosTurn As Single = 1

    Dim currentPlayer1Position As Single = 0
    Dim currentPlayer2Position As Single = 0


    Public Sub easySingle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPlayer1.Text = Play.txtPlayer1.Text()
        lblPlayer2.Text = Play.txtPlayer2.Text()
        'Player 1 Avatar
        If Play.Avatar1 = 1 Then
            picPlayer1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p1.jpg")
        ElseIf Play.Avatar1 = 2 Then
            picPlayer1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p2.jpg")
        ElseIf Play.Avatar1 = 3 Then
            picPlayer1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p3.jpg")
        End If

        'Player 2 Avatar
        If Play.Avatar2 = 4 Then
            picPlayer2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p4.jpg")
        ElseIf Play.Avatar2 = 5 Then
            picPlayer2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p5.jpg")
        ElseIf Play.Avatar2 = 6 Then
            picPlayer2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\p6.jpg")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Result = Rand.Next(1, 6)
        If (Result = 1) Then
            picDice.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\1.jpg")
        ElseIf (Result = 2) Then
            picDice.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\2.jpg")
        ElseIf (Result = 3) Then
            picDice.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\3.jpg")
        ElseIf (Result = 4) Then
            picDice.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\4.jpg")
        ElseIf (Result = 5) Then
            picDice.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\5.jpg")
        ElseIf (Result = 6) Then
            picDice.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\6.jpg")
        End If


        Tim += 1
        If (Tim = 20) Then
            Timer1.Stop()
            If whosTurn Mod 2 = 0 Then
                lblRemarks.Text = Play.txtPlayer1.Text + "'s turn. Roll the Dice"
                Player2Positions()
            Else
                lblRemarks.Text = Play.txtPlayer2.Text + "'s turn. Roll the Dice"
                Player1Positions()
            End If
        End If

    End Sub

    Private Sub Player1Positions()
        whosTurn += 1
        clearBluePeons()

        Player1 += Result

        If Player1 > 49 Then
            MsgBox("You're out of bounds! Player 2 wins!")
            restart()
        End If

        If Player1 = 1 Then
            currentPlayer1Position = 1
            p1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 2 Then
            currentPlayer1Position = 2
            p2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 3 Then
            currentPlayer1Position = 3
            p3.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 4 Then
            currentPlayer1Position = 4
            p4.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 5 Then
            currentPlayer1Position = 5
            p5.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 6 Then
            currentPlayer1Position = 6
            p6.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 7 Then
            currentPlayer1Position = 7
            p7.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            MsgBox("Weee! You found a ladder. Up to position 20. :D")
            currentPlayer1Position = 20
            p7.Image = Nothing
            p20.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            'up to position 13
            Player1 = 20
        ElseIf Player1 = 8 Then
            currentPlayer1Position = 8
            p8.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 9 Then
            currentPlayer1Position = 9
            p9.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 10 Then
            currentPlayer1Position = 10
            p10.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 11 Then
            currentPlayer1Position = 11
            p11.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            MsgBox("Weee! You found a ladder. Up to position 46. :D")
            currentPlayer1Position = 46
            p11.Image = Nothing
            p46.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            'up to position 13
            Player1 = 46
        ElseIf Player1 = 12 Then
            currentPlayer1Position = 12
            p12.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 13 Then
            currentPlayer1Position = 13
            p13.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 14 Then
            currentPlayer1Position = 14
            p14.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 15 Then
            currentPlayer1Position = 15
            p15.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            MsgBox("Weee! You found a ladder. Up to position 41. :D")
            currentPlayer1Position = 41
            p15.Image = Nothing
            p41.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            'up to position 13
            Player1 = 41
        ElseIf Player1 = 16 Then
            currentPlayer1Position = 16
            p16.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 17 Then
            currentPlayer1Position = 17
            p17.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 18 Then
            currentPlayer1Position = 18
            p18.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 19 Then
            currentPlayer1Position = 19
            p19.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 20 Then
            currentPlayer1Position = 20
            p20.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 21 Then
            currentPlayer1Position = 21
            p21.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 22 Then
            currentPlayer1Position = 22
            p22.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 23 Then
            currentPlayer1Position = 23
            p23.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 24 Then
            currentPlayer1Position = 24
            p24.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 25 Then
            currentPlayer1Position = 25
            p25.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 26 Then
            currentPlayer1Position = 26
            p26.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 27 Then
            currentPlayer1Position = 27
            p27.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            MsgBox("Ouch! You just stinged. Back to position 3. :(")
            currentPlayer1Position = 3
            p17.Image = Nothing
            p3.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            'back to position 5
            Player1 = 3
        ElseIf Player1 = 28 Then
            currentPlayer1Position = 28
            p28.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 29 Then
            currentPlayer1Position = 29
            p29.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 30 Then
            currentPlayer1Position = 30
            p30.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 31 Then
            currentPlayer1Position = 31
            p31.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 32 Then
            currentPlayer1Position = 32
            p32.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 33 Then
            currentPlayer1Position = 33
            p33.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 34 Then
            currentPlayer1Position = 34
            p34.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 35 Then
            currentPlayer1Position = 35
            p35.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 36 Then
            currentPlayer1Position = 36
            p36.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 37 Then
            currentPlayer1Position = 37
            p37.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            MsgBox("Ouch! You just stinged. Back to position 19. :(")
            currentPlayer1Position = 19
            p37.Image = Nothing
            p19.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            'back to position 5
            Player1 = 19
        ElseIf Player1 = 38 Then
            currentPlayer1Position = 38
            p38.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 39 Then
            currentPlayer1Position = 39
            p39.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 40 Then
            currentPlayer1Position = 20
            p40.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 41 Then
            currentPlayer1Position = 41
            p41.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 42 Then
            currentPlayer1Position = 42
            p42.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 43 Then
            currentPlayer1Position = 43
            p43.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 44 Then
            currentPlayer1Position = 44
            p44.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            MsgBox("Ouch! You just stinged. Back to position 29. :(")
            currentPlayer1Position = 29
            p44.Image = Nothing
            p29.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            'back to position 5
            Player1 = 29
        ElseIf Player1 = 45 Then
            currentPlayer1Position = 45
            p45.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 46 Then
            currentPlayer1Position = 46
            p46.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 47 Then
            currentPlayer1Position = 47
            p47.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 48 Then
            currentPlayer1Position = 48
            p48.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
        ElseIf Player1 = 49 Then
            currentPlayer1Position = 49
            p49.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\blue.jpg")
            btnDice.Enabled = False
            MsgBox("Player 1 wins!!!")

        End If
    End Sub


    Private Sub Player2Positions()

        whosTurn += 1

        clearRedPeons()

        Player2 = Player2 + Result

        If Player2 > 49 Then
            MsgBox("You're out of bounds! Player 1 wins!")
            restart()
        End If

        If Player2 = 1 Then
            currentPlayer2Position = 1
            p1.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 2 Then
            currentPlayer2Position = 2
            p2.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 3 Then
            currentPlayer2Position = 3
            p3.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 4 Then
            currentPlayer2Position = 4
            p4.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 5 Then
            currentPlayer2Position = 5
            p5.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 6 Then
            currentPlayer2Position = 6
            p6.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 7 Then
            currentPlayer2Position = 7
            p7.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            MsgBox("Weee! You found a ladder. Up to position 20. :D")
            currentPlayer2Position = 20
            p7.Image = Nothing
            p20.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            'up to position 13
            Player2 = 20
        ElseIf Player2 = 8 Then
            currentPlayer2Position = 8
            p8.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 9 Then
            currentPlayer2Position = 9
            p9.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 10 Then
            currentPlayer2Position = 10
            p10.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 11 Then
            currentPlayer2Position = 11
            p11.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            MsgBox("Weee! You found a ladder. Up to position 46. :D")
            currentPlayer2Position = 46
            p11.Image = Nothing
            p46.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            'up to position 13
            Player2 = 46
        ElseIf Player2 = 12 Then
            currentPlayer2Position = 12
            p12.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 13 Then
            currentPlayer2Position = 13
            p13.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 14 Then
            currentPlayer2Position = 14
            p14.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 15 Then
            currentPlayer2Position = 15
            p15.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            MsgBox("Weee! You found a ladder. Up to position 41. :D")
            currentPlayer2Position = 41
            p15.Image = Nothing
            p41.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            'up to position 13
            Player2 = 41
        ElseIf Player2 = 16 Then
            currentPlayer2Position = 16
            p16.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 17 Then
            currentPlayer2Position = 17
            p17.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 18 Then
            currentPlayer2Position = 18
            p18.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 19 Then
            currentPlayer2Position = 19
            p19.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 20 Then
            currentPlayer2Position = 20
            p20.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 21 Then
            currentPlayer2Position = 21
            p21.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 22 Then
            currentPlayer2Position = 22
            p22.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 23 Then
            currentPlayer2Position = 23
            p23.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 24 Then
            currentPlayer2Position = 24
            p24.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 25 Then
            currentPlayer2Position = 25
            p25.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 26 Then
            currentPlayer2Position = 26
            p26.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 27 Then
            currentPlayer2Position = 27
            p27.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            MsgBox("Ouch! You just stinged. Back to position 3. :(")
            currentPlayer2Position = 3
            p17.Image = Nothing
            p3.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            'back to position 5
            Player2 = 3
        ElseIf Player2 = 28 Then
            currentPlayer2Position = 28
            p28.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 29 Then
            currentPlayer2Position = 29
            p29.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 30 Then
            currentPlayer2Position = 30
            p30.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 31 Then
            currentPlayer2Position = 31
            p31.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 32 Then
            currentPlayer2Position = 32
            p32.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 33 Then
            currentPlayer2Position = 33
            p33.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 34 Then
            currentPlayer2Position = 34
            p34.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 35 Then
            currentPlayer2Position = 35
            p35.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 36 Then
            currentPlayer2Position = 36
            p36.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 37 Then
            currentPlayer2Position = 37
            p37.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            MsgBox("Ouch! You just stinged. Back to position 19. :(")
            currentPlayer2Position = 19
            p37.Image = Nothing
            p19.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            'back to position 5
            Player2 = 19
        ElseIf Player2 = 38 Then
            currentPlayer2Position = 38
            p38.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 39 Then
            currentPlayer2Position = 39
            p39.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 40 Then
            currentPlayer2Position = 20
            p40.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 41 Then
            currentPlayer2Position = 41
            p41.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 42 Then
            currentPlayer2Position = 42
            p42.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 43 Then
            currentPlayer2Position = 43
            p43.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 44 Then
            currentPlayer2Position = 44
            p44.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            MsgBox("Ouch! You just stinged. Back to position 29. :(")
            currentPlayer2Position = 29
            p44.Image = Nothing
            p29.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            'back to position 5
            Player2 = 29
        ElseIf Player2 = 45 Then
            currentPlayer2Position = 45
            p45.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 46 Then
            currentPlayer2Position = 46
            p46.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 47 Then
            currentPlayer2Position = 47
            p47.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 48 Then
            currentPlayer1Position = 48
            p48.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
        ElseIf Player2 = 49 Then
            currentPlayer2Position = 49
            p49.Image = Image.FromFile("C:\Users\kienah\Documents\Visual Studio 2008\Projects\Snakes and Ladders\Snakes and Ladders\red.jpg")
            btnDice.Enabled = False
            MsgBox("Player 2 wins!!!")
        End If
    End Sub

    Private Sub btnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDice.Click
        Tim = 0
        Timer1.Start()
    End Sub

    Private Sub clearRedPeons()

        If currentPlayer2Position = 1 Then
            p1.Image = Nothing
        ElseIf currentPlayer2Position = 2 Then
            p2.Image = Nothing
        ElseIf currentPlayer2Position = 3 Then
            p3.Image = Nothing
        ElseIf currentPlayer2Position = 4 Then
            p4.Image = Nothing
        ElseIf currentPlayer2Position = 5 Then
            p5.Image = Nothing
        ElseIf currentPlayer2Position = 6 Then
            p6.Image = Nothing
        ElseIf currentPlayer2Position = 7 Then
            p7.Image = Nothing
        ElseIf currentPlayer2Position = 8 Then
            p8.Image = Nothing
        ElseIf currentPlayer2Position = 9 Then
            p9.Image = Nothing
        ElseIf currentPlayer2Position = 10 Then
            p10.Image = Nothing
        ElseIf currentPlayer2Position = 11 Then
            p11.Image = Nothing
        ElseIf currentPlayer2Position = 12 Then
            p12.Image = Nothing
        ElseIf currentPlayer2Position = 13 Then
            p13.Image = Nothing
        ElseIf currentPlayer2Position = 14 Then
            p14.Image = Nothing
        ElseIf currentPlayer2Position = 15 Then
            p15.Image = Nothing
        ElseIf currentPlayer2Position = 16 Then
            p16.Image = Nothing
        ElseIf currentPlayer2Position = 17 Then
            p17.Image = Nothing
        ElseIf currentPlayer2Position = 18 Then
            p18.Image = Nothing
        ElseIf currentPlayer2Position = 19 Then
            p19.Image = Nothing
        ElseIf currentPlayer2Position = 20 Then
            p20.Image = Nothing
        ElseIf currentPlayer2Position = 21 Then
            p21.Image = Nothing
        ElseIf currentPlayer2Position = 22 Then
            p22.Image = Nothing
        ElseIf currentPlayer2Position = 23 Then
            p23.Image = Nothing
        ElseIf currentPlayer2Position = 24 Then
            p24.Image = Nothing
        ElseIf currentPlayer2Position = 25 Then
            p25.Image = Nothing
        ElseIf currentPlayer2Position = 26 Then
            p26.Image = Nothing
        ElseIf currentPlayer2Position = 27 Then
            p27.Image = Nothing
        ElseIf currentPlayer2Position = 28 Then
            p28.Image = Nothing
        ElseIf currentPlayer2Position = 29 Then
            p29.Image = Nothing
        ElseIf currentPlayer2Position = 30 Then
            p30.Image = Nothing
        ElseIf currentPlayer2Position = 31 Then
            p31.Image = Nothing
        ElseIf currentPlayer2Position = 32 Then
            p32.Image = Nothing
        ElseIf currentPlayer2Position = 33 Then
            p33.Image = Nothing
        ElseIf currentPlayer2Position = 34 Then
            p34.Image = Nothing
        ElseIf currentPlayer2Position = 35 Then
            p35.Image = Nothing
        ElseIf currentPlayer2Position = 36 Then
            p36.Image = Nothing
        ElseIf currentPlayer2Position = 37 Then
            p37.Image = Nothing
        ElseIf currentPlayer2Position = 38 Then
            p38.Image = Nothing
        ElseIf currentPlayer2Position = 39 Then
            p39.Image = Nothing
        ElseIf currentPlayer2Position = 40 Then
            p40.Image = Nothing
        ElseIf currentPlayer2Position = 41 Then
            p41.Image = Nothing
        ElseIf currentPlayer2Position = 42 Then
            p42.Image = Nothing
        ElseIf currentPlayer2Position = 43 Then
            p43.Image = Nothing
        ElseIf currentPlayer2Position = 44 Then
            p44.Image = Nothing
        ElseIf currentPlayer2Position = 45 Then
            p45.Image = Nothing
        ElseIf currentPlayer2Position = 46 Then
            p46.Image = Nothing
        ElseIf currentPlayer2Position = 47 Then
            p47.Image = Nothing
        ElseIf currentPlayer2Position = 48 Then
            p48.Image = Nothing
        ElseIf currentPlayer2Position = 49 Then
            p49.Image = Nothing


        End If
    End Sub

    Private Sub clearBluePeons()

        If currentPlayer1Position = 1 Then
            p1.Image = Nothing
        ElseIf currentPlayer1Position = 2 Then
            p2.Image = Nothing
        ElseIf currentPlayer1Position = 3 Then
            p3.Image = Nothing
        ElseIf currentPlayer1Position = 4 Then
            p4.Image = Nothing
        ElseIf currentPlayer1Position = 5 Then
            p5.Image = Nothing
        ElseIf currentPlayer1Position = 6 Then
            p6.Image = Nothing
        ElseIf currentPlayer1Position = 7 Then
            p7.Image = Nothing
        ElseIf currentPlayer1Position = 8 Then
            p8.Image = Nothing
        ElseIf currentPlayer1Position = 9 Then
            p9.Image = Nothing
        ElseIf currentPlayer1Position = 10 Then
            p10.Image = Nothing
        ElseIf currentPlayer1Position = 11 Then
            p11.Image = Nothing
        ElseIf currentPlayer1Position = 12 Then
            p12.Image = Nothing
        ElseIf currentPlayer1Position = 13 Then
            p13.Image = Nothing
        ElseIf currentPlayer1Position = 14 Then
            p14.Image = Nothing
        ElseIf currentPlayer1Position = 15 Then
            p15.Image = Nothing
        ElseIf currentPlayer1Position = 16 Then
            p16.Image = Nothing
        ElseIf currentPlayer1Position = 17 Then
            p17.Image = Nothing
        ElseIf currentPlayer1Position = 18 Then
            p18.Image = Nothing
        ElseIf currentPlayer1Position = 19 Then
            p19.Image = Nothing
        ElseIf currentPlayer1Position = 20 Then
            p20.Image = Nothing
        ElseIf currentPlayer1Position = 21 Then
            p21.Image = Nothing
        ElseIf currentPlayer1Position = 22 Then
            p22.Image = Nothing
        ElseIf currentPlayer1Position = 23 Then
            p23.Image = Nothing
        ElseIf currentPlayer1Position = 24 Then
            p24.Image = Nothing
        ElseIf currentPlayer1Position = 25 Then
            p25.Image = Nothing
        ElseIf currentPlayer1Position = 26 Then
            p26.Image = Nothing
        ElseIf currentPlayer1Position = 27 Then
            p27.Image = Nothing
        ElseIf currentPlayer1Position = 28 Then
            p28.Image = Nothing
        ElseIf currentPlayer1Position = 29 Then
            p29.Image = Nothing
        ElseIf currentPlayer1Position = 30 Then
            p30.Image = Nothing
        ElseIf currentPlayer1Position = 31 Then
            p31.Image = Nothing
        ElseIf currentPlayer1Position = 32 Then
            p32.Image = Nothing
        ElseIf currentPlayer1Position = 33 Then
            p33.Image = Nothing
        ElseIf currentPlayer1Position = 34 Then
            p34.Image = Nothing
        ElseIf currentPlayer1Position = 35 Then
            p35.Image = Nothing
        ElseIf currentPlayer1Position = 36 Then
            p36.Image = Nothing
        ElseIf currentPlayer1Position = 37 Then
            p37.Image = Nothing
        ElseIf currentPlayer1Position = 38 Then
            p38.Image = Nothing
        ElseIf currentPlayer1Position = 39 Then
            p39.Image = Nothing
        ElseIf currentPlayer1Position = 40 Then
            p40.Image = Nothing
        ElseIf currentPlayer1Position = 41 Then
            p41.Image = Nothing
        ElseIf currentPlayer1Position = 42 Then
            p42.Image = Nothing
        ElseIf currentPlayer1Position = 43 Then
            p43.Image = Nothing
        ElseIf currentPlayer1Position = 44 Then
            p44.Image = Nothing
        ElseIf currentPlayer1Position = 45 Then
            p45.Image = Nothing
        ElseIf currentPlayer1Position = 46 Then
            p46.Image = Nothing
        ElseIf currentPlayer1Position = 47 Then
            p47.Image = Nothing
        ElseIf currentPlayer1Position = 48 Then
            p48.Image = Nothing
        ElseIf currentPlayer1Position = 49 Then
            p49.Image = Nothing

        End If
    End Sub
    Private Sub restart()
        'sets all variables to zero
        Tim = 0
        Result = 0
        Player1 = 0
        Player2 = 0
        'Even, player ones turn, Odd, palyer twos turn
        whosTurn = 1

        currentPlayer1Position = 0
        currentPlayer2Position = 0

        'clear all positions
        p1.Image = Nothing
        p2.Image = Nothing
        p3.Image = Nothing
        p4.Image = Nothing
        p5.Image = Nothing
        p6.Image = Nothing
        p7.Image = Nothing
        p8.Image = Nothing
        p9.Image = Nothing
        p10.Image = Nothing
        p11.Image = Nothing
        p12.Image = Nothing
        p13.Image = Nothing
        p14.Image = Nothing
        p15.Image = Nothing
        p16.Image = Nothing
        p17.Image = Nothing
        p18.Image = Nothing
        p19.Image = Nothing
        p20.Image = Nothing
        p21.Image = Nothing
        p22.Image = Nothing
        p23.Image = Nothing
        p24.Image = Nothing
        p25.Image = Nothing
        p26.Image = Nothing
        p27.Image = Nothing
        p28.Image = Nothing
        p29.Image = Nothing
        p30.Image = Nothing
        p31.Image = Nothing
        p32.Image = Nothing
        p33.Image = Nothing
        p34.Image = Nothing
        p35.Image = Nothing
        p36.Image = Nothing
        p37.Image = Nothing
        p38.Image = Nothing
        p39.Image = Nothing
        p40.Image = Nothing
        p41.Image = Nothing
        p42.Image = Nothing
        p43.Image = Nothing
        p44.Image = Nothing
        p45.Image = Nothing
        p46.Image = Nothing
        p47.Image = Nothing
        p48.Image = Nothing
        p49.Image = Nothing

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        Play.Show()
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        MsgBox("Press OK to continue...")
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        restart()
    End Sub

    Private Sub p8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p8.Click

    End Sub
End Class