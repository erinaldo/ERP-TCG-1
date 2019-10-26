Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Plame" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Plame.svc o l_Plame.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_Plame
    Implements Il_Plame

    Public Sub DoWork() Implements Il_Plame.DoWork
    End Sub

    Dim odPlame As New d_Plame

    Public Function Listar(ByVal oePlame As e_PlameRem) As List(Of e_PlameRem) Implements Il_Plame.Listar
        Try
            Return odPlame.Listar(oePlame)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
