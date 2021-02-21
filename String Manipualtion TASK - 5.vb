Module Module1

    Sub Main()
        Dim myStr1, myStr2 As String
        Dim C, N, aCount, eCount, iCount, oCount, uCount, VowelCount As Integer
        Dim myChar1 As Char

        myStr1 = ""
        myStr2 = "AEIOU"
        C = 0
        myChar1 = ""

        Console.Write("Please enter string: ")
        myStr1 = Console.ReadLine()

        For C = 1 To Len(myStr1)
            myChar1 = Mid(myStr1, C, 1)
            myChar1 = UCase(myChar1)
            N = InStr(myStr2, myChar1)
            If N > 0 Then
                If myChar1 = "A" Then
                    aCount = aCount + 1
                ElseIf myChar1 = "E" Then
                    eCount = eCount + 1
                ElseIf myChar1 = "I" Then
                    iCount = iCount + 1
                ElseIf myChar1 = "O" Then
                    oCount = oCount + 1
                ElseIf myChar1 = "U" Then
                    uCount = uCount + 1
                End If
            End If
        Next

        VowelCount = aCount + eCount + iCount + oCount + uCount

        Console.WriteLine("Number of 'A' in string is: " & aCount)
        Console.WriteLine("Number of 'E' in string is: " & eCount)
        Console.WriteLine("Number of 'I' in string is: " & iCount)
        Console.WriteLine("Number of 'O' in string is: " & oCount)
        Console.WriteLine("Number of 'U' in string is: " & uCount)
        Console.WriteLine("Number of Vowels in string is: " & VowelCount)

        Console.ReadKey()
    End Sub

End Module
