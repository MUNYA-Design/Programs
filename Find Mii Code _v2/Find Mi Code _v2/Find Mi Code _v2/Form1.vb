Public Class Form1
    Dim arrCodeSample_L As String()
    Dim arrCodeSample_LNH_Global(,) As String
    Dim arrHeadingPos() As Integer

    '                              #############################################################
    ' Custom Procedures Start Here #############################################################
    '                              #############################################################
    Sub LoadArrayToRich()
        Dim iHeadingCount, icount As Integer

        'arrCodeSample_L = TopTrimArray(arrCodeSample_L)

        ''''''----------------------------------------------------------

        Dim itemp As String() = arrCodeSample_L
        'Dim icount As Integer
        Dim zcount As Integer
        zcount = 0
        icount = 0

        'Top Trim Array
        Dim bFirst_heading_found As Boolean = False

        If Not ("<vb_code>" = Mid(arrCodeSample_L(icount).ToLower, 1, 9)) Then
            'MsgBox("'<vb_code>' = " & Mid(arrCodeSample_L(icount).ToLower, 1, 9))

            'Find where the first heading begins
            Do While (bFirst_heading_found = False) And (icount <> UBound(arrCodeSample_L) + 1)

                If "<vb_code>" = Mid(arrCodeSample_L(icount).ToLower, 1, 9) Then
                    Debug.WriteLine("bFirst_heading_found is >>True<<")
                    bFirst_heading_found = True
                    Exit Do
                Else
                    bFirst_heading_found = False
                End If
                icount += 1
            Loop 'we get icount = where the first heading is, meaning 0...icount-1 is information unrelated to code samples

            'Make where the first heading is the first line | icount = number of spaces to move/duplicate elements to the left
            For i = icount To UBound(arrCodeSample_L)
                arrCodeSample_L(zcount) = itemp(i)
                zcount += 1
            Next

        End If

        zcount = 0
        icount = 0

        'Bottom Trim Array

        'Find where the last heading ends
        Dim bLast_heading_found As Boolean
        bLast_heading_found = False
        'where the closing tag '</visual_basic_.net_code_samples>' is
        Do While (bLast_heading_found = False) And Not (icount > UBound(arrCodeSample_L))
            For i = 0 To UBound(arrCodeSample_L)
                If "</visual_basic_.net_code_samples>" = Mid(arrCodeSample_L(icount).ToLower, 1, 33) Then
                    bLast_heading_found = True
                End If
            Next
            icount += 1
        Loop ' icount - 1 = where the last heading's last line ends

        'Set UBound of arrCodeSample_L to the last heading's last line number
        itemp = arrCodeSample_L
        ReDim arrCodeSample_L(icount - 2)

        For i = 0 To UBound(arrCodeSample_L)
            arrCodeSample_L(i) = itemp(i)
        Next

        ''''''---------------------------------------------------------- TOP & BOTTOM TRIM ARRAY


        Dim arrCodeSample_LNH(UBound(arrCodeSample_L), 3) As String 'Array Code Sample ( Line | Line Number | Heading )

        'Assign lines and numbers from arrCodeSample_L to arrCodeSample_LNH
        iHeadingCount = 0
        For i = 0 To UBound(arrCodeSample_L)

            arrCodeSample_LNH(i, 1) = arrCodeSample_L(i)
            arrCodeSample_LNH(i, 2) = i

            'MsgBox("i = " & i)

            'Count number of headings in arrCodeSample_L | and assign headings to heading line
            If "<vb_code>" = Mid(arrCodeSample_L(i).ToLower, 1, 9) Then
                arrCodeSample_LNH(i, 3) = arrCodeSample_L(i)
                iHeadingCount += 1
            End If

        Next

        'Debug.WriteLine(" ")
        'Debug.WriteLine(" ")
        'Debug.WriteLine("Lines in arrCodeSample_LNH(i), with a UBound of >>" & UBound(arrCodeSample_LNH) & "<<")
        'Debug.WriteLine(" ")
        'For i = 0 To UBound(arrCodeSample_LNH)
        '    Debug.WriteLine(i & " >> " & arrCodeSample_LNH(i, 1))
        'Next

        'MsgBox("Headings = " & iHeadingCount)

        'Set UBound of arrHeadingPos()
        ReDim arrHeadingPos(iHeadingCount)

        'Get position line (integer) of the headings
        Dim sOut As String
        sOut = ""

        icount = 0

        'Get position of the headings
        For i = 0 To UBound(arrCodeSample_L)
            If "<vb_code>" = Mid(arrCodeSample_L(i).ToLower, 1, 9) And icount <> iHeadingCount Then
                arrHeadingPos(icount) = i
                'MsgBox("Heading At: " & i)
                'MsgBox("Heading Line: " & arrCodeSample_LNH(i, 1))
                sOut += arrHeadingPos(icount) & ", "
                icount += 1
            End If
        Next
        icount = 0
        'MsgBox("Headings at pos (" & sOut & ")")
        'txtSearch.Text = sOut

        'Assign Headings to each line in Array arrCodeSample_LNH
        'MsgBox("Headings = " & iHeadingCount)
        Do While (icount <= iHeadingCount)

            If (icount = 0) Then 'first heading lines

                For i = arrHeadingPos(0) To arrHeadingPos(1) - 1 '...to first heading
                    arrCodeSample_LNH(i, 3) = arrCodeSample_LNH(arrHeadingPos(icount), 3)
                Next

            ElseIf (icount = iHeadingCount) Then 'last heading lines
                'MsgBox("Icount = iheadingcount")
                For i = arrHeadingPos(iHeadingCount - 1) To UBound(arrCodeSample_LNH) '...to the end of file
                    'MsgBox("For i = " & arrHeadingPos(iHeadingCount - 1) & " To " & UBound(arrCodeSample_LNH))
                    arrCodeSample_LNH(i, 3) = arrCodeSample_LNH(arrHeadingPos(icount - 1), 3)
                    'Debug.WriteLine(">>" & arrCodeSample_LNH(i, 3) & "<< = >>" & arrCodeSample_LNH(arrHeadingPos(icount - 1), 3) & "<<")
                Next

            ElseIf (icount > 0) And (icount <> iHeadingCount) Then 'lines inbetween first and last

                For i = arrHeadingPos(icount) To arrHeadingPos(icount + 1) - 1 '...to the pos of the next heading - 1
                    arrCodeSample_LNH(i, 3) = arrCodeSample_LNH(arrHeadingPos(icount), 3)
                Next

            End If

            icount += 1
        Loop

        rchOut.Clear()
        rchOut.Text = Trim(arrCodeSample_LNH(0, 1))
        For i = 1 To UBound(arrCodeSample_LNH)
            rchOut.Text += vbNewLine & arrCodeSample_LNH(i, 1)
        Next

        arrCodeSample_LNH_Global = arrCodeSample_LNH

    End Sub

    Sub RichRefresh(CodeSampleFile As String)
        Dim icount As Integer
        icount = 0
        'Load from textfile
        If Not (CodeSampleFile = "null") And (CodeSampleFile = "C:\Users\munya\OneDrive\Richfield BSc IT\Practical\Visual Basic\Find Mii Code _v2\Find Mi Code _v2\Find Mi Code _v2\Code Samples_v2.txt") Then

            'Create streamreader to read from file
            Dim txtCode As IO.StreamReader
            Dim ssLine As String

            rchOut.Clear()

            'Assign streamreader to Var
            txtCode = New IO.StreamReader(CodeSampleFile)

            'Count num of lines in file
            Do Until txtCode.Peek = -1
                ssLine = txtCode.ReadLine()
                icount += 1
            Loop

            'Set num of lines as UBound of arrCodeSample_L
            ReDim arrCodeSample_L(icount)

            'Close and Restart streamreader
            txtCode.Close()
            txtCode = New IO.StreamReader(CodeSampleFile)

            icount = 0

            'Read from file to array arrCodeSample_L | format text (later stage)
            Do Until txtCode.Peek = -1
                ssLine = txtCode.ReadLine()
                arrCodeSample_L(icount) = ssLine
                icount += 1
            Loop

            '//Close the file
            txtCode.Close()

            'Format and Display the array text
            LoadArrayToRich()

        End If

    End Sub
    Sub CheckSelectedIndex()
        Select Case cmbLang.SelectedIndex
            Case 0
                RichRefresh("C:\Users\munya\OneDrive\Richfield BSc IT\Practical\Visual Basic\Find Mii Code _v2\Find Mi Code _v2\Find Mi Code _v2\Code Samples_v2.txt")
            Case -1
                RichRefresh("null")
                MsgBox("Select Language To Load")
        End Select
    End Sub

    '                            #############################################################
    ' Custom Procedures End Here #############################################################
    '                            #############################################################

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rchOut.Clear()
        'populate comboboxes
        cmbLang.Items.Add("Visual Basic")

        'RichRefresh("C:\Users\munya\Documents\Richfield BSc IT\Practical\VB Coding\Find Mii Code _v2\Find Mi Code _v2\Find Mi Code _v2\Code Samples_v2.txt")
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshCode_Click(sender As Object, e As EventArgs) Handles btnRefreshCode.Click
        rchOut.Clear()
        Call CheckSelectedIndex()
    End Sub

    Private Sub cmbLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLang.SelectedIndexChanged
        Select Case cmbLang.SelectedIndex
            Case 0
                RichRefresh("C:\Users\munya\OneDrive\Richfield BSc IT\Practical\Visual Basic\Find Mii Code _v2\Find Mi Code _v2\Find Mi Code _v2\Code Samples_v2.txt")
            Case -1
                RichRefresh("null")
                MsgBox("Select Language To Load")
        End Select
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sSearch, sLine, iPosFound As String
        Dim iCurrHeading, iHeadingCount, iSearchResults, k, l As Integer
        Dim arrSearchedHeadings(UBound(arrHeadingPos) - 1) As String

        rchOut.Clear()
        rchOut.Text = "Search Results:" & vbNewLine

        sSearch = Trim(txtSearch.Text.ToUpper)
        iPosFound = ""
        iSearchResults = 0
        k = 0
        l = 0


        ' ******** ________ For loop that runs through rchOut's lines searching for the word
        iSearchResults = 0
        Dim bWasSearchedBefore As Boolean
        For m = 0 To UBound(arrCodeSample_LNH_Global) 'Search each array index

            'Check if the heading was checked before and result was found
            bWasSearchedBefore = False
            For i = 0 To UBound(arrSearchedHeadings)
                If arrSearchedHeadings(i) = arrCodeSample_LNH_Global(m, 3) Then
                    'msgbox("Was searched before")
                    bWasSearchedBefore = True
                    Exit For
                Else
                    bWasSearchedBefore = False
                End If
            Next

            If (bWasSearchedBefore = False) Then
                sLine = arrCodeSample_LNH_Global(m, 1)
                sLine = Trim(sLine.ToUpper) 'set to line and upper, sSearch was set to upper above
                'MsgBox("sLine is = " & sLine)

                If "<vb_code>" = Mid(sLine.ToLower, 1, 9) Then 'find the search results heading for display AND Heading position
                    'Which index is this in the arrHeadingPos()
                    For i = 0 To UBound(arrHeadingPos)
                        If m = arrHeadingPos(i) Then
                            iCurrHeading = i
                        End If
                    Next

                End If

                For i = 1 To sLine.Length - sSearch.Length 'Set search parameters

                    'MsgBox(">>" & Trim(Mid(sLine, i, sSearch.Length + 1)) & "<<" & vbNewLine & "VS" & vbNewLine & ">>" & sSearch & "<<" & vbNewLine & " Heading is " & arrRchOutLines(iHeading))

                    If Trim(Mid(sLine, i, sSearch.Length + 1)) = sSearch Then 'Search condition | Display entire section of the 'found' search result

                        'MsgBox("MATCH FOUND")
                        arrSearchedHeadings(iSearchResults) = arrCodeSample_LNH_Global(m, 3)

                        'If the the result is found in the heading, display and end search in section
                        If "<vb_code>" = Mid(sLine.ToLower, 1, 9) Then
                            If (iCurrHeading + 1) > UBound(arrHeadingPos) Then
                                For y = m To arrHeadingPos(UBound(arrHeadingPos))
                                    rchOut.Text += arrCodeSample_LNH_Global(y, 1)
                                Next
                            Else
                                For y = m To arrHeadingPos(iCurrHeading + 1) - 1
                                    rchOut.Text += arrCodeSample_LNH_Global(y, 1)
                                Next
                            End If
                        ElseIf Not ("<vb_code>" = Mid(sLine.ToLower, 1, 9)) Then

                            For y = m To arrHeadingPos(iCurrHeading + 1) - 1
                                rchOut.Text += arrCodeSample_LNH_Global(y, 1)
                            Next

                        End If

                        iSearchResults += 1

                        rchOut.Text += vbNewLine & iSearchResults & "  ---------------------------------------------------------------------------------------------------------------------" & vbNewLine

                    End If

                Next
            End If

        Next

        MsgBox(iSearchResults & " Match(s) of '" & sSearch & "' were found !!!")

    End Sub
End Class
