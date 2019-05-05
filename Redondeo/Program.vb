Imports System
'Crear un proyecto y un módulo llamado “Redondeo” que ingresar un número real por
'teclado y mostrar su valor aproximado por exceso, su valor aproximado por defecto y su valor
'redondeado
Module Program
	Sub Main(args As String())
		Dim numero As Int16
		Dim exceso As Single
		Dim defecto As Single
		Dim redondeo As Single

		Console.Write("Ingrese un Valor: ")
		numero = Console.ReadLine()

		exceso = Math.Ceiling(numero)
		defecto = Math.Floor(numero)
		redondeo = Math.Round(numero)

	End Sub
End Module
