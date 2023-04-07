Module arrayApl
    Sub Main()

        Dim even(9) As Integer 'Create array that will store Integers. This array will hold 10 elements but with index running from 0 - 9
    
        For i As Integer = 1 To 10 'Create a counter i and then Loop from 1 - 10

            even(i - 1) = 2 * i 'Multiply the counter by 2 and store to the array index - 1 

        Next i 'Increment the counter i
        
        'Loop through the even numbers array
        For j as Integer = 0 To (even.length - 1) 'Create a counter j and then loop from 0 - 9

            Console.WriteLine(even(j)) 'Print the value of the even array at that current index

        Next j 'increment the counter j
    
    End Sub
End Module

