Module Module1

    Sub Main()
        Dim X As String
        Dim Highest, charactercount, C1, C2 As Integer
        Dim mychar1, mychar2, mychar3 As Char

        X = ""
        Highest = 0
        charactercount = 0
        mychar1 = ""
        mychar2 = ""
        mychar3 = ""
        C1 = 0
        C2 = 0

        Console.Write("Enter The String: ")
        X = Console.ReadLine
        X = UCase(X)

        For C1 = 1 To Len(X)
            charactercount = 0
            mychar1 = Mid(X, C1, 1)
            If Asc(mychar1) >= 65 And Asc(mychar1) <= 90 Or Asc(mychar1) >= 48 And Asc(mychar1) <= 57 Then
                For C2 = 1 To Len(X)
                    mychar2 = Mid(X, C2, 1)
                    If mychar2 = mychar1 Then
                        charactercount = charactercount + 1
                    End If
                Next
                If charactercount > Highest Then
                    Highest = charactercount
                    mychar3 = mychar1
                End If
            End If
        Next

        If Highest <= 1 Then
            Console.WriteLine("None Of The Characters Are Repeated")
        Else
            Console.WriteLine("The Highest Character is: " & mychar3 & ", And Its Number Is: " & Highest)
        End If


        Console.ReadKey()

    End Sub
End Module
