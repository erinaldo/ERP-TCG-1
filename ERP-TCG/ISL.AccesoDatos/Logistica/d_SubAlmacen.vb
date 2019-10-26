'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions


Public Class d_SubAlmacen
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_SubAlmacen
        Try
            Dim oeSubAlmacen = New e_SubAlmacen( _
                             o_fila("Id").ToString _
                             , o_fila("Seleccion") _
                             , o_fila("Codigo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Referencia").ToString _
            )
            Return oeSubAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarW(ByVal o_fila As DataRow) As e_SubAlmacen
        Try
            Dim oeSubAlmacen = New e_SubAlmacen( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdAlmacen").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdEquipo").ToString _
                             , o_fila("IdGrifo").ToString _
                             , o_fila("IdDireccionGrifo").ToString _
                             , o_fila("IndPrincipal").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("Descripcion").ToString)

            Return oeSubAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSubAlmacen As e_SubAlmacen) As e_SubAlmacen
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("[ALM].[Isp_SubAlmacen_Listar]", oeSubAlmacen.TipoOperacion,
                                          oeSubAlmacen.Id,
                                          oeSubAlmacen.Codigo,
                                          oeSubAlmacen.IdAlmacen,
                                          oeSubAlmacen.Activo,
                                          oeSubAlmacen.UsuarioCreacion,
                                          oeSubAlmacen.IdEquipo,
                                          oeSubAlmacen.IdGrifo,
                                          oeSubAlmacen.IdDireccion,
                                          oeSubAlmacen.IdTrabajador,
                                          oeSubAlmacen.IdArea,
                                          oeSubAlmacen.TipoReferencia,
                                          oeSubAlmacen.IdOrdenAsignacion,
                                          oeSubAlmacen.IndPrincipal)
            oeSubAlmacen = New e_SubAlmacen
            If Not ds Is Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSubAlmacen = CargarW(ds.Tables(0).Rows(0))
            End If
            Return oeSubAlmacen
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    
    Public Function Listar_(ByVal oeSubAlmacen As e_SubAlmacen) As List(Of e_SubAlmacen)
        Try
            Dim ldSubAlmacen As New List(Of e_SubAlmacen)
            Dim ds As DataSet
            With oeSubAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_SubAlmacen_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdAlmacen _
                        , .Activo _
                        )
            End With
            oeSubAlmacen = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeSubAlmacen = Cargar(o_Fila)
                    ldSubAlmacen.Add(oeSubAlmacen)
                Next
                Return ldSubAlmacen
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSubAlmacen As e_SubAlmacen) As List(Of e_SubAlmacen)
        Try
            Dim ldSubAlmacen As New List(Of e_SubAlmacen)
            Dim ds As DataSet
            With oeSubAlmacen
                ds = sqlhelper.ExecuteDataset("ALM.Isp_SubAlmacen_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdAlmacen _
                        , .Activo _
                        )
            End With
            oeSubAlmacen = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeSubAlmacen = CargarW(o_Fila)
                    ldSubAlmacen.Add(oeSubAlmacen)
                Next
                Return ldSubAlmacen
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeSubAlmacen As e_SubAlmacen) As Boolean
        Try
            With oeSubAlmacen
                sqlhelper.ExecuteNonQuery("[ALM].[Isp_SubAlmacen_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .IdAlmacen _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IdEquipo _
                        , .IdGrifo _
                        , .IdDireccion _
                        , .IdTrabajador _
                        , .IdArea _
                        , .TipoReferencia _
                        , .Descripcion, .Referencia)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeSubAlmacen As e_SubAlmacen)
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_SubAlmacen In Listar_(oeSubAlmacen)
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Descripcion
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function
    
End Class

