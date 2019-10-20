'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class d_TipoEmpresa
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoEmpresa
        Try
            Dim oeTipoEmpresa = New e_TipoEmpresa( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeTipoEmpresa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoEmpresa As e_TipoEmpresa) As e_TipoEmpresa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_TipoEmpresa_Listar", "", oeTipoEmpresa.Id)
            If ds.Tables.Count > 0 Then
                oeTipoEmpresa = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoEmpresa
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoEmpresa As e_TipoEmpresa) As List(Of e_TipoEmpresa)
        Try
            Dim ldTipoEmpresa As New List(Of e_TipoEmpresa)
            Dim ds As DataSet
            With oeTipoEmpresa
                ds = sqlhelper.ExecuteDataset("STD.Isp_TipoEmpresa_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeTipoEmpresa = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoEmpresa = Cargar(o_Fila)
                    ldTipoEmpresa.Add(oeTipoEmpresa)
                Next
                Return ldTipoEmpresa
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoEmpresa As e_TipoEmpresa) As Boolean
        Try
            With oeTipoEmpresa
                sqlhelper.ExecuteNonQuery("STD.Isp_TipoEmpresa_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
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

    Public Function Eliminar(ByVal oeTipoEmpresa As e_TipoEmpresa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_TipoEmpresa_IAE", "E", _
             "", oeTipoEmpresa.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
