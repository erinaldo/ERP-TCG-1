
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_ActividadRestringida
    Implements Il_ActividadRestringida

    Dim odActividadRestringida As New d_ActividadRestringida

    Public Function Eliminar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean Implements Il_ActividadRestringida.Eliminar
        Try
            Return odActividadRestringida.Eliminar(oeActividadRestringida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean Implements Il_ActividadRestringida.Guardar
        Try
            If Validar(oeActividadRestringida) Then
                Return odActividadRestringida.Guardar(oeActividadRestringida)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeActividadRestringida As e_ActividadRestringida) As System.Collections.Generic.List(Of e_ActividadRestringida) Implements Il_ActividadRestringida.Listar
        Try
            Return odActividadRestringida.Listar(oeActividadRestringida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividadRestringida As e_ActividadRestringida) As e_ActividadRestringida Implements Il_ActividadRestringida.Obtener
        Try
            Return odActividadRestringida.Obtener(oeActividadRestringida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean Implements Il_ActividadRestringida.Validar
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
