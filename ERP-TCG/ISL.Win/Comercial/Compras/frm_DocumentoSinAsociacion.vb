'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_DocumentoSinAsociacion
#Region "Declaracion de Variables"
    Private oeDocumentoSinAsociacion As New e_DocumentoSinAsociacion
    Private olDocumentoSinAsociacion As New l_DocumentoSinAsociacion
    Dim tipo As String = ""
    Dim IdTipoDoc As String = ""
    Dim Id As String = ""
#End Region
#Region "Procedimiento y Metodos"
    Sub New(ByVal _tipo As String, ByVal _Id As String, ByVal _IdTipoDoc As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        Dim oeDocSinAsoc As New e_DocumentoSinAsociacion
        oeDocSinAsoc.TipoOperacion = ""
        oeDocSinAsoc.Id = _Id
        Id = _Id
        InitializeComponent()
        tipo = _tipo
        IdTipoDoc = _IdTipoDoc
        Inicializar()
        If tipo.Equals("Evaluar") Then
            If Not String.IsNullOrEmpty(Id) Then oeDocSinAsoc = olDocumentoSinAsociacion.Obtener(oeDocSinAsoc)
            gbEvaluar.Enabled = 1
            Me.txtGlosa.Text = oeDocSinAsoc.Glosa
            Me.Fecha.Value = oeDocSinAsoc.Fecha
        End If
    End Sub
    Private Sub Inicializar()
        oeDocumentoSinAsociacion = New e_DocumentoSinAsociacion
        Me.Fecha.Value = Date.Today
        Me.txtGlosa.Text = String.Empty
        rbAprobar.Checked = 0
        rbRechazar.Checked = 0
        gbEvaluar.Enabled = 0
    End Sub
    Private Sub GuardarEvaluar()
        Try
            oeDocumentoSinAsociacion.TipoOperacion = "A"
            oeDocumentoSinAsociacion.Glosa = Me.txtGlosa.Text
            oeDocumentoSinAsociacion.Fecha = Me.Fecha.Value
            oeDocumentoSinAsociacion.IdUsuarioEvalua = gUsuarioSGI.Id
            oeDocumentoSinAsociacion.IdTipoDocumento = IdTipoDoc
            oeDocumentoSinAsociacion.Id = Id
            If rbAprobar.Checked Then
                oeDocumentoSinAsociacion.Evaluado = 1
            ElseIf rbRechazar.Checked Then
                oeDocumentoSinAsociacion.Evaluado = 2
            Else
                oeDocumentoSinAsociacion.Evaluado = 0
            End If
            oeDocumentoSinAsociacion.PrefijoID = PrefijoIdSucursal '@0001
            olDocumentoSinAsociacion.Guardar(oeDocumentoSinAsociacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub GuardarSolicitar()
        Try
            oeDocumentoSinAsociacion.TipoOperacion = "I"
            oeDocumentoSinAsociacion.Glosa = Me.txtGlosa.Text
            oeDocumentoSinAsociacion.Fecha = Me.Fecha.Value
            oeDocumentoSinAsociacion.IdTipoDocumento = IdTipoDoc
            oeDocumentoSinAsociacion.IdUsuarioSolicito = gUsuarioSGI.Id
            oeDocumentoSinAsociacion.UsuarioCreacion = gUsuarioSGI.Id
            oeDocumentoSinAsociacion.Evaluado = 0
            oeDocumentoSinAsociacion.PrefijoID = PrefijoIdSucursal '@0001
            olDocumentoSinAsociacion.Guardar(oeDocumentoSinAsociacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Guardar()
        Try
            Select Case tipo
                Case "Solicitar"
                    GuardarSolicitar()
                Case "Evaluar"
                    GuardarEvaluar()
            End Select
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#End Region
#Region "Eventos"
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub
#End Region

End Class