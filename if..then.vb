Module arrayApl
    Sub Main()
        'How to tell if a number between 1 - 20 is even number using the Mod operator and a conditional statement
        Dim index As Integer
        For i As Integer = 1 To 20 'Check even numbers from 1 - 20

            If (((i Mod 2)) = 0) Then
                Console.WriteLine("{0} is an Even Number", i)
            Else 
                Console.WriteLine("{0} is not an Even Number", i)
            End If

        Next i 'Terminate if i is greater than 20
    
    End Sub
End Module