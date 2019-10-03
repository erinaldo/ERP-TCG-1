Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_LiquidacionTrabajador
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_LiquidacionTrabajador
        Try
            Dim oeLiquidacionTrabajador = New e_LiquidacionTrabajador(o_fila("Id").ToString _
                         , o_fila("Codigo").ToString _
                         , o_fila("Fecha").ToString _
                         , o_fila("FechaIngreso").ToString _
                         , o_fila("FechaCese").ToString _
                         , o_fila("IdTrabajador").ToString _
                         , o_fila("Trabajador").ToString _
                         , o_fila("IdMotivoCese").ToString _
                         , o_fila("MotivoCese").ToString _
                         , o_fila("IdEstado").ToString _
                         , o_fila("Estado").ToString _
                         , o_fila("IdOcupacion").ToString _
                         , o_fila("Ocupacion").ToString _
                         , o_fila("TotalPagar").ToString _
                         , o_fila("RemuBasica").ToString _
                         , o_fila("AsigFamiliar").ToString _
                         , o_fila("PromBoniProd").ToString _
                         , o_fila("PromHorasExtras").ToString _
                         , o_fila("PromGratificacion").ToString _
                         , o_fila("FechaInicioCTS").ToString _
                         , o_fila("CTSM").ToString _
                         , o_fila("CTSD").ToString _
                         , o_fila("CTSxM").ToString _
                         , o_fila("CTSxD").ToString _
                         , o_fila("FechaInicioVT").ToString _
                         , o_fila("VTA").ToString _
                         , o_fila("VTM").ToString _
                         , o_fila("VTD").ToString _
                         , o_fila("VTDGozadas").ToString _
                         , o_fila("VTxA").ToString _
                         , o_fila("VTxM").ToString _
                         , o_fila("VTxD").ToString _
                         , o_fila("VTGozadas").ToString _
                         , o_fila("VTxDescuentoAFP").ToString _
                         , o_fila("FechaInicioGT").ToString _
                         , o_fila("GTM").ToString _
                         , o_fila("GTD").ToString _
                         , o_fila("GTxM").ToString _
                         , o_fila("GTxD").ToString _
                         , o_fila("BoniExtra").ToString _
                         , o_fila("CantidadGraciosa").ToString _
                         , o_fila("FechaInicioDT").ToString _
                         , o_fila("DT").ToString _
                         , o_fila("DTxD").ToString _
                         , o_fila("DTAsigFam").ToString _
                         , o_fila("DTEssaludVida").ToString _
                         , o_fila("DTDsctoAFP").ToString _
                         , o_fila("DTDsctoEPS").ToString _
                         , o_fila("AdelantosSueldo").ToString _
                         , o_fila("Devolucion5ta").ToString _
                         , o_fila("FechaCreacion").ToString _
                         , o_fila("UsuarioCreacion").ToString _
                         , o_fila("Activo").ToString _
                         , o_fila("PorcentajeAFP").ToString _
                         , o_fila("MontoLetras").ToString _
                         , o_fila("Dni").ToString)
            oeLiquidacionTrabajador.IdPeriodo = o_fila("IdPeriodo").ToString

            oeLiquidacionTrabajador.CTSF = o_fila("CTSF").ToString
            oeLiquidacionTrabajador.CTSxF = o_fila("CTSxF").ToString
            oeLiquidacionTrabajador.GTF = o_fila("GTF").ToString
            oeLiquidacionTrabajador.GTxF = o_fila("GTxF").ToString
            oeLiquidacionTrabajador.VTF = o_fila("VTF").ToString
            oeLiquidacionTrabajador.VTxF = o_fila("VTxF").ToString
            oeLiquidacionTrabajador.DTF = o_fila("DTF").ToString
            oeLiquidacionTrabajador.DTxF = o_fila("DTxF").ToString

            oeLiquidacionTrabajador.Retencion5ta = o_fila("Retencion5ta").ToString
            oeLiquidacionTrabajador.AporteEsalud = IIf(o_fila("AporteEsSalud") Is DBNull.Value, 0.0, o_fila("AporteEsSalud"))

            'oeLiquidacionTrabajador.IdPeriodo = o_fila("Descuento").ToString
            'oeLiquidacionTrabajador.IdPeriodo = o_fila("Retencion5ta").ToString


            Return oeLiquidacionTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As e_LiquidacionTrabajador

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_LiquidacionTrabajador_Listar", "", oeLiquidacionTrabajador.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeLiquidacionTrabajador = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeLiquidacionTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As List(Of e_LiquidacionTrabajador)
        Try
            Dim ldLiquidacionTrabajador As New List(Of e_LiquidacionTrabajador)
            Dim ds As DataSet
            With oeLiquidacionTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_LiquidacionTrabajador_Listar", "" _
                        , .Id _
                        , .FechaIngreso _
                        , .FechaCese _
                        , .IdTrabajador)
            End With
            oeLiquidacionTrabajador = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeLiquidacionTrabajador = Cargar(o_Fila)
                ldLiquidacionTrabajador.Add(oeLiquidacionTrabajador)
            Next
            Return ldLiquidacionTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim d_Prestamo As New d_Prestamo
            Dim e_Prestamo As New e_Prestamo
            Dim listaPrestamo As New DataTable
            Dim _id() As String

            Using TransScope As New TransactionScope()
                With oeLiquidacionTrabajador
                    _id = sqlhelper.ExecuteScalar("PER.Isp_LiquidacionTrabajador_IAE", .TipoOperacion, .PrefijoID, _
                                                .Id _
                                                , .Fecha _
                                                , .FechaIngreso _
                                                , .FechaCese _
                                                , .IdTrabajador _
                                                , .IdOcupacion _
                                                , .IdMotivoCese _
                                                , .IdEstado _
                                                , .TotalPagar _
                                                , .RemuneracionBasica _
                                                , .AsigFamiliar _
                                                , .PromBoniProd _
                                                , .PromHorasExtras _
                                                , .PromGratificacion _
                                                , .PorcentajeAFP _
                                                , .FechaInicioCTS _
                                                , .CTSM _
                                                , .CTSD _
                                                , .CTSxM _
                                                , .CTSxD _
                                                , .FechaInicioVT _
                                                , .VTA _
                                                , .VTM _
                                                , .VTD _
                                                , .VTDGozadas _
                                                , .VTxA _
                                                , .VTxM _
                                                , .VTxD _
                                                , .VTGozadas _
                                                , .VTxDescuentoAFP _
                                                , .FechaInicioGT _
                                                , .GTM _
                                                , .GTD _
                                                , .GTxM _
                                                , .GTxD _
                                                , .BoniExtra _
                                                , .CantidadGraciosa _
                                                , .FechaInicioDT _
                                                , .DT _
                                                , .DTxD _
                                                , .DTAsigFam _
                                                , .DTEssaludVida _
                                                , .DTDsctoAFP _
                                                , .DTDsctoEPS _
                                                , .AdelantoSueldo _
                                                , .Dev5taCat _
                                                , .UsuarioCreacion _
                                                , .IdPeriodo _
                                                , .CTSF _
                                                , .CTSxF _
                                                , .VTF _
                                                , .VTxF _
                                                , .GTF _
                                                , .GTxF _
                                                , .DTF _
                                                , .DTxF _
                                                , .Descuento _
                                                , .Retencion5ta _
                                                , .AporteEsalud).ToString.Split("_")
                    oeLiquidacionTrabajador.Id = _id(0)
                End With

                'If oeLiquidacionTrabajador.TipoOperacion = "I" Then
                '    e_Prestamo.TipoOperacion = "L"
                '    e_Prestamo.IdTrabajador = oeLiquidacionTrabajador.IdTrabajador
                '    listaPrestamo = d_Prestamo.ListarDT(e_Prestamo)
                '    For Each fila In listaPrestamo.Rows
                '        sqlhelper.ExecuteNonQuery("PER.Isp_LiquidacionTrabajadorPrestamo_IAE", "I", .PrefijoID, _
                '                                  "", oeLiquidacionTrabajador.Id, fila("IdPrestamo"), fila("IdPrestamoDetalle"), _
                '                                  fila("Saldo"), fila("ImporteCuota"), oeLiquidacionTrabajador.UsuarioCreacion)
                '    Next
                'End If

                TransScope.Complete()
            End Using
            
            
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeLiquidacionTrabajador As e_LiquidacionTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_LiquidacionTrabajador_IAE", "E", _
             "", oeLiquidacionTrabajador.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
