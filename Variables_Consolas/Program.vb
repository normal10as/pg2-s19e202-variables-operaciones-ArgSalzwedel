Imports System

Module Program
	Sub Main(args As String())
		Dim nombre As String
		Dim apellido As String
		Dim fechadenacimiento As Date


		Console.Write("Ingrese Nombre: ")
		nombre = Console.ReadLine()
		Console.Write("Ingrese Apellido: ")
		apellido = Console.ReadLine()
		Console.Write("Ingresar fecha de nacimiento dd/mm/aa: ")
		fechadenacimiento = Console.ReadLine()

		Console.Write(nombre & " " & apellido & "," & fechadenacimiento)
	End Sub

End Module
