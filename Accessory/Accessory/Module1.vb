Module Module1

    Sub Main()
        Dim date1 As New Date(14, 7, 2)
        Dim date2 As New Date(14, 6, 2)

        Console.WriteLine(date1.ToShortDateString())
        Console.WriteLine(date1.ToLongDateString)
        Console.WriteLine(Date.Compare(date1, date2))
        Console.ReadLine()

    End Sub

End Module
