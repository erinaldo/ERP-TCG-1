Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_GRR_Venta_Print

#Region "Variables"

    Private ms_IdGRR As String
    Private olGrr As l_GRR_Venta
    Private olGrr_Detalle As l_GuiaRemisionRemitente_Detalle


#End Region

    Sub New(IdGrr As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ms_IdGRR = IdGrr
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frm_GRR_Venta_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            olGrr = New l_GRR_Venta
            olGrr_Detalle = New l_GuiaRemisionRemitente_Detalle

            lr_CargarDatos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub



    Private Sub lr_CargarDatos()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class