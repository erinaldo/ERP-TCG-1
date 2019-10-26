Imports ERP.AccesoDatos
Imports System.Runtime.Serialization
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CotizacionDetalleSer" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CotizacionDetalleSer.svc o l_CotizacionDetalleSer.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CotizacionDetalleSer
    Implements Il_CotizacionDetalleSer


    Dim odCotizacionDetalleSer As New d_CotizacionDetalleSer

    Public Function Obtener(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As e_CotizacionDetalleSer Implements Il_CotizacionDetalleSer.Obtener
        Try
            Return odCotizacionDetalleSer.Obtener(oeCotizacionDetalleSer)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As List(Of e_CotizacionDetalleSer) Implements Il_CotizacionDetalleSer.Listar
        Try
            Return odCotizacionDetalleSer.Listar(oeCotizacionDetalleSer)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As Boolean Implements Il_CotizacionDetalleSer.Validar
        Try
            With oeCotizacionDetalleSer
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As Boolean Implements Il_CotizacionDetalleSer.Guardar
        Try
            If Validar(oeCotizacionDetalleSer) Then
                Return odCotizacionDetalleSer.Guardar(oeCotizacionDetalleSer)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCotizacionDetalleSer As e_CotizacionDetalleSer) As Boolean Implements Il_CotizacionDetalleSer.Eliminar
        Try
            Return odCotizacionDetalleSer.Eliminar(oeCotizacionDetalleSer)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
