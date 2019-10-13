'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports System.Runtime.InteropServices.Marshal
Imports System.IO

Public Class frm_Scanner

    Declare Function DeleteObject Lib "gdi32.dll" (ByVal hObject As IntPtr) As Boolean
    Dim hdib As System.IntPtr
    Public RutaImagen As String = String.Empty

    Private Sub RefreshSourceList()
        Dim n, i As Integer
        Dim S As String, Def As String
        Def = EZTwain.DefaultSourceName
        SourceList.Items.Clear()
        n = EZTwain.GetSourceList()
        Do
            S = EZTwain.NextSourceName()
            If S.Length = 0 Then Exit Do
            i = SourceList.Items.Add(S)
            If S = Def Then
                SourceList.SetSelected(i, True)
            End If
        Loop
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hdib = System.IntPtr.Zero
        RefreshSourceList()
        'VersionText.Text = "EZTwain " + (EZTwain.EasyVersion() / 100).ToString("N") + " " + EZTwain.BuildName()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If EZTwain.SelectImageSource(Me.Handle()) <> 0 Then
            RefreshSourceList()
        End If
    End Sub

    Private Sub RefreshPic()
        If Not hdib.Equals(IntPtr.Zero) Then
            Dim hdibView As IntPtr
            hdibView = EZTwain.DIB_Thumbnail(hdib, Pic.Width, Pic.Height)
            Pic.Image = EZTwain.DibToImage(hdibView)
            EZTwain.DIB_Free(hdibView)
        End If
    End Sub
    Private Sub SetPic(ByVal hdibNew As IntPtr)
        If Not hdib.Equals(hdibNew) Then
            ' Current hdib is being replaced
            ' If it is not null, free it
            If Not hdib.Equals(IntPtr.Zero) Then
                EZTwain.DIB_Free(hdib)
                hdib = IntPtr.Zero
            End If
            hdib = hdibNew
        End If
        If Not (Pic.Image Is Nothing) Then
            Pic.Image.Dispose()
        End If
        RefreshPic()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim S As String
        If SourceList.SelectedIndex < 0 Then
            MsgBox("No Source selected.")
            Return
        End If
        S = SourceList.Items.Item(SourceList.SelectedIndex)
        EZTwain.SetHideUI(HideUI.Checked)
        If EZTwain.OpenSource(S) Then
            hdib = EZTwain.Acquire(Me.Handle())
            SetPic(hdib)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim n As Integer = EZTwain.SelfTest(0)
        Cursor.Current = System.Windows.Forms.Cursors.Default
        If n = 0 Then
            MsgBox("EZTwain.SelfTest returned " & n & " (success)")
        Else
            MsgBox("EZTwain.SelfTest returned " & n & " (failure)")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EZTwain.Testing123("This dialog should display n=-999, h=ffffffff (hex), d=8.125, and u=65536", _
-999, New System.IntPtr(-1), 8.125, 65536)
    End Sub

    Private Sub StressConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim hbm As IntPtr
        Dim hdib As IntPtr
        hdib = EZTwain.DIB_Allocate(24, 2000, 2000)
        hbm = EZTwain.DIB_ToDibSection(hdib)    ' destroys hdib
        hdib = EZTwain.DIB_FromBitmap(hbm, Nothing) ' does NOT delete hbm
        DeleteObject(hbm)
        EZTwain.DIB_Free(hdib)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        If Not hdib.Equals(IntPtr.Zero) Then
            EZTwain.DIB_Free(hdib)
        End If
    End Sub

    Private Sub RotLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotLeft.Click
        SetPic(EZTwain.DIB_Rotate90(hdib, -1))
    End Sub

    Private Sub RotRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotRight.Click
        SetPic(EZTwain.DIB_Rotate90(hdib, 1))
    End Sub

    Private Sub SaveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToFile.Click
        If Not hdib.Equals(IntPtr.Zero) Then
            EZTwain.WriteToFilename(hdib, "")
            If EZTwain.LastErrorCode() <> 0 Then
                EZTwain.ReportLastError("Saving file")
            End If
        End If
    End Sub

    Private Sub LoadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadFile.Click
        SetPic(EZTwain.LoadFromFilename(""))
        If EZTwain.LastErrorCode() <> 0 Then
            EZTwain.ReportLastError("Saving file")
        End If
    End Sub

    Private Sub Pic_ClientSizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic.ClientSizeChanged
        RefreshPic()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rutaDirectorio As String = "C:\ImagenSGI" 'traer ruta desde base de datos
        Dim rutaImagenAux As String = rutaDirectorio & "\" & Date.Now.Ticks.ToString & ".jpg"


        If Not System.IO.Directory.Exists(rutaDirectorio) Then
            System.IO.Directory.CreateDirectory(rutaDirectorio)
        End If

        While System.IO.File.Exists(rutaImagenAux)
            rutaImagenAux = rutaDirectorio & "\" & Date.Now.Ticks.ToString & ".jpg"
        End While

        If Not hdib.Equals(IntPtr.Zero) Then
            EZTwain.WriteToFilename(hdib, rutaImagenAux)
            If EZTwain.LastErrorCode() <> 0 Then
                Throw New Exception("Error al copiar imagen.")
            End If
        End If

        RutaImagen = rutaImagenAux
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class