Module Module1

    Sub Main()
        Dim choice As Integer
        Do
            Console.WriteLine("Choose an assignment")
            Console.WriteLine("1: Assignment 1")
            Console.WriteLine("2: Assignment 2")
            Console.WriteLine("3: Assignment 3")
            Console.WriteLine("4: Assignment 4")
            Console.WriteLine("5: Assignment 5")
            Console.WriteLine("6: Exit")
            choice = Console.ReadLine
            Select Case choice
                Case 1
                    SchoolSchedule()
                Case 2
                    FiveScores()
                Case 3
                    Tests()
                Case 4
                    GuessingGame()
                Case 5
                    IDNum()


            End Select
        Loop Until choice = 6
    End Sub

    Sub SchoolSchedule()
        Dim Schedule(7) As String
        For i = 1 To 7
            Console.WriteLine("What is your " & i & " period")
            Schedule(i) = Console.ReadLine
        Next

        For i = 1 To 7
            Console.WriteLine("Your " & i & " period is " & Schedule(i))
        Next
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub FiveScores()
        Dim Scores(5) As Integer
        Dim avg As Integer
        Dim total As Integer

        For i = 1 To 5
            Console.WriteLine("Enter score " & i)
            Scores(i) = Console.ReadLine
        Next

        For i = 1 To 5
            total = total + Scores(i)
            avg = total / 5
            Console.WriteLine("Score " & i & " Is: " & Scores(i))

        Next
        Console.WriteLine("the Average is: " & avg)
        Console.WriteLine("The total is: " & total)
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Tests()
        Dim test As Integer
        Dim score(5) As Decimal
        Dim avg As Decimal

        Console.WriteLine("Enter how meny test you have taken (You may only enter up to 5)")
        test = Console.ReadLine

        If test > 5 Then
            Console.WriteLine("You can only enter up to 5 tests, press enter to reset and go back")
            Console.ReadLine()
            Console.Clear()
        End If

        For i = 1 To test
            Console.WriteLine("what is the score of your " & i & " test")
            score(i) = Console.ReadLine
            avg = score(i) + avg

        Next
        avg = avg / test
        Console.WriteLine("The avg is: " & avg)
        If avg < 100 And avg > 89 Then
            Console.WriteLine("You have an A")
        ElseIf avg < 89 And avg > 79 Then
            Console.WriteLine("You have an B")
        ElseIf avg < 79 And avg > 69 Then
            Console.WriteLine("You have an C")
        ElseIf avg < 69 And avg > 59 Then
            Console.WriteLine("You have an D")
        ElseIf avg < 59 And avg > 0 Then
            Console.WriteLine("You have an F")
        End If
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub GuessingGame()
        'SAMPLE "NOT THE REAL ASSINGMENT"
        Dim rndNum As New Random
        Dim CompNum(3) As Integer
        Dim PlayerNum As Integer
        Dim gameOver As Boolean

        For i = 1 To 3
            CompNum(i) = rndNum.Next(1, 26)
        Next

        For i = 1 To 5
            Console.WriteLine("imput your number")
            PlayerNum = Console.ReadLine
            For j = 1 To 3
                If PlayerNum = CompNum(j) Then
                    Console.WriteLine("you are correct!!")
                    gameOver = True
                    Exit For
                End If
            Next
            If gameOver = True Then
                Exit For
            End If
        Next

        'Console.WriteLine("Computer num is: " & CompNum(3))
        ''the player gets 5 chances to guess the num
        'For i = 1 To 5
        '    Console.WriteLine("Enter your Guess")
        '    PlayerNum = Console.ReadLine
        '    If PlayerNum = CompNum Then
        '        Console.WriteLine("you got it correct!!!")
        '        Exit For
        '    End If
        'Next
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub IDNum()
        Dim Id(5) As Integer
        Dim Classification(5) As String
        Dim Major(5) As String
        Dim IdTrack As Integer
        Dim cambrige(5) As String
        Dim IdSearch As Integer
        Dim index As Integer


        IdTrack = 53001

        For i = 1 To 5
            Id(i) = IdTrack
            IdTrack += 1
            Console.WriteLine("Enter your class (Freashmen, sophomore, junior, senior)")
            Classification(i) = Console.ReadLine
            Console.WriteLine("please enter your major")
            Major(i) = Console.ReadLine
            Console.WriteLine("are you in cambrige (y/n)")
            cambrige(i) = Console.ReadLine
        Next

        For i = 1 To 5
            Console.WriteLine("id: " & Id(i) & " class.: " & Classification(i) & " magor: " & Major(i) & " Cambrige: " & cambrige(i))
        Next

        Console.WriteLine("what id are you searching for?")
        IdSearch = Console.ReadLine

        For i = 1 To 5
            If IdSearch = Id(i) Then
                index = i
                Exit For
            End If
        Next

        Console.WriteLine("there id is: " & Id(index) & " Major: " & Major(index) & " Classification: " & Classification(index) & " Cambridge: " & cambrige(index))
        Console.ReadLine()
        Console.Clear()
    End Sub
End Module
