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


Public Class d_MenuItem

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuItem
        Try
            Dim oeMenuItem = New e_MenuItem( _
                             o_fila("Id").ToString _
                             , o_fila("IdMenuGrupo").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Orden").ToString _
                             , o_fila("Protegido").ToString _
            )
            Return oeMenuItem
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuItem As e_MenuItem) As e_MenuItem

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.Isp_MenuItem_Listar", "", oeMenuItem.Id)
            If ds.Tables.Count > 0 Then
                oeMenuItem = Cargar(ds.Tables(0).Rows(0))
                Return oeMenuItem
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuItem As e_MenuItem) As List(Of e_MenuItem)
        Try
            Dim ld As New List(Of e_MenuItem)
            Dim ds As DataSet
            With oeMenuItem
                ds = SqlHelper.ExecuteDataset("SGD.Isp_MenuItem_Listar", "" _
                        , .Id _
                        , .IdMenuGrupo _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
                        )
            End With
            oeMenuItem = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuItem = Cargar(o_Fila)
                    ld.Add(oeMenuItem)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeMenuItem As e_MenuItem) As Boolean
        Try
            With oeMenuItem
                sqlhelper.ExecuteNonQuery("SGD.Isp_MenuItem_IAE", .TipoOperacion,
                        .Id _
                        , .IdMenuGrupo _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMenuItem As e_MenuItem) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SGD.Isp_MenuItem_IAE", "E", _
             "", oeMenuItem.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
