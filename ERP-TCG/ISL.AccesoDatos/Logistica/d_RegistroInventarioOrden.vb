Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RegistroInventarioOrden
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_RegistroInventarioOrden
        Try
            Dim oeRegistroInventarioOrden = New e_RegistroInventarioOrden( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdRegistroInventario").ToString _
                             , o_Fila("IdOrden").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
            )
            Return oeRegistroInventarioOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroInventarioOrden As e_RegistroInventarioOrden) As e_RegistroInventarioOrden

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_RegistroInventarioOrden_Listar", "", oeRegistroInventarioOrden.Id)
            If ds.Tables.Count > 0 Then
                oeRegistroInventarioOrden = Cargar(ds.Tables(0).Rows(0))
                Return oeRegistroInventarioOrden
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroInventarioOrden As e_RegistroInventarioOrden) As List(Of e_RegistroInventarioOrden)
        Try
            Dim ldRegistroInventarioOrden As New List(Of e_RegistroInventarioOrden)
            Dim ds As DataSet
            With oeRegistroInventarioOrden
                ds = sqlhelper.ExecuteDataset("ALM.Isp_RegistroInventarioOrden_Listar", "" _
                        , .Id _
                        , .IdRegistroInventario _
                        , .IdOrden _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        )
            End With
            oeRegistroInventarioOrden = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRegistroInventarioOrden = Cargar(o_Fila)
                    ldRegistroInventarioOrden.Add(oeRegistroInventarioOrden)
                Next
                Return ldRegistroInventarioOrden
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistroInventarioOrden As e_RegistroInventarioOrden) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRegistroInventarioOrden
                sqlhelper.ExecuteNonQuery("ALM.Isp_RegistroInventarioOrden_IAE", .TipoOperacion, .PrefijoID, _
                        .Id, .IdRegistroInventario, .IdOrden, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistroInventarioOrden As e_RegistroInventarioOrden) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_RegistroInventarioOrden_IAE", "E", _
             "", oeRegistroInventarioOrden.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
