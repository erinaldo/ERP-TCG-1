' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_TipoIncidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_TipoIncidencia.svc o l_TipoIncidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_TipoIncidencia
    Implements Il_TipoIncidencia

    Public Sub DoWork() Implements Il_TipoIncidencia.DoWork
    End Sub

    Dim odTipoIncidencia As New d_TipoIncidencia

    Public Function Obtener(ByVal oeTipoIncidencia As e_TipoIncidencia) As e_TipoIncidencia Implements Il_TipoIncidencia.Obtener
        Try
            Return odTipoIncidencia.Obtener(oeTipoIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoIncidencia As e_TipoIncidencia) As List(Of e_TipoIncidencia) Implements Il_TipoIncidencia.Listar
        Try
            Return odTipoIncidencia.Listar(oeTipoIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean Implements Il_TipoIncidencia.Validar
        Try
            With oeTipoIncidencia
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean Implements Il_TipoIncidencia.Guardar
        Try
            If Validar(oeTipoIncidencia) Then
                Return odTipoIncidencia.Guardar(oeTipoIncidencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoIncidencia As e_TipoIncidencia) As Boolean Implements Il_TipoIncidencia.Eliminar
        Try
            Return odTipoIncidencia.Eliminar(oeTipoIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
