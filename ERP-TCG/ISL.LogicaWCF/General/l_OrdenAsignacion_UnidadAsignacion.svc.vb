Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenAsignacion_UnidadAsignacion
    Implements Il_OrdenAsignacion_UnidadAsignacion


    Dim odOrdenAsignacion_UnidadAsignacion As New d_OrdenAsignacion_UnidadAsignacion

    Public Function Eliminar(ByVal oeOrdenAsignacion_UnidadAsignacion As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) As Boolean Implements Il_OrdenAsignacion_UnidadAsignacion.Eliminar
        Try
            Return odOrdenAsignacion_UnidadAsignacion.Eliminar(oeOrdenAsignacion_UnidadAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAsignacion_UnidadAsignacion As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) As Boolean Implements Il_OrdenAsignacion_UnidadAsignacion.Guardar
        Try
            If Validar(oeOrdenAsignacion_UnidadAsignacion) Then
                Return odOrdenAsignacion_UnidadAsignacion.Guardar(oeOrdenAsignacion_UnidadAsignacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAsignacion_UnidadAsignacion As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) Implements Il_OrdenAsignacion_UnidadAsignacion.Listar
        Try
            Return odOrdenAsignacion_UnidadAsignacion.Listar(oeOrdenAsignacion_UnidadAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAsignacion_UnidadAsignacion As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion Implements Il_OrdenAsignacion_UnidadAsignacion.Obtener
        Try
            Return odOrdenAsignacion_UnidadAsignacion.Obtener(oeOrdenAsignacion_UnidadAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenAsignacion_UnidadAsignacion As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) As Boolean Implements Il_OrdenAsignacion_UnidadAsignacion.Validar
        Try
            With oeOrdenAsignacion_UnidadAsignacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodo(ByVal oeOrdenAsignacion_UnidadAsignacion As EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenAsignacion_UnidadAsignacion) Implements Il_OrdenAsignacion_UnidadAsignacion.ListarTodo
        Try
            Return odOrdenAsignacion_UnidadAsignacion.ListarTodo(oeOrdenAsignacion_UnidadAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
