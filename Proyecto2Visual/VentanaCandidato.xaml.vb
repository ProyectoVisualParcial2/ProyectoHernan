Imports System.Data.OleDb
Imports System.Data

Public Class VentanaCandidato

    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsPersonas As DataSet
    Private dsCandidato As DataSet

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrar.Click
        Me.Owner.Show()
        Me.Close()
    End Sub

    Public Sub UpdatePersona(id As Integer, nombre As String, apellido As String, edad As Integer, usuario As String, clave As String, dignidades As String)
        Dim rol As String = "candidato"

        If id = 0 Then
            If dignidades = "presidente" Then
                Me.dsPersonas.Tables("tblPersonas").Rows.Add(id, nombre, apellido, edad, rol)
                Dim idPer = Me.dsPersonas.Tables("tblPersonas").Rows.Count + 14
                Me.dsCandidato.Tables("tblCandidato").Rows.Add(id, usuario, clave, 1, idPer, 0)
            End If
            If dignidades = "asambleista" Then
                Me.dsPersonas.Tables("tblPersonas").Rows.Add(id, nombre, apellido, edad, rol)
                Dim idPer = Me.dsPersonas.Tables("tblPersonas").Rows.Count + 14
                Me.dsCandidato.Tables("tblCandidato").Rows.Add(id, usuario, clave, 2, idPer, 0)
            End If
            If dignidades = "prefecto" Then
                Me.dsPersonas.Tables("tblPersonas").Rows.Add(id, nombre, apellido, edad, rol)
                Dim idPer = Me.dsPersonas.Tables("tblPersonas").Rows.Count + 14
                Me.dsCandidato.Tables("tblCandidato").Rows.Add(id, usuario, clave, 3, idPer, 0)
            End If
        End If

        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "Select * FROM tblPersonas;"
            'Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            'adapter.FillSchema(dsPersonas, SchemaType.Source)

            Dim consultaCan As String = "Select * FROM tblCandidato;"
            'Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim adapterCan As New OleDbDataAdapter(New OleDbCommand(consultaCan, conexion))
            Dim personaCmdBuilderCan = New OleDbCommandBuilder(adapterCan)
            'adapter.FillSchema(dsPersonas, SchemaType.Source)

            Try
                adapter.Update(dsPersonas.Tables("tblPersonas"))
                adapterCan.Update(dsCandidato.Tables("tblCandidato"))
            Catch ex As Exception
                MessageBox.Show("Error al guardar")
            End Try

        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As RoutedEventArgs) Handles btnGuardar.Click
        Dim id = 0
        Try
            id = Me.DataContext.Id()
        Catch ex As Exception

        End Try
        If (txtNombre.Text = "" Or txtApellido.Text = "" Or txtEdad.Text = "" Or txtUsuario.Text = "" Or txtClave.Text = "" Or cbxDignidad.Text = "") Then
            MsgBox("Llenar Todos los campos")
        Else
            UpdatePersona(id, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtUsuario.Text, txtClave.Text, cbxDignidad.Text)
            MsgBox("Guardado Con exito")
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Using conexion As New OleDbConnection(strConexion)

            Dim consulta As String = "Select * FROM tblPersonas;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            dsPersonas = New DataSet("tblPersonas")
            adapter.FillSchema(dsPersonas, SchemaType.Source)

            adapter.Fill(dsPersonas, "tblPersonas")

            dataGridPersona.DataContext = dsPersonas

            Dim consultaCan As String = "Select * FROM tblCandidato;"
            Dim adapterCan As New OleDbDataAdapter(New OleDbCommand(consultaCan, conexion))
            Dim personaCmdBuilderCan = New OleDbCommandBuilder(adapterCan)
            dsCandidato = New DataSet("tblCandidato")
            adapterCan.FillSchema(dsCandidato, SchemaType.Source)

            adapterCan.Fill(dsCandidato, "tblCandidato")

            dataGridCandidato.DataContext = dsCandidato
        End Using
    End Sub
End Class
