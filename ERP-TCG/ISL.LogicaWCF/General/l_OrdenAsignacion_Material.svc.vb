Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenAsignacion_Material
    Implements Il_OrdenAsignacion_Material

    Dim odOrdenAsignacion_Material As New d_OrdenAsignacion_Material

    Public Function Eliminar(ByVal oeOrdenAsignacion_Material As EntidadesWCF.e_OrdenAsignacion_Material) As Boolean Implements Il_OrdenAsignacion_Material.Eliminar
        Try
            Return odOrdenAsignacion_Material.Eliminar(oeOrdenAsignacion_Material)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAsignacion_Material As EntidadesWCF.e_OrdenAsignacion_Material) As Boolean Implements Il_OrdenAsignacion_Material.Guardar
        Try
            If Validar(oeOrdenAsignacion_Material) Then
                Return odOrdenAsignacion_Material.Guardar(oeOrdenAsignacion_Material)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAsignacion_Material As EntidadesWCF.e_OrdenAsignacion_Material) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenAsignacion_Material) Implements Il_OrdenAsignacion_Material.Listar
        Try
            Return odOrdenAsignacion_Material.Listar(oeOrdenAsignacion_Material)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarUnidadAsignadaMaterial(ByVal oeUnidadAsignadaMaterial As EntidadesWCF.e_OrdenAsignacion_Material) As System.Data.DataSet Implements Il_OrdenAsignacion_Material.ListarUnidadAsignadaMaterial
        Try
            Return odOrdenAsignacion_Material.ListarUnidAsig(oeUnidadAsignadaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAsignacion_Material As EntidadesWCF.e_OrdenAsignacion_Material) As EntidadesWCF.e_OrdenAsignacion_Material Implements Il_OrdenAsignacion_Material.Obtener
        Try
            Return odOrdenAsignacion_Material.Obtener(oeOrdenAsignacion_Material)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenAsignacion_Material As EntidadesWCF.e_OrdenAsignacion_Material) As Boolean Implements Il_OrdenAsignacion_Material.Validar
        Try
            With oeOrdenAsignacion_Material
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
