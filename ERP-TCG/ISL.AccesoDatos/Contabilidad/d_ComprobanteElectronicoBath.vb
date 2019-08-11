Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_ComprobanteElectronicoBath

    Private sqlhelper As New SqlHelper
    Public odDetalleBath As New d_ComprobanteElectronicoBath_Detalle

    Private Function Cargar(ByVal o_fila As DataRow) As e_ComprobanteElectronicoBath
        Try
            Dim oeComprobanteElectronicoBath = New e_ComprobanteElectronicoBath( _
                             o_fila("Id").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("FechaEnvio").ToString _
                             , o_fila("xmlbase64").ToString _
                             , o_fila("nombrexml").ToString _
                             , o_fila("cdrxml").ToString _
                             , o_fila("Ticket").ToString _
                             , o_fila("IndBaja").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("ValorResumen").ToString _
                             , o_fila("Firma").ToString _
            )
            Return oeComprobanteElectronicoBath
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As e_ComprobanteElectronicoBath
        Try
            Dim ds As DataSet
            With oeComprobanteElectronicoBath
                ds = sqlhelper.ExecuteDataset("CON.Isp_ComprobanteElectronicoBath_Listar", .TipoOperacion _
                        , .Id _
                        , .TipoReferencia _
                        , .FechaEnvio _
                        , .xmlbase64 _
                        , .nombrexml _
                        , .cdrxml _
                        , .Ticket _
                        , .IndBaja _
                        , .Estado)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeComprobanteElectronicoBath = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeComprobanteElectronicoBath
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As List(Of e_ComprobanteElectronicoBath)
        Try
            Dim ldComprobanteElectronicoBath As New List(Of e_ComprobanteElectronicoBath)
            Dim ds As DataSet
            With oeComprobanteElectronicoBath
                ds = sqlhelper.ExecuteDataset("CON.Isp_ComprobanteElectronicoBath_Listar", "" _
                        , .Id _
                        , .TipoReferencia _
                        , .FechaEnvio _
                        , .xmlbase64 _
                        , .nombrexml _
                        , .cdrxml _
                        , .Ticket _
                        , .IndBaja _
                        , .Estado _
                        )
            End With
            oeComprobanteElectronicoBath = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeComprobanteElectronicoBath = Cargar(o_Fila)
                ldComprobanteElectronicoBath.Add(oeComprobanteElectronicoBath)
            Next
            Return ldComprobanteElectronicoBath
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByRef oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean
        Try
            Dim stResultado() As String
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using TransScope As New TransactionScope()
                With oeComprobanteElectronicoBath
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_ComprobanteElectronicoBath_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .TipoReferencia _
                            , .FechaEnvio _
                            , .xmlbase64 _
                            , .nombrexml _
                            , .cdrxml _
                            , .Ticket _
                            , .IndBaja _
                            , .Estado _
                            , .UsuarioCrea _
                            , .UsuarioModifica _
                            , .valorResumen _
                            , .Firma
                        ).ToString.Split("_")
                    .Id = stResultado(0)
                    If Not .leDetalle Is Nothing Then
                        For Each oeDet In .leDetalle
                            oeDet.IdBath = .Id
                            Select Case oeDet.TipoOperacion
                                Case "I", "A" : odDetalleBath.Guardar(oeDet)
                                Case "E" : odDetalleBath.Eliminar(oeDet)
                            End Select
                        Next
                    End If
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CON.Isp_ComprobanteElectronicoBath_IAE", "E", _
             "", oeComprobanteElectronicoBath.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function AdicionarComprobanteBath(ByVal dtCab As DataTable, ByVal fechaEnvio As DateTime, ByVal nombrexml As String, ByVal xmlbase64 As String, ByVal esBaja As Boolean, ByVal ticket As String, ByVal usuario As String, ByVal valorresumen As String, ByVal firma As String) As Boolean
        Try
            Dim i As Integer = 0
            Dim odComprobanteBathDet As New d_ComprobanteElectronicoBath_Detalle
            Dim oeComprobanteBathDet As e_ComprobanteElectronicoBath_Detalle
            Dim obj As New e_ComprobanteElectronicoBath
            obj.TipoOperacion = "I"
            obj.Id = ""
            obj.TipoReferencia = "1"
            obj.FechaEnvio = fechaEnvio
            obj.xmlbase64 = xmlbase64
            obj.nombrexml = nombrexml
            obj.cdrxml = ""
            obj.Ticket = ticket
            obj.IndBaja = esBaja
            obj.Estado = "E"
            obj.UsuarioCrea = usuario

            Guardar(obj)
            For Each drFila As DataRow In dtCab.Rows
              
                i = i + 1
                oeComprobanteBathDet = New e_ComprobanteElectronicoBath_Detalle
                oeComprobanteBathDet.TipoOperacion = "I"
                oeComprobanteBathDet.IdBath = obj.Id
                oeComprobanteBathDet.Item = i
                oeComprobanteBathDet.IdReferencia = drFila.Item("idcomp")
                oeComprobanteBathDet.TipoReferencia = "1"
                oeComprobanteBathDet.UsuarioCrea = usuario
                odComprobanteBathDet.Guardar(oeComprobanteBathDet)
            Next

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarEstadoBath(ByVal dtCab As List(Of e_ComprobanteElectronicoBath), ByVal dtDet As List(Of e_ComprobanteElectronicoBath_Detalle), ByVal cdrxml As String, ByVal flagError As Boolean, ByVal flagBaja As Boolean) As Boolean
        Dim odDocumento As New d_MovimientoDocumento
        Try
            Using transScope As New TransactionScope()

                If flagError Then
                    For Each drFila In dtCab
                        drFila.TipoOperacion = "A"
                        drFila.Estado = "R"
                        drFila.cdrxml = cdrxml
                        Guardar(drFila)
                    Next
                    For Each drFila In dtDet
                        odDocumento.ActualizarCabeceraComprobante(drFila.IdReferencia, IIf(flagBaja, "R", "C"), "", False)
                    Next
                Else
                    For Each drFila In dtCab
                        drFila.TipoOperacion = "A"
                        drFila.Estado = "A"
                        drFila.cdrxml = cdrxml
                        Guardar(drFila)
                    Next
                    For Each drFila In dtDet
                        odDocumento.ActualizarCabeceraComprobante(drFila.IdReferencia, "A", "", False)
                    Next
                End If
                transScope.Complete()
            End Using
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Function ListarTicket(oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath) As DataSet
        Try
            Dim ds As DataSet
            With oeComprobanteElectronicoBath
                ds = sqlhelper.ExecuteDataset("CON.Isp_ComprobanteElectronicoBath_Listar", .TipoOperacion _
                        , .Id _
                        , .TipoReferencia _
                        , .FechaEnvio.Date _
                        , .xmlbase64 _
                        , .nombrexml _
                        , .cdrxml _
                        , .Ticket _
                        , .IndBaja _
                        , .Estado _
                        , .FechaCrea.Date _
                        , .FechaModifica.Date _
                        )
            End With
            'If ds.Tables.Count = 0 Then Throw New Exception("¡No se encontraron Datos!")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ActualizarEstadoBath_Retencion(ByVal dtCab As List(Of e_ComprobanteElectronicoBath), ByVal dtDet As List(Of e_ComprobanteElectronicoBath_Detalle), ByVal cdrxml As String, ByVal flagError As Boolean, ByVal Usuario As String)
        Dim odDocumento As New d_DocumentoRetencion
        Dim oeDocumento As New e_DocumentoRetencion
        Try
            If flagError Then
                For Each drFila In dtCab
                    drFila.Estado = "R"
                    drFila.cdrxml = cdrxml
                    drFila.UsuarioModifica = Usuario
                    drFila.TipoOperacion = "U"
                    Guardar(drFila)
                Next
                For Each drFila In dtDet
                    With oeDocumento
                        .Id = drFila.Id
                        .EstadoElectronico = "R"
                        .UsuarioModifica = Usuario
                        .TipoOperacion = "U"
                    End With
                    odDocumento.Guardar(oeDocumento)
                Next
            Else
                For Each drFila In dtCab
                    drFila.Estado = "A"
                    drFila.cdrxml = cdrxml
                    drFila.TipoOperacion = "U"
                    Guardar(drFila)
                Next
                For Each drFila In dtDet
                    With oeDocumento
                        .Id = drFila.Id
                        .EstadoElectronico = "A"
                        .UsuarioModifica = Usuario
                        .TipoOperacion = "U"
                    End With
                    odDocumento.Guardar(oeDocumento)
                Next
            End If
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
End Class
