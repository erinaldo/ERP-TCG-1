Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajo_Material
    Implements Il_OrdenTrabajo_Material

    Dim odOrdenTrabajoMaterial As New d_OrdenTrabajo_Material

    Public Function Eliminar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean Implements Il_OrdenTrabajo_Material.Eliminar
        Try
            Return odOrdenTrabajoMaterial.Eliminar(oeOrdenTrabajoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean Implements Il_OrdenTrabajo_Material.Guardar
        Try
            If Validar(oeOrdenTrabajoMaterial) Then
                Return odOrdenTrabajoMaterial.Guardar(oeOrdenTrabajoMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As System.Collections.Generic.List(Of e_OrdenTrabajo_Material) Implements Il_OrdenTrabajo_Material.Listar
        Try
            Return odOrdenTrabajoMaterial.Listar(oeOrdenTrabajoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As System.Data.DataSet Implements Il_OrdenTrabajo_Material.ListarDataSet
        Try
            Return odOrdenTrabajoMaterial.Listar(ls_IdOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As e_OrdenTrabajo_Material Implements Il_OrdenTrabajo_Material.Obtener
        Try
            Return odOrdenTrabajoMaterial.Obtener(oeOrdenTrabajoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajoMaterial As e_OrdenTrabajo_Material) As Boolean Implements Il_OrdenTrabajo_Material.Validar
        Try
            With oeOrdenTrabajoMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOTM As e_ReporteOTMaterial) As System.Collections.Generic.List(Of e_ReporteOTMaterial) Implements Il_OrdenTrabajo_Material.ListarReporte
        Try
            Return odOrdenTrabajoMaterial.ListarReporte(oeReporteOTM)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
