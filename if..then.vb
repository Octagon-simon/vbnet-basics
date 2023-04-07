'This script is not complete yet

Module arrayApl
    Sub Main()

        Dim even(0) As Integer 'Create array that will store Integers. This array will hold 10 elements but with index running from 0 - 9
        ' ReDim even(1)
        Dim index As Integer
        For i As Integer = 1 To 20 'Check even numbers from 1 - 20
          ' Console.WriteLine(((i Mod 2)))
          Index = i - 1
          If (((i Mod 2)) = 0) Then
            Console.WriteLine("{0} is an Even Number", i)
            
            ReDim Preserve even(Index - 2) 'Resize the array and add more index based on if the current index is an even numbers
            
            even(Index) = i 
            
          End If
          
        Next i
        
        For j as Integer = 0 To (even.length - 1)
          
          Console.WriteLine(even(j))
          
        Next j
          Console.ReadKey()
          Console.WriteLine("Length is {0}", even.length)
    End Sub
End Module

