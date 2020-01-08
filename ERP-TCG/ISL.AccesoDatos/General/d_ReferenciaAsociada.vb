
Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ReferenciaAsociada

    Private sqlhelper As New SqlHelper

    Public Function Obtener(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As e_ReferenciaAsociada
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ReferenciaAsociada_Listar", oeReferenciaAsociada.TipoOperacion, oeReferenciaAsociada.Id, oeReferenciaAsociada.IdTablaPrincipal)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReferenciaAsociada = New e_ReferenciaAsociada With {.Id = o_Fila("Id").ToString,
                       .IdEmpresaSis = o_Fila("IdEmpresaSis").ToString, .IdSucursal = o_Fila("IdSucursal").ToString,
                       .IdTablaPrincipal = o_Fila("IdTablaPrincipal").ToString, .IdTablaAsociada = o_Fila("IdTablaAsociada").ToString,
                       .TipoRelacion = o_Fila("Tipo"), .Glosa = o_Fila("Glosa").ToString}
                Next
            End If
            Return oeReferenciaAsociada
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As List(Of e_ReferenciaAsociada)
        Try
            Dim ldReferenciaAsociada As New List(Of e_ReferenciaAsociada)
            Dim ds As DataSet
            With oeReferenciaAsociada
                ds = sqlhelper.ExecuteDataset("STD.Isp_ReferenciaAsociada_Listar", .Id, .IdEmpresaSis, .IdSucursal, .IdTablaPrincipal, .IdTablaAsociada)
            End With
            oeReferenciaAsociada = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReferenciaAsociada = New e_ReferenciaAsociada With {.Id = o_Fila("Id").ToString,
                        .IdEmpresaSis = o_Fila("IdEmpresaSis").ToString, .IdSucursal = o_Fila("IdSucursal").ToString,
                        .IdTablaPrincipal = o_Fila("IdTablaPrincipal").ToString, .IdTablaAsociada = o_Fila("IdTablaAsociada").ToString,
                        .TipoRelacion = o_Fila("Tipo")}
                    ldReferenciaAsociada.Add(oeReferenciaAsociada)
                Next
            End If
            Return ldReferenciaAsociada
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeReferenciaAsociada As e_ReferenciaAsociada) As Boolean
        Try
            Dim stResultado() As String

            With oeReferenciaAsociada
                stResultado = sqlhelper.ExecuteScalar("STD.Isp_ReferenciaAsociada_IAE", .TipoOperacion, .PrefijoID, .Id,
                        .IdEmpresaSis, .IdSucursal, .IdTablaPrincipal, .IdTablaAsociada, .TipoRelacion, .Glosa, .UsuarioCreacion).ToString.Split("_")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
