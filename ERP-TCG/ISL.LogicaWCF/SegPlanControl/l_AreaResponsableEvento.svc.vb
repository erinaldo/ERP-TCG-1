'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_AreaResponsableEvento
    Implements Il_AreaResponsableEvento

    Dim odAreaResponsableEvento As New d_AreaResponsableEvento

    Public Function Obtener(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As e_AreaResponsableEvento Implements Il_AreaResponsableEvento.Obtener
        Try
            Return odAreaResponsableEvento.Obtener(oeAreaResponsableEvento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As List(Of e_AreaResponsableEvento) Implements Il_AreaResponsableEvento.Listar
        Try
            Return odAreaResponsableEvento.Listar(oeAreaResponsableEvento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean Implements Il_AreaResponsableEvento.Validar
        Try
            With oeAreaResponsableEvento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean Implements Il_AreaResponsableEvento.Guardar
        Try
            If Validar(oeAreaResponsableEvento) Then
                Return odAreaResponsableEvento.Guardar(oeAreaResponsableEvento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarGlosa(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean Implements Il_AreaResponsableEvento.GuardarGlosa
        Try
            If Validar(oeAreaResponsableEvento) Then
                Return odAreaResponsableEvento.GuardarGlosa(oeAreaResponsableEvento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarEstado(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean Implements Il_AreaResponsableEvento.GuardarEstado
        Try
            If Validar(oeAreaResponsableEvento) Then
                Return odAreaResponsableEvento.GuardarEstado(oeAreaResponsableEvento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAreaResponsableEvento As e_AreaResponsableEvento) As Boolean Implements Il_AreaResponsableEvento.Eliminar
        Try
            Return odAreaResponsableEvento.Eliminar(oeAreaResponsableEvento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_AreaResponsableEvento.DoWork
    End Sub

End Class
