Module arrayApl
    Sub Main()
        'How to use the ReDim statement to resize an array
        'Create a dynamic array that will store even numbers from 1 to 20 and then resize accordingly to
        'accomodate the even numbers from 1 to 20

        Dim even(-1) As Integer 'Create array that will store Integers. The length changes dynamically
        ' ReDim even(1)
        For i As Integer = 1 To 20 'Check even numbers from 1 - 20

            If (((i Mod 2)) = 0) Then
                Console.WriteLine("{0} is an Even Number, length is {1}", i, even.length)
                ReDim Preserve even(even.length) 'Resize the array and add more index based on if the current counter is an even number
                even(even.length - 1) = i 
            End If

        Next i 'Terminate if i is greater than 20
        
        For j as Integer = 0 To (even.length - 1)

            Console.WriteLine(even(j))

        Next j 'Terminate if j is greater than the length of even.length - 1
    End Sub
End Module