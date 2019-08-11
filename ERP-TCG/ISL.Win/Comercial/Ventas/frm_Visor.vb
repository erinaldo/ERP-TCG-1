Imports System.Windows.Forms

Public Class frm_Visor

    Public Sub EstablecerImagen(ByVal imagen As Image)
        Try
            upbImagen.Image = imagen
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
