'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ClienteViajePrimaDet
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ClienteViajePrimaDet
        Try
            Dim oeClienteViajePrimaDet = New e_ClienteViajePrimaDet( _
                             o_fila("Id").ToString _
                             , o_fila("IdClienteViajePrima").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("FechaViaje").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("IdOperacionDetalle").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("IndAsegurado").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeClienteViajePrimaDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As e_ClienteViajePrimaDet

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteViajePrimaDet_Listar", "", oeClienteViajePrimaDet.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeClienteViajePrimaDet = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeClienteViajePrimaDet
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As List(Of e_ClienteViajePrimaDet)
        Try
            Dim ldClienteViajePrimaDet As New List(Of e_ClienteViajePrimaDet)
            Dim ds As DataSet
            With oeClienteViajePrimaDet
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ClienteViajePrimaDet_Listar", "" _
                        , .Id _
                        , .IdClienteViajePrima)
            End With
            oeClienteViajePrimaDet = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeClienteViajePrimaDet = Cargar(o_Fila)
                ldClienteViajePrimaDet.Add(oeClienteViajePrimaDet)
            Next
            Return ldClienteViajePrimaDet
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As Boolean
        Try
            With oeClienteViajePrimaDet
                sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteViajePrimaDet_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdClienteViajePrima _
                        , .IdViaje _
                        , .IdOperacionDetalle _
                        , .IdCliente _
                        , .IdOrigen _
                        , .IdDestino _
                        , .IdMaterial _
                        , .IndAsegurado _
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

    Public Function Eliminar(ByVal oeClienteViajePrimaDet As e_ClienteViajePrimaDet) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_ClienteViajePrimaDet_IAE", "E", "", oeClienteViajePrimaDet.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Dim stResultado As String
        stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "OPE.ClienteViajePrimaDet", PrefijoID)
        Return stResultado
    End Function

    Public Function GuardaMasivo(datatable As DataTable) As Boolean
        If datatable.Rows.Count > 0 Then sqlhelper.InsertarMasivo("OPE.ClienteViajePrimaDet", datatable, False)
        Return True
    End Function

End Class
