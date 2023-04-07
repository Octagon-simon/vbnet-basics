Module arrayApl
    Sub Main()

        Dim numbers(9) As Integer 'Create array that will store the Integers. This array will hold 10 elements but with index running from 0 - 9
        
        For i As Integer = 1 To 10 step 1 'Create a loop that will increment counter i from 1 until 10

            numbers(i - 1) = i 'Store the current value of the counter to the numbers array

        Next i 'Terminate if i is greater than 10
        
        Console.WriteLine("Let us count from 1 to 10") 'Print some dummy text
        
        For j as Integer = 0 To (numbers.length - 1) step 1 'Create a loop that will Increment counter j from 0 until the length of the numbers array - 1

            Console.WriteLine(numbers(j)) 'Print the value of the array at that particular index

        Next j 'Terminate if j is greater than Numbers.length - 1
        
    End Sub
End Module