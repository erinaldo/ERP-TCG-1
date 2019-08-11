Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Xml
Imports System.Data.SqlClient

Public Class d_DatosConfiguracion

    Public Function Sedes() As List(Of String)
        Dim listaSedes As New List(Of String)
        listaSedes.Add(DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("Sede1"))
        listaSedes.Add(DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("Sede2"))
        Return listaSedes
    End Function

    ''' <summary>
    ''' Variable necesaria como prefijo para la generación del Id
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrefijoID() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("PrefijoID")
    End Function

    Public Function PrefijoID(ByVal sede As Integer) As String
        If sede = 1 Then
            Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("PrefijoIDSede1")
        Else
            Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("PrefijoIDSede2")
        End If
    End Function

    ''' <summary>
    ''' Retorna la IP del Servidor por defecto 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function Servidor() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("Servidor")
    End Function
    Public Function IPServidor() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidor")
    End Function

    ''' <summary>
    ''' Retorna la IP del Servidor de Reportes por defecto 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IPServidorReportes() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("IPServidorReportes")
    End Function


    ''' <summary>
    ''' Ruta de Imagenes del Sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RutaImagen() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("RutaImagen")
    End Function

    Public Function RutaAyuda() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("RutaAyuda")
    End Function

    Public Function Fotos() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("Fotos")
    End Function

    Public Function DocElectronico() As String
        Return DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("DocElectronico")
    End Function

End Class
