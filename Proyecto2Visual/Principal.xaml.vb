Public Class Principal

    Private Sub btnIngresar_Click(sender As Object, e As RoutedEventArgs) Handles btnIngresar.Click
        Dim ingreso As New MainWindow
        ingreso.Owner = Me
        ingreso.Show()
    End Sub

    Private Sub btnVotar_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar.Click
        Dim votar As New LoginVotante
        votar.Owner = Me
        votar.Show()
    End Sub
End Class
