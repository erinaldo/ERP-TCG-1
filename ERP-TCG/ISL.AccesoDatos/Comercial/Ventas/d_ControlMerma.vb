Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ControlMerma
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlMerma
        Try
            Dim oeControlMermas = New e_ControlMerma(o_fila("Id").ToString _
                         , o_fila("IdMovimientoMermas").ToString _
                         , o_fila("IndIngresoSalida").ToString _
                         , o_fila("IdClientePersona").ToString _
                         , o_fila("ClientePersona").ToString _
                         , o_fila("Fecha").ToString _
                         , o_fila("IdViaje").ToString _
                         , o_fila("IdMaterial").ToString _
                         , o_fila("Material").ToString _
                         , o_fila("UnidadCantidad").ToString _
                         , o_fila("Cantidad").ToString _
                         , o_fila("PrecioUnitario").ToString _
                         , o_fila("PrecioTotal").ToString _
                         , o_fila("Saldo").ToString _
                         , o_fila("FactorConversion").ToString _
                         , o_fila("Glosa").ToString _
                         , o_fila("IdEstado").ToString _
                         , o_fila("Estado").ToString _
                         , o_fila("Serie").ToString _
                         , o_fila("Numero").ToString _
                         , o_fila("PrecioFactura").ToString _
                         , o_fila("IndCobro").ToString _
                         , o_fila("TipoPago").ToString _
                         , o_fila("UsuarioCreacion").ToString _
                         , o_fila("Activo").ToString)
            Return oeControlMermas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlMerma As e_ControlMerma) As e_ControlMerma
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_IngresoSalidaMermas_Listar", _
                                          oeControlMerma.TipoOperacion, _
                                          oeControlMerma.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeControlMerma = Cargar(ds.Tables(0).Rows(0))
            Else
                oeControlMerma = New e_ControlMerma
            End If
            Return oeControlMerma
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlMerma As e_ControlMerma) As List(Of e_ControlMerma)
        Try
            Dim ldControlMermas As New List(Of e_ControlMerma)
            Dim ds As DataSet
            With oeControlMerma
                ds = sqlhelper.ExecuteDataset("OPE.Isp_IngresoSalidaMermas_Listar", _
                                                .TipoOperacion _
                                                , .Id _
                                                , .IdClientePersona _
                                                , .IdMaterial _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .IdMovimientoMermas _
                                                , .IdCentro)
            End With
            oeControlMerma = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlMerma = Cargar(o_Fila)
                    ldControlMermas.Add(oeControlMerma)
                Next
            Else
                ldControlMermas = New List(Of e_ControlMerma)
            End If
            Return ldControlMermas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeControlMermas As e_ControlMerma) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeControlMermas
                sqlhelper.ExecuteNonQuery("OPE.Isp_IngresoSalidaMermas_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                             .Id _
                                        , .IdMovimientoMermas _
                                        , .IndIngresoSalida _
                                        , .IdClientePersona _
                                        , .Fecha _
                                        , .IdViaje _
                                        , .IdMaterial _
                                        , .UnidadCantidad _
                                        , .Cantidad _
                                        , .PrecioUnitario _
                                        , .PrecioTotal _
                                        , .Saldo _
                                        , .FactorConversion _
                                        , .Glosa _
                                        , .IdEstado _
                                        , .Serie _
                                        , .Numero _
                                        , .PrecioFactura _
                                        , .IndCobro _
                                        , .TipoPago _
                                        , .UsuarioCreacion _
                                        , .Activo)
                'If .IndIngresoSalida = 1 Then
                '    If .TipoPago = 1 Or .TipoPago = 2 Then
                '        oeSancion = New e_Sancion
                '        oeSancion.TipoOperacion = "I"
                '        oeSancion.Fecha = Date.Now
                '        oeSancion.FechaCreacion = Date.Now
                '        oeTrabajador = New e_Trabajador
                '        oeTrabajador.oePersona.Id = .IdClientePersona
                '        oeTrabajador = odTrabajador.Obtener(oeTrabajador)
                '        If oeTrabajador.Id = "" Then
                '            Throw New Exception("Solo Puede Vender por Credito a Trabajadores en Planilla")
                '            Return False
                '        End If
                '        oeSancion.IdTrabajador = oeTrabajador.Id
                '        oeSancion.IdConcepto = "1SI000006"
                '        oeSancion.IdArea = "1CH000000015"
                '        oeSancion.IdResponsable = .IdClientePersona
                '        If .TipoPago = 1 Then
                '            oeSancion.Monto = .PrecioTotal
                '        Else
                '            oeSancion.Monto = .PrecioTotal - .Saldo
                '        End If
                '        oeSancion.Glosa = "VENTA DE MERCADERIA DE MERMA"
                '        oeSancion.UsuarioCreacion = .UsuarioCreacion
                '        oeSancion.IdEstado = ""
                '        oeSancion.IdGrupo = ""
                '        odSancion.Guardar(oeSancion)
                '    End If
                'End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlMermas As e_ControlMerma) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_IngresoSalidaMermas_IAE", oeControlMermas.TipoOperacion, _
                                        "", oeControlMermas.Id, _
                                        0, "")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


