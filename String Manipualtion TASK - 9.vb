Module Module1

    Sub Main()
        Dim a, b, mystr3, mystr4, mystr5 As String
        Dim mychar1, mychar2, mychar3, mychar4 As Char

        a = ""
        b = ""
        mystr3 = ""
        mystr4 = ""
        mystr5 = ""
        mychar1 = ""
        mychar2 = ""
        mychar3 = ""
        mychar4 = ""

        Console.Write("Please Enter Your First String(a): ")
        a = Console.ReadLine
        a = UCase(a)
        Console.Write("Please Enter Your Second String(b): ")
        b = Console.ReadLine
        b = UCase(b)

        mychar1 = Mid(a, 1)
        mychar2 = Mid(b, 1)

        mystr3 = mychar2
        For count = 2 To Len(a)
            mychar3 = Mid(a, count, 1)
            mystr3 = mystr3 & mychar3
        Next

        mychar2 = Mid(b, 1)
        mystr4 = mychar1
        For count = 2 To Len(b)
            mychar4 = Mid(b, count, 1)
            mystr4 = mystr4 & mychar4
        Next

        mystr5 = mystr3 & " " & mystr4

        Console.WriteLine("The Finalised String Is: " & mystr5)

        Console.ReadKey()
    End Sub

End Module
