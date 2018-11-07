Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("*** Tabla de Multiplicar del 1 al 12 ***")
        Console.WriteLine()
        Dim j, i As Integer

        'Do
        '    Do While (j <= 12)
        '        Console.WriteLine(i & " x " & j & " = " & i * j)
        '    Loop
        'Loop While (i <= 12)

        For i = 1 To 12
            For j = 1 To 12
                Console.WriteLine(i & " x " & j & " = " & i * j)
            Next
        Next
        Console.ReadKey()
    End Sub
End Module
