Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ClienteViajePrima
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ClienteViajePrima
        Try
            Dim oeClienteViajePrima = New e_ClienteViajePrima( _
                             o_fila("Id").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("TotalViajes").ToString _
                             , o_fila("PrimaTotal").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeClienteViajePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeClienteViajePrima As e_ClienteViajePrima) As e_ClienteViajePrima

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ClienteViajePrima_Listar]", "", oeClienteViajePrima.Id,
                                          oeClienteViajePrima.IdPeriodo)
            oeClienteViajePrima = New e_ClienteViajePrima
            If ds.Tables(0).Rows.Count > 0 Then
                oeClienteViajePrima = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeClienteViajePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As List(Of e_ClienteViajePrima)
        Try
            Dim ldClienteViajePrima As New List(Of e_ClienteViajePrima)
            Dim ds As DataSet
            With oeClienteViajePrima
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ClienteViajePrima_Listar]", "" _
                        , .Id _
                        , .IdPeriodo)
            End With
            oeClienteViajePrima = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeClienteViajePrima = Cargar(o_Fila)
                ldClienteViajePrima.Add(oeClienteViajePrima)
            Next
            Return ldClienteViajePrima
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odClienteViajePrimaCon As New d_ClienteViajePrimaCon
            Dim id() As String
            With oeClienteViajePrima
                id = sqlhelper.ExecuteScalar("[OPE].[Isp_ClienteViajePrima_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPeriodo _
                        , .TipoCambio _
                        , .TotalViajes _
                        , .PrimaTotal _
                        , .Observacion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    ).ToString.Split("_")
                .Id = id(0)
                For Each oe As e_ClienteViajePrimaCon In .loViaPriCon
                    oe.TipoOperacion = .TipoOperacion
                    oe.IdClienteViajePrima = .Id
                    oe.UsuarioCreacion = .UsuarioCreacion
                    oe.FechaCreacion = .FechaCreacion
                    odClienteViajePrimaCon.Guardar(oe)
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeClienteViajePrima As e_ClienteViajePrima) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_ClienteViajePrima_IAE]", "E", _
             "", oeClienteViajePrima.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
