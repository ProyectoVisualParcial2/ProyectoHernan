Public Class PrincipalCandidato

    Private _variable As Integer
    Public Property Variable() As Integer
        Get
            Return _variable
        End Get
        Set(ByVal value As Integer)
            _variable = value
        End Set
    End Property



    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim princ As MainWindow
        princ = Me.Owner
        princ.Hide()
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As RoutedEventArgs) Handles btnResultados.Click
        Dim mostrar As New MostrarResultadosCan
        mostrar.Variable = Variable
        mostrar.Owner = Me
        mostrar.Show()
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim venMain As MainWindow
        venMain = Me.Owner
        venMain.txtUsuario.Text = "Ingrese un usuario..."
        venMain.txtPass.Password = ""
        venMain.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim venMain As MainWindow
        venMain = Me.Owner
        venMain.txtUsuario.Text = "Ingrese un usuario..."
        venMain.txtPass.Password = ""
        venMain.Show()
        Me.Close()
    End Sub
End Class
