'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 18/11/2021
' Time: 13:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimension an array
		Dim num(91) As Int16
		Dim bcall(91) As String
		Dim edit As Int16 = 0
		Dim bcallchange As String = ""
		
		For c=0 To 91
			c = c + 1
			num(c) = c
		Next
		
		'Asks the user for data
		Console.WriteLine("Please enter the call you would like to change or add . . . ")
		edit = Console.ReadLine()
		Console.WriteLine("Please enter the call . . . ")
		bcallchange = Console.ReadLine()
		
		For c=1 To 91
			If edit = num(c) Then
				bcall(c) = bcallchange
			End If
		Next
		
		For c=0 To 91
			Console.WriteLine(num(c) & bcall(c))
		Next
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module