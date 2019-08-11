Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleOrdenNeumatico

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleOrdenNeumatico
        Try
            Dim oeDetalleOrdenNeumatico = New e_DetalleOrdenNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdOrdenMaterial").ToString _
                             , o_fila("IdNeumatico").ToString _
                             , o_fila("FechaOrden") _
                             , o_fila("NroOrden").ToString _
                             , o_fila("CodNeumatico").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Confirmacion").ToString _
                             , o_fila("FechaConfirmacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDetalleOrdenNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleOrdenNeumatico As e_DetalleOrdenNeumatico) As e_DetalleOrdenNeumatico

        Try
            Dim ds As DataSet

            With oeDetalleOrdenNeumatico
                ds = sqlhelper.ExecuteDataset("ALM.Isp_DetalleOrdenNeumatico_Listar", .TipoOperacion, .Id)
            End With

            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleOrdenNeumatico = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleOrdenNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleOrdenNeumatico As e_DetalleOrdenNeumatico) As List(Of e_DetalleOrdenNeumatico)
        Try
            Dim ldDetalleOrdenNeumatico As New List(Of e_DetalleOrdenNeumatico)
            Dim ds As DataSet
            With oeDetalleOrdenNeumatico
                ds = sqlhelper.ExecuteDataset("ALM.Isp_DetalleOrdenNeumatico_Listar", .TipoOperacion _
                        , .Id _
                        , .IdOrdenMaterial _
                        , .IdNeumatico _
                        , .Confirmacion _
                        , .FechaConfirmacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDetalleOrdenNeumatico = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleOrdenNeumatico = Cargar(o_Fila)
                ldDetalleOrdenNeumatico.Add(oeDetalleOrdenNeumatico)
            Next
            Return ldDetalleOrdenNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleOrdenNeumatico As e_DetalleOrdenNeumatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleOrdenNeumatico
                sqlhelper.ExecuteNonQuery("ALM.Isp_DetalleOrdenNeumatico_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdOrdenMaterial _
                        , .IdNeumatico _
                        , .CodNeumatico _
                        , .Confirmacion _
                        , .FechaConfirmacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleOrdenNeumatico As e_DetalleOrdenNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_DetalleOrdenNeumatico_IAE", "E", _
             "", oeDetalleOrdenNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
