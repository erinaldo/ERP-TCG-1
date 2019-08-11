Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajoMaterial
    Implements Il_OrdenTrabajoMaterial


    Dim odOrdenTrabajoMaterial As New d_OrdenTrabajo_Material

    Public Function Eliminar(ByVal oeOrdenTrabajoMaterial As EntidadesWCF.e_OrdenTrabajo_Material) As Boolean Implements Il_OrdenTrabajoMaterial.Eliminar
        Try
            Return odOrdenTrabajoMaterial.Eliminar(oeOrdenTrabajoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajoMaterial As EntidadesWCF.e_OrdenTrabajo_Material) As Boolean Implements Il_OrdenTrabajoMaterial.Guardar
        Try
            If Validar(oeOrdenTrabajoMaterial) Then
                Return odOrdenTrabajoMaterial.Guardar(oeOrdenTrabajoMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajoMaterial As EntidadesWCF.e_OrdenTrabajo_Material) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenTrabajo_Material) Implements Il_OrdenTrabajoMaterial.Listar
        Try
            Return odOrdenTrabajoMaterial.Listar(oeOrdenTrabajoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As System.Data.DataSet Implements Il_OrdenTrabajoMaterial.ListarDataSet
        Try
            Return odOrdenTrabajoMaterial.Listar(ls_IdOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajoMaterial As EntidadesWCF.e_OrdenTrabajo_Material) As EntidadesWCF.e_OrdenTrabajo_Material Implements Il_OrdenTrabajoMaterial.Obtener
        Try
            Return odOrdenTrabajoMaterial.Obtener(oeOrdenTrabajoMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajoMaterial As EntidadesWCF.e_OrdenTrabajo_Material) As Boolean Implements Il_OrdenTrabajoMaterial.Validar
        Try
            With oeOrdenTrabajoMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarReporte(ByVal oeReporteOTM As EntidadesWCF.e_ReporteOTMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteOTMaterial) Implements Il_OrdenTrabajoMaterial.ListarReporte
        Try
            Return odOrdenTrabajoMaterial.ListarReporte(oeReporteOTM)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
