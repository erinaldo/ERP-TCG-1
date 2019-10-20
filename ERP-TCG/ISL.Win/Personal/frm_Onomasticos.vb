'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Microsoft.Office.Interop

Public Class frm_Onomasticos
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)

    End Sub

    Private Shared instancia As frm_Onomasticos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            'Operacion = "Inicializa"
            instancia = New frm_Onomasticos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Definición de variables"

    Private oeOnomasticos As New e_Onomastico
    Private olOnomasticos As New l_Trabajador
    Private olPersona As New l_Persona
    Private mes As String = "Enero"
    Private dia As String = "01"
    Dim olConfiguracion As New l_Configuracion

#End Region

    Private Sub opcPorMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcPorMes.CheckedChanged
        Try
            If opcPorMes.Checked Then
                Meses1.Focus()
                MuestraOcultaControlesDia(True)
                MuestraOcultaControlesDiaAntes(True)
                TituloDelMes()
                cache.ForzarActualizacion = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub opcTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcTodos.CheckedChanged
        Try
            TituloTotal()
            MuestraOcultaControlesDia(True)
            MuestraOcultaControlesDiaAntes(True)
            cache.ForzarActualizacion = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub opcDelDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcDelDia.CheckedChanged
        Try
            MuestraOcultaControlesDia(False)
            MuestraOcultaControlesDiaAntes(False)
            If opcDelDia.Checked Then Meses1.Seleccionar(Date.Now.Month)
            TituloDelDia()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Meses1_DatosCambiados(ByVal idMes As String, ByVal NombreMes As String) Handles Meses1.DatosCambiados
        TituloDelMes()
        cache.ForzarActualizacion = True
    End Sub

    Private Sub EnviarEmailDeSaludoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarEmailDeSaludoToolStripMenuItem.Click
        Try
            GenerarArchivoSaludo(True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Meses1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Meses1.Enter
        opcPorMes.Checked = True
    End Sub

    Private Sub TituloDelDia()
        agrTituloGrilla.Text = "Relación de colaboradores que cumplen años el día " & Date.Now.ToLongDateString
    End Sub

    Private Sub TituloDelMes()
        agrTituloGrilla.Text = "Relación de colaboradores que cumplen años en " & Meses1.cboMes.Text
    End Sub

    Private Sub TituloTotal()
        agrTituloGrilla.Text = "Relación de onomásticos de colaboradores de ISL"
    End Sub

    Private Sub MuestraOcultaControlesDia(ByVal ver As Boolean)
        Try
            ColoresDelDia.Visible = ver
            etiEnElDia.Visible = ver
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MuestraOcultaControlesDiaAntes(ByVal ver As Boolean)
        Try
            ColoresFaltanDias.Visible = ver
            etiProximosDias.Visible = ver
            etiDias.Visible = ver
            numDiasAntes.Visible = ver
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            mes = ""
            dia = ""
            If opcPorMes.Checked Or opcDelDia.Checked Then mes = Meses1.cboMes.Text
            If opcDelDia.Checked Then dia = Date.Now.Day.ToString
            Listar(mes, dia)
            Tiempo1.Enabled = True
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()

        'Dim frm As New frm_ReporteOnomastico
        'frm.MdiParent = Me
        'frm.Show()

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griOnomasticos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griOnomasticos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Public Sub Listar(ByVal mes As String, Optional ByVal dia As String = "")
        Try
            oeOnomasticos = New e_Onomastico
            Tiempo1.Enabled = True
            With griOnomasticos
                If Not String.IsNullOrEmpty(dia) Then
                    '.DataSource = DirectCast(cache.Procesar("ListarOnomasticos", olOnomasticos.ListarOnomasticos(mes, dia)), List(Of e_Onomastico))
                    If Not cache.Contiene("ListarOnomasticos") OrElse cache.ForzarActualizacion Then cache.Agregar("ListarOnomasticos", olOnomasticos.ListarOnomasticos(mes, dia))
                    .DataSource = DirectCast(cache.Obtener("ListarOnomasticos"), List(Of e_Onomastico))
                Else
                    '.DataSource = DirectCast(cache.Procesar("ListarOnomasticosMes", olOnomasticos.ListarOnomasticos(mes)), List(Of e_Onomastico))
                    If Not cache.Contiene("ListarOnomasticosMes") OrElse cache.ForzarActualizacion Then cache.Agregar("ListarOnomasticosMes", olOnomasticos.ListarOnomasticos(mes))
                    .DataSource = DirectCast(cache.Obtener("ListarOnomasticosMes"), List(Of e_Onomastico))
                End If
                .DisplayLayout.Bands(0).Columns("OrdenMes").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 300
                .DisplayLayout.Bands(0).Columns("Area").Width = 200
            End With

            Dim proximosDias As Integer = Date.Now.Day + numDiasAntes.Value
            Dim limiteMaximoDias As Integer = Date.DaysInMonth(Date.Now.Year, Date.Now.Month)

            If proximosDias > limiteMaximoDias Then proximosDias = limiteMaximoDias

            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griOnomasticos.Rows

                If fila.Cells("Dia").Value = Date.Now.Day AndAlso fila.Cells("OrdenMes").Value = Date.Now.Month AndAlso Not opcDelDia.Checked Then fila.CellAppearance.BackColor = Me.ColoresDelDia.Color

                If (fila.Cells("Dia").Value >= Date.Now.Day + 1 AndAlso fila.Cells("Dia").Value <= proximosDias) AndAlso fila.Cells("OrdenMes").Value = Date.Now.Month Then fila.CellAppearance.BackColor = Me.ColoresFaltanDias.Color

                If fila.Cells("Edad").Value < 18 OrElse fila.Cells("Edad").Value > 65 Then fila.CellAppearance.BackColor = Me.ColoresVerificarFechaNacimiento.Color

            Next

            ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)

            'Ubica el cursor el el primer registro de la grilla
            If griOnomasticos.Rows.Count > 0 Then
                griOnomasticos.Focus()
                griOnomasticos.Rows.Item(0).Selected = True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' Método para generar un archivo PowerPoint de saludo por onomástico
    ''' al trabajador seleccionado
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Sub GenerarArchivoSaludo(Optional ByVal Email As Boolean = False)
        Try
            Dim oApp As PowerPoint.Application
            Dim oPres As PowerPoint.Presentation
            Dim sTemplate As String
            If opcFormato1.Checked Then
                sTemplate = "\\" & olConfiguracion.IPServidor & "\Fotos\CumpleFormato1.pptm"
            ElseIf opcFormato2.Checked Then
                sTemplate = "\\" & olConfiguracion.IPServidor & "\Fotos\CumpleFormato2.pptm"
            Else
                sTemplate = "\\" & olConfiguracion.IPServidor & "\Fotos\CumpleFormato3.pptm"
            End If

            If Not System.IO.File.Exists(sTemplate) Then Throw New Exception("El archivo " & sTemplate & " no existe, comuníquese con el área de sistemas para recuperarlo")
            Dim nombre As String = griOnomasticos.ActiveRow.Cells("NombreCompleto").Value
            Dim area As String = griOnomasticos.ActiveRow.Cells("Area").Value

            Dim oPresentations As PowerPoint.Presentations

            oApp = New PowerPoint.Application

            oApp.Visible = True

            oApp.WindowState = IIf(Email, PowerPoint.PpWindowState.ppWindowMinimized, PowerPoint.PpWindowState.ppWindowMaximized)

            oPresentations = oApp.Presentations
            oPres = oPresentations.Open2007(sTemplate, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse, True)

            Dim MySlide As PowerPoint.Slide


            Dim foto As String = "\\" & olConfiguracion.IPServidor & "\Fotos\" & griOnomasticos.ActiveRow.Cells("Dni").Value & ".jpg"
            Dim logo As String = "\\" & olConfiguracion.IPServidor & "\Imagenes\Logo Induamerica.jpg"


            If opcFormato1.Checked Then
                'Distribución de datos en el formato1

                MySlide = oPres.Slides.Add(1, PowerPoint.PpSlideLayout.ppLayoutCustom)

                If System.IO.File.Exists(foto) Then MySlide.Shapes.AddPicture(foto, False, True, 260, 150, 200, 250)
                'If System.IO.File.Exists(logo) Then MySlide.Shapes.AddPicture(logo, False, True, 380, 200, 150, 100)
                With MySlide.Shapes.Item(1).TextFrame.TextRange
                    '.Text = Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "Hoy " & griOnomasticos.ActiveRow.Cells("Dia").Value & " de " & griOnomasticos.ActiveRow.Cells("Mes").Value & Chr(13) & "celebramos el onomástico de nuestro amigo" & Chr(13) & nombre & Chr(13) & "del área de " & area
                    .Text = Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & txtSaludo.Text
                    .Font.Name = "Lucida Calligraphy"
                    .Font.Size = 22
                    .Font.Color.RGB = RGB(128, 0, 0)
                    .Font.Shadow = Microsoft.Office.Core.MsoTriState.msoCTrue
                    .Font.Bold = Microsoft.Office.Core.MsoTriState.msoCTrue
                End With


                MySlide.Shapes.Item(1).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentCentered
                If chkTexto3D.Checked Then
                    MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect30
                End If

                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect25

                'Celeste - ultimo OK
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect30

            ElseIf opcFormato2.Checked Then

                'Distribución de datos en el formato2
                MySlide = oPres.Slides.Add(1, PowerPoint.PpSlideLayout.ppLayoutCustom)

                If System.IO.File.Exists(foto) Then MySlide.Shapes.AddPicture(foto, False, True, 400, 130, 215, 300)
                'If System.IO.File.Exists(logo) Then MySlide.Shapes.AddPicture(logo, False, True, 380, 200, 150, 100)
                With MySlide.Shapes.Item(1).TextFrame.TextRange
                    '.Text = "Hoy " & griOnomasticos.ActiveRow.Cells("Dia").Value & " de " & griOnomasticos.ActiveRow.Cells("Mes").Value & Chr(13) & "celebramos el onomástico de nuestro amigo" & Chr(13) & nombre & Chr(13) & "del área de " & area
                    .Text = txtSaludo.Text
                    .Font.Name = "Lucida Calligraphy"
                    .Font.Size = 20
                    .Font.Color.RGB = RGB(128, 0, 0)
                    .Font.Shadow = Microsoft.Office.Core.MsoTriState.msoCTrue
                    .Font.Bold = Microsoft.Office.Core.MsoTriState.msoCTrue
                End With

                MySlide.Shapes.Item(1).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentRight
                'Naranja con fondo transparente
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect27
                'Naranja 
                If chkTexto3D.Checked Then
                    MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect17
                End If
                ''Celete con sombra y relleno en 3D
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect25
                'Azul con sombra en 3D
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect30
                ''Azul
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect11
                ''Celeste
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect14
                ''Naranja
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect12
                ''Gris
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect13
                ''Bordes rojos fondo blanco
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect2
                ' ''Verde claro
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect24
                ''Borde Celeste con fondo blanco
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect9

            Else
                'Distribución de datos en el formato3

                MySlide = oPres.Slides.Add(1, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)

                If System.IO.File.Exists(foto) Then MySlide.Shapes.AddPicture(foto, False, True, 150, 130, 200, 250)
                If System.IO.File.Exists(logo) Then MySlide.Shapes.AddPicture(logo, False, True, 380, 200, 150, 100)
                With MySlide.Shapes.Item(1).TextFrame.TextRange
                    '.Text = "Hoy " & griOnomasticos.ActiveRow.Cells("Dia").Value & " de " & griOnomasticos.ActiveRow.Cells("Mes").Value & Chr(13) & "celebramos el onomástico de nuestro amigo" & Chr(13) & nombre & Chr(13) & "del área de " & area
                    .Text = txtSaludo.Text
                    .Font.Name = "Lucida Calligraphy"
                    .Font.Size = 24
                    .Font.Color.RGB = RGB(255, 255, 0)
                    .Font.Shadow = Microsoft.Office.Core.MsoTriState.msoCTrue
                    .Font.Bold = Microsoft.Office.Core.MsoTriState.msoCTrue
                End With

                MySlide.Shapes.Item(1).TextEffect.Alignment = Microsoft.Office.Core.MsoTextEffectAlignment.msoTextEffectAlignmentCentered
                If chkTexto3D.Checked Then
                    MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect19
                End If

                ''Borde blanco fondo azul
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect16

                ''Naranja
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect17

                ''Borde blanco fondo negro
                'MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect18
                ''Contorno blanco sin fondo
                ''MySlide.Shapes.Item(1).TextEffect.PresetTextEffect = Microsoft.Office.Core.MsoPresetTextEffect.msoTextEffect28

            End If

            GC.Collect()

            If Email Then

                '    oApp.Visible = True
                'Else
                Dim ruta As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & oPres.Name
                Dim ruta2 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & oPres.Name
                'Dim Documento As String
                If System.IO.File.Exists(ruta) Then
                    System.IO.File.Delete(ruta)
                End If
                If System.IO.File.Exists(ruta2) Then
                    System.IO.File.Delete(ruta2)
                End If
                oPres.SaveAs(ruta)
                oPres.Close()
                oApp.Quit()

                Dim listaMailProveedor As String = ""

                listaMailProveedor = "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com," & _
                "consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com,consultores.tecnologicos.2010@gmail.com"
                'listaMailProveedor = "consultores.tecnologicos.2010@gmail.com"
                Dim ms_CodEmpres As String = "ERP Transporte & Logistica"
                Dim correoTrabajador As String = "" 'Quien lo envia                    
                Dim formulario As frm_EnvioCorreo
                formulario = frm_EnvioCorreo
                formulario.txtAsunto.Value = "ONOMASTICO DE " & nombre
                Dim mensajePersonalizado As String = "Estimadas señores." & vbNewLine & vbNewLine & _
"Por el presente para saludar en este día a nuestro colaborador " & nombre & vbNewLine & _
", quien se encuentran cumpliendo años, darle un saludo cordial y así poder en este día" & vbNewLine & _
"desearles éxitos en su Vida Laboral, Familiar, Personal, que  la pase en" & vbNewLine & _
"Unión y fraternidad con sus seres queridos." & vbNewLine & vbNewLine & vbNewLine & _
"Son los deseos a nombre del área de Recursos Humanos ISL"
                'If goeUsuario.leEmail.Count > 0 Then correoTrabajador = goeUsuario.leEmail.Item(0).Nombre '"weezer@hotmail.com" 'Quiem lo envia 
                correoTrabajador = "consultores.tecnologicos.2010@gmail.com"
                If formulario.ObtenerDatos(ms_CodEmpres, ruta, correoTrabajador, True, False, True, True, _
                     listaMailProveedor, mensajePersonalizado) Then
                    formulario.ShowDialog()
                    'ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                End If
                formulario = Nothing

                oPres.Close()
                oPres = Nothing
                oApp.Quit()
                oApp = Nothing

            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Onomasticos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Dim archivoComplemetario = "\\" & olConfiguracion.IPServidor & "\Fotos\SinFoto.jpg"
        If Not System.IO.File.Exists(archivoComplemetario) Then Throw New Exception("El archivo SinFoto.jpg ha sido eliminado, comuníquese con el área de sistemas para recuperarlo")
    End Sub

    Private Sub frm_Onomasticos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Onomasticos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Onomasticos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Meses1.Seleccionar(Date.Now.Month)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            opcDelDia.Checked = True
            opcPorMes.Checked = False
            opcTodos.Checked = False
            TituloDelDia()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griOnomasticos_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles griOnomasticos.AfterRowActivate
        Try
            If griOnomasticos.ActiveRow.Index > -1 Then
                Dim olTrabajador As New l_Trabajador
                'PictureBox1.Image = olPersona.Foto(griOnomasticos.ActiveRow.Cells("Dni").Value)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnMostrarOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarOcultar.Click
        spcOnomastico.Panel2Collapsed = IIf(spcOnomastico.Panel2Collapsed, False, True)
    End Sub

    ''' <summary>
    ''' Evento para controlar la apertura del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuContextual1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items(0).Visible = False
        MenuContextual1.Items(1).Visible = False
        'Menú contextual se muestra exclusivamente al administrador y personal del área de recursos humanos

        If (PerfilIdAsignado("1CH000000001") Or gUsuarioSGI.oeArea.Nombre.Contains("PERSONAL") Or gUsuarioSGI.oeArea.Nombre.Contains("HUMANO")) AndAlso griOnomasticos.Selected.Rows.Count > 0 Then
            MenuContextual1.Items(0).Visible = True
            MenuContextual1.Items(1).Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Controla el evento click en el menú contextual, para crear un archivo de tipo PowerPoint para saludo por onomástico
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GenerarArchivoPowerPointDeSaludoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarArchivoPowerPointDeSaludoToolStripMenuItem.Click
        Try
            GenerarArchivoSaludo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub griOnomasticos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles griOnomasticos.Click
        If griOnomasticos.Rows.Count > 0 Then
            txtSaludo.Text = griOnomasticos.ActiveRow.Cells("NombreCompleto").Value & vbNewLine & "de " & griOnomasticos.ActiveRow.Cells("Area").Value
        Else
            txtSaludo.Text = ""
        End If
    End Sub

End Class
