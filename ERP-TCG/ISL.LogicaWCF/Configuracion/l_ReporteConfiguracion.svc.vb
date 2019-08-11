Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ReporteConfiguracion
    Implements Il_ReporteConfiguracion

    Private oeReporteConfiguracion As New e_ReporteConfiguracion
    Private odReporteConfiguracion As New d_ReporteConfiguracion
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Eliminar un ReporteConfiguracion
    ''' </summary>
    ''' <param name="oeReporteConfiguracion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeReporteConfiguracion As EntidadesWCF.e_ReporteConfiguracion) As Boolean Implements Il_ReporteConfiguracion.Eliminar
        Try
            Return odReporteConfiguracion.Eliminar(oeReporteConfiguracion)
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información de un ReporteConfiguracion
    ''' </summary>
    ''' <param name="oeReporteConfiguracion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeReporteConfiguracion As EntidadesWCF.e_ReporteConfiguracion) As Boolean Implements Il_ReporteConfiguracion.Guardar
        Try
            If Validar(oeReporteConfiguracion) Then
                Return odReporteConfiguracion.Guardar(oeReporteConfiguracion)
            End If
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener una lista de ReporteConfiguracions
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeReporteConfiguracion As EntidadesWCF.e_ReporteConfiguracion) As System.Collections.Generic.List(Of EntidadesWCF.e_ReporteConfiguracion) Implements Il_ReporteConfiguracion.Listar
        Try
            Return odReporteConfiguracion.Listar(oeReporteConfiguracion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para obtener un ReporteConfiguracion específico
    ''' </summary>
    ''' <param name="oeReporteConfiguracion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeReporteConfiguracion As EntidadesWCF.e_ReporteConfiguracion) As EntidadesWCF.e_ReporteConfiguracion Implements Il_ReporteConfiguracion.Obtener
        Try
            Return odReporteConfiguracion.Obtener(oeReporteConfiguracion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Método para validar los datos del objeto ReporteConfiguracion
    ''' </summary>
    ''' <param name="oeReporteConfiguracion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeReporteConfiguracion As EntidadesWCF.e_ReporteConfiguracion) As Boolean Implements Il_ReporteConfiguracion.Validar
        Try
            With oeReporteConfiguracion
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre del Reporte")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
