'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Stimulsoft.Report

Public Class frm_ERetencion

#Region "Declaracion de Variables"

    Private olRetencion As l_DocumentoRetencion
    Private srReporte As StiReport
    Private dsDatos As DataSet
    Public mensajeEmergente As New c_Alertas

#End Region

#Region "Eventos"

    Private Sub frm_ERetencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "REPRESENTACION IMPRESA - " & ISL_Nombre
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub svcReporte_Close(sender As Object, e As EventArgs) Handles svcReporte.Close
        Me.Close()
    End Sub

#End Region

#Region "Metodos"

    Public Sub mt_CargarDatos(ls_IdDocumento As String)
        Try
            olRetencion = New l_DocumentoRetencion
            dsDatos = olRetencion.ImpresionElectronico(New e_DocumentoRetencion With {.TipoOperacion = "I", .Id = ls_IdDocumento})
            If dsDatos.Tables.Count > 0 Then
                dsDatos.Tables(0).TableName = "Cabecera_Pie"
                dsDatos.Tables(1).TableName = "Detalle"
            End If
            mt_CargarReporte("eRetencion.mrt")
            svcReporte.Report.Render()
            svcReporte.Zoom = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mt_CargarReporte(ls_NombreReporte As String)
        Try
            Dim ls_Moneda As String = "", ls_MontoLetra As String = "", ls_Hash As String = ""
            Dim ln_Retencion As Double = 0
            srReporte = New StiReport
            srReporte.Load(ISL_RutaImpresion & ls_NombreReporte)
            svcReporte.Report = srReporte
            srReporte.RegData(dsDatos)
            srReporte.Dictionary.Synchronize()
            ls_Moneda = dsDatos.Tables("Cabecera_Pie").Rows(0).Item("TXT_CATEGORIA_MONEDA").ToString.Trim
            ln_Retencion = Math.Round(dsDatos.Tables("Cabecera_Pie").Rows(0).Item("CAN_IMPUESTO_VTA"), 2)
            ls_MontoLetra = ConvertirNumeroALetras(ln_Retencion)
            ls_Hash = dsDatos.Tables("Cabecera_Pie").Rows(0).Item("TXT_SELLO_IMPRESION").ToString.Trim
            srReporte.Dictionary.Variables.Add("CAN_LETRAS", (ls_MontoLetra & " " & ls_Moneda).ToUpper)
            srReporte.Dictionary.Variables.Add("HASH", ls_Hash)
            srReporte.Compile()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class