Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MantenimientoMaterial
    Implements Il_MantenimientoMaterial

    Dim odMantenimientoMaterial As New d_MantenimientoMaterial

    Public Function Eliminar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean Implements Il_MantenimientoMaterial.Eliminar
        Try
            Return odMantenimientoMaterial.Eliminar(oeMantenimientoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean Implements Il_MantenimientoMaterial.Guardar
        Try
            If Validar(oeMantenimientoMaterial) Then
                Return odMantenimientoMaterial.Guardar(oeMantenimientoMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As System.Collections.Generic.List(Of e_MantenimientoMaterial) Implements Il_MantenimientoMaterial.Listar
        Try
            Return odMantenimientoMaterial.Listar(oeMantenimientoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As e_MantenimientoMaterial Implements Il_MantenimientoMaterial.Obtener
        Try
            Return odMantenimientoMaterial.Obtener(oeMantenimientoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean Implements Il_MantenimientoMaterial.Validar
        Try
            With oeMantenimientoMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
