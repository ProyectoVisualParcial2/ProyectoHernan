Imports System.Data
Imports System.Data.OleDb

Public Class LoginVotante
    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsVotante As New DataSet
    Dim estado As Boolean

    Private Sub btnIni_Click(sender As Object, e As RoutedEventArgs) Handles btnIni.Click
        estado = False
        Using conexion As New OleDbConnection(strConexion)

            Dim VenVotante As New PrincipalVotante

            Dim consultaVot As String = "Select * FROM tblVotante;"
            Dim adapterVot As New OleDbDataAdapter(New OleDbCommand(consultaVot, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapterVot)
            dsVotante = New DataSet("tblVotante")
            adapterVot.FillSchema(dsVotante, SchemaType.Source)
            adapterVot.Fill(dsVotante, "tblVotante")

            For Each votante As DataRow In Me.dsVotante.Tables("tblVotante").Rows

                If Me.txtCedula.Text = votante("cedula") Then
                    If votante("sufragio") = True Then
                        MsgBox("Este usuario ya votó")
                        estado = True
                    Else
                        VenVotante.Owner = Me
                        VenVotante.Show()
                        estado = True
                        Dim id As Integer = votante("Id")
                        UpdateVotante(id)
                    End If
                    
                End If
            Next
            If estado = False Then
                MsgBox("Cédula no existe")
            End If
        End Using



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

    Private Sub UpdateVotante(id As Integer)
        For Each persona As DataRow In Me.dsVotante.Tables("tblVotante").Rows
            If persona("Id") = id Then
                persona("sufragio") = True
            End If
        Next

        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "Select * FROM tblVotante;"

            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)

            Try
                adapter.Update(dsVotante.Tables("tblVotante"))
            Catch ex As Exception
                MessageBox.Show("Error al guardar")
            End Try

        End Using
    End Sub

End Class
