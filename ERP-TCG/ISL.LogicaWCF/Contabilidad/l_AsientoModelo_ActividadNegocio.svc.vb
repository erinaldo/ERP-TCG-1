Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AsientoModelo_ActividadNegocio
    Implements Il_AsientoModelo_ActividadNegocio

    Private odAsiModActNeg As New d_AsientoModelo_ActividadNegocio
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeAsientoModelo As e_AsientoModelo_ActividadNegocio) As Boolean Implements Il_AsientoModelo_ActividadNegocio.Eliminar
        Try
            Return odAsiModActNeg.Eliminar(oeAsientoModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeAsientoModelo As e_AsientoModelo_ActividadNegocio) As Boolean Implements Il_AsientoModelo_ActividadNegocio.Guardar
        Try
            If Validar(oeAsientoModelo) Then
                Return odAsiModActNeg.Guardar(oeAsientoModelo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeAsientoModelo As e_AsientoModelo_ActividadNegocio) As List(Of e_AsientoModelo_ActividadNegocio) Implements Il_AsientoModelo_ActividadNegocio.Listar
        Try
            Return odAsiModActNeg.Listar(oeAsientoModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeAsientoModelo As e_AsientoModelo_ActividadNegocio) As e_AsientoModelo_ActividadNegocio Implements Il_AsientoModelo_ActividadNegocio.Obtener
        Try
            Return odAsiModActNeg.Obtener(oeAsientoModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeAsientoModelo As e_AsientoModelo_ActividadNegocio) As Boolean Implements Il_AsientoModelo_ActividadNegocio.Validar

    End Function
End Class
