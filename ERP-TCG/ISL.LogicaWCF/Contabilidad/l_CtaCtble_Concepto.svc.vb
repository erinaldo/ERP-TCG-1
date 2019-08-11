Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CtaCtble_Concepto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CtaCtble_Concepto.svc o l_CtaCtble_Concepto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CtaCtble_Concepto
    Implements Il_CtaCtble_Concepto

    Dim odCtaCtble_Concepto As New d_CtaCtble_Concepto

    Public Function Obtener(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As e_CtaCtble_Concepto Implements Il_CtaCtble_Concepto.Obtener
        Try
            Return odCtaCtble_Concepto.Obtener(oeCtaCtble_Concepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCtble_Concepto As e_CtaCtble_Concepto) As List(Of e_CtaCtble_Concepto) Implements Il_CtaCtble_Concepto.Listar
        Try
            Return odCtaCtble_Concepto.Listar(oeCtaCtble_Concepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
