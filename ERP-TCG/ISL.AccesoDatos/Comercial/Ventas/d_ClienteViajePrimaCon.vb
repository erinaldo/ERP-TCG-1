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

Public Class d_ClienteViajePrimaCon
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ClienteViajePrimaCon
        Try
            Dim oeClienteViajePrimaCon = New e_ClienteViajePrimaCon(o_fila("Id").ToString _
                             , o_fila("IdClienteViajePrima").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("CuentaViaje").ToString _
                             , o_fila("ImporteSeguro").ToString _
                             , o_fila("Factor1").ToString _
                             , o_fila("PrimaReal").ToString _
                             , o_fila("PrimaMinima").ToString _
                             , o_fila("Factor").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeClienteViajePrimaCon
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As e_ClienteViajePrimaCon

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteViajePrimaCon_Listar", "", oeClienteViajePrimaCon.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeClienteViajePrimaCon = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeClienteViajePrimaCon
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As List(Of e_ClienteViajePrimaCon)
        Try
            Dim ldClienteViajePrimaCon As New List(Of e_ClienteViajePrimaCon)
            Dim ds As DataSet
            With oeClienteViajePrimaCon
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteViajePrimaCon_Listar", "" _
                        , .Id _
                        , .IdClienteViajePrima _
                        , .IdCliente)
            End With
            oeClienteViajePrimaCon = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeClienteViajePrimaCon = Cargar(o_Fila)
                ldClienteViajePrimaCon.Add(oeClienteViajePrimaCon)
            Next
            Return ldClienteViajePrimaCon
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As Boolean
        Try
            With oeClienteViajePrimaCon
                sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteViajePrimaCon_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdClienteViajePrima _
                        , .IdCliente _
                        , .CuentaViaje _
                        , .ImporteSeguro _
                        , .Factor1 _
                        , .PrimaReal _
                        , .PrimaMinima _
                        , .Factor _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeClienteViajePrimaCon As e_ClienteViajePrimaCon) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteViajePrimaCon_IAE", "E", _
             "", oeClienteViajePrimaCon.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
