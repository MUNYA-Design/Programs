Public Class frmDodgerTheGame
    '---------------------
    ' Classes START
    '---------------------

    'Game rules and boundaries obj
    Dim GameTerrain As New Terrain()

    Public Class Terrain
        'Var Decleration

        'Floor/Ceiling
        Public iFloor2_Ceiling As Integer = 0 + 10 + 6  ' Max height of floor 2
        Public iFloor2_Floor As Integer = 140 ' Min height of floor 2

        Public iFloor1_Ceiling As Integer = 140 + 10 + 6  ' Max height of floor 1
        Public iFloor1_Floor As Integer = 280 ' Min height of floor 1

        Public iFloor0_Ceiling As Integer = 280 + 10 + 6 ' Max height of floor 0
        Public iFloor0_Floor As Integer = 420 ' Min height of floor 0

        Public iPlayerMaxLeft As Integer = 928 ' Max left a player can go
        Public iPlayerMinLeft As Integer = 36 ' Min left a player can go

    End Class
    '---------------------
    ' Classes END
    '---------------------

    '---------------------
    ' FUNCTIONS/SUBPROCEDURES START
    '---------------------

    Private Sub Moveblocks(pPicture As PictureBox)
        ' Falling blocks
        'Check at which floor is the block and execute accordingly

        'Generate random number
        Dim irandom As Integer = Int((30 * Rnd()) + 1)

        Dim bskipfloor As Boolean = (irandom < 10)

        'if (bock.top >= floor2 ceil) and (block.top + height < floor2 floor) then
        If (pPicture.Top >= GameTerrain.iFloor2_Ceiling) And ((pPicture.Top + pPicture.Height) < GameTerrain.iFloor2_Floor) Then
            pPicture.Top += (4 + irandom)
            '-      if ((block.top + height) >= floor2 floor value)
            If ((pPicture.Top + pPicture.Height) >= GameTerrain.iFloor2_Floor) Then
                pPicture.Top = GameTerrain.iFloor1_Ceiling
            End If
        End If

        If (bskipfloor = False) Then
            'if (block.top >= floor1 ceil) and (block.top + height < floor1 floor) then
            If (pPicture.Top >= GameTerrain.iFloor1_Ceiling) And ((pPicture.Top + pctBlock1.Height) < GameTerrain.iFloor1_Floor) Then
                pPicture.Top += (4 + irandom)
                '-      if ((block.top + height) >= floor1 floor value)
                If ((pPicture.Top + pPicture.Height) >= GameTerrain.iFloor1_Floor) Then
                    pPicture.Top = GameTerrain.iFloor0_Ceiling
                End If
            End If
        ElseIf (bskipfloor = True) Then
            'Skip to floor0
            If (pPicture.Top >= GameTerrain.iFloor1_Ceiling) And ((pPicture.Top + pctBlock1.Height) < GameTerrain.iFloor1_Floor) Then
                pPicture.Top = GameTerrain.iFloor0_Ceiling
            End If
        End If

        'if (block.top >= floor0 ceil) and (block.top + height < floor0 floor) then
        If (pPicture.Top >= GameTerrain.iFloor0_Ceiling) And ((pPicture.Top + pctBlock1.Height) < GameTerrain.iFloor0_Floor) Then
            pPicture.Top += (4 + irandom)
            '-      if ((block.top + height) >= floor0 floor value)
            If ((pPicture.Top + pPicture.Height) >= GameTerrain.iFloor0_Floor) Then
                pPicture.Top = GameTerrain.iFloor2_Ceiling
            End If
        End If

    End Sub
    Sub PlayerFloorLevel(Optional iupdate As Integer = 0)

        Select Case iupdate
            Case 0
                ' Dodger (User) goes to floor0
                pctDodger.Left = 54
                pctDodger.Top = 364

            Case 1
                ' Dodger (User) goes to floor1
                pctDodger.Left = 901
                pctDodger.Top = 224

            Case 2
                ' Dodger (User) goes to floor2 (Highest Floor)
                pctDodger.Left = 54
                pctDodger.Top = 84
        End Select

    End Sub



    Function CheckForCollision() As Boolean
        Dim collision As Boolean = True

        'Colision Detection 
        For Each picturebox In Me.Controls

            'Detect player touching blocks
            If pctBlock1 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(pctBlock1.Bounds) Then
                collision = 0
                Exit Function
            End If

            If pctBlock2 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(pctBlock2.Bounds) Then
                collision = 0
                Exit Function
            End If

            If pctBlock3 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(pctBlock3.Bounds) Then
                collision = 0
                Exit Function
            End If

            If pctBlock4 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(pctBlock4.Bounds) Then
                collision = 0
                Exit Function
            End If

            If pctBlock5 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(pctBlock5.Bounds) Then
                collision = 0
                Exit Function
            End If

            If pctBlock6 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(pctBlock6.Bounds) Then
                collision = 0
                Exit Function
            End If

            'Detect player reaching floor exit gate
            If picDoor5 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(picDoor5.Bounds) Then
                PlayerFloorLevel(1)
            End If

            If picDoor3 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(picDoor3.Bounds) Then
                PlayerFloorLevel(2)
            End If

            'Last gate | wins game
            If picDoor1 IsNot pctDodger AndAlso pctDodger.Bounds.IntersectsWith(picDoor1.Bounds) Then
                tmrOne.Enabled = False
                MsgBox("You won")
            End If

            Return collision

        Next
    End Function

    Sub showpos(iLeft As Integer, iRight As Integer, iTop As Integer)
        'Debugging: Shows current position
        MsgBox("The 'Left' property is >>" & iLeft & "<<" & vbNewLine & "The 'Right' property is >>" & iRight & "<<" & vbNewLine & vbNewLine & "The 'Top' property is >>" & iTop & "<<")
    End Sub

    Sub CharacterStartPos()

        ' Dodger (User)
        pctDodger.Left = 54
        pctDodger.Top = 364

        ' Blocks Left Property
        pctBlock1.Left = 100
        pctBlock2.Left = 244
        pctBlock3.Left = 388
        pctBlock4.Left = 532
        pctBlock5.Left = 676
        pctBlock6.Left = 820

        ' Blocks Top Property
        Dim iFloor2_Top = 16
        pctBlock1.Top = iFloor2_Top
        pctBlock2.Top = iFloor2_Top
        pctBlock3.Top = iFloor2_Top
        pctBlock4.Top = iFloor2_Top
        pctBlock5.Top = iFloor2_Top
        pctBlock6.Top = iFloor2_Top

        'Doors Left Property
        Dim iCharacterMin_Left = 11
        picDoor6.Left = iCharacterMin_Left
        picDoor3.Left = iCharacterMin_Left
        picDoor2.Left = iCharacterMin_Left
        picDoor5.Left = 943
        picDoor4.Left = 943
        picDoor1.Left = 911

        'Doors Top Property
        picDoor6.Top = 364
        picDoor5.Top = 364
        picDoor3.Top = 224
        picDoor4.Top = 224
        picDoor2.Top = 84
        picDoor1.Top = 16

        'Floor Top Property
        pnlfloor0.Top = 420
        pnlfloor1.Top = 280
        pnlfloor2.Top = 140
        pnlRoof.Top = 0

        'Floor Left Property
        pnlfloor1.Left = iCharacterMin_Left
        pnlfloor1.Left = iCharacterMin_Left
        pnlfloor2.Left = iCharacterMin_Left
        pnlRoof.Left = 0

    End Sub

    Sub Stopgame()
        CharacterStartPos()
        tmrOne.Enabled = False
        tmrPlayer.Enabled = False
        MsgBox("Dodger Died !!!")
    End Sub

    '---------------------
    ' FUNCTIONS/SUBPROCEDURES END
    '---------------------

    '---------------------
    ' TIMERS START HERE
    '---------------------
    Private Sub tmrOne_Tick(sender As Object, e As EventArgs) Handles tmrOne.Tick

        'Adding motion to the blocks (1 to 6)
        Moveblocks(pctBlock1)
            Moveblocks(pctBlock2)
            Moveblocks(pctBlock3)
            Moveblocks(pctBlock4)
            Moveblocks(pctBlock5)
            Moveblocks(pctBlock6)

        'Check for colision once
        If (CheckForCollision() = 0) Then
            Stopgame()
            Exit Sub
        End If

    End Sub

    Private Sub tmrPlayer_Tick(sender As Object, e As EventArgs) Handles tmrPlayer.Tick

    End Sub

    '---------------------
    ' TIMERS END HERE
    '---------------------

    Private Sub frmDodgerTheGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When game loads
        CharacterStartPos()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        'Right Button Click
        If (pctDodger.Left < GameTerrain.iPlayerMaxLeft) Then
            pctDodger.Left += 20
        End If
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        'Left Button Click
        If (pctDodger.Left > GameTerrain.iPlayerMinLeft) Then
            pctDodger.Left -= 20
        End If
    End Sub

    Private Sub pctChrcDoger_Click(sender As Object, e As EventArgs) Handles pctDodger.Click
        'Debugging: Shows current position
        showpos(pctDodger.Left, pctDodger.Right, pctDodger.Top)
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        CharacterStartPos()
        tmrOne.Enabled = 1
        tmrPlayer.Enabled = 1
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub


End Class

