Module Module1

    Sub Main()
        Dim mystr1 As String
        Dim mychar1 As Char
        Dim alphaCount, digitCount, C, OtherCharacterCount As Integer

        mystr1 = ""
        mychar1 = ""
        alphaCount = 0
        digitCount = 0
        OtherCharacterCount = 0
        C = 0

        Console.Write("Enter Your String :")
        mystr1 = Console.ReadLine

        For C = 1 To Len(mystr1)
            mychar1 = Mid(mystr1, C, 1)
            mychar1 = UCase(mychar1)

            If Asc(mychar1) >= 65 And Asc(mychar1) <= 90 Then
                alphaCount = alphaCount + 1
            ElseIf Asc(mychar1) >= 48 And Asc(mychar1) <= 57 Then
                digitCount = digitCount + 1
            End If
        Next

        OtherCharacterCount = Len(mystr1) - (alphaCount + digitCount)

        Console.WriteLine("The total count of characters is: " & Len(mystr1))
        Console.WriteLine("The Count of alphabets is: " & alphaCount)
        Console.WriteLine("The Count of Digits is: " & digitCount)
        Console.WriteLine("The Count of other characters is: " & OtherCharacterCount)

        Console.ReadKey()
    End Sub

End Module
