Module Module1

    Sub Main()
        Dim mystr1, mystr2 As String
        Dim c, n As Integer
        Dim mychar1 As Char
        Dim has_all As Boolean

        mystr1 = ""
        mystr2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        c = 0
        n = 0
        mychar1 = ""
        has_all = False

        Console.Write("Please Enter Your String: ")
        mystr1 = Console.ReadLine
        mystr1 = UCase(mystr1)

        For c = 1 To Len(mystr2)
            mychar1 = Mid(mystr1, c, 1)
            n = InStr(mystr1, mychar1)
            If n = 1 Then
                n = n + 1
            End If
        Next

        If n = 26 Then
            has_all = True
        End If

        If has_all = False Then
            Console.WriteLine("The string entered does not have all the alphabets")
        Else
            Console.WriteLine("The string entered does have all the alphabets")
        End If

        Console.ReadKey()
    End Sub

End Module
