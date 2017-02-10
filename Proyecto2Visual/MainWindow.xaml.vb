Imports System.Data
Imports System.Data.OleDb

Class MainWindow

    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsAdministrador As New DataSet
    Private dsCandidato As New DataSet
    Dim estado As Boolean
    Dim idCandidato As Integer

    Private Sub btnIni_Click(sender As Object, e As RoutedEventArgs) Handles btnIni.Click
        estado = False
        Using conexion As New OleDbConnection(strConexion)
            Dim VenAdministrador As New PrincipalAdministrador
            Dim VenCandidato As New PrincipalCandidato

            Dim consulta As String = "Select * FROM tblAdministrador;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            dsAdministrador = New DataSet("tblAdministrador")
            adapter.FillSchema(dsAdministrador, SchemaType.Source)
            adapter.Fill(dsAdministrador, "tblAdministrador")

            Dim consultaCan As String = "Select * FROM tblCandidato;"
            Dim adapterCan As New OleDbDataAdapter(New OleDbCommand(consultaCan, conexion))
            Dim personaCmdBuilderCan = New OleDbCommandBuilder(adapterCan)
            dsCandidato = New DataSet("tblCandidato")
            adapterCan.FillSchema(dsCandidato, SchemaType.Source)
            adapterCan.Fill(dsCandidato, "tblCandidato")

            For Each persona As DataRow In Me.dsAdministrador.Tables("tblAdministrador").Rows

                If Me.txtUsuario.Text = persona("usuario") And Me.txtPass.Password = persona("clave") Then
                    VenAdministrador.Owner = Me
                    VenAdministrador.Show()
                    estado = True
                End If
            Next

            For Each candidato As DataRow In Me.dsCandidato.Tables("tblCandidato").Rows

                If txtUsuario.Text = candidato("usuario") And txtPass.Password = candidato("clave") Then
                    VenCandidato.Variable = Integer.Parse(candidato("idDignidad"))
                    VenCandidato.Owner = Me
                    VenCandidato.Show()
                    estado = True



                End If
            Next
            If estado = False Then
                MsgBox("Usuario o Contraseña Incorrecta")
            End If

        End Using



    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtUsuario.GotFocus
        If txtUsuario.Text = "Ingrese un usuario..." Then
            txtUsuario.Text = ""
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtUsuario.LostFocus
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "Ingrese un usuario..."
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim VenPrincipal As Principal
        VenPrincipal = Me.Owner
        VenPrincipal.Hide()
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim VenPrincipal As Principal
        VenPrincipal = Me.Owner
        VenPrincipal.Show()
    End Sub




End Class
