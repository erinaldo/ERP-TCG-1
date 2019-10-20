'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================


Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ViajesOperacion
    Private FechaServidor As Date = ObtenerFechaServidor()
    Private olFuncionesGenerales As New l_FuncionesGenerales
    Public mensajeEmergente As New c_Alertas
    Private oeViaje As New e_Viaje
    Private olOperacion As New l_Operacion
    Dim cadenaDemandas As String = ""
    Dim cadenaDevuelta As Array
    Public Shared motivoCancelacion As String = ""
    Public Shared IdConceptoCancEliminacion As String = ""

    Public Function ObtenerViajeOperacion(Listas As List(Of e_Viaje)) As Boolean
        Try
            LimpiaGrid(griViajesElimina, ogdListaOperacion)
            griViajesElimina.DataSource = Listas
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim testDialog As New frm_justificacion_cancelacion()
        testDialog.tipo = "VD"
        Dim ids As String = ""
        Dim codigos As String = ""
        Dim olCombo As New l_Combo
        Dim TipoEC As String = "E"
        Try
            Dim Operacion As String = ""
            Dim Estado As String = ""
            For Each Viaje As e_Viaje In ListaViajesOperacion
                If gUsuarioSGI.oeArea.Nombre <> gNombreAreaInformaticaSistemas Then
                    olFuncionesGenerales.ValidarFechaCierre("Eliminar", Viaje.Fecha.Date, FechaServidor.Date)
                End If
                '------------------------------
                oeViaje = New e_Viaje
                oeViaje.Id = Viaje.Id
                oeViaje.TipoOperacion = "P"
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                If oeViaje.IdCopiloto.Trim = "" Then
                    If oeViaje.Estado = "PROGRAMADO" Then
                        If CInt(oeViaje.Cantidad) = 0 And CInt(oeViaje.FleteUnitario) = 0 And CInt(oeViaje.IncluyeIgv) = 0 Then
                            If oeViaje.Escala = "" Then
                                If oeViaje.Tesoreria <> "PENDIENTE" Then
                                    TipoEC = "D"                                    
                                End If
                                If CInt(oeViaje.PesoToneladas) <> 0 Then
                                    Throw New Exception(oeViaje.Codigo & " Ya fue Habilitado por Tesoreria, Consulte su Saldo")
                                End If

                            Else
                                Throw New Exception(oeViaje.Codigo & " Este viaje tiene tanqueos asociados, Comunicarse con el Area de Combustible")
                            End If
                        Else
                            Throw New Exception(oeViaje.Codigo & " ya se an ingresaron documentos en guias")
                        End If
                    Else
                        Throw New Exception(oeViaje.Codigo & " Se encuentra en Seguimiento")
                    End If
                Else
                    Throw New Exception("El Viaje no se puede Eliminar/Cancelar pues esta siendo ediatado por" & Environment.NewLine & Environment.NewLine & _
                                "el Usuario: " & oeViaje.UsuarioModifica & Environment.NewLine & _
                                "desde: " & oeViaje.LlegadaOrigen & Environment.NewLine & _
                                "en la Sucursal: " & oeViaje.Piloto)
                End If
                Operacion = Viaje.Operacion
            Next
            'If MessageBox.Show("Esta seguro de Eliminar/Cancelar los Viajes de la Operacion: " & Operacion, _
            '                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '    ugb_Espera.Visible = True
            '    Application.DoEvents()
            '    Cursor.Current = Cursors.WaitCursor
            '    Cursor.Show()
            '    For Each Viajes As e_Viaje In ListaViajesOperacion
            '        Viajes.TipoOperacion = "D"
            '        Viajes.UsuarioCreacion = gUsuarioSGI.Id
            '        olOperacion.EliminarViaje(Viajes)
            '    Next
            '    EliminaViajes = True
            '    ugb_Espera.Visible = False
            '    Me.Close()
            'End If
            'verificar demandas afectadas
            '    Me.Dispose()
            Dim listaCancelacion = New List(Of e_Combo)
            Dim oeCombo = New e_Combo
            If TipoEC = "E" Then
                testDialog.Text = "Motivo de Eliminación"                
                oeCombo.Nombre = "ConceptoEliminacion"
                oeCombo.Descripcion = "Descripcion;NombreTabla;Viaje"
                listaCancelacion = olCombo.Listar(oeCombo)
            Else
                testDialog.Text = "Motivo de Cancelación"
                oeCombo.Nombre = "ConceptoCancelacion"
                oeCombo.Descripcion = "Descripcion;NombreTabla;Viaje"
                listaCancelacion = olCombo.Listar(oeCombo)
            End If            
            LlenarComboMaestro(testDialog.cboConcepto, listaCancelacion, 1)
            If testDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then              
                'cambios
                ugb_Espera.Visible = True
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                For Each Viajes As e_Viaje In ListaViajesOperacion
                    'Viajes.TipoOperacion = IIf(TipoEC = "C", "D", "E")
                    Viajes.TipoOperacion = TipoEC
                    Viajes.UsuarioCreacion = gUsuarioSGI.Id
                    Viajes.GlosaEscala = motivoCancelacion
                    Viajes.Flota = IdConceptoCancEliminacion
                    cadenaDemandas = olOperacion.EliminarViajes(Viajes)
                    If cadenaDemandas <> "" Then
                        cadenaDemandas = cadenaDemandas.Substring(0, cadenaDemandas.Length - 1)
                        cadenaDevuelta = cadenaDemandas.Split(";")
                        For i As Integer = 0 To cadenaDevuelta.Length - 1
                            ids = ids + cadenaDevuelta(i).ToString.Split("-")(0) + "-"
                            codigos = codigos + cadenaDevuelta(i).ToString.Split("-")(1) + "-"
                        Next
                        codigos = codigos.Substring(0, codigos.Length - 1)
                        ids = ids.Substring(0, ids.Length - 1)
                    End If
                    If cadenaDemandas <> "" Then
                        If MessageBox.Show("El estado de las DEMANDA(S) " & codigos & " fueron afectadas al " & IIf(TipoEC = "D", "CANCELAR", "ELIMINAR") & " el Viaje: " & _
                                             oeViaje.Codigo & " ¿Desea enviar las DEMANDAS a SU CORREO?", _
                                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            For i As Integer = 0 To ids.Trim.Split("-").Length - 1
                                EnviarCorreo(ids.Trim.Split("-")(i))
                            Next
                        End If
                        ids = ""
                        codigos = ""
                    End If
                Next
                ugb_Espera.Visible = False
                Me.Dispose()
            Else
                Exit Sub
            End If
            EliminaViajes = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub EnviarCorreo(ByVal idDemanda As String)
        Try
            Dim formulario As frm_EnvioEmail
            formulario = New frm_EnvioEmail
            formulario.Modulo = "DemandaRapida"
            formulario.bandFrmExterno = "OP"
            formulario.cadenaMensajeHtml = llenarTablaDemanda(idDemanda)
            formulario.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub frm_ViajesOperacion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        EliminaViajes = False
        Me.Close()
    End Sub

End Class