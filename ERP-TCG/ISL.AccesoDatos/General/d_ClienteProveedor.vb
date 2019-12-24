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

Public Class d_ClienteProveedor

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ClienteProveedor
        Try
            Dim oeClienteProveedor = New e_ClienteProveedor( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("TipoClienteProveedor").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Comisionista").ToString _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("FechaActividad").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IndCategoriaSGI").ToString)
            Return oeClienteProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeClienteProveedor As e_ClienteProveedor) As e_ClienteProveedor

        Try
            Dim ds As DataSet
            With oeClienteProveedor
                ds = sqlhelper.ExecuteDataset("STD.Isp_ClienteProveedor_Listar", _
                                              "" _
                                            , .Id _
                                            , .Codigo _
                                            , -1 _
                                            , -1 _
                                            , -1 _
                                            , .TipoPersonaEmpresa _
                                            , .IdPersonaEmpresa)
            End With

            If ds.Tables(0).rows.Count > 0 Then
                oeClienteProveedor = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeClienteProveedor
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeClienteProveedor As e_ClienteProveedor) As List(Of e_ClienteProveedor)
        Try
            Dim ldClienteProveedor As New List(Of e_ClienteProveedor)
            Dim ds As DataSet
            With oeClienteProveedor
                ds = sqlhelper.ExecuteDataset("STD.Isp_ClienteProveedor_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Cliente _
                        , .Proveedor _
                        , .Comisionista _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .FechaActividad _
                        , .FechaCreacion _
                        , .UsuarioCreacion)
            End With
            oeClienteProveedor = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeClienteProveedor = Cargar(o_Fila)
                ldClienteProveedor.Add(oeClienteProveedor)
            Next
            Return ldClienteProveedor
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByRef oeClienteProveedor As e_ClienteProveedor) As Boolean
        Try
            Dim IdClieProv As String = ""
            With oeClienteProveedor
                IdClieProv = sqlhelper.ExecuteScalar("STD.Isp_ClienteProveedor_IAE", _
                                                     .TipoOperacion, _
                                                     .PrefijoID, _
                                                    .Id _
                                                    , .Codigo _
                                                    , .Cliente _
                                                    , .Proveedor _
                                                    , .Comisionista _
                                                    , .TipoPersonaEmpresa _
                                                    , .IdPersonaEmpresa _
                                                    , .FechaActividad _
                                                    , .FechaCreacion _
                                                    , .UsuarioCreacion _
                                                    , .IndCategoriaSGI)

                .Id = IdClieProv
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    Public Function Eliminar(ByVal oeClienteProveedor As e_ClienteProveedor) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ClienteProveedor_IAE", _
                                      "E", _
                                       "", _
                                       oeClienteProveedor.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
