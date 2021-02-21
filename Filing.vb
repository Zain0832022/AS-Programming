Module Module1

    Dim Name, Search As String
    Dim Menu, MemID, Telephone As Integer
    Dim isFound As Boolean
    Dim start As Integer



    Sub Main()

        Console.WriteLine("MENU:")
        Console.WriteLine("1. CREATE FILE")
        Console.WriteLine("2. OUTPUT")
        Console.WriteLine("3. SEARCH")
        Console.WriteLine("4. NEW RECORDS")
        Console.WriteLine("5. NEW FIELDS")
        Console.WriteLine("0. EXIT")

        Menu = 1

        While Menu = 1 Or Menu = 2 Or Menu = 3 Or Menu = 4 Or Menu = 5
            Do
                Console.Write("Enter Operation Number: ")

                Menu = Console.ReadLine

                If Menu < 0 Or Menu > 6 Then

                    Console.WriteLine("Unacceptable Choice")
                End If
            Loop Until Menu > -1 Or Menu < 6




            If Menu > 0 And Menu < 6 Then
                If Menu = 1 Then Call Task1()
                If Menu = 2 Then Call Task2()
                If Menu = 3 Then Call task3()
                If Menu = 4 Then Call Task4()
                If Menu = 5 Then Call Task5()
            End If
        End While


    End Sub

    Sub Task1()

        FileOpen(1, "D:\College Stuff\Members.txt", OpenMode.Output)

        Do

            Console.WriteLine("Please Enter The Name: ")
            Name = Console.ReadLine

            If Name = "" Then
            Else
                Console.WriteLine("Your Membership ID: ")
                MemID = Console.ReadLine

                WriteLine(1, Name)
                WriteLine(1, MemID)

            End If

        Loop Until Name = ""

        FileClose(1)

        Console.ReadKey()

    End Sub

    Sub Task2()

        FileOpen(1, "D:\College Stuff\Members.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, Name)
            Input(1, MemID)

            Console.WriteLine(Name)
            Console.WriteLine(MemID)

        End While

        FileClose(1)

        Console.ReadKey()

    End Sub

    Sub task3()

        isFound = False

        Console.WriteLine("Name To Find: ")
        Search = Console.ReadLine
        Search = UCase(Search)

        FileOpen(1, "D:\College Stuff\Members.txt", OpenMode.Input)

        Do

            Input(1, Name)
            Input(1, MemID)

            If Search = UCase(Name) Then
                isFound = True

                Console.WriteLine("Match Found Membership ID is: ")
                Console.WriteLine(MemID)

            End If

        Loop Until EOF(1) = True

        If isFound = False Then
            Console.WriteLine("Not Found")
        End If

        FileClose(1)

        Console.ReadKey()

    End Sub

    Sub Task4()

        FileOpen(1, "D:\College Stuff\Members.txt", OpenMode.Append)

        Do

            Console.WriteLine("Please Enter The Name: ")
            Name = Console.ReadLine

            If Name = "" Then

            Else
                Console.WriteLine("Your Membership ID: ")
                MemID = Console.ReadLine

                WriteLine(1, Name)
                WriteLine(1, MemID)

            End If

        Loop Until Name = ""

        FileClose(1)

        Console.ReadKey()


    End Sub

    Sub task5()

        FileOpen(2, "D:\College Stuff\Members Updated.txt", OpenMode.Output)
        FileOpen(1, "D:\College Stuff\Members.txt", OpenMode.Input)
        While Not EOF(1)

            Input(1, Name)
            Input(1, MemID)

            Console.WriteLine("Name: " & Name)
            Console.WriteLine("Membership ID: " & MemID)


            Console.Write("Enter Telephone Number: ")
            Telephone = Console.ReadLine

            Console.Write("Enter Membership Start Date (format: DD/MM/YY): ")
            start = Console.ReadLine

            WriteLine(2, Name)
            WriteLine(2, MemID)
            WriteLine(2, Telephone)
            WriteLine(2, start)

        End While

        FileClose(1)
        FileClose(2)

        My.Computer.FileSystem.DeleteFile("D:\College Stuff\Members.txt")
        My.Computer.FileSystem.RenameFile("D:\College Stuff\Members Updated.txt", "Members.txt")

        
        Console.ReadKey()

    End Sub

End Module
