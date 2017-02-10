Imports System.Data.OleDb
Imports System.Data

Public Class VentanaDignidad

    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsDignidades As DataSet

    Private Sub btnCerrar_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrar.Click
        Me.Owner.Show()
        Me.Close()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Using conexion As New OleDbConnection(strConexion)

            Dim consulta As String = "Select * FROM tblDignidades;"

            'Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            dsDignidades = New DataSet("tblDignidades")
            adapter.FillSchema(dsDignidades, SchemaType.Source)

            adapter.Fill(dsDignidades, "tblDignidades")

            dataGrid1.DataContext = dsDignidades
        End Using
    End Sub

    Public Sub UpdatePersona(id As Integer, nombre As String)
        If id = 0 Then
            Me.dsDignidades.Tables("tblDignidades").Rows.Add(id, nombre)

        End If

        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "Select * FROM tblDignidades;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)

            Try
                adapter.Update(dsDignidades.Tables("tblDignidades"))
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
        If (txtNombre.Text = "") Then
            MsgBox("Llenar el campo")
        Else
            UpdatePersona(id, txtNombre.Text)
            MsgBox("Dignidad Guardada")
        End If
    End Sub
End Class
