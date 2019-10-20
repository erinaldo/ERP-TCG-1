'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles

Public Class frm_AsignarConfiguracionGrafica

    Private ms_IdVehiculo As String
    Private ms_PlacaVeh As String
    Private mn_NroLlantasRespuestos As Integer
    Private ms_IdConfigVeh As String
    Dim oeConfiguracionNeumatico As New e_ConfiguracionNeumatico, olConfiguracionNeumatico As New l_ConfiguracionNeumatico
    Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo
    Dim lstConfiguracionNeumatico As New List(Of e_ConfiguracionNeumatico)

    Sub New(ByVal ls_IdVehiculo As String, ByVal ls_PlacaVeh As String _
    , ByVal ln_NroLLantasRepuestos As Integer, ByVal ls_IdConfigNeu As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ms_IdVehiculo = ls_IdVehiculo
        ms_PlacaVeh = ls_PlacaVeh
        mn_NroLlantasRespuestos = ln_NroLLantasRepuestos
        ms_IdConfigVeh = ls_IdConfigNeu
    End Sub

    Private Sub frm_AsignarConfiguracionGrafica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarConfiguracionNeumatico()
        Me.gb_AsigConfGraf.Text = ms_PlacaVeh & ":"
        Me.ndNroLlantasRepuesto.Value = mn_NroLlantasRespuestos
        Me.cmbConfiguracionNeumatico.Value = ms_IdConfigVeh
    End Sub

    Sub ListarConfiguracionNeumatico()
        Try
            oeConfiguracionNeumatico.Id = "CERO"
            oeConfiguracionNeumatico.Nombre = "NINGUNA"
            lstConfiguracionNeumatico.Add(oeConfiguracionNeumatico)
            oeConfiguracionNeumatico = New e_ConfiguracionNeumatico
            oeConfiguracionNeumatico.Activo = True
            oeConfiguracionNeumatico.TipoOperacion = ""
            lstConfiguracionNeumatico.AddRange(olConfiguracionNeumatico.Listar(oeConfiguracionNeumatico))
            LlenarComboMaestro(cmbConfiguracionNeumatico, lstConfiguracionNeumatico, 0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Function ValidarConfigGraf() As Boolean
        If cmbConfiguracionNeumatico.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione Configuracion Grafica !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbConfiguracionNeumatico.Focus()
            Return False
        End If
        If Me.ndNroLlantasRepuesto.Text.Trim = "" Then
            MessageBox.Show("Ingrese Llantas de Repuesto.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ndNroLlantasRepuesto.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If ValidarConfigGraf() Then
                oeVehiculo.TipoOperacion = "A"
                oeVehiculo.TipoActualizacion = "C"
                oeVehiculo.Id = ms_IdVehiculo
                oeVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olVehiculo.Guardar(oeVehiculo) Then
                    MessageBox.Show("Actualizado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ndNroLlantasRepuesto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndNroLlantasRepuesto.ValueChanged
        oeVehiculo.NroNeumaticosRepuesto = ndNroLlantasRepuesto.Value
    End Sub

    Private Sub cmbConfiguracionNeumatico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConfiguracionNeumatico.ValueChanged
        oeVehiculo.IdConfiguracionNeumaticos = IIf(Me.cmbConfiguracionNeumatico.Value = "CERO", "", cmbConfiguracionNeumatico.Value)
    End Sub

End Class