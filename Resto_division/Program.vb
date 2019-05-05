Imports System

Module Program
	Sub Main(args As String())
		Dim numero As Int16
		Dim divisor As SByte = 2

		Console.WriteLine("Ingrese un valor a dividir: ")
		numero = Console.ReadLine


		numero = numero Mod divisor
		Console.Write("resultado: " & numero)
	End Sub
End Module
