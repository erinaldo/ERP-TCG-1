Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles

Public Class frm_DiseñoNeumatico
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_DiseñoNeumatico = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_DiseñoNeumatico()
        End If
        Instancia.Activate()
        Return Instancia
    End Function
#End Region

#Region "Declaración de variables"

    Private WithEvents oeDiseñoNeumatico As New e_DiseñoNeumatico
    Dim olDiseñoNeumatico As New l_DiseñoNeumatico
    Dim oeMedidaNeumatico As New e_MedidaNeumatico, olMedidaNeumatico As New l_MedidaNeumatico
    Dim oeMarca As New e_Marca, olMarca As New l_Marca
    'Variable para controlar el estado de los registros mostrados (Activo - Inactivo)
    Dim Estado As String
    'Variable para controlar el estado de la botonera principal del sistema
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_DiseñoNeumatico.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeDiseñoNeumatico = New e_DiseñoNeumatico
            oeDiseñoNeumatico.TipoOperacion = "I"
            oeDiseñoNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            MostrarTabs(1, tcDiseños, 1)
            Inicializar()
            txtNombre.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            oeDiseñoNeumatico.Modificado = False

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            oeDiseñoNeumatico = New e_DiseñoNeumatico
            MostrarDiseñoNeumatico()
            oeDiseñoNeumatico.TipoOperacion = "A"
            txtNombre.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeDiseñoNeumatico.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDiseñoNeumatico() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcDiseños, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeDiseñoNeumatico.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarDiseñoNeumatico() Then
                            MostrarTabs(0, tcDiseños, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcDiseños, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcDiseños, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcDiseños, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_DiseñoNeumatico
                If .Selected.Rows.Count > 0 Then
                    If ValidarGrilla(grid_DiseñoNeumatico, "Medida Neumatico") Then
                        oeDiseñoNeumatico.Id = .ActiveRow.Cells("Id").Value
                        oeDiseñoNeumatico = olDiseñoNeumatico.Obtener(oeDiseñoNeumatico)
                        If oeMedidaNeumatico.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la Medida Neumatico: " & _
                            .ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeDiseñoNeumatico.TipoOperacion = "E"
                                olDiseñoNeumatico.Eliminar(oeDiseñoNeumatico)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                        End If
                    Else
                        mensajeEmergente.Confirmacion("Seleccione un registro para eliminar")
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If grid_DiseñoNeumatico.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_DiseñoNeumatico)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_DiseñoNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        MostrarTabs(0, tcDiseños)
        grid_DiseñoNeumatico.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        grid_DiseñoNeumatico.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeDiseñoNeumatico.Nombre = txtNombre.Text
    End Sub

    Private Sub cmbMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.ValueChanged
        oeDiseñoNeumatico.IdMarca = cmbMarca.Value
    End Sub

    Private Sub cmbMedidaNeumatico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedidaNeumatico.ValueChanged
        oeDiseñoNeumatico.IdMedidaNeumatico = cmbMedidaNeumatico.Value
    End Sub

    Private Sub ndLonas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndLonas.ValueChanged
        oeDiseñoNeumatico.NroLonas = ndLonas.Value
    End Sub

    Private Sub ndRibete1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndRibete1.ValueChanged
        oeDiseñoNeumatico.Ribete1 = ndRibete1.Value
    End Sub

    Private Sub ndRibete2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndRibete2.ValueChanged
        oeDiseñoNeumatico.Ribete2 = ndRibete2.Value
    End Sub

    Private Sub ndRibete3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndRibete3.ValueChanged
        oeDiseñoNeumatico.Ribete3 = ndRibete3.Value
    End Sub

    Private Sub ndCocada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCocada.ValueChanged
        oeDiseñoNeumatico.Cocada = ndCocada.Value
    End Sub

    Private Sub ndCocadaMinima_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCocadaMinima.ValueChanged
        oeDiseñoNeumatico.CocadaMinima = ndCocadaMinima.Value
    End Sub

    Private Sub frm_DiseñoNeumatico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_DiseñoNeumatico_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub grid_DiseñoNeumatico_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_DiseñoNeumatico.DoubleClickRow
        If grid_DiseñoNeumatico.Selected.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Metodos"

    Private Sub oeDiseñoNeumatico_DatoCambiado() Handles oeDiseñoNeumatico.DatoCambiado
        oeDiseñoNeumatico.Modificado = True
    End Sub

    Public Sub LlenaCombos()
        Try
            oeMedidaNeumatico.Activo = True
            'LlenarComboMaestro(cmbMedidaNeumatico, olMedidaNeumatico.Listar(oeMedidaNeumatico), -1)
            If Not cache.Contiene("MedidaNeumatico") OrElse cache.ForzarActualizacion Then cache.Agregar("MedidaNeumatico", olMedidaNeumatico.Listar(oeMedidaNeumatico))
            LlenarComboMaestro(cmbMedidaNeumatico, DirectCast(cache.Obtener("MedidaNeumatico"), List(Of e_MedidaNeumatico)), -1)

            oeMarca.Activo = True
            oeMarca.TipoMarca = 1
            'LlenarComboMaestro(cmbMarca, olMarca.Listar(oeMarca), -1)
            If Not cache.Contiene("Marcas") OrElse cache.ForzarActualizacion Then cache.Agregar("Marcas", olMarca.Listar(oeMarca))
            LlenarComboMaestro(cmbMarca, DirectCast(cache.Obtener("Marcas"), List(Of e_Marca)), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Inicializar()
        Try
            LlenaCombos()
            Me.txtNombre.Text = String.Empty
            Me.ndLonas.Value = 0
            Me.ndCocada.Value = 0
            ndRibete1.Value = 0
            ndRibete2.Value = 0
            ndRibete3.Value = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeDiseñoNeumatico = New e_DiseñoNeumatico
            With grid_DiseñoNeumatico
                oeDiseñoNeumatico.Activo = Activo
                .DataSource = olDiseñoNeumatico.Listar(oeDiseñoNeumatico)
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_DiseñoNeumatico.Focus()
        End Try
    End Sub

    Function GuardarDiseñoNeumatico() As Boolean
        Try
            If olDiseñoNeumatico.Guardar(oeDiseñoNeumatico) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcDiseños, 2)
                Consultar(True)
                grid_DiseñoNeumatico.Focus()
                Return True
            End If
        Catch ex As Exception
            Enfocar(ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub MostrarDiseñoNeumatico()
        Try
            If grid_DiseñoNeumatico.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeDiseñoNeumatico.Id = grid_DiseñoNeumatico.ActiveRow.Cells("Id").Value.ToString
                oeDiseñoNeumatico = olDiseñoNeumatico.Obtener(oeDiseñoNeumatico)
                txtCodigo.Text = oeDiseñoNeumatico.Codigo
                txtNombre.Text = oeDiseñoNeumatico.Nombre
                ndLonas.Value = oeDiseñoNeumatico.NroLonas
                cmbMarca.Value = oeDiseñoNeumatico.IdMarca
                ndRibete1.Value = oeDiseñoNeumatico.Ribete1
                ndRibete2.Value = oeDiseñoNeumatico.Ribete2
                ndRibete3.Value = oeDiseñoNeumatico.Ribete3
                ndCocada.Value = oeDiseñoNeumatico.Cocada
                ndCocadaMinima.Value = oeDiseñoNeumatico.CocadaMinima
                cmbMedidaNeumatico.Value = oeDiseñoNeumatico.IdMedidaNeumatico
                verActivo.Checked = oeDiseñoNeumatico.Activo
                MostrarTabs(1, tcDiseños, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("nombre") Then txtNombre.Focus()
        If excepcion.Contains("aro") Then ndLonas.Focus()
        If excepcion.Contains("abreviatura") Then cmbMedidaNeumatico.Focus()
    End Sub

#End Region
   
End Class
