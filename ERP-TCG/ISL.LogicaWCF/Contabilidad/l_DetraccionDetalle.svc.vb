Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DetraccionDetalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DetraccionDetalle.svc o l_DetraccionDetalle.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract(), Serializable()> _
Public Class l_DetraccionDetalle
    Implements Il_DetraccionDetalle

    Private odDetraccionDetalle As New d_DetraccionDetalle

    Public Function Obtener(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As e_DetraccionDetalle Implements Il_DetraccionDetalle.Obtener
        Try
            Return odDetraccionDetalle.Obtener(oeDetraccionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As List(Of e_DetraccionDetalle) Implements Il_DetraccionDetalle.Listar
        Try
            Return odDetraccionDetalle.Listar(oeDetraccionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean Implements Il_DetraccionDetalle.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeDetraccionDetalle) Then
                bol_guardado = odDetraccionDetalle.Guardar(oeDetraccionDetalle)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean Implements Il_DetraccionDetalle.Eliminar
        Try
            Return odDetraccionDetalle.Eliminar(oeDetraccionDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeDetraccionDetalle As e_DetraccionDetalle) As Boolean
        Try
            With oeDetraccionDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
