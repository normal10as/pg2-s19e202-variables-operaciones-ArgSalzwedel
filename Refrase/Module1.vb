Module Module1
	'	Crear un proyecto y un módulo llamado “Refrase” que ingrese por teclado dos palabras,
	'la primera palabra será reemplazada por la segunda dentro de la frase: “Aunque la cadena sea
	'de oro, sirve para lo mismo.”. La palabra que es reemplazada es reconocida dentro de la frase
	'porque esta precedida de un espacio y seguida de un espacio, de una coma o de un punto.
	'Mostrar el resultado.
	Sub Main()
		Dim palabra1 As Char
		Dim palabra2 As Char
		Dim cadenee As Char = "Aunque la cadena sea de oro, sirve para lo mismo"
		Console.Write("Ingrese la primera palabra a reemplazar: ")
		palabra1 = Console.ReadLine()
		Console.Write("Ingrese la segunda palabrar a reemplazar: ")
		palabra2 = Console.ReadLine()

		Console.WriteLine(cadenee)

		cadenee = Replace(cadenee, palabra1, palabra2)

		Console.WriteLine(cadenee)






	End Sub

End Module
