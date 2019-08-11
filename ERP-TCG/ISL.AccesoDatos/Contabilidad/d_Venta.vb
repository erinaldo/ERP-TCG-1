Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Venta
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Venta
        Try
            Dim oeVenta = New e_Venta( _
                             o_fila("Id").ToString _
                             , o_fila("Exportacion").ToString _
                             , o_fila("Grabado").ToString _
                             , o_fila("Exonerado").ToString _
                             , o_fila("Inafecto").ToString _
                             , o_fila("ISC").ToString _
                             , o_fila("IGV").ToString _
                             , o_fila("OtrosTributos").ToString _
                             , o_fila("Descuentos").ToString _
                             , o_fila("Detraccion").ToString _
                             , o_fila("SaldoDetraccion").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IdTipoVenta").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdDireccion").ToString _
                             , o_fila("IdTipoPago").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("FactorRefUni") _
                             , o_fila("PorcenDetrac") _
                             , o_fila("IndCliente") _
                        )
            Return oeVenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeVenta As e_Venta) As e_Venta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_Venta_Listar", "", oeVenta.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeVenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeVenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerConIdDocumento(ByVal oeVenta As e_Venta) As e_Venta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_Venta_Listar", "", "" _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , oeVenta.IdMovimientoDocumento)
            If ds.Tables(0).Rows.Count > 0 Then
                oeVenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeVenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeVenta As e_Venta) As List(Of e_Venta)
        Try
            Dim ldVenta As New List(Of e_Venta)
            Dim ds As DataSet
            With oeVenta
                ds = sqlhelper.ExecuteDataset("CON.Isp_Venta_Listar", "" _
                        , .Id _
                        , .Exportacion _
                        , .Gravado _
                        , .Exonerado _
                        , .Inafecto _
                        , .ISC _
                        , .IGV _
                        , .OtrosTributos _
                        , .Descuentos _
                        , .Detraccion _
                        , .SaldoDetraccion _
                        , .IdMovimientoDocumento _
                        , .IdTipoVenta _
                        , .Activo _
                        )
            End With
            oeVenta = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeVenta = Cargar(o_Fila)
                    ldVenta.Add(oeVenta)
                Next
            End If
            Return ldVenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeVenta As e_Venta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeVenta
                sqlhelper.ExecuteNonQuery("CON.Isp_Venta_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Exportacion _
                        , .Gravado _
                        , .Exonerado _
                        , .Inafecto _
                        , .ISC _
                        , .IGV _
                        , .OtrosTributos _
                        , .Descuentos _
                        , .Detraccion _
                        , .SaldoDetraccion _
                        , .IdMovimientoDocumento _
                        , .IdTipoVenta _
                        , .Activo _
                        , .IdDireccion _
                        , .IdTipoPago _
                        , .Glosa _
                        , .FactorRefUni _
                        , .PorcenDetra _
                        , .IndCliente _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeVenta As e_Venta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_Venta_IAE", "E", _
             "", oeVenta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
