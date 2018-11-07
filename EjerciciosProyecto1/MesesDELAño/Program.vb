Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("*** Meses del Año Segun su Numero de Orden ***")
        Console.WriteLine()
        Dim opcion As Integer

        Console.WriteLine("Ingrese un Numero Correspondiente al Mes del Año")
        opcion = Console.ReadLine()

        Select Case opcion
            Case 1
                Console.WriteLine("Ha seleccionado el Mes *Enero*")
            Case 2
                Console.WriteLine("Ha seleccionado el Mes *Febrero*")
            Case 3
                Console.WriteLine("Ha seleccionado el Mes *Marzo*")
            Case 4
                Console.WriteLine("Ha seleccionado el Mes *Abrir*")
            Case 5
                Console.WriteLine("Ha seleccionado el Mes *Mayo*")
            Case 6
                Console.WriteLine("Ha seleccionado el Mes *Junio*")
            Case 7
                Console.WriteLine("Ha seleccionado el Mes *Julio*")
            Case 8
                Console.WriteLine("Ha seleccionado el Mes *Agosto*")
            Case 9
                Console.WriteLine("Ha seleccionado el Mes *Septiembre*")
            Case 10
                Console.WriteLine("Ha seleccionado el Mes *Octubre*")
            Case 11
                Console.WriteLine("Ha seleccionado el Mes *Noviembre*")
            Case 12
                Console.WriteLine("Ha seleccionado el Mes *Diciembre*")
            Case Else
                Console.WriteLine("ERROR *** El numero ingresado no corresponde a ningun mes del año")
        End Select

        Console.ReadKey()
    End Sub
End Module
