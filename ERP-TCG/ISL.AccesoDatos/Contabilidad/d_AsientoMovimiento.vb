'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsientoMovimiento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoMovimiento
        Try
            Dim oeAsientoMovimiento = New e_AsientoMovimiento( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsiento").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("Glosa").ToString _
                             , FormatNumber(o_fila("DebeMN").ToString, 2) _
                             , FormatNumber(o_fila("HaberMN").ToString, 2) _
                             , FormatNumber(o_fila("DebeME").ToString, 2) _
                             , FormatNumber(o_fila("HaberME").ToString, 2) _
                             , o_fila("IdUsuarioCrea").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("NroLinea") _
            )
            Return oeAsientoMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoMovimiento_Listar", "", oeAsientoMovimiento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAsientoMovimiento = Cargar(ds.Tables(0).Rows(0))

                Dim oeMovAnalisis As New e_MovimientoAnalisis
                Dim odMovAnalisis As New d_MovimientoAnalisis
                oeMovAnalisis.IdAsientoMovimiento = oeAsientoMovimiento.Id
                oeAsientoMovimiento.MovimientoAnalisis.AddRange(odMovAnalisis.Listar(oeMovAnalisis))
                If oeAsientoMovimiento.MovimientoAnalisis.Count > 0 Then
                    Dim listaMA As New List(Of e_MovimientoAnalisis)
                    listaMA = oeAsientoMovimiento.MovimientoAnalisis.Where(Function(item) item.Monto <> item.Saldo).ToList 'el monto es diferente al saldo(caso 16 que ya se rindio)
                    If listaMA.Count > 0 Then ' si tiene analisis y el monto es diferente al saldo(caso 16 que ya se rindio) no puede editar
                        oeAsientoMovimiento.Editable = False
                    End If
                End If

                Dim oeMovCajaBanco As New e_MovimientoCajaBanco
                Dim odMovCajaBanco As New d_MovimientoCajaBanco
                oeMovCajaBanco.IdAsientoMovimiento = oeAsientoMovimiento.Id
                oeMovCajaBanco = odMovCajaBanco.Obtener(oeMovCajaBanco)
                oeAsientoMovimiento.MovimientoCajaBanco = oeMovCajaBanco
                If oeMovCajaBanco.Id <> "" Then
                    If Not oeMovCajaBanco.IdPeriodoConcilia Is Nothing Then
                        If oeMovCajaBanco.IdPeriodoConcilia.Trim <> "" Then
                            oeAsientoMovimiento.Editable = False
                        End If
                    End If
                End If

                '-----------tabla relacion con Documento-------------
                Dim oeAsMovMovDoc As New e_AsientoMov_MovDoc
                Dim odAsMovMovDoc As New d_AsientoMov_MovDoc
                Dim leAsMovMovDoc As New List(Of e_AsientoMov_MovDoc)
                oeAsMovMovDoc.IdAsientoMovimiento = oeAsientoMovimiento.Id
                leAsMovMovDoc.AddRange(odAsMovMovDoc.Listar(oeAsMovMovDoc))
                If leAsMovMovDoc.Count > 0 Then
                    oeAsMovMovDoc = leAsMovMovDoc.Item(0)
                End If
                '--------------------------------------
                If oeAsMovMovDoc.IdMovimientoDocumento.Trim <> "" Then
                    Dim oeMovDocumento As New e_MovimientoDocumento
                    Dim odMovDocumento As New d_MovimientoDocumento
                    oeMovDocumento.Id = oeAsMovMovDoc.IdMovimientoDocumento
                    oeMovDocumento = odMovDocumento.Obtener(oeMovDocumento)
                    oeAsientoMovimiento.MovimientoDocumento = oeMovDocumento
                    If oeMovDocumento.Total <> oeMovDocumento.Saldo Then 'no se puede eliminar si el saldo es diferente del total
                        oeAsientoMovimiento.Editable = False
                    End If
                End If

                '-----------tabla relacion con Obligacion-------------
                Dim oeAsMovObliga As New e_AsientoMov_ObligacionFin
                Dim odAsMovObliga As New d_AsientoMov_ObligacionFin
                Dim leAsMovObliga As New List(Of e_AsientoMov_ObligacionFin)
                oeAsMovObliga.TipoOperacion = String.Empty
                oeAsMovObliga.IdAsientoMovimiento = oeAsientoMovimiento.Id
                leAsMovObliga.AddRange(odAsMovObliga.Listar(oeAsMovObliga))
                If leAsMovObliga.Count > 0 Then
                    oeAsMovObliga = leAsMovObliga.Item(0)
                End If
                '--------------------------------------
                If oeAsMovObliga.IdObligacionFinanciera <> "" Then
                    Dim oeObligacion As New e_ObligacionFin
                    Dim odObligacion As New d_ObligacionFinanciera
                    oeObligacion.Id = oeAsMovObliga.IdObligacionFinanciera
                    oeObligacion.TipoOperacion = String.Empty
                    oeObligacion = odObligacion.Obtener2(oeObligacion)
                    oeAsientoMovimiento.ObligacionFin = oeObligacion
                    If IIf(oeObligacion.IdMoneda = "1CH01", oeObligacion.MontoMN, oeObligacion.MontoME) <> oeObligacion.Saldo Then 'no se puede eliminar si el saldo es diferente del total
                        oeAsientoMovimiento.Editable = False
                    End If
                End If

            End If
            Return oeAsientoMovimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerAsientoCompra(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoMovimiento_Listar", "", oeAsientoMovimiento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                '--------saca id de asiento-------------
                oeAsientoMovimiento = Cargar(ds.Tables(0).Rows(0))
                '---------------------------------------
            End If
            Return oeAsientoMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As List(Of e_AsientoMovimiento)
        Try
            Dim ldAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Dim ds As DataSet
            With oeAsientoMovimiento
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoMovimiento_Listar", .TipoOperacion _
                        , .Id _
                        , .IdAsiento _
                        , .IdCuentaContable _
                        , .Glosa _
                        , .DebeMN _
                        , .HaberMN _
                        , .DebeME _
                        , .HaberME _
                        , .IdUsuarioCrea _
                        , .FechaCreacion _
                        , .Activo _
                        )
            End With
            oeAsientoMovimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAsientoMovimiento = Cargar(o_Fila)
                    ldAsientoMovimiento.Add(oeAsientoMovimiento)
                Next
            End If
            Return ldAsientoMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByRef oeAsientoMovimiento As e_AsientoMovimiento) As Boolean
        Try
            Dim stResultado() As String
            With oeAsientoMovimiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_AsientoMovimiento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdAsiento _
                        , .IdCuentaContable _
                        , .Glosa _
                        , .DebeMN _
                        , .HaberMN _
                        , .DebeME _
                        , .HaberME _
                        , .IdUsuarioCrea _
                        , .FechaCreacion _
                        , .Activo
                    ).ToString.Split("_")
                oeAsientoMovimiento.Id = stResultado(0)

                Dim odMovAn As New d_MovimientoAnalisis
                If Not .MovimientoAnalisis Is Nothing Then
                    Dim Ids As String = ""
                    For Each oeMovAn As e_MovimientoAnalisis In .MovimientoAnalisis 'analisi relacionado a detalles de asiento
                        oeMovAn.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        With oeMovAn
                            .IdAsientoMovimiento = stResultado(0)
                            If .TipoOperacion = "I" Or .TipoOperacion = "G" Then
                                If .Id <> "" Then
                                    ._IdMovimientoAnalisis = .Id
                                End If
                                odMovAn.Guardar(oeMovAn)
                            ElseIf .TipoOperacion = "E" Then
                                odMovAn.Eliminar(oeMovAn)

                            End If
                            If ._CambiaSaldo = True Then
                                If ._SaldoFinal <> 0 Then
                                    odMovAn.CancelaSaldo("P", .Id, ._SaldoFinal)
                                Else
                                    Ids = Ids & .Id & ","
                                End If
                            End If
                        End With
                    Next

                    If .MovimientoAnalisis.Count > 0 And .DivideAnalisis Then
                        odMovAn.ActualizaMonto(stResultado(0))
                    End If
                    If Ids <> "" Then
                        odMovAn.CancelaSaldo("S", Ids)
                    End If
                End If
                If Not .MovimientoCajaBanco Is Nothing Then 'movimiento banco relacionado a detalle de asiento y a ctas x CYP
                    If .MovimientoCajaBanco.TipoOperacion <> "" Then
                        Dim odMovCB As New d_MovimientoCajaBanco
                        Dim oeMovCB As New e_MovimientoCajaBanco
                        oeMovCB = .MovimientoCajaBanco
                        oeMovCB.IdAsientoMovimiento = stResultado(0)
                        oeMovCB.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        If .MovimientoCajaBanco.TipoOperacion = "E" Then
                            odMovCB.Eliminar(oeMovCB)
                        Else
                            odMovCB.Guardar(oeMovCB)
                            oeAsientoMovimiento._IdMovimientoCajaBanco = oeMovCB.Id

                        End If
                    End If
                End If
                If Not .MovimientoDocumento Is Nothing Then 'cuando se inserta asiento y documento
                    If .MovimientoDocumento.TipoOperacion <> "" Then 'movimiento documento, llama proceso de movimiento documento
                        Dim odMovDoc As New d_MovimientoDocumento
                        Dim oeMovDoc As New e_MovimientoDocumento
                        oeMovDoc = .MovimientoDocumento
                        oeMovDoc.IdAsientoMovimiento = stResultado(0)
                        oeMovDoc.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        oeMovDoc.CuentaxCyP.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        If .MovimientoDocumento.TipoOperacion = "E" Then
                            odMovDoc.Eliminar(oeMovDoc)
                        Else
                            If Not oeMovDoc.CuentaxCyP Is Nothing Then
                                oeMovDoc.CuentaxCyP._IdAsientoMovimiento = stResultado(0) 'PARA CASO DE COBROS Y PAGOS
                            End If
                            odMovDoc.Guardar(oeMovDoc, Nothing, False)
                        End If
                    End If
                End If
                '(SOLO PARA LA PROVISION DEL DOCUMENTO) cuando viene desde DOCUMENTO, para pagos, cobros y cancelacion se encuentra en CuentaxCyP
                If Not .AsMov_MovDoc Is Nothing Then 'cuando documento esta generado y debe generarse relacion
                    If .AsMov_MovDoc.TipoOperacion <> "" Then 'relacion detalle de asiento y movimiento documento
                        Dim odAsM As New d_AsientoMov_MovDoc
                        .AsMov_MovDoc.IdAsientoMovimiento = stResultado(0)
                        .AsMov_MovDoc.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        If .AsMov_MovDoc.TipoOperacion = "E" Then
                            odAsM.Eliminar(.AsMov_MovDoc)
                        Else
                            odAsM.Guardar(.AsMov_MovDoc)
                        End If
                    End If
                End If
                '(SOLO PARA LA PROVISION DEL DOCUMENTO) cuando viene desde OBLIGACION, para pagos se encuentra en OBLIGACIONPAGO
                If Not .AsMov_ObligacionFin Is Nothing Then 'cuando documento esta generado y debe generarse relacion
                    If .AsMov_ObligacionFin.TipoOperacion <> "" Then
                        Dim odAsM As New d_AsientoMov_ObligacionFin
                        .AsMov_ObligacionFin.IdAsientoMovimiento = stResultado(0)
                        .AsMov_ObligacionFin.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        If .AsMov_ObligacionFin.TipoOperacion = "E" Then
                            odAsM.Eliminar(.AsMov_ObligacionFin)
                        Else
                            odAsM.Guardar(.AsMov_ObligacionFin)
                        End If
                    End If
                End If
                'Para caso de Pago de Obligacion Financiera
                If Not .ObligacionFinanciera Is Nothing Then
                    If .ObligacionFinanciera.TipoOperacion <> "" Then
                        Dim odObligacion As New d_ObligacionFinanciera
                        .ObligacionFinanciera._IdAsientoMovimiento = oeAsientoMovimiento.Id
                        .ObligacionFinanciera.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odObligacion.Guardar(.ObligacionFinanciera, Nothing, False)
                    End If
                End If
                If Not .GrupoAsiento Is Nothing Then
                    If .GrupoAsiento.TipoOperacion = "I" Then
                        Dim odGrupoAsiento As New d_Grupo_Asiento
                        .GrupoAsiento.IdAsientoMovimiento = stResultado(0)
                        .GrupoAsiento.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odGrupoAsiento.Guardar(.GrupoAsiento)
                    End If
                End If
                '---------para caso de guardar retencion--------------------
                If Not .DocumentoRetencion Is Nothing Then
                    If .DocumentoRetencion.TipoOperacion = "I" Then
                        Dim odDocumentoRetencion As New d_DocumentoRetencion
                        .DocumentoRetencion.IdAsientoMovimiento = stResultado(0)
                        .DocumentoRetencion.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odDocumentoRetencion.Guardar(.DocumentoRetencion)
                    End If
                End If
                '-----------------------------------------------------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean
        Try
            Dim stResultado() As String
            Dim odMvimientoAnalisis As New d_MovimientoAnalisis
            With oeAsientoMovimiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_AsientoMovimiento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdAsiento _
                        , .IdCuentaContable _
                        , .Glosa _
                        , .DebeMN _
                        , .HaberMN _
                        , .DebeME _
                        , .HaberME _
                        , .IdUsuarioCrea _
                        , .FechaCreacion _
                        , .Activo
                    ).ToString.Split("_")
                oeAsientoMovimiento.Id = stResultado(0)
                If Not .DataTableAnalisis Is Nothing Then
                    For Each row As DataRow In .DataTableAnalisis.Rows
                        row("IdAsientoMovimiento") = stResultado(0)
                    Next
                    If .DataTableAnalisis.Rows.Count > 0 Then
                        odMvimientoAnalisis.GuardarMasivo(.DataTableAnalisis)
                    End If
                End If
                Dim Ids As String = ""
                If Not .MovimientoAnalisis Is Nothing Then
                    For Each oeMovAn As e_MovimientoAnalisis In .MovimientoAnalisis 'analisi relacionado a detalles de asiento
                        oeMovAn.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        With oeMovAn
                            If ._TipoGuardarMasivo = "Rendir" Then
                                If ._CambiaSaldo = True Then
                                    If ._SaldoFinal <> 0 Then
                                        odMvimientoAnalisis.CancelaSaldo("P", .Id, ._SaldoFinal)
                                    Else
                                        Ids = Ids & .Id & ","
                                    End If
                                End If
                            Else
                                If .TipoOperacion = "G" Then
                                    If .Id <> "" Then
                                        ._IdMovimientoAnalisis = .Id
                                    End If
                                    odMvimientoAnalisis.Guardar(oeMovAn)
                                ElseIf .TipoOperacion = "E" Then
                                    odMvimientoAnalisis.Eliminar(oeMovAn)

                                End If
                                'If .TipoOperacion = "E" Then
                                '    odMvimientoAnalisis.Eliminar(oeMovAn)
                                'End If
                            End If
                        End With
                    Next
                    If Ids <> "" Then
                        odMvimientoAnalisis.CancelaSaldo("S", Ids)
                    End If
                End If

                If Not .AsMov_MovDoc Is Nothing Then
                    ' si insertamos asiento_movimiento se inserta detalle 
                    '-----------tabla relacion-------------
                    Dim oeAsMovMovDoc As New e_AsientoMov_MovDoc
                    Dim odAsMovMovDoc As New d_AsientoMov_MovDoc
                    If .AsMov_MovDoc.TipoOperacion = "I" Then
                        .AsMov_MovDoc.IdAsientoMovimiento = stResultado(0)
                        .AsMov_MovDoc.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odAsMovMovDoc.Guardar(.AsMov_MovDoc)
                    End If
                    '--------
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarComprobante(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean
        Try
            Dim stResultado() As String
            With oeAsientoMovimiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_AsientoMovimiento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdAsiento _
                        , .IdCuentaContable _
                        , .Glosa _
                        , .DebeMN _
                        , .HaberMN _
                        , .DebeME _
                        , .HaberME _
                        , .IdUsuarioCrea _
                        , .FechaCreacion _
                        , .Activo
                    ).ToString.Split("_")
                Dim odMovAn As New d_MovimientoAnalisis
                If Not .MovimientoAnalisis Is Nothing AndAlso .MovimientoAnalisis.Count > 0 Then
                    For Each oeMovAn As e_MovimientoAnalisis In .MovimientoAnalisis
                        oeMovAn.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        With oeMovAn
                            .IdAsientoMovimiento = stResultado(0)
                            If .TipoOperacion = "I" Then
                                odMovAn.Guardar(oeMovAn)
                            ElseIf .TipoOperacion = "E" Then
                                odMovAn.Eliminar(oeMovAn)
                            End If
                        End With
                    Next
                Else
                    Dim oeMovAn As New e_MovimientoAnalisis
                    oeMovAn.IdAsientoMovimiento = stResultado(0)
                    oeMovAn.TipoOperacion = "L"
                    oeMovAn.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                    odMovAn.Guardar(oeMovAn) '---elimina por AsientoMovimento
                End If


                If Not .AsMov_MovDoc Is Nothing Then
                    ' si insertamos asiento_movimiento se inserta detalle 
                    '-----------tabla relacion-------------
                    Dim oeAsMovMovDoc As New e_AsientoMov_MovDoc
                    Dim odAsMovMovDoc As New d_AsientoMov_MovDoc
                    If .AsMov_MovDoc.TipoOperacion = "I" Then
                        .AsMov_MovDoc.IdAsientoMovimiento = stResultado(0)
                        .AsMov_MovDoc.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odAsMovMovDoc.Guardar(.AsMov_MovDoc)
                    ElseIf .AsMov_MovDoc.TipoOperacion = "A" Then

                        oeAsMovMovDoc = New e_AsientoMov_MovDoc
                        oeAsMovMovDoc.IdAsientoMovimiento = stResultado(0)
                        oeAsMovMovDoc.IdMovimientoDocumento = .AsMov_MovDoc.IdMovimientoDocumento
                        oeAsMovMovDoc.TipoOperacion = "I"
                        oeAsMovMovDoc.Activo = True
                        oeAsMovMovDoc.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odAsMovMovDoc.Guardar(oeAsMovMovDoc)
                        '------------------------------
                    End If

                    '--------
                End If
                'If Not .ObligacionFinanciera Is Nothing Then
                '    If .ObligacionFinanciera.TipoOperacion = "S" Then 'solo para el caso de compras por leasing debe entrar aqui
                '        '.ObligacionFinanciera.oeObligacionPago.OeAsientoMov_ObligFin.IdAsientoMovimiento = stResultado(0)
                '        '.ObligacionFinanciera._IdAsientoMovimiento = stResultado(0)
                '        .ObligacionFinanciera._IdAsientoMovimiento = stResultado(0)
                '        Dim odObligacion As New d_ObligacionFinanciera
                '        odObligacion.Guardar(.ObligacionFinanciera, Nothing, False)
                '    End If
                'End If
                If Not .ObligacionFin Is Nothing Then
                    If .ObligacionFin.TipoOperacion = "S" Then 'solo para el caso de compras por leasing debe entrar aqui
                        .ObligacionFin._IdAsientoMovimiento = stResultado(0)
                        Dim odObligacion As New d_ObligacionFinanciera
                        .ObligacionFin.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odObligacion.GuardarObligacion2(.ObligacionFin)
                    End If
                End If
                '----------------------------------------------------------------------------------------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean
        Try
            With oeAsientoMovimiento
                sqlhelper.ExecuteNonQuery("CON.Isp_AsientoMovimiento_IAE", "E", _
                 "", .Id, "", "", "", 0, 0, 0, 0, .IdUsuarioCrea)
                '----ES STORE ELIMINA MovimientoAnalisis,MovimientoCajaBanco,AsientoMov_MovDoc
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.AsientoMovimiento para casos de insercion masiva (Solo para apertura)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.AsientoMovimiento", Left(PrefijoID, 1) & "SI"
                                  )
            Return IIf(stResultado Is Nothing, Left(PrefijoID, 1) & "SI" & "0000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInsertar(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.AsientoMovimiento", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "0000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guarda esta tabla en masivo
    ''' </summary>
    ''' <param name="DTAsientoMovimiento">Estructura de Con.AsientoMovimiento</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarMasivo2(ByVal DTAsientoMovimiento As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsientoMovimiento, False)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener2(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As e_AsientoMovimiento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoMovimiento_Listar", "E", oeAsientoMovimiento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAsientoMovimiento = Cargar(ds.Tables(0).Rows(0))
                Dim oeMovAnalisis As New e_MovimientoAnalisis, odMovAnalisis As New d_MovimientoAnalisis
                oeMovAnalisis.TipoOperacion = "D"
                oeMovAnalisis.IdAsientoMovimiento = oeAsientoMovimiento.Id
                oeAsientoMovimiento.MovimientoAnalisis.AddRange(odMovAnalisis.Listar(oeMovAnalisis))
            End If
            Return oeAsientoMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function


#Region "Descuento de Personal"

    ''' <summary>
    ''' Guadar Asiento Movimiento con Movimiento Analisis y Movimiento Caja Banco
    ''' </summary>
    ''' <param name="oeAsientoMovimiento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarAsiMov(ByVal oeAsientoMovimiento As e_AsientoMovimiento) As Boolean
        Try
            Dim odMovCajaBanco As New d_MovimientoCajaBanco, odMovAnalisis As New d_MovimientoAnalisis
            Dim odAsiMov_MovDoc As New d_AsientoMov_MovDoc, odAsiMov_OblFin As New d_AsientoMov_ObligacionFin
            Dim odObligacionbPago As New d_ObligacionPago
            Dim odCtaCP As New d_CuentaxCyP, odGrupoAsiento As New d_Grupo_Asiento
            Dim stResultado() As String
            Dim IdObliPago As String = ""
            With oeAsientoMovimiento
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_AsientoMovimiento_IAE", .TipoOperacion, .PrefijoID,
                       .Id _
                       , .IdAsiento _
                       , .IdCuentaContable _
                       , .Glosa _
                       , .DebeMN _
                       , .HaberMN _
                       , .DebeME _
                       , .HaberME _
                       , .IdUsuarioCrea _
                       , .FechaCreacion _
                       , .Activo
                   ).ToString.Split("_")
                .Id = stResultado(0)
                'Guardar Movimiento Analisis
                If (.DataTableAnalisis IsNot Nothing) AndAlso .DataTableAnalisis.Rows.Count > 0 Then
                    For Each fil In .DataTableAnalisis.Rows
                        fil("IdAsientoMovimiento") = stResultado(0)
                    Next
                    odMovAnalisis.GuardarMasivo(.DataTableAnalisis)
                End If
                'Guardar Movimiento Caja Banco
                If (.MovimientoCajaBanco IsNot Nothing) AndAlso .MovimientoCajaBanco.TipoOperacion = "I" Then
                    .MovimientoCajaBanco.IdAsientoMovimiento = stResultado(0)
                    .MovimientoCajaBanco.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                    odMovCajaBanco.Guardar(.MovimientoCajaBanco)
                    If .MovimientoCajaBanco.IdCuentaBancaria <> "" Then ._IdMovimientoCajaBanco = .MovimientoCajaBanco.Id
                End If
                'Guardar Cuenta por Cobrar y Pagar
                If (.oeCuentaCP IsNot Nothing) AndAlso .oeCuentaCP.TipoOperacion = "I" Then
                    .oeCuentaCP._IdAsientoMovimiento = stResultado(0)
                    .oeCuentaCP.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                    odCtaCP.GuardarCuentaCyP_AsiMovMovDoc(.oeCuentaCP)
                End If
                'Guardar Asiento Movimiento - MovimientoDocumento
                If (.AsMov_MovDoc IsNot Nothing) AndAlso .AsMov_MovDoc.TipoOperacion = "I" Then
                    .AsMov_MovDoc.IdAsientoMovimiento = stResultado(0)
                    .AsMov_MovDoc.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                    odAsiMov_MovDoc.Guardar(.AsMov_MovDoc)
                End If
                'Guardar Asiento Movimiento - Obligacion Financiera
                If (.AsMov_ObligacionFin IsNot Nothing) AndAlso .AsMov_ObligacionFin.TipoOperacion = "I" Then
                    .AsMov_ObligacionFin.IdAsientoMovimiento = stResultado(0)
                    'Guardar Pago Obligacion
                    If (.ObligacionFinanciera.oeObligacionPago IsNot Nothing) AndAlso .ObligacionFinanciera.oeObligacionPago.TipoOperacion = "I" Then
                        .ObligacionFinanciera.oeObligacionPago.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                        odObligacionbPago.Guardar(.ObligacionFinanciera.oeObligacionPago)
                        IdObliPago = .ObligacionFinanciera.oeObligacionPago.Id
                    End If
                    .AsMov_ObligacionFin.IdObligacionPago = IdObliPago
                    .AsMov_ObligacionFin.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                    odAsiMov_OblFin.Guardar(.AsMov_ObligacionFin)
                End If
                'Guardar Asiento Movimiento - Grupo Asiento
                If (.GrupoAsiento IsNot Nothing) AndAlso .GrupoAsiento.TipoOperacion = "I" Then
                    .GrupoAsiento.IdAsientoMovimiento = stResultado(0)
                    .GrupoAsiento.PrefijoID = oeAsientoMovimiento.PrefijoID '@0001
                    odGrupoAsiento.Guardar(.GrupoAsiento)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

End Class
