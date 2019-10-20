'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_LimiteCredito
    Inherits ISL.Win.frm_MenuPadre
    Private oeLimiteCredito As New e_LimiteCredito
    Private olLimiteCredito As New l_LimiteCredito
    Private Shared instancia As frm_LimiteCredito = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_LimiteCredito()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_ListaLimiteCredito.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        oeLimiteCredito.TipoOperacion = "I"
        oeLimiteCredito.Modificado = False
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            'If ValidarGrilla(grid_ListaLimiteCredito, "Periodo") Then
            If grid_ListaLimiteCredito.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Inicializar()
                MostrarLimiteCredito()
                oeLimiteCredito.TipoOperacion = "A"
                oeLimiteCredito.Modificado = False
                cboBanco.Focus()
                MyBase.Editar()
            Else
                Throw New Exception("Seleccione una Fila!")
            End If
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLimiteCredito() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcLimiteCredito, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeLimiteCredito.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarLimiteCredito() Then
                            MostrarTabs(1, tcLimiteCredito)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcLimiteCredito, 2)
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcLimiteCredito, 2)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ListaLimiteCredito
                'If ValidarGrilla(grid_ListaPeriodo, "Periodo") Then
                If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                    oeLimiteCredito.Id = .ActiveRow.Cells("ID").Value
                    oeLimiteCredito = olLimiteCredito.Obtener(oeLimiteCredito)
                    If oeLimiteCredito.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar este registro ", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeLimiteCredito.TipoOperacion = "E"
                            olLimiteCredito.Eliminar(oeLimiteCredito)
                            Consultar(_Activo)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
                'End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_ListaLimiteCredito.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaLimiteCredito)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeLimiteCredito = New e_LimiteCredito
        cboBanco.SelectedIndex = -1
        CboMoneda.SelectedIndex = -1
        cboTipoDocumento.SelectedIndex = -1
        DecTC.Value = 0
        DecTotalMN.Value = 0
        DecTotalME.Value = 0
        MostrarTabs(1, tcLimiteCredito, 1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            LimpiaGrid(grid_ListaLimiteCredito, UltraDataSource2)
            Me.Cursor = Cursors.WaitCursor
            Dim leLimiteCredito As New List(Of e_LimiteCredito)
            Dim olLimiteCredito As New l_LimiteCredito
            oeLimiteCredito = New e_LimiteCredito
            oeLimiteCredito.Activo = Activo
            leLimiteCredito.AddRange(olLimiteCredito.Listar(oeLimiteCredito))
            grid_ListaLimiteCredito.DataSource = leLimiteCredito

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ListaLimiteCredito.Focus()
    End Sub

    Private Function GuardarLimiteCredito() As Boolean
        Try
            If Validar() Then
                oeLimiteCredito.PrefijoID = gs_PrefijoIdSucursal '@0001
                olLimiteCredito.Guardar(oeLimiteCredito)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                MostrarTabs(0, tcLimiteCredito, 2)
                Consultar(True)
                grid_ListaLimiteCredito.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            If cboBanco.SelectedIndex = -1 Then Throw New Exception("Selecciona el banco")
            If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Selecciona la moneda")
            If cboTipoDocumento.SelectedIndex = -1 Then Throw New Exception("Selecciona el tipo de cambio")
            If DecTC.Value <= 0 Then Throw New Exception("El tipo de cambio no puede ser menor o igual a cero")
            If DecTotalMN.Value <= 0 Then Throw New Exception("El Total en soles no puede ser menor igual a cero")
            If DecTotalME.Value <= 0 Then Throw New Exception("El Total en dolares no puede ser menor igual a cero")
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub MostrarLimiteCredito()
        Try
            If grid_ListaLimiteCredito.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeLimiteCredito = New e_LimiteCredito
                oeLimiteCredito.Id = grid_ListaLimiteCredito.ActiveRow.Cells("Id").Value.ToString
                oeLimiteCredito = olLimiteCredito.Obtener(oeLimiteCredito)
                cboBanco.Value = oeLimiteCredito.IdEmpresaBanco
                cboTipoDocumento.Value = oeLimiteCredito.IdTipoDocumento
                CboMoneda.Value = oeLimiteCredito.IdMoneda
                DecTotalMN.Value = oeLimiteCredito.MontoCreditoMN
                DecTotalME.Value = oeLimiteCredito.MontoCreditoME
                DecTC.Value = oeLimiteCredito.TipoCambio
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Banco()
        Try
            Dim oeBanco As New e_Empresa
            Dim olBanco As New l_Empresa
            Dim leBanco As New List(Of e_Empresa)
            leBanco.AddRange(olBanco.Listar(oeBanco))
            '--------------------- para llenar combo en grilla    
            grid_ListaLimiteCredito.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
            With grid_ListaLimiteCredito.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
                .Clear()
                For Each oeTD As e_Empresa In leBanco
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdEmpresaBanco", "Nombre", grid_ListaLimiteCredito, True)
            '------------------------------------------
            With cboBanco
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leBanco
            End With


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TipoDocumento()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim olTipoDoc As New l_TipoDocumento
            Dim leTipoDoc As New List(Of e_TipoDocumento)
            oeTipoDoc.Activo = True
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            '--------------------- para llenar combo en grilla    
            grid_ListaLimiteCredito.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With grid_ListaLimiteCredito.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", grid_ListaLimiteCredito, True)
            '------------------------------------------
            With cboTipoDocumento
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTipoDoc
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TipoMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            grid_ListaLimiteCredito.DisplayLayout.ValueLists.Add("IdMoneda")
            With grid_ListaLimiteCredito.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", grid_ListaLimiteCredito, True)
            '------------------------------------------
            With CboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_LimiteCredito_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_LimiteCredito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_LimiteCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            MostrarTabs(0, tcLimiteCredito)
            TipoMoneda()
            TipoDocumento()
            Banco()
            InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_ListaEjercicio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_ListaLimiteCredito.DoubleClick
        If grid_ListaLimiteCredito.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ListaEjercicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_ListaLimiteCredito.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaEjercicio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaLimiteCredito.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaPeriodo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_ListaLimiteCredito.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub cboBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.ValueChanged
        oeLimiteCredito.IdEmpresaBanco = cboBanco.Value
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        oeLimiteCredito.IdTipoDocumento = cboTipoDocumento.Value
    End Sub

    Private Sub CboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMoneda.ValueChanged
        oeLimiteCredito.IdMoneda = CboMoneda.Value
    End Sub

    Private Sub DecTotalMN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTotalMN.ValueChanged
        oeLimiteCredito.MontoCreditoMN = DecTotalMN.Value
    End Sub

    Private Sub DecTotalME_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTotalME.ValueChanged
        oeLimiteCredito.MontoCreditoME = DecTotalME.Value
    End Sub

    Private Sub DecTC_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecTC.Validated
        Try
            If DecTotalMN.Value > 0 And DecTC.Value > 0 Then
                DecTotalME.Value = DecTotalMN.Value / DecTC.Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        oeLimiteCredito.TipoCambio = DecTC.Value
    End Sub

#End Region

End Class
