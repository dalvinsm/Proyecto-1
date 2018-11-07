Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("*** Programa para determinar Numeros Mayores ***")
        Dim Num1, Num2, Num3 As Integer
        Dim opcion As Integer = 0
        Do

            Console.WriteLine()
            Console.WriteLine("*** Ingrese el Primer Numero ***")
            Num1 = Console.ReadLine()

            Console.WriteLine("*** Ingrese el Segundo Numero ***")
            Num2 = Console.ReadLine()

            Console.WriteLine("*** Ingrese el Tercer Numero ***")
            Num3 = Console.ReadLine()

            If Num1 > Num2 And Num1 > Num3 Then
                Console.WriteLine("*** El Primer Numero es Mayor: " & Num1)
            ElseIf Num2 > Num1 And Num2 > Num3 Then
                Console.WriteLine("*** El Segundo Numero es Mayor: " & Num2)
            ElseIf Num3 > Num2 And Num3 > Num1 Then
                Console.WriteLine("*** El Tercer Numero es Mayor: " & Num3)
            Else
                Console.WriteLine("*** Todos los Numeros son iguales ***")
            End If

            Console.WriteLine()
            Console.WriteLine("*** Preciones la tecla CERO para salir ***")
        Loop While opcion Like 0
        Console.ReadKey()
    End Sub
End Module
