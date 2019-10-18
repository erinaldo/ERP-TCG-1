'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConceptoGasto
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ConceptoGasto
        Try
            Dim oeConceptoGasto = New e_ConceptoGasto( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeConceptoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConceptoGasto As e_ConceptoGasto) As e_ConceptoGasto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ConceptoGasto_Listar]", "", oeConceptoGasto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConceptoGasto = Cargar(ds.Tables(0).Rows(0))
                Return oeConceptoGasto
            Else
                oeConceptoGasto = New e_ConceptoGasto
                Return oeConceptoGasto
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptoGasto As e_ConceptoGasto) As List(Of e_ConceptoGasto)
        Try
            Dim ldConceptoGasto As New List(Of e_ConceptoGasto)
            Dim ds As DataSet
            With oeConceptoGasto
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ConceptoGasto_Listar]", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        )
            End With
            oeConceptoGasto = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeConceptoGasto = Cargar(o_Fila)
                    ldConceptoGasto.Add(oeConceptoGasto)
                Next
                Return ldConceptoGasto
            Else
                ldConceptoGasto = New List(Of e_ConceptoGasto)
                Return ldConceptoGasto
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean
        Try
            With oeConceptoGasto
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
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

    Public Function Eliminar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeConceptoGasto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaConceptoGasto As List(Of e_ConceptoGasto))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_ConceptoGasto In ListaConceptoGasto
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function
End Class

