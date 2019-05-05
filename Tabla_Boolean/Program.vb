Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("tabla de and ")
		Console.WriteLine("v and  v", True And True)
		Console.WriteLine("v and f ", True And False)
		Console.WriteLine("f and v", False And True)
		Console.WriteLine("f and f", False And False)
		Console.WriteLine()
		Console.WriteLine("tabla de or ")
		Console.WriteLine("v or v", True Or True)
		Console.WriteLine("v or f ", True Or False)
		Console.WriteLine("f or v", False Or True)
		Console.WriteLine("f or f", False Or False)
		Console.WriteLine()
		Console.WriteLine("tabla de not ")
		Console.WriteLine("v not v", Not True)
		Console.WriteLine("v not f ", Not False)
		Console.WriteLine()
		Console.WriteLine("tabla de xor ")
		Console.WriteLine("v xor v", True Xor True)
		Console.WriteLine("v xor f ", True Xor False)
		Console.WriteLine("f xor v", False Xor True)
		Console.WriteLine("f xor f", False Xor False)
	End Sub
End Module
