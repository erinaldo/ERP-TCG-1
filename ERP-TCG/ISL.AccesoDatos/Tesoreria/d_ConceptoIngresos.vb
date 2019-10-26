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

Public Class d_ConceptoIngresos

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ConceptoIngresos
        Try
            Dim oeConceptoIngresos = New e_ConceptoIngresos( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeConceptoIngresos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConceptoIngresos As e_ConceptoIngresos) As e_ConceptoIngresos

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ConceptoIngresos_Listar", "", oeConceptoIngresos.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConceptoIngresos = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConceptoIngresos
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As List(Of e_ConceptoIngresos)
        Try
            Dim ldConceptoIngresos As New List(Of e_ConceptoIngresos)
            Dim ds As DataSet
            With oeConceptoIngresos
                ds = sqlhelper.ExecuteDataset("TES.Isp_ConceptoIngresos_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Activo _
                        , .IdProcesoNegocio)
            End With
            oeConceptoIngresos = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeConceptoIngresos = Cargar(o_Fila)
                    ldConceptoIngresos.Add(oeConceptoIngresos)
                Next
            End If
            Return ldConceptoIngresos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean
        Try
            With oeConceptoIngresos
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Nombre _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeConceptoIngresos.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

