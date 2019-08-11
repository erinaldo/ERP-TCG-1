Public Class c_Ficha

    Private WithEvents mForm As Form ' variables para interceptar los eventos ( para el form y para el TabStrip )
    Private WithEvents mTabControl As TabControl
    Private mClsMdi As Object  ' variable local que apunta al MDI

    Public Sub CargarForm(ByVal frm As Form, ByVal clsMDI As c_Mdi, Optional ByVal Imagen As String = "")
        Try
            If frm.IsMdiChild = False Then Throw New Exception("El Formulario: " & frm.Name & " no es Formulario Hijo")

            mClsMdi = clsMDI
            mForm = frm
            mTabControl = clsMDI.mTabControl

            With mTabControl
                If Imagen = "" Then
                    .TabPages.Add(mForm.Name, mForm.Text)
                Else
                    .TabPages.Add(mForm.Name, mForm.Text, Imagen)
                End If
            End With
            mForm.Show()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    ' cuando se activa el form, se activa la pestaña que le corresponde
    Private Sub mForm_Activate()
        Call ActivarFicha()
    End Sub
    ' descarga el form
    Private Sub mForm_Unload(ByVal Cancel As Integer)
        Call DescargarFormulario()
    End Sub


    Sub ActivarFicha()

        'mClsMdi.Flag = True ' chapuza

        '' selecciona la ficha
        'mTabStrip.tabs(mForm.Name).Selected = True
        ''If Err.Number = 35601 Then Resume Next: Err.Clear

        'mClsMdi.Flag = False 'reestablece la chapuza

    End Sub


    Sub DescargarFormulario()

        'Dim i As Integer
        '' recorre las fichas, y descarga la coincide con el formulario
        'For i = 1 To mTabStrip.Tabs.Count
        '    If mTabStrip.Tabs(i).Key = mForm.Name Then
        '        mTabStrip.Tabs.Remove(i)
        '        Exit For
        '    End If
        'Next
        '' descarga y elimina la referencia del formulario
        'Unload(mForm)
        'mForm = Nothing

    End Sub


End Class
