Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleMaterialAsignacion
    Implements Il_DetalleMaterialAsignacion

    Dim odDetalleMaterialAsignacion As New d_DetalleMaterialAsignacion

    Public Function Eliminar(ByVal oeDetalleMaterialAsignacion As EntidadesWCF.e_DetalleMaterialAsignacion) As Boolean Implements Il_DetalleMaterialAsignacion.Eliminar
        Try
            Return odDetalleMaterialAsignacion.Eliminar(oeDetalleMaterialAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleMaterialAsignacion As EntidadesWCF.e_DetalleMaterialAsignacion) As Boolean Implements Il_DetalleMaterialAsignacion.Guardar
        Try
            If Validar(oeDetalleMaterialAsignacion) Then
                Return odDetalleMaterialAsignacion.Guardar(oeDetalleMaterialAsignacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleMaterialAsignacion As EntidadesWCF.e_DetalleMaterialAsignacion) As System.Collections.Generic.List(Of EntidadesWCF.e_DetalleMaterialAsignacion) Implements Il_DetalleMaterialAsignacion.Listar
        Try
            Return odDetalleMaterialAsignacion.Listar(oeDetalleMaterialAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeDetalleMaterial As EntidadesWCF.e_DetalleMaterialAsignacion) As System.Data.DataSet Implements Il_DetalleMaterialAsignacion.ListarDetalle
        Try
            Return odDetalleMaterialAsignacion.ListarDetalleMaterial(oeDetalleMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleMaterialAsignacion As EntidadesWCF.e_DetalleMaterialAsignacion) As EntidadesWCF.e_DetalleMaterialAsignacion Implements Il_DetalleMaterialAsignacion.Obtener
        Try
            Return odDetalleMaterialAsignacion.Obtener(oeDetalleMaterialAsignacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleMaterialAsignacion As EntidadesWCF.e_DetalleMaterialAsignacion) As Boolean Implements Il_DetalleMaterialAsignacion.Validar
        Try
            With oeDetalleMaterialAsignacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
