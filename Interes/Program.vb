Imports System
'Crear un proyecto y un m�dulo llamado �Interes� que d� como resultado los intereses
'producidos y el capital acumulado de un monto m invertido a un inter�s anual r durante t d�as.
'La f�rmula utilizada es I= ??
'?
'donde I es el inter�s producido. Ingresar por teclado el
'monto, el inter�s y el tiempo.
Module Program
	Sub Main(args As String())
		Dim monto As Int16
		Dim interes As Single
		Dim dias As Byte
		Dim I As Single

		Console.WriteLine("ingrese un monto")
		monto = Console.ReadLine()
		Console.WriteLine("Ingrese un interes anual")
		interes = Console.ReadLine()
		Console.WriteLine("Ingrese un numero de dias")
		dias = Console.ReadLine

		I = ((monto * interes) * dias) / (360 * 100)

		Console.WriteLine("el interes prdocido es de:" & I)
	End Sub

End Module
