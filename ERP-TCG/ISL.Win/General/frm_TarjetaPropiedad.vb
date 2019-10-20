'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_TarjetaPropiedad
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared Instancia As frm_TarjetaPropiedad = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_TarjetaPropiedad()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Dim _ingresando_datos As Boolean
    Dim oeDocumentoVehicular As New e_DocumentoVehicular
    Dim olDocumentoVehicular As New l_DocumentoVehicular
    Dim oeDetalleDocumentoVehicular As New e_DetalleDocumentoVehiculo
    Dim olDetalleDocumentoVehiculo As New l_DetalleDocumentoVehiculo
    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim lstVehiculo As New List(Of e_Vehiculo)
    Dim lstVehiculo2 As New List(Of e_Vehiculo)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If Grid_ListadoTarjetaP.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            MostrarTabs(1, tc_DocumentosVehiculares, 1)
            oeDocumentoVehicular.TipoOperacion = "I"
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            oeDocumentoVehicular = New e_DocumentoVehicular
            If Grid_ListadoTarjetaP.ActiveRow.Band.Index = 0 Then
                EditarTarjeta()
                MostrarTabs(1, tc_DocumentosVehiculares, 1)
                TxtPartidaTP.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("Seleccione un Registro válido")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDocumento() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tc_DocumentosVehiculares, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tc_DocumentosVehiculares, 2)
            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            _ingresando_datos = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With Grid_ListadoTarjetaP
                If Grid_ListadoTarjetaP.ActiveRow.Band.Index = 0 And Grid_ListadoTarjetaP.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    If MessageBox.Show("Esta seguro de eliminar la Revisión Técnica N°: " & _
                    .ActiveRow.Cells("Numero").Value.ToString.Trim & " ?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeDocumentoVehicular.TipoOperacion = "E"
                        oeDocumentoVehicular.Id = .ActiveRow.Cells("Id").Value
                        olDocumentoVehicular.Eliminar(oeDocumentoVehicular)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("Seleccione una Tarjeta de propiedad válida para poder eliminarla")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If Grid_ListadoTarjetaP.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(Grid_ListadoTarjetaP)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub MostrarDetalleVehiculo()
        Try
            If CmbPlacaTP.Value <> "" Then
                Dim oeVeh As New e_Vehiculo
                oeVeh = lstVehiculo.Where(Function(item) item.Id = CmbPlacaTP.Value)(0)
                TxtClaseTP.Value = oeVeh.TipoVehiculo
                TxtModeloTP.Value = oeVeh.Modelo
                TxtMarcaTP.Value = oeVeh.Marca
                TxtSerieTP.Value = oeVeh.NroSerieChasis
                TxtMotorTP.Value = oeVeh.NroSerieMotor
                TxtCarroceriaTP.Value = "--"
                TxtCombustibleTP.Value = IIf(oeVeh.IdMaterialCombustible = "1CH000001990", "DIESEL D2", IIf(oeVeh.IdMaterialCombustible = "1CH000000149", "GASOLINA 95 OCT", _
                                            IIf(oeVeh.IdMaterialCombustible = "1CH000000148", "GASOLINA 90 OCT", IIf(oeVeh.IdMaterialCombustible = "1CH000000147", "GASOLINA 84 OCT.", "--"))))
                TxtPotenciaTP.Value = "--"
                TxtLargoTP.Value = oeVeh.Largo
                TxtAnchoTP.Value = oeVeh.Ancho
                TxtAltoTP.Value = oeVeh.Alto
                TxtPBrutoTP.Value = "--"
                TxtCUtilTP.Value = oeVeh.Capacidad
                TxtPNetoTP.Value = "--"
                TxtAñoFabTP.Value = oeVeh.AnioFabricacion
                TxtAñoModTP.Value = "--"
                TxtFRTP.Value = oeVeh.ConfiguracionNeumaticos
                TxtEjesTP.Value = oeVeh.NroEjes
                TxtRuedasTP.Value = oeVeh.NroNeumaticos
            Else
                TxtClaseTP.Value = ""
                TxtModeloTP.Value = ""
                TxtMarcaTP.Value = ""
                TxtSerieTP.Value = ""
                TxtMotorTP.Value = ""
                TxtCarroceriaTP.Value = ""
                TxtCombustibleTP.Value = ""
                TxtPotenciaTP.Value = ""
                TxtLargoTP.Value = ""
                TxtAnchoTP.Value = ""
                TxtAltoTP.Value = ""
                TxtPBrutoTP.Value = ""
                TxtCUtilTP.Value = ""
                TxtPNetoTP.Value = ""
                TxtAñoFabTP.Value = ""
                TxtAñoModTP.Value = ""
                TxtFRTP.Value = ""
                TxtEjesTP.Value = ""
                TxtRuedasTP.Value = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombo()
        Try
            LlenarTracto()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarTracto()
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "NINGUNO"
            lstVehiculo.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbPlacaTP, lstVehiculo, 0)

            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "TODOS"
            lstVehiculo2.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo2.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbFilTracto, lstVehiculo2, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            CmbPlacaTP.Value = ""
            TxtGlosaTP.Value = ""
            TxtPartidaTP.Value = ""
            TxtTituloTP.Value = ""
            dtp_FechaAdquisicionTP.Value = Date.Now()
            dtp_FechaAdquisicionTP.Value = Date.Now.AddDays(7)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeDocumentoVehicular = New e_DocumentoVehicular
            With Grid_ListadoTarjetaP
                oeDocumentoVehicular.Activo = True
                oeDocumentoVehicular.TipoOperacion = "T"
                oeDocumentoVehicular.IdVehiculo = CmbFilTracto.Value
                oeDocumentoVehicular.IdEmpresaEmisora = ""
                oeDocumentoVehicular.IndVigencia = False
                oeDocumentoVehicular.TipoDocumento = "1CH000000051"
                Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)
                Grid_ListadoTarjetaP.DataSource = ds
                Me.Cursor = Cursors.WaitCursor
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GuardarDocumento() As Boolean
        Try
            If oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo <> "").Count() = 0 Then Throw New Exception("Especifique la unidad de la revisión técnica.")
            oeDocumentoVehicular.IdTipoDocumento = "1CH000000051"
            oeDocumentoVehicular.IdEmpresaEmisora = "1CH000003827"
            oeDocumentoVehicular.NroResolucion = TxtPartidaTP.Value
            oeDocumentoVehicular.Numero = TxtTituloTP.Value
            oeDocumentoVehicular.FechaEmision = dtp_FechaEmisionTP.Value
            oeDocumentoVehicular.FechaAdquisicion = dtp_FechaAdquisicionTP.Value
            oeDocumentoVehicular.Descripcion = TxtGlosaTP.Value
            oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
            oeDocumentoVehicular.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olDocumentoVehicular.Guardar(oeDocumentoVehicular) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tc_DocumentosVehiculares, 2)
                Consultar(True)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EditarTarjeta()
        Try
            Inicializar()

            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.TipoOperacion = "O"
            oeDocumentoVehicular.Id = Grid_ListadoTarjetaP.ActiveRow.Cells("Id").Value
            oeDocumentoVehicular = olDocumentoVehicular.Obtener(oeDocumentoVehicular)
            oeDocumentoVehicular.TipoOperacion = "A"

            oeDetalleDocumentoVehicular.TipoOperacion = "O"
            oeDetalleDocumentoVehicular.Id = ""
            oeDetalleDocumentoVehicular.IdDocumento = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldDetalleDocVeh = olDetalleDocumentoVehiculo.Listar(oeDetalleDocumentoVehicular)

            TxtPartidaTP.Value = oeDocumentoVehicular.NroResolucion
            TxtTituloTP.Value = oeDocumentoVehicular.Numero
            dtp_FechaEmisionTP.Value = oeDocumentoVehicular.FechaEmision
            dtp_FechaAdquisicionTP.Value = oeDocumentoVehicular.FechaAdquisicion
            TxtGlosaTP.Value = oeDocumentoVehicular.Descripcion

            CmbPlacaTP.Value = oeDocumentoVehicular.ldDetalleDocVeh(0).IdVehiculo

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TarjetaPropiedad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarCombo()
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_TarjetaPropiedad_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_TarjetaPropiedad_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_TarjetaPropiedad_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If tc_DocumentosVehiculares.Tabs(0).Selected = True Then
                If Grid_ListadoTarjetaP.Rows.Count() = 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                End If
            ElseIf tc_DocumentosVehiculares.Tabs(1).Selected = True Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CmbPlacaTP_ValueChanged(sender As Object, e As EventArgs) Handles CmbPlacaTP.ValueChanged
        Try
            MostrarDetalleVehiculo()
            If oeDocumentoVehicular.ldDetalleDocVeh.Count = 0 Then
                oeDetalleDocumentoVehicular = New e_DetalleDocumentoVehiculo
                oeDetalleDocumentoVehicular.Activo = IIf(CmbPlacaTP.Value = "", False, True)
                oeDetalleDocumentoVehicular.IdVehiculo = CmbPlacaTP.Value
                oeDetalleDocumentoVehicular.IndTipoVehiculo = ""
                oeDetalleDocumentoVehicular.UsuarioCreacion = ObtenerPerfilPrincipal.Id
                oeDocumentoVehicular.ldDetalleDocVeh.Add(oeDetalleDocumentoVehicular)
            Else
                For Each odd In oeDocumentoVehicular.ldDetalleDocVeh
                    odd.Activo = IIf(CmbPlacaTP.Value = "", False, True)
                    odd.IdVehiculo = CmbPlacaTP.Value
                    odd.IndTipoVehiculo = 0
                    odd.UsuarioCreacion = ObtenerPerfilPrincipal.Id
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_ListadoTarjetaP_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_ListadoTarjetaP.DoubleClickRow
        Try
            If Grid_ListadoTarjetaP.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Operacion = "Editar"
                oeDocumentoVehicular = New e_DocumentoVehicular
                If Grid_ListadoTarjetaP.ActiveRow.Band.Index = 0 Then
                    EditarTarjeta()
                    MostrarTabs(1, tc_DocumentosVehiculares, 1)
                    TxtPartidaTP.Focus()
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una fila válida.")
                End If
            Else
                Throw New Exception("Seleccione una fila válida")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class