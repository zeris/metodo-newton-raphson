Imports info.lundin.math
Public Class Metodo_biseccion
    Dim a, b, n, ec As Single
    Dim fa, fb As Single
    Dim x(50), er(50) As Single
    Dim i, redon As Integer
    Dim cadena As String
    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function
    Function fd(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tdf.Text)
    End Function
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        salida.Rows.Clear()
        i = 0
        n = tcs.Text
        x(i) = tx0.Text
        redon = n + 2
        ec = 0.5 * 10 ^ (-n)
        er(i) = 1
        salida.Rows.Add(i, Math.Round(x(i), redon), "-")
        Do While er(i) > ec
            x(i + 1) = x(i) - (f(x(i)) / fd(x(i)))
            er(i + 1) = Math.Abs((x(i + 1) - x(i)) / x(i + 1))
            salida.Rows.Add(i + 1, Math.Round(x(i + 1), redon), Math.Round(er(i + 1), redon))
            i = i + 1
        Loop
        lResultado.Text = "La raiz aproximada a " + n.ToString() + " cifras significativas es x = " + Math.Round(x(i), redon).ToString()
    End Sub
End Class
