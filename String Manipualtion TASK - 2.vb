Module Module1

    Sub Main()
        Dim mystr1, mystr2 As String
        Dim mychar1, mychar2, mychar3 As Char
        Dim c As Integer

        mystr1 = ""
        mystr2 = ""
        mychar1 = ""
        mychar2 = ""
        mychar3 = ""
        c = 0

        Console.Write("Please enter your String : ")
        mystr1 = Console.ReadLine

        Console.Write("Which character do you want to remove : ")
        mychar1 = Console.ReadLine

        Console.Write("Which character do you want to replace the previous one with : ")
        mychar2 = Console.ReadLine

        For c = 1 To Len(mystr1)
            mychar3 = Mid(mystr1, c, 1)
            If mychar3 <> mychar1 Then
                mystr2 = mystr2 & mychar3
            Else
                mystr2 = mystr2 & mychar2
            End If
        Next

        Console.WriteLine("Your Finalised string is : " & mystr2)

        Console.ReadKey()
    End Sub

End Module
