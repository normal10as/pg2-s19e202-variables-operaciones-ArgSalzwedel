Imports System
'Crear un proyecto y un módulo llamado aritmética que Declare y asigne dos valores enteros y
'dos valores de punto flotante. Luego demostrar las operaciones aritméticas básicas mezclando
'los tipos de datos utilizados y mostrar los resultados por consola previo un mensaje adecuado.
'Por ejemplo: sumar entero con entero, entero con punto flotante y punto flotante con punto
'flotante.
Module Program
	Sub Main()
		Dim numero1 As Int16 = 8
		Dim numero2 As Int16 = 2
		Dim numfloat1 As Single = 3.3
		Dim numfloat2 As Single = 7.5
		Dim resulent As Single


		resulent = numero1 + numero2
		Console.WriteLine("suma Enteros: " & resulent)


		resulent = numero1 - numero2
		Console.WriteLine("Resta Enteros: " & resulent)


		resulent = numfloat1 + numfloat2
		Console.WriteLine("Suma Flotantes: " & resulent)


		resulent = numfloat1 - numfloat2
		Console.WriteLine("Resta Flotantes: " & resulent)
		'//////////////////////////////////////////////////////////////////////////
		resulent = numero1 * numero2
		Console.WriteLine("Multi Enteros: " & resulent)


		resulent = numfloat1 * numfloat2
		Console.WriteLine("Multi Float: " & resulent)


		resulent = numero1 / numero2
		Console.WriteLine("div Enteros: " & resulent)


		resulent = numfloat1 / numfloat2
		Console.WriteLine("div float: " & resulent)
		'//////////////////////////////////////////////////////////////////////////

		resulent = numero1 + numfloat2
		Console.WriteLine("mix suma: " & resulent)

		resulent = numero1 - numfloat1
		Console.WriteLine("mix Resta: " & resulent)

		resulent = numero1 * numfloat1
		Console.WriteLine("Mix multi: " & resulent)

		resulent = numero1 / numfloat2
		Console.WriteLine("Mix div: " & resulent)




		Console.WriteLine("Hello World!")
	End Sub
End Module
