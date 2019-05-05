Imports System

'Crear un proyecto y un programa que resuelva la siguiente ecuación  =
' donde a = 1, b = 5
'y c = 2.Mostrar el resultado obtenido
Module Program
	Sub Main()
		Dim a As Int16 = 1
		Dim b As Int16 = 5
		Dim c As Int16 = 2
		Dim x As Int16

		x = ((b ^ 2) - (4 * a * c)) / (2 * a)

		Console.WriteLine("Resultado: " & x)






		Console.WriteLine("Hello World!")
	End Sub
End Module
