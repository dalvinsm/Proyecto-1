Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("** Calcular el Sueldo de Empleados  **")
        Dim SueldoBruto, SalarioHora As Double
        Dim CantidadHoras As Integer
        Dim NombresApellidos As String

        'Iniciamos la Captura de los Datos del Usuario
        Console.WriteLine("Por favor ingrese su Nombre y Apellidos")
        NombresApellidos = Console.ReadLine()
        Console.WriteLine("Por favor ingrese su Sueldo por Horas")
        SalarioHora = Console.ReadLine()
        Console.WriteLine("Por favor ingrese su Cantidad de Horas Trabajadas")
        CantidadHoras = Console.ReadLine()

        SueldoBruto = CantidadHoras * SalarioHora

        'Iniciamos la Imprecion de los Datos del Usuario
        Console.WriteLine()
        Console.WriteLine("**  Datos del Usuario  **")
        Console.WriteLine()
        Console.WriteLine("Nombre y Apellidos: " & NombresApellidos)
        Console.WriteLine("Salario por Horas: " & SalarioHora)
        Console.WriteLine("Cantidad de Horas Trabajadas: " & CantidadHoras)
        Console.WriteLine("Sueldo Bruto: " & SueldoBruto)

        Console.ReadKey()
    End Sub
End Module
