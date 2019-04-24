Imports System
'.3. Crear un proyecto y un módulo llamado concatenación y en el declarar variables para almacenar
'los siguientes datos: nombre de la empresa, nombre de la calle, altura de la calle y fecha de
'inicio de actividades. Mostrar los mismos concatenados en la salida de la consola dos veces: la
'primera utilizando conversión explícita y la segunda conversión implícita.
Module Program
	Sub Main()
		Dim nombreempresa = "equisde"
		Dim nombrecalle = "Av.PepeMaria"
		Dim alturacalle = 3134
		Dim fechainicioact = #3/08/2008#

		Console.WriteLine("nombre empresa" & Convert.ToString(nombreempresa) & ";" & "Nombre de Calle: " & Convert.ToString(nombrecalle) & ";" & Convert.ToInt16(alturacalle) & ";" & Convert.ToDateTime(fechainicioact))

	End Sub
End Module
