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

Public Class d_ModalidadContrato
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ModalidadContrato
        Try
            Dim oeModalidadContrato = New e_ModalidadContrato(o_fila("Id").ToString _
                                                              , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString)
            Return oeModalidadContrato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeModalidadContrato As e_ModalidadContrato) As List(Of e_ModalidadContrato)
        Try
            Dim ldModalidadContrato As New List(Of e_ModalidadContrato)
            Dim ds As DataSet
            With oeModalidadContrato
                ds = sqlhelper.ExecuteDataset("PER.Isp_ModalidadContrato_Listar", "")
            End With
            oeModalidadContrato = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeModalidadContrato = Cargar(o_Fila)
                ldModalidadContrato.Add(oeModalidadContrato)
            Next
            Return ldModalidadContrato
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
