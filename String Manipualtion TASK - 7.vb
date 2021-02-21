Module Module1

    Sub Main()
        Dim s, mystr2, mystr3, mystr4 As String

        Console.Write("Enter the string: ")
        s = Console.ReadLine
        s = UCase(s)

        If Len(s) < 2 Then
            Console.WriteLine("The Entered String Is Short You Got No Answer")
        Else
            mystr2 = Left(s, 2)
            mystr3 = Right(s, 2)
            mystr4 = mystr2 & mystr3
            Console.WriteLine("The Final String is: " & mystr4)
        End If


        Console.ReadKey()
    End Sub

End Module
