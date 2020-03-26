Module Module1

    Class mobil
        Sub New(ByVal bensin As String)
            Console.WriteLine("Tipe Bensin: {0}", bensin)

        End Sub

    End Class

    Sub Main()
        Dim bensinBaru As New mobil("Pertalite")

        Console.Read()
    End Sub


End Module
