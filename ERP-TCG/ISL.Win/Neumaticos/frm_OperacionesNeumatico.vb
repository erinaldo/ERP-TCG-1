'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinDataSource
Imports System.Collections
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_OperacionesNeumatico
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo, leVehiculo As New List(Of e_Vehiculo)
    Dim oeNeumatico As New e_Neumatico, olNeumatico As New l_Neumatico
    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico
    Dim oeDetalleConfigNeu As New e_DetalleConfiguracionNeumatico, olDetalleConfigNeu As New l_DetalleConfiguracionNeumatico
    Dim lstDetalleConfigNeu As New List(Of e_DetalleConfiguracionNeumatico)
    Dim lstVidaNeumatico As New List(Of e_VidaNeumatico)
    Dim oeOperacionNeumatico As New e_OperacionNeumatico, olOperacionNeumatico As New l_OperacionNeumatico
    Dim lstOperacionesNeu As New List(Of e_OperacionNeumatico), leOperacionNeu As New List(Of e_OperacionNeumatico)
    Dim x As Integer = 0
    Dim picOrigen As PictureBox
    Dim picDestino As PictureBox
    Private _Posicion As Integer
    Private imgTag As String
    Dim CtrlMask As Byte = 8
    Dim _ingresando_datos As Boolean = False
    Dim ribete1 As Integer = 0, ribete2 As Integer = 0, ribete3 As String = 0, ribete4 As Integer = 0
    Dim olConfiguracion As New l_Configuracion
    Private BandScrollgrid_Codigos As Boolean = True
    Private _indmotriz As Integer = 0
    Private BandLoad As Boolean = True

