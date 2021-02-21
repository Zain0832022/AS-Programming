Module Module1

    Sub Main()
        Dim mystr1, mystr2 As String
        Dim n1, n2 As Integer
        Dim mychar1, mychar2, mychar3 As Char

        mystr1 = ""
        mystr2 = ""
        mychar1 = ""
        mychar2 = ""
        mychar3 = ""
        n1 = 0
        n2 = 0

        Console.Write("Enter Your String(which should include 'not' and/or 'bad'(end): ")
        mystr1 = Console.ReadLine
        mystr1 = UCase(mystr1)

        n1 = InStr(mystr1, "NOT")
        n2 = InStr(mystr1, "BAD")

        If n1 > 0 Then
            For count = 1 To n1 - 1
                mychar1 = Mid(mystr1, count, 1)
                mystr2 = mystr2 & mychar1
            Next
            For count = n1 + 4 To n2 - 1
                mychar2 = Mid(mystr1, count, 1)
                mystr2 = mystr2 & mychar2
            Next
            For count = n2 + 3 To Len(mystr1)
                mychar3 = Mid(mystr1, count, 1)
                mystr2 = mystr2 & mychar3
            Next
            Console.WriteLine("The Finalised String Is: " & mystr2 & "GOOD")
        Else
            Console.WriteLine("Your String Cannot Be Affected.")
        End If

        Console.ReadKey()
    End Sub

End Module
