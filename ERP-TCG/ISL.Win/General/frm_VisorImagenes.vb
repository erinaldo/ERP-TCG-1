'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class frm_VisorImagenes

    Private _idCarpeta As String

    Dim imagenNumero As Integer = 0
    Dim cuantasImagenes As Integer = 0
    Private listaArchivos As String()

    Private Sub frmVisorImagenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim t As New e_ListaTiposOperacionCabecera

        t.EstablecerOperacionActual(0)

        MessageBox.Show(t.ObtenerOperacionActual.Nombre)

        ActualizaListaImagenes()

    End Sub

    Private Sub ActualizaListaImagenes()
        Try

            If Directorio(IdCarpeta).GetFiles.Count > 0 Then
                Dim i As Integer = 0
                For Each imag In Directorio(IdCarpeta).GetFiles("*.png")
                    Dim archivo As String = imag.FullName
                    Dim imagen As System.Drawing.Image = Image.FromFile(archivo)
                    ListaImagenes.Images.Add(imagen)

                    ListaImagenes.Images.SetKeyName(i, archivo)
                    i = i + 1
                Next

                cuantasImagenes = ListaImagenes.Images.Count

                If cuantasImagenes > 0 Then
                    MostrarImagen(imagenNumero)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MostrarImagen(ByVal numero As Integer)
        Try
            If numero > cuantasImagenes Then Throw New Exception("Sólo hay " & cuantasImagenes.ToString & " imágenes disponibles")
            imagenNumero = numero
            PictureBox1.Image = ListaImagenes.Images.Item(imagenNumero)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        EliminarImagen(ListaImagenes.Images.Keys(imagenNumero).ToString())
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub chrAjustar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chrAjustar.CheckedChanged
        If chrAjustar.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    ''' <summary>
    ''' Carga la información de una carpeta específica, en caso no exista la crea
    ''' </summary>
    ''' <param name="idCarpeta">Id de identificación de la carpeta de imágenes</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Directorio(ByVal idCarpeta As String) As System.IO.DirectoryInfo
        Dim carpeta As String = RutaBase & idCarpeta
        If Not My.Computer.FileSystem.DirectoryExists(carpeta) Then
            My.Computer.FileSystem.CreateDirectory(carpeta)
        End If
        Return My.Computer.FileSystem.GetDirectoryInfo(carpeta)
    End Function

    ''' <summary>
    ''' Eliminar una imagen de la carpeta actual
    ''' </summary>
    ''' <param name="nombreImagen"></param>
    ''' <remarks></remarks>
    Private Sub EliminarImagen(ByVal nombreImagen As String)
        Try

            If Not My.Computer.FileSystem.FileExists(nombreImagen) Then Throw New Exception("Imagen no existe")
            My.Computer.FileSystem.DeleteFile(nombreImagen, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Permite almacenar el tipo de operacion disponible
    ''' </summary>
    ''' <remarks></remarks>
    Private _tipoOperacion As String
    Public Property TipoOperacion() As String
        Get
            Return _tipoOperacion
        End Get
        Set(ByVal value As String)
            _tipoOperacion = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdCarpeta() As String
        Get
            Return _idCarpeta
        End Get
        Set(ByVal value As String)
            _idCarpeta = value
        End Set
    End Property

    Private _rutaBase As String
    Public Property RutaBase() As String
        Get
            Return _rutaBase
        End Get
        Set(ByVal value As String)
            _rutaBase = value
        End Set
    End Property

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        imagenNumero = 0
        MostrarImagen(imagenNumero)
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If imagenNumero > 0 Then
            imagenNumero = imagenNumero - 1
            MostrarImagen(imagenNumero)
        Else
            MessageBox.Show("Esta es la primera imagen")
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If imagenNumero < cuantasImagenes - 1 Then
            imagenNumero = imagenNumero + 1
            MostrarImagen(imagenNumero)
        Else
            MessageBox.Show("Esta es la última imagen")
        End If
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        imagenNumero = cuantasImagenes
        MostrarImagen(imagenNumero)
    End Sub

End Class