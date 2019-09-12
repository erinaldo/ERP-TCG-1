Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MovimientoMermas
    Private sqlhelper As New SqlHelper
    Private odControlMermas As New d_ControlMerma
    Private odOtrosIngresos As New d_OtrosIngresos
    Private oeSancion As New e_Sancion
    Private odSancion As New d_Sancion
    Private odTrabajador As New d_Trabajador

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoMermas
        Try
            Dim oeMovimientoMermas = New e_MovimientoMermas(o_fila("Seleccion").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("IndIngresoSalida").ToString _
                             , o_fila("IdPersona").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdSancion").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("PorcentajeDescuento").ToString _
                             , o_fila("SubTotal").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Descuento").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IndCobro").ToString _
                             , o_fila("TipoPago").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeMovimientoMermas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoMermas As e_MovimientoMermas) As e_MovimientoMermas

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_MovimientoMermas_Listar", _
                                          oeMovimientoMermas.TipoOperacion, _
                                          oeMovimientoMermas.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoMermas = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMovimientoMermas = New e_MovimientoMermas
            End If
            Return oeMovimientoMermas
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoMermas As e_MovimientoMermas) As List(Of e_MovimientoMermas)
        Try
            Dim ldMovimientoMermas As New List(Of e_MovimientoMermas)
            Dim ds As DataSet
            With oeMovimientoMermas
                ds = sqlhelper.ExecuteDataset("OPE.Isp_MovimientoMermas_Listar", _
                                              .TipoOperacion _
                                                , .Id _
                                                , .IdPersona _
                                                , .FechaDesde _
                                                , .FechaHasta _
                                                , .IdCentro)
            End With
            oeMovimientoMermas = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoMermas = Cargar(o_Fila)
                    ldMovimientoMermas.Add(oeMovimientoMermas)
                Next
            Else
                ldMovimientoMermas = New List(Of e_MovimientoMermas)
            End If
            Return ldMovimientoMermas
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoMermas As e_MovimientoMermas) As Boolean
        Dim stResultado() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeMovimientoMermas
                    If .TipoOperacion <> "C" Then
                        If .IndIngresoSalida = 1 Then
                            If .TipoPago = 1 Or .TipoPago = 2 Then
                                oeSancion = New e_Sancion
                                If .IdSancion = "" Then
                                    oeSancion.TipoOperacion = "I"
                                Else
                                    oeSancion.TipoOperacion = "A"
                                End If
                                oeSancion.Fecha = .Fecha
                                oeSancion.FechaCreacion = .Fecha
                                If .IdPersona = "" Then
                                    Throw New Exception("Solo Puede Vender por Credito/Amortizado a Trabajadores en Planilla")
                                End If
                                oeSancion.IdTrabajador = .IdPersona
                                oeSancion.IdConcepto = "1CH000006"
                                oeSancion.IdArea = "1CH000000022"
                                oeSancion.IdResponsable = .Numero
                                If .TipoPago = 1 Then
                                    oeSancion.Monto = .Total
                                Else
                                    oeSancion.Monto = .Total - .Saldo
                                End If
                                oeSancion.Glosa = "VENTA DE MERCADERIA DE MERMA"
                                oeSancion.UsuarioCreacion = .UsuarioCreacion
                                oeSancion.IdEstado = "1CH00031"
                                oeSancion.IdGrupo = .Serie
                                odSancion.Guardar(oeSancion)
                                oeMovimientoMermas.IdSancion = oeSancion.Id
                            End If
                        End If
                    End If
                    stResultado = sqlhelper.ExecuteScalar("OPE.Isp_MovimientoMermas_IAE",
                                              .TipoOperacion,
                                              .PrefijoID,
                                                .Id _
                                                , .IndIngresoSalida _
                                                , .IdPersona _
                                                , .IdSancion _
                                                , .Fecha _
                                                , .PorcentajeDescuento _
                                                , .SubTotal _
                                                , .Saldo _
                                                , .Descuento _
                                                , .Total _
                                                , .Glosa _
                                                , .IdEstado _
                                                , .Serie _
                                                , .Numero _
                                                , .IndCobro _
                                                , .TipoPago _
                                                , .UsuarioCreacion _
                                                , .Activo _
                                                , .IdCentro).ToString.Split("_")
                    .Id = stResultado(0)
                    If .ListaControlMermas.Count > 0 Then
                        For Each oeControlMerma As e_ControlMerma In .ListaControlMermas
                            oeControlMerma.TipoOperacion = "I"
                            oeControlMerma.IdMovimientoMermas = stResultado(0)
                            odControlMermas.Guardar(oeControlMerma)
                        Next
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoMermas As e_MovimientoMermas) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_MovimientoMermas_IAE", _
                                      "E", _
                                    "", _
                                    oeMovimientoMermas.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cobrar(ByVal loMovimientoMermas As List(Of e_MovimientoMermas), oeOtrIng As e_OtrosIngresos) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                For Each movmer As e_MovimientoMermas In loMovimientoMermas
                    Guardar(movmer)
                Next
                odOtrosIngresos.Guardar(oeOtrIng)
                transScope.Complete()
            End Using
            Return oeOtrIng.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    

End Class
