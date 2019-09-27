'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

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
