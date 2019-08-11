Public Class c_Mdi
    ' copia local con evento para hacer referencia al MDI
    Private WithEvents mFormMdi As Form 'MDIForm
    ' copia local con evento  para hacer referencia al TabStrip
    Public WithEvents mTabControl As TabControl

    Public Flag As Boolean

    ' inicia
    Sub Iniciar(ByVal ElMdi As Form, ByVal ElTabControl As TabControl)

        mFormMdi = ElMdi
        mTabControl = ElTabControl
        ' Acá se pueden poner propiedades por default
        With mTabControl
            .TabPages.Clear()
            .Multiline = False
        End With
    End Sub

    ' cada ves que se hace clic en el TabStrip se dispara este evento
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub mTabStrip_Click()
        If Not Flag Then
            ' recorre todos los formularios del programa
            'Dim miColeccion As Form.ControlCollection
            'For Each o_frm As Form In miColeccion
            '    ' si el form  coincide con la clave de la ficha, entonces lo activa
            '    If (o_frm.Name = mTabControl.SelectedTab.Name) Then
            '        o_frm.Activate()
            '        Exit For
            '    End If
            'Next
        End If
    End Sub

End Class
