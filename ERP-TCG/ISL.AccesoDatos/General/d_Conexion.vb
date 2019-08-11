Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text
Imports System.Collections.Specialized

''' <summary>
''' Clase para administrar las cadenas de conexión al SGI
''' </summary>
''' <remarks>Esta clase se utiliza junto al sql helper,Capa del Sistema:Capa de Datos</remarks>
Public Class d_Conexion

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Cadena de conexión de la base de datos de la empresa ISL
    ''' </summary>
    ''' <returns>Devuelve un cadena</returns>
    ''' <remarks></remarks>
    Public Shared Function CadenaConexionSGI() As String
        Try
            Return ConfigurationManager.ConnectionStrings("ISL").ConnectionString
            'Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            'Dim TipoConex As String = config.AppSettings.Settings.Item("0").Value
            '= ConfigurationManager.AppSettings.Get("TipoConex")

            'If TipoConex = 0 Then
            'Else
            'Return ConfigurationManager.ConnectionStrings("ISLext").ConnectionString
            'End If

            'Dim config As New NameValueCollection
            'Dim cad As String
            'config = DirectCast(ConfigurationManager.GetSection("userSettings/ISL.Win.My.MySettings"), NameValueCollection)

            'If Not IsNothing(config) Then
            '    Dim inKeyCnt As Integer
            '    'Loop to populate all the company code in the dropdown list
            '    For inKeyCnt = 0 To config.Keys.Count - 1
            '        'DropDown List ID is ddlAssociation
            '        cad = config(inKeyCnt).ToString
            '    Next
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


