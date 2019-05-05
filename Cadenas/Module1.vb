Module Module1
	'	crear un proyecto y un módulo llamado “Cadenas1” que ingrese una palabra por teclado
	'e informar : 
	' En que posición aparece la primer “a”.
	' En que posición aparece la primer “o”.
	' La palabra invertida
	Sub Main()
		Dim cadenee As String

		Console.Write("Ingrese una cadena : ")
		cadenee = Console.ReadLine



		Console.Write("La primer 'a': " & InStr(cadenee, "a"))

		Console.Write("La primer 'o': " & InStr(cadenee, "o"))

		Console.Write("La palabra invertida es : " & StrReverse(cadenee))









	End Sub

End Module
