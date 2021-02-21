Module Module1

    Sub Main()
        Dim mystr1, mystr2 As String
        Dim mychar1, mychar2 As Char

        mystr1 = ""
        mystr2 = ""
        mychar1 = ""
        mychar2 = ""

        Console.Write("Enter the string of your choice: ")
        mystr1 = Console.ReadLine

        mychar1 = Mid(mystr1, 1)
        mystr2 = mychar1

        For count = 2 To Len(mystr1)
            mychar2 = Mid(mystr1, count, 1)
            If mychar2 = mychar1 Then
                mystr2 = mystr2 & "*"
            Else
                mystr2 = mystr2 & mychar2
            End If
        Next

        Console.WriteLine("The Finalised String Is: " & mystr2)

        Console.ReadKey()
    End Sub

End Module
