'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Public Class frm_ConfirmarCargaOperacionGRT
    Private mensajeEmergente As New c_Alertas

#Region "Declaración de variables"

    Dim oeDemandaDetalle As New e_DemandaDetalle
    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle
    Dim listaOD As New List(Of e_OperacionDetalle)
    Dim olOperacion As New l_Operacion
    Dim olIgv As New l_Impuesto
    Dim oeIgv As New e_Impuesto


    
#End Region

    Public Function ListarViajeCarga(ByVal Id As String, _
                                          ByVal IdViaje As String) As Boolean
        Try
            ComboGrilla()
            LimpiaGrid(griViajeDetalle, ogdOperacionDetalle)
            LimpiaGrid(griCargasConfirmadas, ogdOperacionDetalle)
            txtIdOperacionDetalle.Text = Id
            oeViaje = New e_Viaje
            txtIdViaje.Text = IdViaje
            oeViaje.Id = IdViaje
            oeViaje.TipoOperacion = "G"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            txtIdSeguimiento.Text = oeViaje.Id
            txtIdOperacion.Text = oeViaje.IdOperacion
            txtCodigoOperacion.Text = oeViaje.Operacion
            txtCodigoViaje.Text = oeViaje.Codigo
            txtViajeTracto.Text = oeViaje.Tracto
            txtViajeCarreta.Text = oeViaje.Carreta
            fecViaje.Value = oeViaje.Fecha
            exgruOperacion.Text = "Informacion de Viaje - Ruta: " & oeViaje.Origen & " - " & oeViaje.Destino
            txtViajePiloto.Text = oeViaje.Piloto
            txtViajeCopiloto.Text = oeViaje.Copiloto
            txtViajeEscala.Text = oeViaje.Escala
            oeOperacionDetalle = New e_OperacionDetalle
            oeOperacionDetalle.Id = Id
            oeOperacionDetalle.TipoOperacion = "G"
            griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)

            oeOperacionDetalle = New e_OperacionDetalle
            oeOperacionDetalle.IdOperacion = oeViaje.IdOperacion
            oeOperacionDetalle.TipoOperacion = "F"
            griCargasConfirmadas.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle).Where(Function(Item) Item.Id <> Id).ToList
            Dim olCombo As New l_Combo
            CrearComboGrid("ClienteFinal", "Nombre", griViajeDetalle, olCombo.ComboGrilla(ClientesPublic), True)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Sub ComboGrilla()
        Dim Lugar As New DataTable
        Dim Cliente As New DataTable
        Dim Carga As New DataTable
        Dim Material As New DataTable
        Dim Moneda As New DataTable
        Dim Comisionista As New DataTable
        Dim olCombo As New l_Combo

        Carga = olCombo.ComboGrilla(TipoCargaPublic)
        Cliente = olCombo.ComboGrilla(ClientesPublic)
        Comisionista = olCombo.ComboGrilla(ComisionistasPublic)
        Moneda = olCombo.ComboGrilla(MonedaPublic)
        Material = olCombo.ComboGrilla(MaterialesPublic)
        Lugar = olCombo.ComboGrilla(LugaresPublic)

        CrearComboGrid("Moneda", "Nombre", griViajeDetalle, Moneda, True)
        CrearComboGrid("Moneda", "Nombre", griCargasConfirmadas, Moneda, True)

        CrearComboGrid("Cliente", "Nombre", griViajeDetalle, Cliente, True)
        CrearComboGrid("Cliente", "Nombre", griCargasConfirmadas, Cliente, True)

        CrearComboGrid("Comisionista", "Nombre", griViajeDetalle, Comisionista, True)
        CrearComboGrid("Comisionista", "Nombre", griCargasConfirmadas, Comisionista, True)

        CrearComboGrid("Carga", "Nombre", griViajeDetalle, Carga, True)
        CrearComboGrid("Carga", "Nombre", griCargasConfirmadas, Carga, True)

        CrearComboGrid("Material", "Nombre", griViajeDetalle, Material, True)
        CrearComboGrid("Material", "Nombre", griCargasConfirmadas, Material, True)

        CrearComboGrid("Origen", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("Destino", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("Origen", "Nombre", griCargasConfirmadas, Lugar, True)
        CrearComboGrid("Destino", "Nombre", griCargasConfirmadas, Lugar, True)
        CrearComboGrid("ClienteFinal", "Nombre", griViajeDetalle, olCombo.ComboGrilla(ClientesPublic), True)

    End Sub

    Private Sub griViajeDetalle_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeDetalle.CellChange
        Try
            griViajeDetalle.UpdateData()
            FleteDetalleGrilla()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FleteDetalleGrilla()
        Try
            With oeDemandaDetalle
                With griViajeDetalle.ActiveRow
                    Select Case .Cells("Carga").Text
                        Case "VIAJE"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                        Case "TONELADA"
                            If Not .Cells("PesoToneladasDescarga").Value.ToString = "" Or Not IsNumeric(.Cells("PesoToneladasDescarga").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("PesoToneladasDescarga").Value)
                            Else
                                .Cells("PesoToneladasDescarga").Value = 0
                            End If
                            If .Cells("Seleccion").Value Then
                                .Cells("IndPesoTnDescarga").Value = 1
                            Else
                                .Cells("IndPesoTnDescarga").Value = 0
                            End If
                        Case "BOLSA"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                            If .Cells("Seleccion").Value Then
                                .Cells("IndPesoTnDescarga").Value = 1
                            Else
                                .Cells("IndPesoTnDescarga").Value = 0
                            End If
                        Case "PARIHUELA"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                        Case "METRO CUBICO"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                        Case "KILOMETRAJE"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                            If .Cells("Seleccion").Value Then
                                .Cells("IndPesoTnDescarga").Value = 1
                            Else
                                .Cells("IndPesoTnDescarga").Value = 0
                            End If
                    End Select

                    If Not .Cells("FleteUnitario").Value.ToString = "" Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                        oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                    Else
                        .Cells("FleteUnitario").Value = 0
                    End If
                    oeIgv = olIgv.IGV(Date.Now)
                    oeDemandaDetalle.IGV = oeIgv.Porcentaje
                    If .Cells("IncluyeIgv").Value = False Then
                        .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                    Else
                        .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularIgv
                    End If

                End With
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub griViajeDetalle_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griCargasConfirmadas_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griCargasConfirmadas.CellChange
        griCargasConfirmadas.UpdateData()
    End Sub

    Private Sub griCargasConfirmadas_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griCargasConfirmadas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim IdODconfirmada As String = ""
            Dim IndOD As Integer = 0
            If griCargasConfirmadas.Rows.Count > 0 Then
                For Each Fila As UltraWinGrid.UltraGridRow In griCargasConfirmadas.Rows.Where(Function(item) item.Cells("Seleccion").Value = True)
                    IndOD += 1
                    IdODconfirmada = Fila.Cells("Id").Value.ToString
                Next
                If IndOD <> 1 Then
                    griCargasConfirmadas.Focus()
                    Throw New Exception("Seleccione solo una Carga confirmada. para copiar sus GRT. y GRR.")
                End If
                oeOperacionDetalle = New e_OperacionDetalle
                listaOD = New List(Of e_OperacionDetalle)
                listaOD = griViajeDetalle.DataSource
                For Each OD As e_OperacionDetalle In listaOD
                    oeOperacionDetalle = OD
                Next
                oeOperacionDetalle.TipoOperacion = "1"
                oeOperacionDetalle.IdOperacion = IdODconfirmada
                oeOperacionDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                olOperacion.GuardarOperacionDetalle(oeOperacionDetalle)
                IndDocumentos = True
                Me.Close()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class