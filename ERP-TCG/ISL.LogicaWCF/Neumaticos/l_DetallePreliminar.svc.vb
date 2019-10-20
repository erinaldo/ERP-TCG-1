Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetallePreliminar

    Implements Il_DetallePreliminar
    Dim odDetallePreliminar As New d_DetallePreliminar
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean Implements Il_DetallePreliminar.Eliminar
        Try
            Return odDetallePreliminar.Eliminar(oeDetallePreliminar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean Implements Il_DetallePreliminar.Guardar
        Try
            If Validar(oeDetallePreliminar) Then
                Return odDetallePreliminar.Guardar(oeDetallePreliminar)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetallePreliminar As e_DetallePreliminar) As System.Collections.Generic.List(Of e_DetallePreliminar) Implements Il_DetallePreliminar.Listar
        Try
            Return odDetallePreliminar.Listar(oeDetallePreliminar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetallePreliminar As e_DetallePreliminar) As e_DetallePreliminar Implements Il_DetallePreliminar.Obtener
        Try
            Return odDetallePreliminar.Obtener(oeDetallePreliminar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetallePreliminar As e_DetallePreliminar) As Boolean Implements Il_DetallePreliminar.Validar
        Try
            With oeDetallePreliminar
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
