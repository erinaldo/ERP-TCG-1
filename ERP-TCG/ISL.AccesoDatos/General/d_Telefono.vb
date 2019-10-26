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


Public Class d_Telefono
    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_Telefono
        Try
            Dim oeTelefono = New e_Telefono( _
                             o_fila("Id").ToString _
                             , o_fila("Tipo") _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("CodigoLargaDistancia").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Principal") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            oeTelefono.IdOperadorTelefonico = o_fila("IdOperadorTelefonico").ToString
            Return oeTelefono
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTelefono As e_Telefono) As e_Telefono
        Try
            Dim ds As DataSet
            With oeTelefono
                ds = sqlhelper.ExecuteDataset("STD.Isp_Telefono_Listar", "", .Id, .Tipo, .TipoPersonaEmpresa,
                                              .IdPersonaEmpresa, .CodigoLargaDistancia, .Nombre, .Principal, .UsuarioCreacion, .Activo)
            End With
            oeTelefono = New e_Telefono
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTelefono = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTelefono
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTelefono As e_Telefono) As List(Of e_Telefono)
        Try
            Dim ldTelefonoMovil As New List(Of e_Telefono)
            Dim ds As DataSet
            With oeTelefono
                ds = sqlhelper.ExecuteDataset("STD.Isp_Telefono_Listar", .TipoOperacion _
                        , .Id _
                        , .Tipo _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .CodigoLargaDistancia _
                        , .Nombre _
                        , .Principal _
                        , .UsuarioCreacion _
                        , .Activo
                        )
            End With
            oeTelefono = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTelefono = Cargar(o_Fila)
                    ldTelefonoMovil.Add(oeTelefono)
                Next
                Return ldTelefonoMovil
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTelefono As e_Telefono) As Boolean
        Try
            With oeTelefono
                sqlhelper.ExecuteNonQuery("STD.Isp_Telefono_IAE", .TipoOperacion _
                        , .Id _
                        , .Tipo _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .CodigoLargaDistancia _
                        , .Nombre _
                        , .Principal _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                        , .IdOperadorTelefonico
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeTelefono As e_Telefono) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Telefono_IAE", "E", oeTelefono.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
