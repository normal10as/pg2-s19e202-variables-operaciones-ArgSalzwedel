Imports System

Module Program
	Sub Main(args As String())
		Dim num1 As Int16
		Dim num2 As Int16
		Dim num3 As Int16
		Dim mayor2 As Int16



		Console.Write("Ingrese numero 1: ")
		num1 = Console.ReadLine

		Console.Write("Ingrese numero 2: ")
		num2 = Console.ReadLine

		Console.Write("Ingrese numero 3: ")
		num3 = Console.ReadLine

		mayor2 = Math.Max(num1, num2)

		Console.Write("El mayor es el: " & Math.Max(mayor2, num3))
	End Sub
End Module
