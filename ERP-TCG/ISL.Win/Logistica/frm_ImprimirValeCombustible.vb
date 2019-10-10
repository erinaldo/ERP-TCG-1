'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports System.Drawing.Printing
Public Class frm_ImprimirValeCombustible
    Private mo_Datos As IDictionary

    Sub New(ByVal lo_LDatos As IDictionary)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mo_Datos = lo_LDatos

    End Sub
    Private Sub CargarImpresoras()
        Try
            Dim pd As New PrintDocument
            Dim Impresoras As String
            Dim ls_Impresora_X_Defecto As String = pd.PrinterSettings.PrinterName
            For Each Impresoras In PrinterSettings.InstalledPrinters
                lsb_Impresora.Items.Add(Impresoras.ToString)
            Next
            lsb_Impresora.Text = ls_Impresora_X_Defecto
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub frm_ImprimirValeCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarImpresoras()
    End Sub

    Private Sub Imprimir_Vale()
        Try
            Dim o_printD As New PrintDocument
            btnImprimir.Enabled = False

            'If lsb_Impresora.Text <> "" Then o_printD.PrinterSettings.PrinterName = lsb_Impresora.Text
            If Not o_printD.PrinterSettings.DefaultPageSettings.Landscape Then
                RemoveHandler o_printD.PrintPage, AddressOf Imprimir_ValeCombustible
                AddHandler o_printD.PrintPage, AddressOf Imprimir_ValeCombustible
                o_printD.Print()
                'Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Throw New Exception("Debe Cambiar el Modo de Impresion a Vertical")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            btnImprimir.Enabled = True
        End Try

    End Sub

    Sub Imprimir_ValeCombustible(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim lo_Datos As IDictionary
        lo_Datos = mo_Datos
        Dim posY As Integer = 0
        Dim posX As Integer = -25

        Dim font As New Font("Courier New", 9)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim pen As New Pen(Color.Black, 1.0F)
        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid

        e.Graphics.DrawString("ISL SAC", font, drawBrush, posX + 125, posY + 50)
        e.Graphics.DrawString("VALE DE CONSUMO", font, drawBrush, posX + 100, posY + 70)
        'e.Graphics.DrawLine(pen, posX + 40, posY + 75, posX + 300, posY + 75)

        e.Graphics.DrawString("NRO   :", font, drawBrush, posX + 40, posY + 100)
        e.Graphics.DrawString(lo_Datos("NUMERO"), font, drawBrush, posX + 110, posY + 100)

        e.Graphics.DrawString("FECHA :", font, drawBrush, posX + 40, posY + 125)
        e.Graphics.DrawString(lo_Datos("FECHA"), font, drawBrush, posX + 110, posY + 125)

        e.Graphics.DrawString("PILOTO:", font, drawBrush, posX + 40, posY + 150)
        e.Graphics.DrawString(lo_Datos("NOM_CHOFER"), font, drawBrush, posX + 110, posY + 150)

        e.Graphics.DrawString("UNIDAD:", font, drawBrush, posX + 40, posY + 175)
        e.Graphics.DrawString(lo_Datos("PLACA_VEH"), font, drawBrush, posX + 110, posY + 175)

        e.Graphics.DrawString("KILOMETRAJE:", font, drawBrush, posX + 40, posY + 200)
        e.Graphics.DrawString(lo_Datos("KILOMETRAJE"), font, drawBrush, posX + 150, posY + 200)

        'e.Graphics.DrawLine(pen, posX + 40, posY + 220, posX + 300, posY + 220)

        e.Graphics.DrawString("DESCRIPCION", font, drawBrush, posX + 60, posY + 230)
        e.Graphics.DrawString("CANTIDAD", font, drawBrush, posX + 180, posY + 230)

        e.Graphics.DrawLine(pen, posX + 40, posY + 250, posX + 260, posY + 250)

        e.Graphics.DrawString("D2", font, drawBrush, posX + 40, posY + 255)
        e.Graphics.DrawString(lo_Datos("GALONES"), font, drawBrush, posX + 185, posY + 255)

        e.Graphics.DrawLine(pen, posX + 40, posY + 275, posX + 260, posY + 275)

        If Trim(lo_Datos("GLOSA")) <> "" Then
            e.Graphics.DrawString("GLOSA:", font, drawBrush, posX + 40, posY + 295)
            e.Graphics.DrawString(lo_Datos("GLOSA").ToString.Substring(0, 20), font, drawBrush, posX + 110, posY + 295)
            e.Graphics.DrawString(lo_Datos("GLOSA").ToString.Substring(20, 20), font, drawBrush, posX + 110, posY + 320)
            e.Graphics.DrawString(lo_Datos("GLOSA").ToString.Substring(40), font, drawBrush, posX + 110, posY + 345)

            e.Graphics.DrawLine(pen, posX + 80, posY + 385, posX + 200, posY + 385)
            e.Graphics.DrawString("AUTORIZA", font, drawBrush, posX + 115, posY + 395)
        Else
            e.Graphics.DrawLine(pen, posX + 80, posY + 315, posX + 200, posY + 315)
            e.Graphics.DrawString("AUTORIZA", font, drawBrush, posX + 115, posY + 320)
        End If

       

        e.HasMorePages = False

    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Imprimir_Vale()
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class