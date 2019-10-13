'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ProcesoTipoDocumento
    Implements Il_ProcesoTipoDocumento

    Dim odProcesoTipoDocumento As New d_ProcesoTipoDocumento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeProcesoTipoDocumento As EntidadesWCF.e_ProcesoTipoDocumento) As Boolean Implements Il_ProcesoTipoDocumento.Eliminar
        Try
            Return odProcesoTipoDocumento.Eliminar(oeProcesoTipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoTipoDocumento As EntidadesWCF.e_ProcesoTipoDocumento) As Boolean Implements Il_ProcesoTipoDocumento.Guardar
        Try
            If Validar(oeProcesoTipoDocumento) Then
                Return odProcesoTipoDocumento.Guardar(oeProcesoTipoDocumento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoTipoDocumento As EntidadesWCF.e_ProcesoTipoDocumento) As System.Collections.Generic.List(Of EntidadesWCF.e_ProcesoTipoDocumento) Implements Il_ProcesoTipoDocumento.Listar
        Try
            Return odProcesoTipoDocumento.Listar(oeProcesoTipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoTipoDocumento As EntidadesWCF.e_ProcesoTipoDocumento) As EntidadesWCF.e_ProcesoTipoDocumento Implements Il_ProcesoTipoDocumento.Obtener
        Try
            Return odProcesoTipoDocumento.Obtener(oeProcesoTipoDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeProcesoTipoDocumento As EntidadesWCF.e_ProcesoTipoDocumento) As Boolean Implements Il_ProcesoTipoDocumento.Validar
        Try
            With oeProcesoTipoDocumento
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdProceso, "Debe seleccionar algún proceso")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "Debe seleccionar algún Tipo de Documento")
                ValidarDuplicado(oeProcesoTipoDocumento)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar que no se dupliquen los procesos asociados a algún tipo de documento
    ''' </summary>
    ''' <param name="oeProcesoTipoDocumento">Objeto de tipo ProcesoTipoDocumento</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal oeProcesoTipoDocumento As EntidadesWCF.e_ProcesoTipoDocumento) As Boolean Implements Il_ProcesoTipoDocumento.ValidarDuplicado
        Try
            If String.IsNullOrEmpty(oeProcesoTipoDocumento.IdProceso) Then Throw New Exception("No se ha definido que proceso se va a verificar si existe")
            If String.IsNullOrEmpty(oeProcesoTipoDocumento.IdTipoDocumento) Then Throw New Exception("No se ha especificado el tipo de documento que se va a validar")
            Dim p As New e_ProcesoTipoDocumento
            p = odProcesoTipoDocumento.ObtenerUnico(oeProcesoTipoDocumento)
            If Not String.IsNullOrEmpty(p.Id) Then Throw New Exception("Documento ya se encuentra vinculado a este proceso")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
