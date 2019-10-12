'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteGrupoSancion

    Private Sub frm_ReporteGrupoSancion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Me.rptGrupoSancion.RefreshReport()
        Me.rptGrupoSancion.RefreshReport()
    End Sub

    Private Function CrearDTDetalleGrupo() As Data.DataTable
        Dim DetalleGrup As New Data.DataTable
        With DetalleGrup
            .Columns.Add(New Data.DataColumn("Fecha", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Trabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Concepto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Double")))
        End With
        Return DetalleGrup
    End Function

    Public Sub CargarDetalleInforme(ByVal oeGrupo As e_GrupoSancion)

        Try

            Dim dtDetalle As DataTable = CrearDTDetalleGrupo()
            For Each oeDetalle As e_Sancion In oeGrupo.leDetalle

                Dim rwDetalle As Data.DataRow
                rwDetalle = dtDetalle.NewRow

                rwDetalle("Fecha") = oeDetalle.Fecha
                rwDetalle("Trabajador") = oeDetalle.Trabajador
                rwDetalle("Concepto") = oeDetalle.Concepto
                rwDetalle("Glosa") = oeDetalle.Glosa
                rwDetalle("Monto") = oeDetalle.Monto
                dtDetalle.Rows.Add(rwDetalle)

            Next

            'Procesa los datos de Informe
            Me.rptGrupoSancion.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.rptGrupoSancion.Visible = True
            Dim oReport As New ReportDataSource("dsDetalleGrupoSancion_DetalleGrupoSancion", dtDetalle)

            'Parámetros de la cabecera de Informe
            Dim parametros As New List(Of ReportParameter)
            parametros.Add(New ReportParameter("NombreEmpresa", ISL_Nombre, False))
            parametros.Add(New ReportParameter("CodigoGrupo", oeGrupo.Codigo, False))
            parametros.Add(New ReportParameter("Glosa", oeGrupo.Glosa, False))

            'Proceso de generación de la factura
            Me.rptGrupoSancion.LocalReport.DataSources.Clear()
            Me.rptGrupoSancion.LocalReport.DataSources.Add(oReport)

            Me.rptGrupoSancion.LocalReport.SetParameters(parametros)

            Me.rptGrupoSancion.LocalReport.Refresh()
            Me.rptGrupoSancion.RefreshReport()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub



End Class