Imports System
'Crear un proyecto y un m�dulo llamado �Reloj� que muestre en l�neas diferentes con sus
'correspondientes t�tulos los siguientes valores en el momento de la ejecuci�n: d�a del a�o, mes,
'hora y minuto
Module Program
	Sub Main(args As String())

		Console.Write("Dia del anio : " & DateTime.Now.Day())

		Console.WriteLine("Mes del anio : " & DateTime.Now.Month())

		Console.WriteLine("Hora y minutos : " & DateTime.Now.ToShortTimeString)


	End Sub
End Module
