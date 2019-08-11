Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_DireccionarGRT
    Public mensajeEmergente As New c_Alertas

#Region "Declaración de variables"

    Dim oeSeguimiento As New e_Seguimiento
    Dim olSeguimiento As New l_Seguimiento

    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportista As New l_GuiaTransportista

    Dim GuiaTransportistaLista As New List(Of e_GuiaTransportista)

    Dim oeGuiaRemitente As New e_GuiaRemitente
    Dim olGuiaRemitente As New l_GuiaRemitente

    Dim oeGuiaTransportistaInterrumpida As New e_GuiaTransportistaInterrumpida
    Dim olGuiaTransportistaInterrumpida As New l_GuiaTransportistaInterrumpida

    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle

    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim ListaTracto As New List(Of e_Vehiculo)

    Dim oeFechas As New e_Fechas

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

#End Region

    Public Function ObtenerViaje(ByVal IdViaje As String, ByVal IdGuiaTransportista As String) As Boolean
        Try
            oeViaje = New e_Viaje
            oeViaje.Id = IdViaje
            oeViaje.TipoOperacion = "G"
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            txtIdViaje.Text = IdViaje
            txtIdSeguimiento.Text = oeViaje.Id
            txtIdOperacion.Text = oeViaje.IdOperacion
            txtCodigoOperacion.Text = oeViaje.Operacion
            txtCodigoViaje.Text = oeViaje.Codigo
            txtViajeTracto.Text = oeViaje.Tracto
            txtViajeCarreta.Text = oeViaje.Carreta
            fecViaje.Value = oeViaje.Fecha
            txtViajeOrigen.Text = oeViaje.Origen
            txtViajeDestino.Text = oeViaje.Destino
            txtViajePiloto.Text = oeViaje.Piloto
            txtViajeCopiloto.Text = oeViaje.Copiloto
            txtViajeEscala.Text = oeViaje.Escala
            txtIdOperacionDetalle.Text = oeViaje.Tesoreria

            oeGuiaTransportista = New e_GuiaTransportista
            oeGuiaTransportista.Id = IdGuiaTransportista
            oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
            txtIdGrt.Text = oeGuiaTransportista.Id
            txtSerie.Text = oeGuiaTransportista.Serie
            txtNumero.Text = oeGuiaTransportista.Numero
            verFacturado.Checked = oeGuiaTransportista.IndFacturado
            verConfirmado.Checked = oeGuiaTransportista.IndGrtConfirmada
            verDocumentos.Checked = oeGuiaTransportista.IndDocumentos
            verDoctsPerdido.Checked = oeGuiaTransportista.IndGrtPerdido
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Public Sub LlenaCombos()
        LlenarCombo(cboTracto, "Nombre", TractoPublic, -1)
    End Sub

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
    End Sub

    Private Sub frm_DireccionarGRT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaCombos()
        ControlRangoFechaInicializa()
        LimpiaGrid(griLista, ogdListaGuias)
    End Sub

    Private Sub verConfirmado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verConfirmado.CheckedChanged
        If verConfirmado.Checked Then
            verDocumentos.Enabled = True
            verDoctsPerdido.Enabled = True
        Else
            verDocumentos.Enabled = False
            verDocumentos.Checked = False
            verDoctsPerdido.Enabled = False
            verDoctsPerdido.Checked = False
        End If
    End Sub

    Private Sub verDocumentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verDocumentos.CheckedChanged
        If verDocumentos.Checked Then
            verDoctsPerdido.Enabled = False
            verDoctsPerdido.Checked = False
        Else
            verDoctsPerdido.Enabled = True
            verDoctsPerdido.Checked = False
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeViaje = New e_Viaje
            oeViaje.TipoOperacion = "6"
            oeViaje.ViajeVacio = 2
            oeViaje.Activo = 0
            oeViaje.FechaDesde = fecDesde.Value
            oeViaje.FechaHasta = fecHasta.Value
            oeViaje.IndMotriz = 1
            oeViaje.IdTracto = cboTracto.Value
            griLista.DataSource = olOperacion.ListarViaje(oeViaje)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Private Sub frm_DireccionarGRT_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griLista_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.AfterCellUpdate
        Try
            Dim Total_Selec As Integer = 0

            For I As Integer = 0 To griLista.Rows.Count - 1
                If griLista.Rows(I).Cells("Seleccion").Value = True Then
                    Total_Selec += 1
                End If
                If Total_Selec > 1 Then
                    griLista.Rows(I).Cells("Seleccion").Value = False
                    griLista.Rows(I).Appearance.BackColor = Color.White
                    griLista.Rows(I).Fixed = False
                End If
                If Total_Selec = 0 Then
                    txtDireccionarIdViaje.Text = ""
                    txtDireccionarCodigoViaje.Text = ""
                End If
            Next

            Select Case e.Cell.Column.Key.ToUpper
                Case "SELECCION"
                    If Total_Selec <= 1 Then
                        With griLista.Rows(e.Cell.Row.Index)
                            If .Cells("Seleccion").Value Then
                                .Fixed = True
                                txtDireccionarIdViaje.Text = .Cells("IdOperacion").Value
                                txtDireccionarCodigoViaje.Text = .Cells("Operacion").Value
                                .Appearance.BackColor = Color.Aqua
                            Else
                                .Appearance.BackColor = Color.White
                                .Fixed = False
                            End If
                        End With
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        Try
            griLista.UpdateData()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            oeGuiaTransportista = New e_GuiaTransportista
            With oeGuiaTransportista
                .TipoOperacion = "D"
                .Id = txtIdGrt.Text.Trim
                .IdSeguimiento = txtDireccionarIdViaje.Text.Trim
                .IndFacturado = verFacturado.Checked
                .IndGrtConfirmada = verConfirmado.Checked
                .IndDocumentos = verDocumentos.Checked
                .IndGrtPerdido = verDoctsPerdido.Checked
                .IdOperacionDetalle = txtIdOperacionDetalle.Text.Trim
            End With
            olGuiaTransportista.Guardar(oeGuiaTransportista)
            IndDireccionarGRT = True
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            Me.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        IndDireccionarGRT = False
        Me.Close()
    End Sub

    Private Sub fecDesde_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecDesde.Validating
        If fecDesde.Value = Nothing Then
            fecDesde.Value = Today.Date
        End If
    End Sub

    Private Sub fecHasta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecHasta.Validating
        If fecHasta.Value = Nothing Then
            fecHasta.Value = Today.Date
        End If
    End Sub
End Class