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

''' <summary>
''' Clase que permite el acceso a los datos de la tabla DocumentoVehicular
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_ReporteRecorrido

    Private sqlhelper As New SqlHelper
    Dim odDetalleDocumentoVehiculo As New d_DetalleDocumentoVehiculo
    Dim odCuotaDocumentoVehiculo As New d_CuotaDocumentoVehiculo
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_DocumentoVehicular y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeDocumentoVehicular) de tipo e_DocumentoVehicular</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_ReporteRecorrido
        Try
            Dim oeReporteRecorrido = New e_ReporteRecorrido( _
                             o_fila("CodigoOperacion").ToString _
                             , o_fila("EstadoOperacion").ToString _
                             , o_fila("FechaOperacion").ToString _
                             , o_fila("CodigoViaje").ToString _
                             , o_fila("EstadoViaje").ToString _
                             , o_fila("FechaViaje").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("Carreta").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("KmTractoOrigen").ToString _
                             , o_fila("KmTractoDestino").ToString _
                             , o_fila("KmCarretaOrigen").ToString _
                             , o_fila("KmCarretaDestino").ToString _
                             , o_fila("KmIdeal").ToString _
                             , o_fila("KmDiferencia").ToString _
                             , o_fila("KmMuerto").ToString _
                             , o_fila("KmReal").ToString _
            )
            Return oeReporteRecorrido
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeReporteRecorrido As e_ReporteRecorrido) As e_ReporteRecorrido

        Try
            Dim ds As DataSet
            With oeReporteRecorrido
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ReporteRecorrido_Listar]", _
                                                  .TipoOperacion _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .IdTractos _
                                                , .IdCarretas _
                                                , .Motriz)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeReporteRecorrido = Cargar(ds.Tables(0).Rows(0))
            Else
                oeReporteRecorrido = New e_ReporteRecorrido
            End If
            Return oeReporteRecorrido
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeReporteRecorrido As e_ReporteRecorrido) As List(Of e_ReporteRecorrido)
        Try
            Dim ldReporteRecorrido As New List(Of e_ReporteRecorrido)
            Dim ds As DataSet
            With oeReporteRecorrido
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_ReporteRecorrido_Listar]", _
                                                  .TipoOperacion _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .IdTractos _
                                                , .IdCarretas _
                                                , .Motriz)
            End With
            oeReporteRecorrido = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteRecorrido = Cargar(o_Fila)
                    ldReporteRecorrido.Add(oeReporteRecorrido)
                Next
            Else
                ldReporteRecorrido = New List(Of e_ReporteRecorrido)
            End If
            Return ldReporteRecorrido
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDts(ByVal oeReporteRecorrido As e_ReporteRecorrido) As DataSet
        Try
            With oeReporteRecorrido
                Return sqlhelper.ExecuteDataset("[OPE].[Isp_ReporteRecorrido_Listar]", _
                                              .TipoOperacion, _
                                              .FechaDesde, _
                                              .FechaHasta, _
                                              .IdTractos, _
                                              .IdCarretas, _
                                              .Motriz)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class