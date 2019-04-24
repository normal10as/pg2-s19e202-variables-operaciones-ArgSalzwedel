Imports System

Module Program
	Sub Main(args As String())

		Dim Nombre As String = "Lucas Salzwedel"
		Dim dni As Int32 = 36471896
		Dim LugNacimiento As String = "Obera"
		Dim FechaNacimiento As Date = #1994-8-31#
		Dim Altura As Double = 1.68
		Dim ArgentinoBoolean As Boolean = True
		Dim TemperaturaC As Double = 28.3
		Dim NombreCalle As String = "Av. Queteimporta 123"
		Dim DistanciaEntreCiudades As Double = 325.7
		Dim ProfundidadMarmts As Double = 8887488.87
		Dim CantidadHabitantes As Int32 = 545742214
		Dim PesoProducto As Double = 5.87
		Dim MontoProducto As Double = 2.5

		Console.WriteLine("Nombre: " & Nombre)
		Console.WriteLine("DNI: " & dni)
		Console.WriteLine("Lugar de Nacimiento: " & LugNacimiento)
		Console.WriteLine("Fecha de Nacimiento: " & FechaNacimiento)
		Console.WriteLine("Altura: " & Altura)
		Console.WriteLine("Es argentino?: " & ArgentinoBoolean)
		Console.WriteLine("Temperatura Corporal: " & TemperaturaC)
		Console.WriteLine("Direccion: " & NombreCalle)
		Console.WriteLine("Distancia entre Ciudades: " & DistanciaEntreCiudades)
		Console.WriteLine("Profundidad del mar: " & ProfundidadMarmts)
		Console.WriteLine("cantidad de habitantes: " & CantidadHabitantes)
		Console.WriteLine("Peso de Productos: " & PesoProducto)
		Console.WriteLine("Monto de Productos: " & MontoProducto)
	End Sub
End Module
