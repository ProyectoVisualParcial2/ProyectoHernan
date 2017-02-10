Imports System.Data
Imports System.Data.OleDb

Public Class PrincipalAdministrador
    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsPersonas As DataSet

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim princ As MainWindow
        princ = Me.Owner
        princ.Hide()
    End Sub

    Private Sub btnDignidad_Click(sender As Object, e As RoutedEventArgs) Handles btnDignidad.Click
        Dim VenDignidad As New VentanaDignidad
        VenDignidad.Owner = Me
        VenDignidad.Show()
    End Sub

    Private Sub btnCandidato_Click(sender As Object, e As RoutedEventArgs) Handles btnCandidato.Click
        Dim VenCandidato As New VentanaCandidato
        VenCandidato.Owner = Me
        VenCandidato.Show()
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim princ As MainWindow
        princ = Me.Owner
        princ.Show()
        princ.txtUsuario.Text = "Ingrese un usuario..."
        princ.txtPass.Password = ""
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As RoutedEventArgs) Handles btnResultados.Click
        Dim ventanaResultados As New MostrarResultados
        ventanaResultados.Owner = Me
        ventanaResultados.Show()
    End Sub
End Class