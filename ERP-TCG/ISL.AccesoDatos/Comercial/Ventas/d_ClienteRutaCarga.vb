Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ClienteRutaCarga
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ClienteRutaCarga
        Try
            Dim oeClienteRutaCarga = New e_ClienteRutaCarga( _
                             o_fila("Id").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("IndCuenta").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeClienteRutaCarga
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As e_ClienteRutaCarga

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteRutaCarga_Listar", "", oeClienteRutaCarga.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeClienteRutaCarga = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeClienteRutaCarga
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As List(Of e_ClienteRutaCarga)
        Try
            Dim ldClienteRutaCarga As New List(Of e_ClienteRutaCarga)
            Dim ds As DataSet
            With oeClienteRutaCarga
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteRutaCarga_Listar", "" _
                        , .Id _
                        , .IdCliente _
                        , .IdOrigen _
                        , .IdDestino)
            End With
            oeClienteRutaCarga = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeClienteRutaCarga = Cargar(o_Fila)
                ldClienteRutaCarga.Add(oeClienteRutaCarga)
            Next
            Return ldClienteRutaCarga
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean
        Try
            With oeClienteRutaCarga
                sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteRutaCarga_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCliente _
                        , .IdMaterial _
                        , .IdOrigen _
                        , .IdDestino _
                        , .IndCuenta _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteRutaCarga_IAE", "E", _
             "", oeClienteRutaCarga.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
