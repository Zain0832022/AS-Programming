Module Module1

    Sub Main()
        Dim mystr1, mystr2, mystr3 As String

        mystr1 = ""
        mystr2 = ""

        Console.Write("Enter Your word, ending with either 'ing' or can be fitted with 'ing',: ")
        mystr1 = Console.ReadLine
        mystr1 = UCase(mystr1)

        If Len(mystr1) < 3 Then
            Console.WriteLine("Your Word Cannot Be Edited")
        Else
            mystr2 = Right(mystr1, 3)
            If mystr2 = "ING" Then
                mystr3 = mystr1 & "LY"
                Console.WriteLine("The Final Word Is: " & mystr3)
            Else
                mystr3 = mystr1 & "ING"
                Console.WriteLine("The Final Word Is: " & mystr3)
            End If
        End If

        Console.ReadKey()
    End Sub

End Module
