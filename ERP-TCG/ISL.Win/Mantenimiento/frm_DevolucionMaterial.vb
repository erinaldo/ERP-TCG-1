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

Public Class frm_DevolucionMaterial
    Inherits ISL.Win.frm_MenuPadre
    Dim oeMaterial As New e_Material, olMaterial As New l_Material
    Public md_CantEntregada As Double
    Dim _cantPendienteDevolver As Double

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ValidaEntradas() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_DevolucionMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ndCantidad.SelectAll()
    End Sub

    Private Function ValidaEntradas() As Boolean
        Try
            If Me.ndCantidad.Value = 0 Then
                Me.ndCantidad.Focus()
                Throw New Exception("Ingrese la cantidad")
            End If
            If Me.ndCantidad.Value > (md_CantEntregada - _cantPendienteDevolver) Then
                Throw New Exception("La Cantidad a devolver no debe ser mayor que la cantidad entregada")
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function CargarDatosMaterial(ByVal IdMaterial As String, ByVal CantidadEntregada As Double, Optional ByVal CantPendienteDevolver As Double = 0) As Boolean
        Try
            md_CantEntregada = CantidadEntregada
            _cantPendienteDevolver = CantPendienteDevolver
            oeMaterial = New e_Material
            oeMaterial.TipoOperacion = "G"
            oeMaterial.Id = IdMaterial
            oeMaterial = olMaterial.Obtener(oeMaterial)
            If oeMaterial.Activo Then
                Inicializar()
                txtCodigo.Text = oeMaterial.Codigo
                txtNombre.Text = oeMaterial.Nombre
                etiPendiente.Text = "Cantidad Máxima por Devolver: " & (md_CantEntregada - _cantPendienteDevolver).ToString("#,##0.00")
                ndCantidad.Focus()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Function


    Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        ndCantidad.Value = 0
    End Sub

End Class
