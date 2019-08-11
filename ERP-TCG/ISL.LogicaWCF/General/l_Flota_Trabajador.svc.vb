Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

<DataContract(), Serializable()>
Public Class l_Flota_Trabajador
    Implements Il_Flota_Trabajador
    Private odFlota_Trabajador As New d_Flota_Trabajador

    Public Function Obtener(oeFlota_Trabajador As e_Flota_Trabajador) As e_Flota_Trabajador Implements Il_Flota_Trabajador.Obtener
        Try
            Return odFlota_Trabajador.Obtener(oeFlota_Trabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeFlota_Trabajador As e_Flota_Trabajador) As List(Of e_Flota_Trabajador) Implements Il_Flota_Trabajador.Listar
        Try
            Return odFlota_Trabajador.Listar(oeFlota_Trabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeFlota_Trabajador As e_Flota_Trabajador) As Boolean Implements Il_Flota_Trabajador.Guardar
        Try
            Return odFlota_Trabajador.Guardar(oeFlota_Trabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeFlota_Trabajador As e_Flota_Trabajador) As Boolean Implements Il_Flota_Trabajador.Eliminar
        Try
            Return odFlota_Trabajador.Eliminar(oeFlota_Trabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class