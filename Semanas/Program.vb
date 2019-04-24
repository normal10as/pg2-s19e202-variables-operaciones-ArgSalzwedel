Imports System
'.Crear un proyecto y un módulo llamado semanas y en el declarar las siguientes constantes: días
'del año, días laborables y días de la semana. Informar cuantas semanas tiene el año y cuantas
'semanas son laborables.





Module Program
	Sub Main()
		Dim semana As SByte = 7
		Dim anio As UShort = 365
		Dim semanaslaborables As Byte
		Dim diaslaborables As SByte = 5
		Dim x As Byte
		x = anio / semana

		Console.Write("Semanas del anio: " & x)
		Console.WriteLine()
		semanaslaborables = x / diaslaborables

		Console.Write("semanas laborables del anio: " & semanaslaborables)











	End Sub
End Module
