Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ProcesoServicio
    Implements Il_ProcesoServicio

    Dim odProcesoServicio As New d_ProcesoServicio
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeProcesoServicio As EntidadesWCF.e_ProcesoServicio) As Boolean Implements Il_ProcesoServicio.Eliminar
        Try
            Return odProcesoServicio.Eliminar(oeProcesoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoServicio As EntidadesWCF.e_ProcesoServicio) As Boolean Implements Il_ProcesoServicio.Guardar
        Try
            If Validar(oeProcesoServicio) Then
                Return odProcesoServicio.Guardar(oeProcesoServicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoServicio As EntidadesWCF.e_ProcesoServicio) As System.Collections.Generic.List(Of EntidadesWCF.e_ProcesoServicio) Implements Il_ProcesoServicio.Listar
        Try
            Return odProcesoServicio.Listar(oeProcesoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoServicio As EntidadesWCF.e_ProcesoServicio) As EntidadesWCF.e_ProcesoServicio Implements Il_ProcesoServicio.Obtener
        Try
            Return odProcesoServicio.Obtener(oeProcesoServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeProcesoServicio As EntidadesWCF.e_ProcesoServicio) As Boolean Implements Il_ProcesoServicio.Validar
        Try
            With oeProcesoServicio
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdProcesoNegocio, "Debe seleccionar algún proceso")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdServicio, "Debe seleccionar algún Servicio")
                ValidarDuplicado(oeProcesoServicio)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal oeProcesoServicio As EntidadesWCF.e_ProcesoServicio) As Boolean Implements Il_ProcesoServicio.ValidarDuplicado
        Try
            If String.IsNullOrEmpty(oeProcesoServicio.IdProcesoNegocio) Then Throw New Exception("No se ha definido que proceso se va a verificar si existe")
            If String.IsNullOrEmpty(oeProcesoServicio.IdServicio) Then Throw New Exception("No se ha especificado el Servicio que se va a validar")
            Dim p As New e_ProcesoServicio
            p = odProcesoServicio.ObtenerUnico(oeProcesoServicio)
            If Not String.IsNullOrEmpty(p.Id) Then Throw New Exception("Servicio ya se encuentra vinculado a este proceso")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
