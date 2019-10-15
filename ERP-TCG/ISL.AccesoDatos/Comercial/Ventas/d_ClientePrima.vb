Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ClientePrima
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ClientePrima
        Try
            Dim oeClientePrima = New e_ClientePrima( _
                             o_fila("Id").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("MontoAsegurado").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("Vigente").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeClientePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeClientePrima As e_ClientePrima) As e_ClientePrima

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_ClientePrimaSeguro_Listar", "", oeClientePrima.Id,
                                          oeClientePrima.IdCliente,
                                          oeClientePrima.IdMoneda,
                                          oeClientePrima.Vigente)
            oeClientePrima = New e_ClientePrima
            If ds.Tables(0).Rows.Count > 0 Then
                oeClientePrima = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeClientePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeClientePrima As e_ClientePrima) As List(Of e_ClientePrima)
        Try
            Dim ldClientePrima As New List(Of e_ClientePrima)
            Dim ds As DataSet
            With oeClientePrima
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ClientePrimaSeguro_Listar", "" _
                        , .Id, .IdCliente, .IdMoneda, .Vigente)
            End With
            oeClientePrima = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeClientePrima = Cargar(o_Fila)
                ldClientePrima.Add(oeClientePrima)
            Next
            Return ldClientePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeClientePrima As e_ClientePrima) As Boolean
        Try
            With oeClientePrima
                sqlhelper.ExecuteNonQuery("OPE.Isp_ClientePrimaSeguro_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdCliente _
                        , .IdMoneda _
                        , .MontoAsegurado _
                        , .Observacion _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Vigente _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeClientePrima As e_ClientePrima) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_ClientePrimaSeguro_IAE", "E", "", oeClientePrima.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
