'Seth Rasmussen
'RCET 0265
'Spring 2022
'Fortune Cookie
'

Option Strict On
Option Explicit On
Module FortuneCookie

    Sub Main()
        For i = 0 To 15

            RandomInteger()
        Next
    End Sub

    Sub RandomInteger()
        Dim theRandomNmber As Single

        Randomize()
        theRandomNmber = CInt(Rnd() * 10)

        If theRandomNmber = 2 Or theRandomNmber = 1 Then
            Console.WriteLine("If you want somethin you've never had, you'll have to do something you've never done")
        ElseIf theRandomNmber = 0 Or theRandomNmber = 3 Then
            Console.WriteLine("You never lose, you either win or learn")
        ElseIf theRandomNmber = 4 Or theRandomNmber = 5 Then
            Console.WriteLine("The early bird gets the worm but the second mouse gets the cheese.")
        ElseIf theRandomNmber = 6 Or theRandomNmber = 7 Then
            Console.WriteLine("You are the crispy noodle in the vegetarian salad of life")
        ElseIf theRandomNmber = 8 Or theRandomNmber = 9 Then
            Console.WriteLine("Ignore the previous cookie")
        ElseIf theRandomNmber = 10 Then
            Console.WriteLine("Error 404: Fortune not found")
        End If

        Console.ReadLine()
    End Sub

End Module
