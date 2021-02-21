Module Module1

    Sub Main()
        Dim donuts As Integer

        Console.Write("Enter a number of donuts: ")
        donuts = Console.ReadLine

        If donuts > 9 Then
            donuts = Str(donuts)
            Console.WriteLine("The Number Of Donuts: " & "Many")
        Else
            donuts = Str(donuts)
            Console.WriteLine("The Number Of Donuts: " & donuts)
        End If

        Console.ReadKey()
    End Sub

End Module