#End Region

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_OperacionesNeumatico = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_OperacionesNeumatico()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_Vehiculos.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        'MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            oeVehiculo = New e_Vehiculo
            If grid_Vehiculos.ActiveRow.Cells("IdConfiguracionNeumaticos").Value.ToString.Trim <> "" Then
                MostrarVehiculo()
                MostrarTabs(1, tcVehiculo, 1)
                txtPlaca.Focus()
                Operacion = "Editar"
                MyBase.Vista()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarInspeccion() Then
                MyBase.Guardar()
            Else
                MostrarTabs(0, tcVehiculo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        MostrarTabs(0, tcVehiculo)
        '_ingresando_datos = False
        Consultar(True)
    End Sub

    Public Overrides Sub Eliminar()
        'Try
        '    With grid_Neumatico
        '        If Not ValidarGrilla(grid_Neumatico, "Neumatico") Then Exit Sub
        '        oeNeumatico.Id = .ActiveRow.Cells("Id").Value
        '        oeNeumatico = olNeumatico.Obtener(oeNeumatico)
        '        If oeNeumatico.Activo Then
        '            If MessageBox.Show("Esta seguro de eliminar el Neumatico: " & _
        '            .ActiveRow.Cells("Codigo").Value.ToString.Trim & "?", _
        '            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '                oeNeumatico.TipoOperacion = "E"
        '                olNeumatico.Eliminar(oeNeumatico)
        '                Consultar(True)
        '            End If
        '        Else
        '            Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
        '        End If
        '    End With
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

#End Region

#Region "Metodos y Procedimientos"

    Sub MostrarVehiculo()
        Try
            If grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                r_EstablecerDrop()
                oeVehiculo.Id = grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                txtPlaca.Text = oeVehiculo.Placa
                txtConfiguracion.Text = oeVehiculo.ConfiguracionNeumaticos
                txtMarca.Text = oeVehiculo.Marca
                txtTipo.Text = oeVehiculo.TipoVehiculo
                _indmotriz = oeVehiculo.Motriz
                ndKmVehiculo.Value = oeVehiculo.Odometro
                r_CargarConfigNeumatico(oeVehiculo.Id, oeVehiculo.IdConfiguracionNeumaticos)
                r_CargarAlmacen()
                MostrarTabs(1, tcVehiculo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub r_PoblarEsquema(ByVal NroLlantas As Integer, ByVal IndMotriz As Boolean, ByVal Posicion As Integer, ByVal pnl_Esquema As Panel, _
      ByVal pa As PictureBox, ByVal pb As PictureBox, ByVal pc As PictureBox, ByVal pd As PictureBox)
        Try

            Dim Derecha As New PictureBox
            Derecha.Image = GeneraImagen("\Llanta derecha especial.jpg", False, "", True)

            Dim Izquierda As New PictureBox
            Izquierda.Image = GeneraImagen("\Llanta izquierda especial.jpg", False, "", True)
            pnl_Esquema.Visible = True

            If NroLlantas = 4 Then 'Nro Llantas

                If pa.Name.Substring(9, 2) = "1a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 1 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pb.Image = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 1 Or (Not pb.Image Is Nothing), Izquierda.Image, Nothing)
                    pc.Image = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 1 Or (Not pc.Image Is Nothing), Derecha.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 1 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)

                    lblLlanta1a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 1 Or (lblLlanta1a.Text = ""), pa.Tag, lblLlanta1a.Text)
                    lblLlanta1b.Text = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 1 Or (lblLlanta1b.Text = ""), pb.Tag, lblLlanta1b.Text)
                    lblLlanta1c.Text = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 1 Or (lblLlanta1c.Text = ""), pc.Tag, lblLlanta1c.Text)
                    lblLlanta1d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 1 Or (lblLlanta1d.Text = ""), pd.Tag, lblLlanta1d.Text)

                ElseIf pa.Name.Substring(9, 2) = "2a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 2 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pb.Image = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 2 Or (Not pb.Image Is Nothing), Izquierda.Image, Nothing)
                    pc.Image = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 2 Or (Not pc.Image Is Nothing), Derecha.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 2 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)

                    lblLlanta2a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 2 Or (lblLlanta2a.Text = ""), pa.Tag, lblLlanta2a.Text)
                    lblLlanta2b.Text = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 2 Or (lblLlanta2b.Text = ""), pb.Tag, lblLlanta2b.Text)
                    lblLlanta2c.Text = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 2 Or (lblLlanta2c.Text = ""), pc.Tag, lblLlanta2c.Text)
                    lblLlanta2d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 2 Or (lblLlanta2d.Text = ""), pd.Tag, lblLlanta2d.Text)

                ElseIf pa.Name.Substring(9, 2) = "3a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 3 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pb.Image = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 3 Or (Not pb.Image Is Nothing), Izquierda.Image, Nothing)
                    pc.Image = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 3 Or (Not pc.Image Is Nothing), Derecha.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 3 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)

                    lblLlanta3a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 3 Or (lblLlanta3a.Text = ""), pa.Tag, lblLlanta3a.Text)
                    lblLlanta3b.Text = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 3 Or (lblLlanta3b.Text = ""), pb.Tag, lblLlanta3b.Text)
                    lblLlanta3c.Text = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 3 Or (lblLlanta3c.Text = ""), pc.Tag, lblLlanta3c.Text)
                    lblLlanta3d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 3 Or (lblLlanta3d.Text = ""), pd.Tag, lblLlanta3d.Text)

                ElseIf pa.Name.Substring(9, 2) = "4a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 4 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pb.Image = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 4 Or (Not pb.Image Is Nothing), Izquierda.Image, Nothing)
                    pc.Image = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 4 Or (Not pc.Image Is Nothing), Derecha.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 4 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)

                    lblLlanta4a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 4 Or (lblLlanta4a.Text = ""), pa.Tag, lblLlanta4a.Text)
                    lblLlanta4b.Text = IIf(Posicion = CInt(pb.Tag) And pnl_Esquema.Tag = 4 Or (lblLlanta4b.Text = ""), pb.Tag, lblLlanta4b.Text)
                    lblLlanta4c.Text = IIf(Posicion = CInt(pc.Tag) And pnl_Esquema.Tag = 4 Or (lblLlanta4c.Text = ""), pc.Tag, lblLlanta4c.Text)
                    lblLlanta4d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 4 Or (lblLlanta4d.Text = ""), pd.Tag, lblLlanta4d.Text)
                End If

                If IndMotriz Then 'IndicaMotriz
                    pnl_Esquema.BackgroundImage = GeneraImagen("\4.jpg", False, "", True)
                Else
                    pnl_Esquema.BackgroundImage = GeneraImagen("\3.jpg", False, "", True)
                End If

            ElseIf NroLlantas = 2 Then

                If pa.Name.Substring(9, 2) = "1a" Then

                    pa.Image = IIf((Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 1) Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 1 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)
                    pb.Enabled = False
                    pc.Enabled = False
                    'ACA AGREGAR RESTRICCION A LOS IMAGENES Q FALTAN ENABLED=FALSE
                    lblLlanta1a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 1 Or (lblLlanta1a.Text = ""), pa.Tag, lblLlanta1a.Text)
                    lblLlanta1d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 1 Or (lblLlanta1d.Text = ""), pd.Tag, lblLlanta1d.Text)

                ElseIf pa.Name.Substring(9, 2) = "2a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 2 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 2 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)
                    pb.Enabled = False
                    pc.Enabled = False
                    lblLlanta2a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 2 Or (lblLlanta2a.Text = ""), pa.Tag, lblLlanta2a.Text)
                    lblLlanta2d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 2 Or (lblLlanta2d.Text = ""), pd.Tag, lblLlanta2d.Text)

                ElseIf pa.Name.Substring(9, 2) = "3a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 3 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 3 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)
                    pb.Enabled = False
                    pc.Enabled = False
                    lblLlanta3a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 3 Or (lblLlanta3a.Text = ""), pa.Tag, lblLlanta3a.Text)
                    lblLlanta3d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 3 Or (lblLlanta3d.Text = ""), pd.Tag, lblLlanta3d.Text)

                ElseIf pa.Name.Substring(9, 2) = "4a" Then

                    pa.Image = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 4 Or (Not pa.Image Is Nothing), Izquierda.Image, Nothing)
                    pd.Image = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 4 Or (Not pd.Image Is Nothing), Derecha.Image, Nothing)
                    pb.Enabled = False
                    pc.Enabled = False
                    lblLlanta4a.Text = IIf(Posicion = CInt(pa.Tag) And pnl_Esquema.Tag = 4 Or (lblLlanta4a.Text = ""), pa.Tag, lblLlanta4a.Text)
                    lblLlanta4d.Text = IIf(Posicion = CInt(pd.Tag) And pnl_Esquema.Tag = 4 Or (lblLlanta4d.Text = ""), pd.Tag, lblLlanta4d.Text)

                End If
                If IndMotriz Then
                    pnl_Esquema.BackgroundImage = GeneraImagen("\1.jpg", False, "", True)
                Else
                    pnl_Esquema.BackgroundImage = GeneraImagen("\2.jpg", False, "", True)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub r_NumerarTag(ByVal nrollantas As Integer, ByVal IndicaMotriz As Boolean, ByVal pa As PictureBox, ByVal pb As PictureBox, ByVal pc As PictureBox, ByVal pd As PictureBox)
        Select Case nrollantas
            Case 2
                pa.Tag = x + 1
                pd.Tag = x + 2
                x += 2

            Case 4
                pa.Tag = x + 1
                pb.Tag = x + 2
                pc.Tag = x + 3
                pd.Tag = x + 4
                x += 4
        End Select
    End Sub

    Sub r_CargarConfigNeumatico(ByVal ls_IdVehiculo As String, ByVal ls_IdConfiguracionNeumaticos As String)
        Try
            Dim ind1 As Integer = 0, ind2 As Integer = 0, ind3 As Integer = 0, ind4 As Integer = 0
            oeDetalleConfigNeu = New e_DetalleConfiguracionNeumatico
            oeDetalleConfigNeu.IdConfiguracionNeumatico = ls_IdConfiguracionNeumaticos
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
            oeOperacionNeumatico.TipoOperacion = "V"
            oeOperacionNeumatico.IdVehiculo = ls_IdVehiculo
            If ls_IdConfiguracionNeumaticos = "" Then Throw New Exception("Debe Asignarle una configuración!!!")
            lstDetalleConfigNeu = olDetalleConfigNeu.Listar(oeDetalleConfigNeu)
            lstOperacionesNeu = olOperacionNeumatico.Listar(oeOperacionNeumatico)
            pnl_Eje1.Visible = False : pnl_Eje2.Visible = False : pnl_Eje3.Visible = False : pnl_Eje4.Visible = False
            If lstDetalleConfigNeu.Count > 0 Then
                x = 0
                For Each fila As e_DetalleConfiguracionNeumatico In lstDetalleConfigNeu
                    For i As Integer = 0 To IIf(lstOperacionesNeu.Count = 0, 1, lstOperacionesNeu.Count) - 1
                        Dim j As Integer = 0
                        If lstOperacionesNeu.Count > 0 Then j = lstOperacionesNeu(i).Posicion
                        Select Case fila.NroLineaEje  'Nro Ejes
                            Case 1
                                ind1 = ind1 + 1
                                If ind1 = 1 Then
                                    r_NumerarTag(fila.CantidadLlantas, fila.IndTraccion, picLlanta1a, picLlanta1b, picLlanta1c, picLlanta1d)
                                End If
                                r_PoblarEsquema(fila.CantidadLlantas, fila.IndTraccion, j, pnl_Eje1, _
                                                picLlanta1a, picLlanta1b, picLlanta1c, picLlanta1d)
                            Case 2
                                ind2 = ind2 + 1
                                If ind2 = 1 Then
                                    r_NumerarTag(fila.CantidadLlantas, fila.IndTraccion, picLlanta2a, picLlanta2b, picLlanta2c, picLlanta2d)
                                End If
                                r_PoblarEsquema(fila.CantidadLlantas, fila.IndTraccion, j, pnl_Eje2, _
                                 picLlanta2a, picLlanta2b, picLlanta2c, picLlanta2d)
                            Case 3
                                ind3 = ind3 + 1
                                If ind3 = 1 Then
                                    r_NumerarTag(fila.CantidadLlantas, fila.IndTraccion, picLlanta3a, picLlanta3b, picLlanta3c, picLlanta3d)
                                End If
                                r_PoblarEsquema(fila.CantidadLlantas, fila.IndTraccion, j, pnl_Eje3, _
                                                picLlanta3a, picLlanta3b, picLlanta3c, picLlanta3d)
                            Case 4
                                ind4 = ind4 + 1
                                If ind4 = 1 Then
                                    r_NumerarTag(fila.CantidadLlantas, fila.IndTraccion, picLlanta4a, picLlanta4b, picLlanta4c, picLlanta4d)
                                End If
                                r_PoblarEsquema(fila.CantidadLlantas, fila.IndTraccion, j, pnl_Eje4, _
                                picLlanta4a, picLlanta4b, picLlanta4c, picLlanta4d)
                        End Select
                    Next
                Next
                If oeVehiculo.NroNeumaticosRepuesto > 0 Then
                    r_CargarRepuestos(oeVehiculo.NroNeumaticosRepuesto)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_CargarRepuestos(ByVal ls_cantidad As Integer)
        Try
            Select Case ls_cantidad
                Case 1
                    pnlRepuestos.Visible = True : Me.lblLlanta5c.Visible = True
                Case 2
                    pnlRepuestos.Visible = True : Me.lblLlanta5c.Visible = True
                    pnl_R2.Visible = True : Me.lblLlanta5d.Visible = True
                Case 3
                    pnlRepuestos.Visible = True : Me.lblLlanta5c.Visible = True
                    pnl_R2.Visible = True : Me.lblLlanta5d.Visible = True
                    pnl_R3.Visible = True : Me.lblLlanta5e.Visible = True
            End Select
            'If ls_cantidad = 1 Then
            '    pnlRepuestos.Visible = True
            '    Me.lblLlanta5c.Visible = True
            'ElseIf ls_cantidad = 2 Then
            '    pnlRepuestos.Visible = True
            '    Me.lblLlanta5c.Visible = True
            '    pnl_R2.Visible = True
            '    Me.lblLlanta5d.Visible = True
            'End If
            Dim ImagenNeumatico As Bitmap = GeneraImagen("\Llanta derecha especial.jpg", False, "", True)
            For Each obj As e_OperacionNeumatico In lstOperacionesNeu
                Select Case obj.Posicion
                    Case -1
                        picLlanta5c.Image = ImagenNeumatico
                        picLlanta5c.Tag = -1
                    Case -2
                        picLlanta5d.Image = ImagenNeumatico
                        picLlanta5d.Tag = -2
                    Case -3
                        picLlanta5e.Image = ImagenNeumatico
                        picLlanta5e.Tag = -3
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            txtPlaca.Focus()
            txtPlaca.Text = String.Empty
            txtConfiguracion.Text = String.Empty
            txtPlacaInsp.Text = String.Empty
            txtConfigInsp.Text = String.Empty
            ndKmVehiculo.Value = Nothing
            ndOdometro.Value = Nothing
            txtMarca.Text = String.Empty
            txtMarcaInsp.Text = String.Empty
            txtTipo.Text = String.Empty
            txtTipoInps.Text = String.Empty
            ndKMInspeccion.Value = 0
            dtpFechaInspeccion.Value = Date.Now
            txtCodigo.Text = String.Empty
            txtMarcaN.Text = String.Empty
            txtEstado.Text = String.Empty
            txtMedida.Text = String.Empty
            txtDiseño.Text = String.Empty
            ndKmTotalNeu.Value = 0
            ndRibete1.Value = 0
            ndRibete2.Value = 0
            ndRibete3.Value = 0
            ndRibete4.Value = 0
            ndCocada.Value = 0
            lstOperacionesNeu.Clear()
            lstVidaNeumatico.Clear()
            grid_Operaciones.DataSource = lstOperacionesNeu : grid_Operaciones.DataBind()
            grid_VidasNeumatico.DataSource = lstVidaNeumatico : grid_VidasNeumatico.DataBind()

            picLlanta1a.Enabled = True : picLlanta1b.Enabled = True : picLlanta1c.Enabled = True : picLlanta1d.Enabled = True
            picLlanta2a.Enabled = True : picLlanta2b.Enabled = True : picLlanta2c.Enabled = True : picLlanta2d.Enabled = True
            picLlanta3a.Enabled = True : picLlanta3b.Enabled = True : picLlanta3c.Enabled = True : picLlanta3d.Enabled = True
            picLlanta4a.Enabled = True : picLlanta4b.Enabled = True : picLlanta4c.Enabled = True : picLlanta4d.Enabled = True
            picLlanta5c.Enabled = True : picLlanta5d.Enabled = True : picLlanta5e.Enabled = True

            picLlanta1a.Image = Nothing : picLlanta1b.Image = Nothing : picLlanta1c.Image = Nothing : picLlanta1d.Image = Nothing
            picLlanta2a.Image = Nothing : picLlanta2b.Image = Nothing : picLlanta2c.Image = Nothing : picLlanta2d.Image = Nothing
            picLlanta3a.Image = Nothing : picLlanta3b.Image = Nothing : picLlanta3c.Image = Nothing : picLlanta3d.Image = Nothing
            picLlanta4a.Image = Nothing : picLlanta4b.Image = Nothing : picLlanta4c.Image = Nothing : picLlanta4d.Image = Nothing
            picLlanta5c.Image = Nothing : picLlanta5d.Image = Nothing : picLlanta5e.Image = Nothing

            lblLlanta1a.Text = String.Empty : lblLlanta1b.Text = String.Empty : lblLlanta1c.Text = String.Empty : lblLlanta1d.Text = String.Empty
            lblLlanta2a.Text = String.Empty : lblLlanta2b.Text = String.Empty : lblLlanta2c.Text = String.Empty : lblLlanta2d.Text = String.Empty
            lblLlanta3a.Text = String.Empty : lblLlanta3b.Text = String.Empty : lblLlanta3c.Text = String.Empty : lblLlanta3d.Text = String.Empty
            lblLlanta4a.Text = String.Empty : lblLlanta4b.Text = String.Empty : lblLlanta4c.Text = String.Empty : lblLlanta4d.Text = String.Empty

            pnlRepuestos.Visible = False : Me.lblLlanta5c.Visible = False
            pnl_R2.Visible = False : Me.lblLlanta5d.Visible = False
            pnl_R3.Visible = False : Me.lblLlanta5e.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeVehiculo = New e_Vehiculo()
            oeVehiculo.Activo = Activo
            oeVehiculo.Motriz = -1
            oeVehiculo.TipoOperacion = "N"
            leVehiculo = olVehiculo.Listar(oeVehiculo)
            CargarVehiculos(leVehiculo)
        Catch ex As Exception
            Throw ex
        Finally
            Cursor = Cursors.Default
            ugb_Espera.Visible = False
        End Try
        grid_Vehiculos.Focus()
    End Sub

    Sub r_CargarAlmacen()
        'Listar llantas que estan desmontadas
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Ubicacion = "ALMACEN"
            oeVidaNeumatico.EstadoActual = "DES"
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumatico = olVidaNeumatico.Listar(oeVidaNeumatico)
            With grid_Codigos
                'If lstVidaNeumatico.Count > 0 Then
                .DataSource = lstVidaNeumatico
                .DataBind()
                .DisplayLayout.Bands(0).Columns("IndLugar").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndLog").Hidden = True
                'End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub r_Montaje(ByVal pic As PictureBox, Optional ByVal Opcion As Integer = 0)
        Try
            'r_CargarDatosVehiculo()
            Dim LtrPos As String = pic.Name.ToString.Substring(10, 1)
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.Posicion = _Posicion
            oeOperacionNeumatico.KmVehiculo = CDbl(ndKmVehiculo.Value)
            oeOperacionNeumatico.IdVidaNeumatico = grid_Codigos.ActiveRow.Cells("Id").Value.ToString
            oeOperacionNeumatico.IdVehiculo = oeVehiculo.Id
            Dim frm As frm_MontajeNeumatico
            frm = New frm_MontajeNeumatico(oeOperacionNeumatico)
            frm.StartPosition = FormStartPosition.CenterScreen
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                pic.Image = IIf(LtrPos = "a" Or LtrPos = "b", GeneraImagen("\Llanta izquierda especial.jpg", False, "", True), GeneraImagen("\Llanta derecha especial.jpg", False, "", True))
                pic.Tag = _Posicion
                r_CargarAlmacen()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub r_EstablecerDrop()
        Dim Control1, Control2, Control3 As Object
        For Each myControl In pnl_Eje1.Controls
            If myControl.Name.Substring(0, 9) = "picLlanta" Then myControl.AllowDrop = True
        Next
        For Each Control1 In pnl_Eje2.Controls
            If Control1.Name.Substring(0, 9) = "picLlanta" Then Control1.AllowDrop = True
        Next
        For Each Control2 In pnl_Eje3.Controls
            If Control2.Name.Substring(0, 9) = "picLlanta" Then Control2.AllowDrop = True
        Next
        For Each Control3 In pnl_Eje4.Controls
            If Control3.Name.Substring(0, 9) = "picLlanta" Then Control3.AllowDrop = True
        Next

        For Each myControl In pnlRepuestos.Controls
            If myControl.Name.Substring(0, 9) = "picLlanta" Then myControl.AllowDrop = True
        Next

        For Each myControl In pnl_R2.Controls
            If myControl.Name.Substring(0, 9) = "picLlanta" Then myControl.AllowDrop = True
        Next

        For Each myControl In pnl_R3.Controls
            If myControl.Name.Substring(0, 9) = "picLlanta" Then myControl.AllowDrop = True
        Next

        picAlmacen.AllowDrop = True
        picBaja.AllowDrop = True
        picReencauche.AllowDrop = True
        picReparar.AllowDrop = True
        picEliminarMon.AllowDrop = True
        grid_Vehiculos.AllowDrop = True

    End Sub

    Sub ListarNeumaticosMontados()
        Try
            leOperacionNeu = New List(Of e_OperacionNeumatico)
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
            oeOperacionNeumatico.TipoOperacion = "I"
            oeOperacionNeumatico.IndMontaje = 0
            oeOperacionNeumatico.IndInspeccion = 1
            oeOperacionNeumatico.IdVehiculo = grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString
            lstOperacionesNeu = olOperacionNeumatico.Listar(oeOperacionNeumatico)
            If lstOperacionesNeu.Count > 0 Then
                Dim lstOperNeu As New List(Of e_OperacionNeumatico)
                oeOperacionNeumatico = New e_OperacionNeumatico
                oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
                oeOperacionNeumatico.TipoOperacion = "I"
                oeOperacionNeumatico.IndMontaje = 1
                oeOperacionNeumatico.IndInspeccion = 0
                oeOperacionNeumatico.IdVehiculo = grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString
                lstOperNeu = olOperacionNeumatico.Listar(oeOperacionNeumatico)
                If lstOperNeu.Count > 0 Then
                    Dim oeONAux = New e_OperacionNeumatico
                    For Each oeONM In lstOperNeu
                        oeONM.Equivale = 2
                        If lstOperacionesNeu.Contains(oeONM) Then
                            oeONM.IndAct = 1
                            oeONAux = New e_OperacionNeumatico
                            oeONAux = lstOperacionesNeu.Item(lstOperacionesNeu.IndexOf(oeONM))
                            oeONAux.IndAct = 1
                            leOperacionNeu.Add(oeONAux)
                        Else
                            leOperacionNeu.Add(oeONM)
                        End If
                    Next
                    'lstOperNeu.RemoveAll(AddressOf VerificaNeu)
                    'lstOperacionesNeu.AddRange(lstOperNeu)
                End If
                'grid_Neumaticos.DataSource = lstOperacionesNeu
                grid_Neumaticos.DataSource = leOperacionNeu
            Else
                oeOperacionNeumatico = New e_OperacionNeumatico
                oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
                oeOperacionNeumatico.TipoOperacion = "I"
                oeOperacionNeumatico.IndMontaje = 1
                oeOperacionNeumatico.IndInspeccion = 0
                oeOperacionNeumatico.IdVehiculo = grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString
                lstOperacionesNeu = olOperacionNeumatico.Listar(oeOperacionNeumatico)
                leOperacionNeu = lstOperacionesNeu
                grid_Neumaticos.DataSource = leOperacionNeu
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub MostrarVehiculoInspeccion()
        Try
            If grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                txtPlacaInsp.Text = oeVehiculo.Placa
                txtConfigInsp.Text = oeVehiculo.ConfiguracionNeumaticos
                txtMarcaInsp.Text = oeVehiculo.Marca
                txtTipoInps.Text = oeVehiculo.TipoVehiculo
                ndOdometro.Value = oeVehiculo.Odometro
                ndKMInspeccion.Value = oeVehiculo.Odometro
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CalculaCocada()
        Dim cocada As Integer = 0
        Dim ribetes(2) As Integer
        ribetes(0) = grid_Neumaticos.ActiveRow.Cells("Ribete1").Value
        ribetes(1) = grid_Neumaticos.ActiveRow.Cells("Ribete2").Value
        ribetes(2) = grid_Neumaticos.ActiveRow.Cells("Ribete3").Value
        'ribetes(3) = grid_Neumaticos.ActiveRow.Cells("Ribete4").Value
        cocada = ribetes(0)
        For Each rib As Integer In ribetes
            If rib < cocada Then
                cocada = rib
            End If
        Next
        grid_Neumaticos.ActiveRow.Cells("Cocada").Value = cocada
    End Sub

    Private Function GuardarInspeccion() As Boolean
        Try
            For Each objOperacion As e_OperacionNeumatico In leOperacionNeu
                objOperacion.TipoOperacion = "I"
                objOperacion.Operacion = "INSPECCION"
                objOperacion.FechaOperacion = dtpFechaInspeccion.Value
                objOperacion.IndMontaje = 0
                objOperacion.IndInspeccion = 1
                objOperacion.KmVehiculo = ndKMInspeccion.Value
                objOperacion.UsuarioCreacion = gUsuarioSGI.Id
                objOperacion.Activo = True
                objOperacion.KmNeumatico = objOperacion.KmRecorridoNeu
                'olOperacionNeumatico.Guardar(objOperacion)
                objOperacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            Next
            olOperacionNeumatico.GuardarLista(leOperacionNeu)
            mensajeEmergente.Confirmacion("Se realizo correctamente la inspeccion ")
            Consultar(True)
            grid_Neumaticos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_Vehiculos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Vehiculos)
            MyBase.Exportar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarVehiculos(leVeh As List(Of e_Vehiculo))
        Try
            With grid_Vehiculos
                If BandLoad Then .ResetDisplayLayout()
                .DataSource = leVeh
                If BandLoad Then
                    ConfiguraGrilla(grid_Vehiculos, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(grid_Vehiculos, False, "IdFlota", "Placa", "Motriz", "TipoVehiculo", "Marca", "Modelo", "ConfiguracionNeumaticos", _
                                    "AnioFabricacion", "NroEjes", "NroNeumaticos", "NroNeumaticosRepuesto", "TipoNeumatico", "SuspensionNeumatica", _
                                    "RutaAsignada", "ConductorAsignada")
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 50
                    .DisplayLayout.Bands(0).Columns("Placa").Width = 70
                    .DisplayLayout.Bands(0).Columns("ConfiguracionNeumaticos").Width = 60
                    .DisplayLayout.Bands(0).Columns("AnioFabricacion").Width = 50
                    .DisplayLayout.Bands(0).Columns("NroEjes").Width = 50
                    .DisplayLayout.Bands(0).Columns("NroNeumaticos").Width = 50
                    .DisplayLayout.Bands(0).Columns("NroNeumaticosRepuesto").Width = 50
                    .DisplayLayout.Bands(0).Columns("ConfiguracionNeumaticos").Header.Caption = "Conf. Neu."
                    .DisplayLayout.Bands(0).Columns("IdFlota").Header.Caption = "Flota"
                    .DisplayLayout.Bands(0).Columns("AnioFabricacion").Header.Caption = "Año Fab."
                    .DisplayLayout.Bands(0).Columns("NroEjes").Header.Caption = "Nro. Ejes."
                    .DisplayLayout.Bands(0).Columns("NroNeumaticos").Header.Caption = "Nro. Neu."
                    .DisplayLayout.Bands(0).Columns("NroNeumaticosRepuesto").Header.Caption = "Nro. Rep."
                    .DisplayLayout.Bands(0).Columns("IdFlota").Header.VisiblePosition = 0
                    .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                    .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
                    FormatoColumna(grid_Vehiculos, "", ColumnStyle.CheckBox, HAlign.Default, "Motriz")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub EliminarInspeccion()
        Try
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.Id = grid_Operaciones.ActiveRow.Cells("Id").Value
            oeOperacionNeumatico = olOperacionNeumatico.Obtener(oeOperacionNeumatico)
            If oeOperacionNeumatico.IndMontaje = 0 And oeOperacionNeumatico.IndInspeccion = 1 Then
                If MessageBox.Show("¿Está seguro de eliminar la inspeccion?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                    oeOperacionNeumatico = New e_OperacionNeumatico
                    oeOperacionNeumatico.TipoOperacion = "D"
                    oeOperacionNeumatico.Id = grid_Operaciones.ActiveRow.Cells("Id").Value
                    olOperacionNeumatico.Eliminar(oeOperacionNeumatico)
                    MessageBox.Show("Eliminado correctamente", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarDetalleNeumatico(grid_Operaciones.ActiveRow.Cells("Posicion").Value)
                End If
            Else
                Throw New Exception("No se puede eliminar la inspeccion, no se encuentra vigente.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CargarDetalleNeumatico(ByVal ln_Pos As Integer)
        Try
            oeOperacionNeumatico = New e_OperacionNeumatico
            oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
            oeOperacionNeumatico.TipoOperacion = ""
            oeOperacionNeumatico.IndMontaje = 1
            oeOperacionNeumatico.IndInspeccion = -1
            oeOperacionNeumatico.IdVehiculo = oeVehiculo.Id
            oeOperacionNeumatico.Posicion = ln_Pos
            lstOperacionesNeu = olOperacionNeumatico.Listar(oeOperacionNeumatico)
            If lstOperacionesNeu.Count > 0 Then
                oeVidaNeumatico = New e_VidaNeumatico
                oeVidaNeumatico.Activo = True
                oeVidaNeumatico.Vigente = 1
                oeVidaNeumatico.Id = lstOperacionesNeu(0).IdVidaNeumatico
                oeVidaNeumatico = olVidaNeumatico.Obtener(oeVidaNeumatico)

                Dim _IdNeumatico As String = oeVidaNeumatico.IdNeumatico
                oeNeumatico = New e_Neumatico
                oeNeumatico.Id = _IdNeumatico
                oeNeumatico.TipoOperacion = ""
                oeNeumatico = olNeumatico.Obtener(oeNeumatico)

                Me.txtCodigo.Text = oeVidaNeumatico.CodigoNeumatico
                Me.txtDiseño.Text = oeVidaNeumatico.Diseño
                Me.txtMarcaN.Text = oeVidaNeumatico.Marca
                Me.txtMedida.Text = oeVidaNeumatico.Medida
                Dim cad As String = ""
                Select Case oeVidaNeumatico.Condicion
                    Case "NVO"
                        cad = "NUEVO"
                    Case "USD"
                        cad = "USADO"
                    Case "REE"
                        cad = "REENCAUCHADO"
                End Select
                Me.txtEstado.Text = cad
                Me.ndKmTotalNeu.Value = oeVidaNeumatico.KmTotalNeumatico
                Me.ndCostoTotalDol.Value = oeNeumatico.CostoTotalDolares
                Me.ndRibete1.Value = oeVidaNeumatico.Ribete1
                Me.ndRibete2.Value = oeVidaNeumatico.Ribete2
                Me.ndRibete3.Value = oeVidaNeumatico.Ribete3
                Me.ndRibete4.Value = oeVidaNeumatico.Ribete4
                Me.ndCocada.Value = oeVidaNeumatico.Cocada
                Me.txtPosicion.Value = ln_Pos
                oeVidaNeumatico = New e_VidaNeumatico
                oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
                oeVidaNeumatico.Activo = True
                oeVidaNeumatico.Vigente = -1
                oeVidaNeumatico.IdNeumatico = _IdNeumatico
                grid_VidasNeumatico.DataSource = olVidaNeumatico.Listar(oeVidaNeumatico)
                lstOperacionesNeu.Clear()
                grid_Operaciones.DataSource = lstOperacionesNeu
                grid_Operaciones.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Llantas_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
      picLlanta1a.DragDrop, picLlanta1b.DragDrop, picLlanta1c.DragDrop, _
      picLlanta2a.DragDrop, picLlanta2b.DragDrop, picLlanta2c.DragDrop, picLlanta2d.DragDrop, _
      picLlanta3a.DragDrop, picLlanta3b.DragDrop, picLlanta3c.DragDrop, picLlanta3d.DragDrop, _
      picLlanta4a.DragDrop, picLlanta4b.DragDrop, picLlanta4c.DragDrop, picLlanta4d.DragDrop, _
      picLlanta5c.DragDrop, picLlanta5d.DragDrop, picLlanta1d.DragDrop, picLlanta5e.DragDrop
        Try
            picDestino = CType(sender, PictureBox) 'Llanta a la que se va a montar
            If picOrigen.Name.Substring(0, 3) <> "pic" Then
                If picDestino.Image Is Nothing Then
                    _Posicion = picDestino.Tag
                    r_Montaje(picDestino, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Llantas_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
   picLlanta1a.DragEnter, picLlanta1b.DragEnter, picLlanta1c.DragEnter, picLlanta1d.DragEnter, _
   picLlanta2a.DragEnter, picLlanta2b.DragEnter, picLlanta2c.DragEnter, picLlanta2d.DragEnter, _
   picLlanta3a.DragEnter, picLlanta3b.DragEnter, picLlanta3c.DragEnter, picLlanta3d.DragEnter, _
   picLlanta4a.DragEnter, picLlanta4b.DragEnter, picLlanta4c.DragEnter, picLlanta4d.DragEnter, _
   picLlanta5c.DragEnter, picLlanta5d.DragEnter, picLlanta5e.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            If (e.KeyState And CtrlMask) = CtrlMask Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picAlmacen_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
   picAlmacen.DragEnter, picBaja.DragEnter, picReencauche.DragEnter, picReparar.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            If (e.KeyState And CtrlMask) = CtrlMask Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picLlanta1a_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
       picLlanta1a.MouseUp, picLlanta1b.MouseUp, picLlanta1c.MouseUp, picLlanta1d.MouseUp _
          , picLlanta2a.MouseUp, picLlanta2b.MouseUp, picLlanta2c.MouseUp, picLlanta2d.MouseUp _
          , picLlanta3a.MouseUp, picLlanta3b.MouseUp, picLlanta3c.MouseUp, picLlanta3d.MouseUp _
          , picLlanta4a.MouseUp, picLlanta4b.MouseUp, picLlanta4c.MouseUp, picLlanta4d.MouseUp _
          , picLlanta5c.MouseUp, picLlanta5d.MouseUp, picLlanta5e.MouseUp
        Try
            Dim pB As PictureBox
            pB = CType(sender, PictureBox)
            imgTag = pB.Tag
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Codigos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_Codigos.MouseDown, picAlmacen.MouseDown
        Try
            Dim Derecha As New PictureBox
            Derecha.Image = GeneraImagen("\Llanta derecha especial.jpg", False, "", True)
            Derecha.Name = "grid_Almacen"
            picOrigen = Derecha
            If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 1 Then
                If grid_Codigos.Rows.Count > 0 And grid_Codigos.Selected.Rows.Count > 0 Then
                    grid_Codigos.DoDragDrop(Derecha.Image, DragDropEffects.Move)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_OperacionesNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, grid_Neumaticos.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcVehiculo)
            Tiempo1.Enabled = False
            leVehiculo = New List(Of e_Vehiculo)
            BandLoad = True
            CargarVehiculos(leVehiculo)
            BandLoad = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try     
    End Sub

    Private Sub frm_OperacionesNeumatico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_OperacionesNeumatico_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub picEliminarMon_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picEliminarMon.DragDrop
        Try
            If picOrigen.Name.Substring(3, 6) = "Llanta" And picOrigen.Name <> "picBaja" Then
                _Posicion = picOrigen.Tag
                If Not picOrigen.Image Is Nothing Then
                    oeOperacionNeumatico = New e_OperacionNeumatico
                    oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
                    oeOperacionNeumatico.TipoOperacion = ""
                    oeOperacionNeumatico.IndMontaje = 0
                    oeOperacionNeumatico.IndInspeccion = 1
                    oeOperacionNeumatico.IdVehiculo = oeVehiculo.Id
                    oeOperacionNeumatico.Posicion = _Posicion
                    oeOperacionNeumatico = olOperacionNeumatico.Obtener(oeOperacionNeumatico)

                    If oeOperacionNeumatico.Id Is Nothing Then
                        oeOperacionNeumatico = New e_OperacionNeumatico
                        oeOperacionNeumatico.Activo = True
                        oeOperacionNeumatico.Posicion = _Posicion
                        oeOperacionNeumatico.IndMontaje = 1
                        oeOperacionNeumatico.IndInspeccion = 0
                        oeOperacionNeumatico.IdVehiculo = oeVehiculo.Id
                        oeOperacionNeumatico = olOperacionNeumatico.Obtener(oeOperacionNeumatico)
                        If MessageBox.Show("¿Está seguro de eliminar montaje?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                            oeOperacionNeumatico.TipoOperacion = "E"
                            olOperacionNeumatico.Eliminar(oeOperacionNeumatico)
                            MessageBox.Show("Eliminado correctamente", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            picOrigen.Image = Nothing
                            r_CargarAlmacen()
                        End If
                    Else
                        Throw New Exception("No se puede deshacer el montaje, el neumatico tiene una inspeccion.")
                    End If

                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub picEliminarMon_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picEliminarMon.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            ' Si presionó la tecla Ctrl durante la operación Arrastrar, llevar a cabo
            ' la operación Copiar. En caso contrario, ejecutar la operación Mover.
            If (e.KeyState And CtrlMask) = CtrlMask Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picLlantas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
     picLlanta1a.DoubleClick, picLlanta1b.DoubleClick, picLlanta1c.DoubleClick, picLlanta1d.DoubleClick _
        , picLlanta2a.DoubleClick, picLlanta2b.DoubleClick, picLlanta2c.DoubleClick, picLlanta2d.DoubleClick _
        , picLlanta3a.DoubleClick, picLlanta3b.DoubleClick, picLlanta3c.DoubleClick, picLlanta3d.DoubleClick _
        , picLlanta4a.DoubleClick, picLlanta4b.DoubleClick, picLlanta4c.DoubleClick, picLlanta4d.DoubleClick _
        , picLlanta5c.DoubleClick, picLlanta5d.DoubleClick, picLlanta5e.DoubleClick
        Try
            picOrigen = CType(sender, PictureBox)
            _Posicion = picOrigen.Tag
            CargarDetalleNeumatico(_Posicion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Llantas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    picLlanta1a.MouseDown, picLlanta1b.MouseDown, picLlanta1c.MouseDown, picLlanta1d.MouseDown, _
    picLlanta2a.MouseDown, picLlanta2b.MouseDown, picLlanta2c.MouseDown, picLlanta2d.MouseDown, _
    picLlanta3a.MouseDown, picLlanta3b.MouseDown, picLlanta3c.MouseDown, picLlanta3d.MouseDown, _
    picLlanta4a.MouseDown, picLlanta4b.MouseDown, picLlanta4c.MouseDown, picLlanta4d.MouseDown, _
    picLlanta5c.MouseDown, picLlanta5d.MouseDown, picLlanta5e.MouseDown, _
     picBaja.MouseDown, picReencauche.MouseDown, picReparar.MouseDown _
     , picEliminarMon.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 1 Then
            picOrigen = CType(sender, PictureBox)
            If Not picOrigen.Image Is Nothing Then
                picOrigen.DoDragDrop(picOrigen.Image, DragDropEffects.Move Or DragDropEffects.Copy)
            End If
        End If
    End Sub

    Private Sub picAlmacen_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
   picAlmacen.DragDrop, picReencauche.DragDrop, picBaja.DragDrop, picReparar.DragDrop
        Try
            Dim Operacion As String = ""
            picDestino = CType(sender, PictureBox)
            If picOrigen.Name <> "picBaja" Then
                If picOrigen.Name.Substring(3, 6) = "Llanta" Then
                    If Not picOrigen.Image Is Nothing Then
                        _Posicion = picOrigen.Tag
                        Select Case picDestino.Name
                            Case "picAlmacen"
                                Operacion = "ALMACEN"
                            Case "picReencauche"
                                Operacion = "REENCAUCHE"
                            Case "picReparar"
                                Operacion = "REPARACION"
                            Case "picBaja"
                                Operacion = "BAJA"
                        End Select
                        oeOperacionNeumatico = New e_OperacionNeumatico
                        oeOperacionNeumatico.Posicion = _Posicion
                        oeOperacionNeumatico.KmVehiculo = CDbl(ndKmVehiculo.Value)
                        oeOperacionNeumatico.IdVehiculo = oeVehiculo.Id
                        oeOperacionNeumatico.Descripcion = Operacion
                        Dim frm As New frm_MantenimientoNeumaticos(oeOperacionNeumatico)
                        frm.StartPosition = FormStartPosition.CenterScreen
                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            picOrigen.Image = Nothing
                            r_CargarAlmacen()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Vehiculos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Vehiculos.DoubleClickRow
        Editar()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub AsignarConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarConfiguracionToolStripMenuItem.Click
        Try
            Dim frm As frm_AsignarConfiguracionGrafica
            frm = New frm_AsignarConfiguracionGrafica(grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString, _
                                                      grid_Vehiculos.ActiveRow.Cells("Placa").Value.ToString, _
                                                      grid_Vehiculos.ActiveRow.Cells("NroNeumaticosRepuesto").Value.ToString, _
                                                      grid_Vehiculos.ActiveRow.Cells("IdConfiguracionNeumaticos").Value.ToString)
            frm.StartPosition = FormStartPosition.CenterScreen
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub InspecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspecciónToolStripMenuItem.Click
        Try
            oeVehiculo = New e_Vehiculo
            If grid_Vehiculos.ActiveRow.Cells("IdConfiguracionNeumaticos").Value.ToString.Trim <> "" Then
                MostrarVehiculoInspeccion()
                ListarNeumaticosMontados()
                MostrarTabs(2, tcVehiculo, 2)
                grid_Neumaticos.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("El vehiculo no tiene una configuracion de neumaticos asignada")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCalcularKmNeu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularKmNeu.Click
        For Each obj As e_OperacionNeumatico In lstOperacionesNeu.Where(Function(it) it.Posicion > 0).ToList
            obj.KmNeumatico = obj.KmRecorridoNeu + (ndKMInspeccion.Value - obj.KmVehiculo)
            obj.Ribete4 = (ndKMInspeccion.Value - obj.KmVehiculo)
        Next
        grid_Neumaticos.DataBind()
    End Sub

    Private Sub grid_Neumaticos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Neumaticos.AfterCellUpdate
        Try
            With grid_Neumaticos
                Select Case e.Cell.Column.Key.ToUpper
                    Case "RIBETE1"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Ribete1").Value = ribete1
                        End If
                        CalculaCocada()
                    Case "RIBETE2"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Ribete2").Value = ribete2
                        End If
                        CalculaCocada()
                    Case "RIBETE3"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Ribete3").Value = ribete3
                        End If
                        CalculaCocada()
                    Case "RIBETE4"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("Ribete4").Value = ribete4
                        End If
                        CalculaCocada()
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Neumaticos_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_Neumaticos.BeforeCellUpdate
        Try
            If IsDBNull(e.NewValue) Then
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Neumaticos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Neumaticos.CellChange
        'grid_Neumaticos.UpdateData()
    End Sub

    Private Sub dtpFechaInspeccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInspeccion.ValueChanged
        For Each obj As e_OperacionNeumatico In lstOperacionesNeu
            obj.FechaOperacion = dtpFechaInspeccion.Value
        Next
        grid_Neumaticos.DataBind()
    End Sub

    Private Sub grid_Codigos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Codigos.DoubleClickRow
        Try
            If grid_Codigos.Selected.Rows.Count > 0 Then
                lstOperacionesNeu.Clear()
                If grid_Codigos.Rows.Count > 0 Then
                    oeVidaNeumatico = New e_VidaNeumatico
                    oeVidaNeumatico.Activo = True
                    oeVidaNeumatico.Vigente = 1
                    oeVidaNeumatico.Id = grid_Codigos.ActiveRow.Cells("Id").Value.ToString
                    oeVidaNeumatico = olVidaNeumatico.Obtener(oeVidaNeumatico)
                    Dim _IdNeumatico As String = oeVidaNeumatico.IdNeumatico
                    oeNeumatico = New e_Neumatico
                    oeNeumatico.Id = _IdNeumatico
                    oeNeumatico.TipoOperacion = ""
                    oeNeumatico = olNeumatico.Obtener(oeNeumatico)
                    Me.txtCodigo.Text = oeVidaNeumatico.CodigoNeumatico
                    Me.txtDiseño.Text = oeVidaNeumatico.Diseño
                    Me.txtMarcaN.Text = oeVidaNeumatico.Marca
                    Me.txtMedida.Text = oeVidaNeumatico.Medida
                    Dim cad As String = ""
                    Select Case oeVidaNeumatico.Condicion
                        Case "NVO"
                            cad = "NUEVO"
                        Case "USD"
                            cad = "USADO"
                        Case "REE"
                            cad = "REENCAUCHADO"
                    End Select
                    Me.txtEstado.Text = cad
                    Me.ndKmTotalNeu.Value = oeVidaNeumatico.KmTotalNeumatico
                    Me.ndCostoTotalDol.Value = oeNeumatico.CostoTotalDolares

                    Me.ndRibete1.Value = oeVidaNeumatico.Ribete1
                    Me.ndRibete2.Value = oeVidaNeumatico.Ribete2
                    Me.ndRibete3.Value = oeVidaNeumatico.Ribete3
                    Me.ndRibete4.Value = oeVidaNeumatico.Ribete4
                    Me.ndCocada.Value = oeVidaNeumatico.Cocada

                    oeVidaNeumatico = New e_VidaNeumatico
                    oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
                    oeVidaNeumatico.Activo = True
                    oeVidaNeumatico.Vigente = -1
                    oeVidaNeumatico.IdNeumatico = _IdNeumatico
                    grid_VidasNeumatico.DataSource = olVidaNeumatico.Listar(oeVidaNeumatico)
                    grid_Operaciones.DataSource = lstOperacionesNeu
                    grid_Operaciones.DataBind()
                End If
            End If         
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_OperacionesNeumatico_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case tcVehiculo.SelectedTab.Index
            Case 0
                If grid_Vehiculos.Rows.Count > 0 Then
                    ControlBoton(1, 0, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
            Case 2
                If grid_Neumaticos.Rows.Count > 0 Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                End If
        End Select
    End Sub

    Private Sub btnInspeccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInspeccion.Click
        Try
            If leOperacionNeu.Count > 0 Then
                Dim ofrm As New frm_ReporteInspeccion
                Dim leOpeNeu As New List(Of e_OperacionNeumatico)
                leOpeNeu = leOperacionNeu.OrderBy(Function(item) item.Posicion).ToList
                ofrm.CargarInspeccion(oeVehiculo, leOpeNeu)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.Refresh()
                ofrm.ShowDialog()
            Else
                Throw New Exception("No hay Neumaticos")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub grid_Codigos_BeforeColRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeColRegionScrollEventArgs) Handles grid_Codigos.BeforeColRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Codigos.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Codigos_BeforeRowRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowRegionScrollEventArgs) Handles grid_Codigos.BeforeRowRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Codigos.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Neumaticos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_Neumaticos.KeyDown
        Try
            With grid_Neumaticos
                Select Case e.KeyValue
                    Case Keys.Enter
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(BelowCell, False, False)
                    Case Keys.Down
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(BelowCell, False, False)
                    Case Keys.Up
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(AboveCell, False, False)
                    Case Keys.Right
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(NextCell, False, False)
                    Case Keys.Left
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(PrevCell, False, False)
                End Select
                e.Handled = True
                If .ActiveCell.Column.CellClickAction = CellClickAction.EditAndSelectText Then
                    .PerformAction(EnterEditMode, False, False)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_VidasNeumatico_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_VidasNeumatico.DoubleClickRow
        Try
            lstOperacionesNeu.Clear()
            If grid_VidasNeumatico.Rows.Count > 0 Then
                oeOperacionNeumatico = New e_OperacionNeumatico
                oeOperacionNeumatico.TipoOperacion = ""
                oeOperacionNeumatico.Activo = True
                oeOperacionNeumatico.IndMontaje = -1
                oeOperacionNeumatico.IndInspeccion = -1
                oeOperacionNeumatico.FechaOperacion = Date.Parse("01/01/1901")
                'oeOperacionNeumatico.IdVehiculo = oeVehiculo.Id
                oeOperacionNeumatico.IdVidaNeumatico = grid_VidasNeumatico.ActiveRow.Cells("Id").Value.ToString
                lstOperacionesNeu = olOperacionNeumatico.Listar(oeOperacionNeumatico)
                grid_Operaciones.DataSource = lstOperacionesNeu.OrderByDescending(Function(it) it.FechaOperacion).ToList
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
        grid_Operaciones.Focus()
    End Sub

    Private Sub mcSubMenuOperaciones_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcSubMenuOperaciones.Opening
        With mcSubMenuOperaciones
            .Items(0).Visible = False
            Dim ls_Operacion As String = grid_Operaciones.ActiveRow.Cells("Codigo").Value
            If Strings.Left(ls_Operacion, 3) = "INS" Then
                .Items(0).Visible = True
            End If
        End With
    End Sub

    Private Sub tsmEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEliminar.Click
        Try
            EliminarInspeccion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Neumaticos_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grid_Neumaticos.DoubleClickCell
        Try
            With grid_Neumaticos
                If .ActiveRow.Index > -1 AndAlso .Selected.Rows.Count = 0 Then
                    Select Case .ActiveCell.Column.Key
                        Case "KmNeumatico"
                            Dim _kmAux As String
                            _kmAux = InputBox("Ingrese Kilometraje de Neumatico " & .ActiveRow.Cells("CodigoNeumatico").Value & ": ", _
                                              "Mensaje de Sistema", .ActiveRow.Cells("KmNeumatico").Value)
                            If Not IsNumeric(_kmAux) Then Throw New Exception("Solo se Permite Ingresar Números")
                            If _kmAux < 0 Then Throw New Exception("Debe Ingresar un Km mayor a Cero")
                            .ActiveRow.Cells("KmNeumatico").Value = _kmAux
                            .UpdateData()
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarKmVeh_Click(sender As Object, e As EventArgs) Handles btnActualizarKmVeh.Click
        Try
            If grid_Neumaticos.Rows.Count > 0 Then
                Dim _kmAux As String = String.Empty
                _kmAux = InputBox("Ingrese Kilometraje de Vehiculo " & txtPlacaInsp.Text.ToString & ": ", _
                                  "Mensaje de Sistema", "0.00")
                For Each obj As e_OperacionNeumatico In lstOperacionesNeu
                    obj.KmVehiculo = _kmAux
                Next
                grid_Neumaticos.DataBind()
            Else
                Throw New Exception("No hay Registros para Actualizar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_OperacionesNeumatico_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

End Class
