Imports System
'Crear un proyecto y un módulo llamado “Reloj” que muestre en líneas diferentes con sus
'correspondientes títulos los siguientes valores en el momento de la ejecución: día del año, mes,
'hora y minuto
Module Program
	Sub Main(args As String())

		Console.Write("Dia del anio : " & DateTime.Now.Day())

		Console.WriteLine("Mes del anio : " & DateTime.Now.Month())

		Console.WriteLine("Hora y minutos : " & DateTime.Now.ToShortTimeString)


	End Sub
End Module
