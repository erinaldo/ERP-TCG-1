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

Public Class d_DetalleLibroElectronico

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleLibroElectronico
        Try
            Dim oeDetalleLibroElectronico = New e_DetalleLibroElectronico( _
                             o_fila("Id").ToString _
                             , o_fila("IdLibroElectronico").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("CUO").ToString _
                             , o_fila("NumeroCorrelativo").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("TipoDocumento").ToString _
                             , o_fila("SerieDoc").ToString _
                             , o_fila("AnioEmisionDUA").ToString _
                             , o_fila("NumeroDoc").ToString _
                             , o_fila("NumeroDoc2").ToString _
                             , o_fila("TipoDocIdentidad").ToString _
                             , o_fila("NumeroDocIdentidad").ToString _
                             , o_fila("Denominacion").ToString _
                             , o_fila("SubTotal1").ToString _
                             , o_fila("IGV1").ToString _
                             , o_fila("SubTotal2").ToString _
                             , o_fila("IGV2").ToString _
                             , o_fila("SubTotal3").ToString _
                             , o_fila("IGV3").ToString _
                             , o_fila("NoGravada").ToString _
                             , o_fila("ISC").ToString _
                             , o_fila("OtrosTributos").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("FechaEmisionAso").ToString _
                             , o_fila("TipoDocumentoAso").ToString _
                             , o_fila("SerieAso").ToString _
                             , o_fila("NumeroDocAso").ToString _
                             , o_fila("NumeroDocAso2").ToString _
                             , o_fila("FechaEmisionDetraccion").ToString _
                             , o_fila("NroConstanciaDetraccion").ToString _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , o_fila("Retencion").ToString _
                             , o_fila("Indicador").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("CodigoMoneda").ToString _
                             , o_fila("ClasificacionBienServicio").ToString _
                             , o_fila("IdentificacionContratoProy").ToString _
                             , o_fila("ErrorTipo1").ToString _
                             , o_fila("ErrorTipo2").ToString _
                             , o_fila("ErrorTipo3").ToString _
                             , o_fila("ErrorTipo4").ToString _
                             , o_fila("IndCancelaComprobPago").ToString _
                             , o_fila("DsctoBaseImp") _
                             , o_fila("DsctoIGV") _
                             , o_fila("IndClienteProveedor").ToString _
                             , o_fila("CodPais").ToString _
                             , o_fila("CodConvenio").ToString _
                             , o_fila("CodTipoRenta").ToString _
                             , o_fila("IndAfectaAnticipo").ToString)
            Return oeDetalleLibroElectronico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As e_DetalleLibroElectronico
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeDetalleLibroElectronico.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleLibroElectronico = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleLibroElectronico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As List(Of e_DetalleLibroElectronico)
        Try
            Dim ldDetalleLibroElectronico As New List(Of e_DetalleLibroElectronico)
            Dim ds As DataSet
            With oeDetalleLibroElectronico
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleLibroElectronico_Listar", .TipoOperacion _
                        , .IdLibroElectronico _
                        , .IdPeriodo _
                        , ._Ejercicio _
                        , ._Mes _
                        , .Año _
                        , .CuentaInicial _
                        , .CuentaFinal)
            End With
            oeDetalleLibroElectronico = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetalleLibroElectronico = Cargar(o_Fila)
                    ldDetalleLibroElectronico.Add(oeDetalleLibroElectronico)
                Next
            Else
                ldDetalleLibroElectronico = New List(Of e_DetalleLibroElectronico)
            End If
            Return ldDetalleLibroElectronico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean
        Try
            With oeDetalleLibroElectronico
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdLibroElectronico _
                        , .IdMovimientoDocumento _
                        , .Periodo _
                        , .NumeroCorrelativo _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .TipoDocumento _
                        , .SerieDoc _
                        , .AnioEmisionDUA _
                        , .NumeroDoc _
                        , .NumeroDoc2 _
                        , .TipoDocIdentidad _
                        , .NumeroDocIdentidad _
                        , .Denominacion _
                        , .SubTotal1 _
                        , .IGV1 _
                        , .SubTotal2 _
                        , .IGV2 _
                        , .SubTotal3 _
                        , .IGV3 _
                        , .NoGravada _
                        , .ISC _
                        , .OtrosTributos _
                        , .Total _
                        , .TipoCambio _
                        , .FechaEmisionAso _
                        , .TipoDocumentoAso _
                        , .SerieAso _
                        , .NumeroDocAso _
                        , .NumeroDocAso2 _
                        , .FechaEmisionDetraccion _
                        , .NroConstanciaDetraccion _
                        , .Retencion _
                        , .Indicador _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleLibroElectronico As e_DetalleLibroElectronico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", "", oeDetalleLibroElectronico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dt As Data.DataTable) As Integer
        Try
            sqlhelper.InsertarMasivo("CON.DetalleLibroElectronico", dt)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.DetalleLibroElectronico", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
