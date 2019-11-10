'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Configuracion
    Implements Il_Configuracion

    Private odDatosConfiguracion As New d_DatosConfiguracion

    ''' <summary>
    ''' Obtiene la ruta donde se ubican las fotos de los trabajadores o empleados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function Fotos() As String Implements Il_Configuracion.Fotos
    '    Return odDatosConfiguracion.Fotos
    'End Function

    ''' <summary>
    ''' Retorna el IP del Servidor por defecto
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function Servidor() As String Implements Il_Configuracion.Servidor
        Return odDatosConfiguracion.Servidor
    End Function

    Public Function IPServidor() As String Implements Il_Configuracion.IPServidor
        Return odDatosConfiguracion.IPServidor
    End Function

    Public Function IPServidorReportes() As String Implements Il_Configuracion.IPServidorReportes
        Return odDatosConfiguracion.IPServidorReportes
    End Function

    '@0001
    'Public Function PrefijoID() As String Implements Il_Configuracion.PrefijoID
    '    Return odDatosConfiguracion.PrefijoID
    'End Function

    Public Function RutaAyuda() As String Implements Il_Configuracion.RutaAyuda
        Return odDatosConfiguracion.RutaAyuda
    End Function

    '@0001
    'Public Function RutaImagen() As String Implements Il_Configuracion.RutaImagen
    '    Return odDatosConfiguracion.RutaImagen
    'End Function

    Public Function Sedes() As System.Collections.Generic.List(Of String) Implements Il_Configuracion.Sedes
        Return odDatosConfiguracion.Sedes
    End Function

    'Public Function DocElectronico() As String Implements Il_Configuracion.DocElectronico
    '    Return odDatosConfiguracion.DocElectronico
    'End Function

End Class
