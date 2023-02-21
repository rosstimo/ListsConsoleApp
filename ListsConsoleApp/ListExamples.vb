
Option Strict On
Option Explicit On
Imports System

Module ListExamples
    Sub Main(args As String())
        SimpleList()

    End Sub

    Sub SimpleList()
        'constructor for new list 
        Dim names As New List(Of String)

        names.Add("Bill")
        names.Add("Mary")
        names.Add("Joe")
        names.Add("Jill")
        names.Add("Sally")

        Console.WriteLine($"The list contains: {names.Count} items")
        Console.WriteLine($"Does the list contain Frank? {names.Contains("Frank}")}")
        Console.WriteLine($"Mary is at index: {names.IndexOf("Mary")}")
        Console.WriteLine($"The name at index 1 is: {names.Item(1)}")
        Console.WriteLine($"The last item in the list is: {names.Last}")

    End Sub


End Module
