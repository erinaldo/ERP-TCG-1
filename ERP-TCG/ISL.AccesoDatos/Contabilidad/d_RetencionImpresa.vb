'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RetencionImpresa
    Private sqlhelper As New SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_RetencionImpresa
        Try
            Dim oeRetencion = New e_RetencionImpresa(o_fila("IdDocRet"), o_fila("1"), o_fila("2"), o_fila("3"), o_fila("4"), o_fila("5"), o_fila("6"), _
                                                     o_fila("7"), o_fila("8"), o_fila("9"), o_fila("10"), o_fila("11"), o_fila("12"), o_fila("13"), _
                                                     o_fila("14"), o_fila("15"), o_fila("16"), o_fila("17"), o_fila("18"), o_fila("19"), o_fila("20"), _
                                                     o_fila("21"), o_fila("22"), o_fila("23"), o_fila("24"), o_fila("25"), o_fila("26"), o_fila("27"), o_fila("Id"))
            Return oeRetencion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oe As e_RetencionImpresa) As List(Of e_RetencionImpresa)
        Try
            Dim lo As New List(Of e_RetencionImpresa)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_Retencion_Listar]", "", .Fecha)
            End With
            oe = New e_RetencionImpresa
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oe = Cargar(o_Fila)
                    lo.Add(oe)
                Next
            End If
            Return lo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(lo As List(Of e_RetencionImpresa)) As Boolean
        Try
            Dim oeRetDoc As e_DocumentoRetencion
            Dim odRetDoc As New d_DocumentoRetencion
            Using transScope As New TransactionScope()
                For Each oe As e_RetencionImpresa In lo
                    oeRetDoc = New e_DocumentoRetencion
                    oeRetDoc.PrefijoID = oe.PrefijoID '@0001
                    oeRetDoc.TipoOperacion = "T"
                    oeRetDoc.Id = oe.IdDocRet
                    oeRetDoc.FechaEmision = Date.Parse("01/01/1901")
                    odRetDoc.Guardar(oeRetDoc)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
