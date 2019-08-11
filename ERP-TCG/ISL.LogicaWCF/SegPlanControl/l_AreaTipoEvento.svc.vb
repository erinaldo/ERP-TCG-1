' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_AreaTipoEvento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_AreaTipoEvento.svc o l_AreaTipoEvento.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_AreaTipoEvento
    Implements Il_AreaTipoEvento

    Dim odAreaTipoEvento As New d_AreaTipoEvento

    Public Function Obtener(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As e_AreaTipoEvento Implements Il_AreaTipoEvento.Obtener
        Try
            Return odAreaTipoEvento.Obtener(oeAreaTipoEvento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As List(Of e_AreaTipoEvento) Implements Il_AreaTipoEvento.Listar
        Try
            Return odAreaTipoEvento.Listar(oeAreaTipoEvento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean Implements Il_AreaTipoEvento.Validar
        Try
            With oeAreaTipoEvento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    'Public Function Guardar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean Implements Il_AreaTipoEvento.Guardar
    '    Try
    '        If Validar(oeAreaTipoEvento) Then
    '            Return odAreaTipoEvento.Guardar(oeAreaTipoEvento)
    '        End If
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function Eliminar(ByVal oeAreaTipoEvento As e_AreaTipoEvento) As Boolean Implements Il_AreaTipoEvento.Eliminar
        Try
            Return odAreaTipoEvento.Eliminar(oeAreaTipoEvento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_AreaTipoEvento.DoWork
    End Sub

End Class
