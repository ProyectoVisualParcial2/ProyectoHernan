Imports System.Data
Imports System.Data.OleDb

Public Class MostrarResultados

    Private dbPath As String = "..\..\recinto1.mdb"
    Private strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private dsPesonas As DataSet
    Private dsPesonas2 As DataSet
    Private dsPesonas3 As DataSet
    Private dsVotos As DataSet
    Private dsVotos2 As DataSet
    Private dsVotos3 As DataSet

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Using conexion As New OleDbConnection(strConexion)

            Dim sumaPresidente As Integer = 0
            Dim sumaAsambleista As Integer = 0
            Dim sumaPrefecto As Integer = 0

            Dim consulta As String = "SELECT tblPersonas.Nombre, tblPersonas.Apellido FROM tblDignidades INNER JOIN (tblPersonas INNER JOIN tblCandidato ON tblPersonas.Id = tblCandidato.idPersona) ON tblDignidades.Id = tblCandidato.idDignidad WHERE tblCandidato.idDignidad=1;"
            Dim consulta2 As String = "SELECT tblPersonas.Nombre, tblPersonas.Apellido FROM tblDignidades INNER JOIN (tblPersonas INNER JOIN tblCandidato ON tblPersonas.Id = tblCandidato.idPersona) ON tblDignidades.Id = tblCandidato.idDignidad WHERE tblCandidato.idDignidad=2;"
            Dim consulta3 As String = "SELECT tblPersonas.Nombre, tblPersonas.Apellido FROM tblDignidades INNER JOIN (tblPersonas INNER JOIN tblCandidato ON tblPersonas.Id = tblCandidato.idPersona) ON tblDignidades.Id = tblCandidato.idDignidad WHERE tblCandidato.idDignidad=3;"
            Dim consulta4 As String = "SELECT * From tblCandidato Where idDignidad=1"
            Dim consulta5 As String = "SELECT tblCandidato.votos From tblCandidato Where idDignidad=2"
            Dim consulta6 As String = "SELECT tblCandidato.votos From tblCandidato Where idDignidad=3"
            'Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            Dim adapter2 As New OleDbDataAdapter(New OleDbCommand(consulta2, conexion))
            Dim adapter3 As New OleDbDataAdapter(New OleDbCommand(consulta3, conexion))
            Dim adapter4 As New OleDbDataAdapter(New OleDbCommand(consulta4, conexion))
            Dim adapter5 As New OleDbDataAdapter(New OleDbCommand(consulta5, conexion))
            Dim adapter6 As New OleDbDataAdapter(New OleDbCommand(consulta6, conexion))
            Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
            Dim personaCmdBuilder2 = New OleDbCommandBuilder(adapter2)
            Dim personaCmdBuilder3 = New OleDbCommandBuilder(adapter3)
            Dim personaCmdBuilder4 = New OleDbCommandBuilder(adapter4)
            Dim personaCmdBuilder5 = New OleDbCommandBuilder(adapter5)
            Dim personaCmdBuilder6 = New OleDbCommandBuilder(adapter6)
            dsPesonas = New DataSet("tblPersonas")
            dsPesonas2 = New DataSet("tblPersonas")
            dsPesonas3 = New DataSet("tblPersonas")
            dsVotos = New DataSet("tblCandidato")
            dsVotos2 = New DataSet("tblCandidato")
            dsVotos3 = New DataSet("tblCandidato")
            adapter.FillSchema(dsPesonas, SchemaType.Source)
            adapter.Fill(dsPesonas, "tblPersonas")
            adapter2.FillSchema(dsPesonas2, SchemaType.Source)
            adapter2.Fill(dsPesonas2, "tblPersonas")
            adapter3.FillSchema(dsPesonas3, SchemaType.Source)
            adapter3.Fill(dsPesonas3, "tblPersonas")
            adapter4.FillSchema(dsVotos, SchemaType.Source)
            adapter4.Fill(dsVotos, "tblCandidato")
            adapter5.FillSchema(dsVotos2, SchemaType.Source)
            adapter5.Fill(dsVotos2, "tblCandidato")
            adapter6.FillSchema(dsVotos3, SchemaType.Source)
            adapter6.Fill(dsVotos3, "tblCandidato")

            dataGridMosPresidentes.DataContext = dsPesonas
            dataGridMosAsambleistas.DataContext = dsPesonas2
            dataGridMosPrefectos.DataContext = dsPesonas3
            dataGridVotosPresidentes.DataContext = dsVotos
            dataGridVotosPrefectos.DataContext = dsVotos2
            dataGridVotosAsambleistas.DataContext = dsVotos3

            Dim numbar1 As Integer = -599
            Dim numbar2 As Integer = 235
            Dim numbar3 As Integer = -169

            For Each VotoPresidente As DataRow In dsVotos.Tables("tblCandidato").Rows
                sumaPresidente = sumaPresidente + VotoPresidente("votos")
            Next
            For Each VotoPresidente As DataRow In dsVotos.Tables("tblCandidato").Rows
                numbar1 += 38
                Dim porcentaje As Integer = CInt((VotoPresidente("votos") + 1) * 100 / sumaPresidente)
                Dim barra As New ProgressBar
                barra.Height = 10
                barra.Width = 150
                barra.Value = porcentaje
                barra.Margin = New Thickness(300, numbar1, 0, 0)
                gridVentana.Children.Add(barra)
                Dim lbl As New Label
                lbl.Content = porcentaje & "%"
                lbl.FontSize = 10
                lbl.HorizontalContentAlignment = HorizontalAlignment.Center
                lbl.VerticalContentAlignment = VerticalAlignment.Center
                lbl.Margin = New Thickness(300, numbar1, 0, 0)
                gridVentana.Children.Add(lbl)
            Next


            For Each VotoAsambleista As DataRow In dsVotos2.Tables("tblCandidato").Rows
                sumaAsambleista = sumaAsambleista + VotoAsambleista("votos")
            Next
            For Each VotoAsambleista As DataRow In dsVotos2.Tables("tblCandidato").Rows
                numbar2 += 38
                Dim porcentaje As Integer = CInt((VotoAsambleista("votos") + 1) * 100 / sumaAsambleista)
                Dim barra As New ProgressBar
                barra.Height = 10
                barra.Width = 150
                barra.Value = porcentaje
                barra.Margin = New Thickness(300, numbar2, 0, 0)
                gridVentana.Children.Add(barra)
                Dim lbl As New Label
                lbl.Content = porcentaje & "%"
                lbl.FontSize = 10
                lbl.HorizontalContentAlignment = HorizontalAlignment.Center
                lbl.VerticalContentAlignment = VerticalAlignment.Center
                lbl.Margin = New Thickness(300, numbar2, 0, 0)
                gridVentana.Children.Add(lbl)
            Next


            For Each VotoPrefecto As DataRow In dsVotos3.Tables("tblCandidato").Rows
                sumaPrefecto = sumaPrefecto + VotoPrefecto("votos")
            Next
            For Each VotoPrefecto As DataRow In dsVotos3.Tables("tblCandidato").Rows
                numbar3 += 38
                Dim porcentaje As Integer = CInt((VotoPrefecto("votos") + 1) * 100 / sumaPrefecto)
                Dim barra As New ProgressBar
                barra.Height = 10
                barra.Width = 150
                barra.Value = porcentaje
                barra.Margin = New Thickness(300, numbar3, 0, 0)
                gridVentana.Children.Add(barra)
                Dim lbl As New Label
                lbl.Content = porcentaje & "%"
                lbl.FontSize = 10
                lbl.HorizontalContentAlignment = HorizontalAlignment.Center
                lbl.VerticalContentAlignment = VerticalAlignment.Center
                lbl.Margin = New Thickness(300, numbar3, 0, 0)
                gridVentana.Children.Add(lbl)
            Next


        End Using
    End Sub

End Class
