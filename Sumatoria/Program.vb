Imports System

Module Program
	Sub Main()
		Dim num1 As Int16
		Dim num2 As Int16
		Dim num3 As Int16
		Dim num4 As Int16
		Console.Write("ingrese numero1: ")
		num1 = Console.ReadLine()
		Console.WriteLine()
		Console.Write("ingrese numero2: ")
		num2 = Console.ReadLine
		Console.WriteLine()
		Console.Write("ingrese numero3: ")
		num3 = Console.ReadLine
		Console.WriteLine()
		Console.Write("ingrese numero4: ")
		num4 = Console.ReadLine

		num1 = num1 + num2 + num3 + num4
		Console.Write("resultado de la suma de los 4 numeros: " & num1)

		num1 /= 4
		Console.Write("media" & num1)
		Console.WriteLine("Hello World!")
	End Sub
End Module
