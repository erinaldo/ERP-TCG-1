'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Data.SqlClient

Public Class d_DetraccionDetalle
    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetraccionDetalle
        Try
            Dim oeDetraccionDetalle = New e_DetraccionDetalle(
                             o_fila("Id").ToString _
                             , o_fila("IdDetraccion").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("ClienteProveedor").ToString _
                             , o_fila("RUC").ToString _
                             , o_fila("NroProforma").ToString _
                             , o_fila("IdTipoBien").ToString _
                             , o_fila("CodigoBien").ToString _
                             , o_fila("IdCtaCte_Proveedor").ToString _
                             , o_fila("IdTipoOperacion").ToString _
                             , o_fila("CodigoOpe").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("FechaPago").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("CtaContable").ToString)
            Return oeDetraccionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As DataSet
        Try
            Dim ds As DataSet
            With oeDetraccionDetalle
                ds = bd.ExecuteDataset("[CON].[Isp_DetraccionDetalle_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdDetraccion _
                        , .IdClienteProveedor _
                        , .IdMovimientoDocumento)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As e_DetraccionDetalle
        Try
            Dim ds As DataSet = ExecuteLST(oeDetraccionDetalle)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetraccionDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetraccionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As List(Of e_DetraccionDetalle)
        Try
            Dim ldDetraccionDetalle As New List(Of e_DetraccionDetalle)
            Dim ds As DataSet = ExecuteLST(oeDetraccionDetalle)
            oeDetraccionDetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetraccionDetalle = Cargar(o_Fila)
                    ldDetraccionDetalle.Add(oeDetraccionDetalle)
                Next
            End If
            Return ldDetraccionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeDetraccionDetalle
                stResultado = bd.ExecuteScalar("[CON].[Isp_DetraccionDetalle_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdDetraccion _
                        , .IdClienteProveedor _
                        , .NroProforma _
                        , .IdTipoBien _
                        , .IdCtaCte_ProAdq _
                        , .IdTipoOperacion _
                        , .Periodo _
                        , .IdTipoDocumento _
                        , .IdMovimientoDocumento _
                        , .Serie _
                        , .Numero _
                        , .Importe _
                        , .Voucher _
                        , .FechaPago _
                        , .UsuarioCreacion).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean
        Try
            With oeDetraccionDetalle
                bd.ExecuteNonQuery("[CON].[Sp_DetraccionDetalle_IAE]" _
                       , "E" _
                       , "" _
                       , .Id)

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
