Imports System.Data
Imports System.Data.OleDb

Public Class PrincipalVotante

    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsPesonas As DataSet
    Private dsPesonas2 As DataSet
    Private dsPesonas3 As DataSet
    Private dsCandidato As DataSet

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles dataGridPresidentes.Loaded
        Dim VenVotante As LoginVotante
        VenVotante = Me.Owner
        VenVotante.Hide()
        btnCerrar.IsEnabled = False
        dataGridAsambleistas.IsEnabled = False
        dataGridPrefectos.IsEnabled = False
        Using conexion As New OleDbConnection(strConexion)

            Dim consulta As String = "SELECT tblPersonas.Id, tblPersonas.Nombre, tblPersonas.Apellido FROM tblDignidades INNER JOIN (tblPersonas INNER JOIN tblCandidato ON tblPersonas.Id = tblCandidato.idPersona) ON tblDignidades.Id = tblCandidato.idDignidad WHERE tblCandidato.idDignidad=1;"
            Dim consulta2 As String = "SELECT tblPersonas.Id, tblPersonas.Nombre, tblPersonas.Apellido FROM tblDignidades INNER JOIN (tblPersonas INNER JOIN tblCandidato ON tblPersonas.Id = tblCandidato.idPersona) ON tblDignidades.Id = tblCandidato.idDignidad WHERE tblCandidato.idDignidad=2;"
            Dim consulta3 As String = "SELECT tblPersonas.Id, tblPersonas.Nombre, tblPersonas.Apellido FROM tblDignidades INNER JOIN (tblPersonas INNER JOIN tblCandidato ON tblPersonas.Id = tblCandidato.idPersona) ON tblDignidades.Id = tblCandidato.idDignidad WHERE tblCandidato.idDignidad=3;"
            'Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim adapter2 As New OleDbDataAdapter(New OleDbCommand(consulta2, conexion))
            Dim adapter3 As New OleDbDataAdapter(New OleDbCommand(consulta3, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            Dim personaCmdBuilder2 = New OleDbCommandBuilder(adapter2)
            Dim personaCmdBuilder3 = New OleDbCommandBuilder(adapter3)
            dsPesonas = New DataSet("tblPersonas")
            dsPesonas2 = New DataSet("tblPersonas")
            dsPesonas3 = New DataSet("tblPersonas")
            adapter.FillSchema(dsPesonas, SchemaType.Source)
            adapter.Fill(dsPesonas, "tblPersonas")
            adapter2.FillSchema(dsPesonas2, SchemaType.Source)
            adapter2.Fill(dsPesonas2, "tblPersonas")
            adapter3.FillSchema(dsPesonas3, SchemaType.Source)
            adapter3.Fill(dsPesonas3, "tblPersonas")

            dataGridPresidentes.DataContext = dsPesonas
            dataGridAsambleistas.DataContext = dsPesonas2
            dataGridPrefectos.DataContext = dsPesonas3

            Dim consultaCan As String = "Select * FROM tblCandidato;"
            Dim adapterCan As New OleDbDataAdapter(New OleDbCommand(consultaCan, conexion))
            Dim personaCmdBuilderCan = New OleDbCommandBuilder(adapterCan)
            dsCandidato = New DataSet("tblCandidato")
            adapterCan.FillSchema(dsCandidato, SchemaType.Source)

            adapterCan.Fill(dsCandidato, "tblCandidato")
        End Using
    End Sub

    Private Sub dataGridPresidentes_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dataGridPresidentes.SelectionChanged
        Dim fila As DataRowView = sender.SelectedItem
        Dim id As Integer = fila("Id")
        dataGridPresidentes.IsEnabled = False
        MsgBox("Usted ha votado por " & fila("Nombre") & " " & fila("Apellido"))
        dataGridAsambleistas.IsEnabled = True
        UpdateCandidato(id)
    End Sub
    Private Sub dataGridPrefectos_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dataGridPrefectos.SelectionChanged
        Dim fila As DataRowView = sender.SelectedItem
        Dim id As Integer = fila("Id")
        dataGridPrefectos.IsEnabled = False
        btnCerrar.IsEnabled = True
        MsgBox("Usted ha votado por " & fila("Nombre") & " " & fila("Apellido"))
        UpdateCandidato(id)
    End Sub
    Private Sub dataGridAsambleistas_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dataGridAsambleistas.SelectionChanged
        Dim fila As DataRowView = sender.SelectedItem
        Dim id As Integer = fila("Id")
        dataGridAsambleistas.IsEnabled = False
        dataGridPrefectos.IsEnabled = True
        MsgBox("Usted ha votado por " & fila("Nombre") & " " & fila("Apellido"))
        UpdateCandidato(id)
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim venVotante As LoginVotante
        venVotante = Me.Owner
        venVotante.Show()
        venVotante.txtCedula.Text = ""

    End Sub


    Public Sub UpdateCandidato(id As Integer)

        For Each persona As DataRow In Me.dsCandidato.Tables("tblCandidato").Rows
            If persona("idPersona") = id Then
                persona("votos") += 1
            End If
        Next

        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "Select * FROM tblCandidato;"
            'Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            'adapter.FillSchema(dsPersonas, SchemaType.Source)
            Try
                adapter.Update(dsCandidato.Tables("tblCandidato"))
            Catch ex As Exception
                MessageBox.Show("Error al guardar")
            End Try

        End Using

    End Sub

End Class
