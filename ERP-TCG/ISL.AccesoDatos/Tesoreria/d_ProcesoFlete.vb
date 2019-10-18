'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF


Public Class d_ProcesoFlete
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoFlete
        Try
            Dim oeProcesoFlete = New e_ProcesoFlete( _
                             o_fila("IdOperacion").ToString _
                             , o_fila("Operacion").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("ViajeVacio") _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("UnidadCarga").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Carga").ToString _
                             , o_fila("Usuario").ToString _
                             , o_fila("Comisionista").ToString _
                             , o_fila("Comision") _
                             , o_fila("Moneda").ToString _
                             , o_fila("FleteUnitario") _
                             , o_fila("Cantidad") _
                             , o_fila("Flete") _
                             , o_fila("PagoContraEntrega") _
                             , o_fila("PesoToneladasCarga") _
                             , o_fila("PesoToneladasDescarga") _
                             , o_fila("IndPesoTnDescarga") _
                             , o_fila("PesoToneladas") _
                             , o_fila("IncluyeIgv") _
                             , o_fila("Activo") _
                        )
            Return oeProcesoFlete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoFlete As e_ProcesoFlete) As e_ProcesoFlete

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ProcesoFlete_Listar", "",
             oeProcesoFlete.TipoOperacion)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoFlete = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeProcesoFlete
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function Listar(ByVal oeMovimiento As e_Movimiento) As List(Of e_Movimiento)
    '    Try
    '        
    '        Dim ldMovimiento As New List(Of e_Movimiento)
    '        Dim ds As DataSet
    '        With oeMovimiento
    '            ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Listar", "" _
    '                    , .Id _
    '                    , .Activo _
    '                    )
    '        End With
    '        oeMovimiento = Nothing
    '        If ds.Tables.Count > 0 Then
    '            For Each o_Fila As DataRow In ds.Tables(0).Rows
    '                oeMovimiento = Cargar(o_Fila)
    '                ldMovimiento.Add(oeMovimiento)
    '            Next
    '        End If
    '        Return ldMovimiento
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

End Class
