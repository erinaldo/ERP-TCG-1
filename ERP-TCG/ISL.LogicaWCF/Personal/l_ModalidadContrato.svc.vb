' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ModalidadContrato" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ModalidadContrato.svc o l_ModalidadContrato.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

Public Class l_ModalidadContrato
    Implements Il_ModalidadContrato

    Dim odModalidadContrato As New d_ModalidadContrato

    Public Function Listar(ByVal oeModalidadContrato As e_ModalidadContrato) As List(Of e_ModalidadContrato) Implements Il_ModalidadContrato.Listar
        Try
            Return odModalidadContrato.Listar(oeModalidadContrato)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
