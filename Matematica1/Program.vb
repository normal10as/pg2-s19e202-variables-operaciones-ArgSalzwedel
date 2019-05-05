Imports System
'Crear un proyecto y un módulo llamado “Matematica1” para ingresar un número por
'teclado y mostrar:
' su valor absoluto,
' el resultado de elevarlo a la décima potencia
' raíz cuadrada
Module Program
	Sub Main(args As String())
		Dim numero As Single
		Dim absoluto As Single
		Dim potencia As Single
		Dim cuadrada As Int16
		Console.Write("Ingrese un numero:")
		numero = Console.ReadLine()

		absoluto = Math.Abs(numero)
		potencia = Math.Pow(numero, 10)
		cuadrada = Math.Sqrt(numero)

		Console.Write("Valor Absoluto: " & absoluto)
		Console.Write("Valor de Potencia: " & potencia)
		Console.Write("Valor Raiz Cuadrada: " & cuadrada)
	End Sub
End Module
