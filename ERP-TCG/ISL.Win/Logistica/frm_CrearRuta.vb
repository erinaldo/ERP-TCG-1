'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_CrearRuta

    Dim oeLugar As New e_Lugar, olLugar As New l_Lugar
    Dim lstLugares As New List(Of e_Lugar)
    Dim _Ruta As String, _Pesos As String

    Sub New(ByVal ls_Ruta As String, ByVal ls_Pesos As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        _Ruta = ls_Ruta
        _Pesos = ls_Pesos
    End Sub

    Private Sub frm_CrearRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r_ListarLugares()
        If Not String.IsNullOrEmpty(_Ruta) Then
            Dim tabla() As String
            tabla = Split(_Ruta, "-")
            For n As Integer = 0 To UBound(tabla, 1)
                lbx_Ruta.Items.Add(tabla(n).Trim)
            Next
            ArmarRuta()
            Me.txt_Pesos.Text = CompletarCadena(_Pesos)
        End If
    End Sub

    Function CompletarCadena(ByVal ls_Pesos As String) As String
        Dim tabla() As String, cadena As String = String.Empty
        tabla = Split(ls_Pesos, "-")
        For n As Integer = 0 To UBound(tabla, 1)
            If tabla(n).Length > 1 Then
                cadena &= tabla(n)
            Else
                cadena &= " " & tabla(n)
            End If
        Next
        Return cadena
    End Function
    Sub r_ListarLugares()
        Try
            lbx_Lugar.ValueMember = "Id"
            lbx_Lugar.DisplayMember = "NombreCorto"

            oeLugar = New e_Lugar
            oeLugar.Activo = True
            oeLugar.TipoOperacion = "O"
            lstLugares = olLugar.Listar(oeLugar)
            Dim sw As Boolean
            For Each item As e_Lugar In lstLugares
                sw = False
                For i As Integer = 0 To lbx_Ruta.Items.Count - 1
                    If item.NombreCorto = lbx_Ruta.Items.Item(i).ToString Then
                        sw = True
                        Exit For
                    End If
                Next
                If Not sw Then lbx_Lugar.Items.Add(item.NombreCorto)
            Next

            lbx_Lugar.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Ocurrió un Error en el Proceso", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If lbx_Lugar.SelectedIndex > -1 Then
                lbx_Ruta.Items.Add(lbx_Lugar.SelectedItem)
                'lbx_Lugar.Items.RemoveAt(lbx_Lugar.SelectedIndex)
                ArmarRuta()
            Else
                MessageBox.Show("Seleccione un lugar para agregar", "AYUDAR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un Error en el Proceso", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            If lbx_Ruta.SelectedIndex > -1 Then
                Me.lbx_Ruta.Items.RemoveAt(lbx_Ruta.SelectedIndex)
                ArmarRuta()
            Else
                MessageBox.Show("Seleccione un lugar para quitar", "AYUDAR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un Error en el Proceso", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Sub ArmarRuta()
        Try
            Dim cadena As String = String.Empty, mascara As String = String.Empty
            For i As Integer = 0 To lbx_Ruta.Items.Count - 1
                cadena &= " - " & lbx_Ruta.Items.Item(i).ToString
                If i > 0 Then mascara &= " - nn"
            Next
            Me.txt_Ruta.Text = Strings.Right(cadena, cadena.Length - 3)
            If lbx_Ruta.Items.Count > 1 Then
                Me.txt_Pesos.InputMask = Strings.Right(mascara, mascara.Length - 3)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArriba.Click
        Try
            If lbx_Ruta.SelectedIndex > 0 Then
                Dim i = lbx_Ruta.SelectedIndex - 1
                lbx_Ruta.Items.Insert(i, lbx_Ruta.SelectedItem)
                lbx_Ruta.Items.RemoveAt(lbx_Ruta.SelectedIndex)
                lbx_Ruta.SelectedIndex = i
                ArmarRuta()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un Error en el Proceso", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        lbx_Lugar.SelectedIndex = lbx_Lugar.FindString(Me.txtBuscar.Text.Trim)
    End Sub

    Private Sub btnAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbajo.Click
        Try
            If lbx_Ruta.SelectedIndex < lbx_Ruta.Items.Count - 1 Then
                Dim i = lbx_Ruta.SelectedIndex + 2
                lbx_Ruta.Items.Insert(i, lbx_Ruta.SelectedItem)
                lbx_Ruta.Items.RemoveAt(lbx_Ruta.SelectedIndex)
                lbx_Ruta.SelectedIndex = i - 1
                ArmarRuta()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un Error en el Proceso", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Function CrearMascaraPesos(ByVal nroLugares As String) As String
        Dim mascara As String = String.Empty
        For i = 1 To nroLugares - 1
            mascara &= " - ##"
        Next
        Return Strings.Right(mascara, mascara.Length - 3)
    End Function

 
End Class