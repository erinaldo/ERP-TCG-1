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

Public Class d_DetalleDocumentoCombustible
    Private sqlhelper As New SqlHelper
    'Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleDocumentoCombustible
    '    Try
    '        'Dim oeDetalleDocumentoCombustible = New e_DetalleDocumentoCombustible( _
    '        '                 o_Fila("Id").ToString _
    '        '                 , o_Fila("IdOperacion").ToString _
    '        '                 , o_Fila("IdVehiculo").ToString _
    '        '                 , o_Fila("IdMaterial").ToString _
    '        '                 , o_Fila("FechaTanqueo").ToString _
    '        '                 , o_Fila("IdEmpresaGrifo").ToString _
    '        '                 , o_Fila("NroLinea").ToString _
    '        '                 , o_Fila("Cantidad").ToString _
    '        '                 , o_Fila("PrecioUnit").ToString _
    '        '                 , o_Fila("SerieComprobante").ToString _
    '        '                 , o_Fila("NumeroComprobante").ToString _
    '        '                 , o_Fila("Igv").ToString _
    '        '                 , o_Fila("Valor").ToString _
    '        '                 , o_Fila("Activo").ToString _
    '        '                 , o_Fila("IndGravado").ToString _
    '        '                 , o_Fila("UsuarioCreacion").ToString _
    '        '                 , o_Fila("FechaCreacion").ToString _
    '        ')
    '        'Return oeDetalleDocumentoCombustible
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function Obtener(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As e_DetalleDocumentoCombustible

    '    Try
    '        
    '        Dim ds As DataSet
    '        ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", _
    '        Left(.PrefijoID, 1), "", oeDetalleDocumentoCombustible.Id)
    '        If ds.Tables(0).rows.Count > 0 Then
    '            oeDetalleDocumentoCombustible = Cargar(ds.Tables(0).Rows(0))
    '        End If
    '        Return oeDetalleDocumentoCombustible
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    'Public Function Listar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As List(Of e_DetalleDocumentoCombustible)
    '    Try
    '        
    '        Dim ldDetalleDocumentoCombustible As New List(Of e_DetalleDocumentoCombustible)
    '        Dim ds As DataSet
    '        With oeDetalleDocumentoCombustible
    '            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
    '    , Left(.PrefijoID, 1), "" _
    '                    , .Id _
    '                    , .IdViaje _
    '                    , .IdVehiculo _
    '                    , .IdMaterial _
    '                    , .FechaTanqueo _
    '                    , .IdEmpresaGrifo _
    '                    , .NroLinea _
    '                    , .Cantidad _
    '                    , .PrecioUnit _
    '                    , .Igv _
    '                    , .Valor _
    '                    , .Activo _
    '                    , .IndGravado _
    '                    , .UsuarioCreacion _
    '                    )
    '        End With
    '        oeDetalleDocumentoCombustible = Nothing
    '        If ds.Tables.Count > 0 Then
    '            For Each o_Fila As DataRow In ds.Tables(0).Rows
    '                oeDetalleDocumentoCombustible = Cargar(o_Fila)
    '                ldDetalleDocumentoCombustible.Add(oeDetalleDocumentoCombustible)
    '            Next
    '        End If
    '        Return ldDetalleDocumentoCombustible
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function Guardar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean
        Try
            With oeDetalleDocumentoCombustible
                sqlhelper.ExecuteNonQuery("CON.Isp_DetalleDocumentoCombustible_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdRegConsumoCombustible _
                        , .Cantidad _
                        , .NroLinea _
                        , .IdDetalleDocumento _
                        , .Activo _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeDetalleDocumentoCombustible.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
