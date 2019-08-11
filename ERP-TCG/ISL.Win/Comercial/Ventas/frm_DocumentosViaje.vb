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

Public Class frm_DocumentosViaje

    Public mensajeEmergente As New c_Alertas
#Region "Declaración de variables"
    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar
    Dim ListaLugar As New List(Of e_Lugar)

    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim ListaMoneda As New List(Of e_Moneda)

    Dim oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente
    Dim ListaCliente As New List(Of e_Cliente)
    Dim ListaComisionista As New List(Of e_Cliente)
    Dim ListaRemitenteLista As New List(Of e_Cliente)
    Dim ListaDestinatario As New List(Of e_Cliente)
    Dim ListaRemitente As New List(Of e_Cliente)

    Dim oeTipoCarga As New e_TipoCarga
    Dim olTipoCarga As New l_TipoCarga
    Dim ListaTipoCarga As New List(Of e_TipoCarga)

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim ListaMaterial As New List(Of e_Material)

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim oeSeguimiento As New e_Seguimiento
    Dim olSeguimiento As New l_Seguimiento

    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportista As New l_GuiaTransportista

    Dim GuiaTransportistaLista As New List(Of e_GuiaTransportista)


    Dim oeGuiaRemitente As New e_GuiaRemitente
    Dim olGuiaRemitente As New l_GuiaRemitente

    Dim oeGuiaTransportistaInterrumpida As New e_GuiaTransportistaInterrumpida
    Dim olGuiaTransportistaInterrumpida As New l_GuiaTransportistaInterrumpida

    Dim olDireccionEmpresa As New l_Direccion_EmpresaPersona
    Dim oeDireccionEmpresa As New e_Direccion_EmpresaPersona
    Dim ListaDireccionEmpresa As New List(Of e_Direccion_EmpresaPersona)
    Dim ListaPuntoPartida As New List(Of e_Direccion_EmpresaPersona)
    Dim ListaPuntoLlegada As New List(Of e_Direccion_EmpresaPersona)


    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle

    Dim olIgv As New l_Impuesto
    Dim oeIgv As New e_Impuesto

    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion

    Dim olTiempoCiclo As New l_TiempoCiclo
    Dim oeTiempoCiclo As New e_TiempoCiclo

    Dim olVehiculo As New l_Vehiculo
    Dim oeVehiculo As New e_Vehiculo

    Dim olMotivoTrasladoInterrumpido As New l_MotivoDocumento
    Dim oeMotivoTrasladoInterrumpido As New e_MotivoDocumento
    Dim ListaMotivoDocumento As New List(Of e_MotivoDocumento)

    Dim oeFechas As New e_Fechas

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

    Dim GRT As String

    Dim oeDemandaDetalle As New e_DemandaDetalle

    Dim SalidaOrigenIndicador As Boolean = False

    Dim SalidaDestinoIndicador As Boolean = False

    Dim oeUsuarioPerfil As New e_UsuarioPerfil
    Dim olUsuarioPerfil As New l_UsuarioPerfil

    Dim oePerfil As New e_Perfil
    Dim olPerfil As New l_Perfil

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim Prefijo As New l_Configuracion

    Dim ctrNuevo As Boolean = False, ctrEditar As Boolean = False, SOrigen As String, SDestino As String

    Dim oeRegConsumoCombustible As New e_RegistroConsumoCombustible, olRegConsumoCombustible As New l_RegistroConsumoCombustible
    Dim lstRegConsumoCombustible As New List(Of e_RegistroConsumoCombustible)

    Dim IdPuntoPartida As String = ""
    Dim IdPuntoLlegada As String = ""

    Dim IdRemitente As String = ""
    Dim IdDestinatario As String = ""

    Dim Nombre As String = ""

    Dim Tipo As Integer = 0

    'Tipo 0 = Guia Transportista Normal
    'Tipo 1 = Agregar Varias Guias Transportistas a Viaje

#End Region
    Public Function ListarDocumentosViaje(ByVal Id As String, _
                                          ByVal IdViaje As String) As Boolean

        Try
            LimpiaGrid(griDocumentosViaje, ogdDocumentosViaje)
            oeGuiaTransportista = New e_GuiaTransportista
            oeGuiaTransportista.Id = Id
            oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
            txtIdOperacionDetalle.Text = oeGuiaTransportista.IdOperacionDetalle
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
            oeOperacionDetalle.IdOperacion = oeViaje.IdOperacion
            oeOperacionDetalle.Activo = True
            oeOperacionDetalle.TipoOperacion = "4"
            griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
            If txtIdOperacionDetalle.Text <> "" Then
                oeViaje = New e_Viaje
                oeViaje.Id = txtIdOperacionDetalle.Text
                griDocumentosViaje.DataSource = olOperacion.ListarDocumentosViaje(oeViaje)
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function
   
    Private Sub griViajeDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDocumentosViaje_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDocumentosViaje.CellChange
        griDocumentosViaje.UpdateData()
    End Sub

    Private Sub griDocumentosViaje_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDocumentosViaje.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarDocumento() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Function EliminarDocumento() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griDocumentosViaje
                If ValidarGrilla(griDocumentosViaje, "Documentos de Viaje") Then
                    If RTrim(griDocumentosViaje.ActiveRow.Cells("TipoDocumento").Value) = "GUIA REMITENTE" Then
                        If griDocumentosViaje.ActiveRow.Cells("Id").Value.ToString.Length > 1 Then
                            oeGuiaRemitente = New e_GuiaRemitente
                            oeGuiaRemitente.Id = griDocumentosViaje.ActiveRow.Cells("Id").Value
                            oeGuiaRemitente = olGuiaRemitente.Obtener(oeGuiaRemitente)
                            If oeGuiaRemitente.Activo Then
                                If MessageBox.Show("Esta seguro de eliminar la Guia Remitente: " & _
                                oeGuiaRemitente.Serie & "-" & oeGuiaRemitente.Numero & " ?", _
                                                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    olGuiaRemitente.Eliminar(oeGuiaRemitente)
                                Else
                                    Return False
                                    Exit Function
                                End If

                            Else
                                Throw New Exception(oeGuiaRemitente.Serie & "-" & oeGuiaRemitente.Numero & " Ya fue eliminado")
                            End If
                        End If
                    Else
                        Throw New Exception("Tipo Documento no se puede eliminar")
                    End If
                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Sub EliminarGrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarGrt.Click
        griDocumentosViaje.ActiveRow.Delete()
    End Sub

    Private Sub MenuGrt_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuGrt.Opening
        If griDocumentosViaje.Selected.Rows.Count > 0 Then
            MenuGrt.Items("EliminarGrt").Visible = True
        Else
            MenuGrt.Items("EliminarGrt").Visible = False
        End If
    End Sub

End Class