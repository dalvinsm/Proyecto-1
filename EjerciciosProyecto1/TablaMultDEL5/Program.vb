Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("*** Tabla de Multiplicar del 5 ***")
        Console.WriteLine()
        Dim numero As Integer = 5

        For i As Integer = 1 To 10

            Console.WriteLine(numero & " x " & i & " = " & numero * i)
        Next

        Console.ReadKey()
    End Sub
End Module
