'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text
Imports System.Collections.Specialized

Public Class d_Conexion

    Public Sub New()

    End Sub


    Public Shared Function CadenaConexionSGI() As String
        Try
            'Return ConfigurationManager.ConnectionStrings("ISL").ConnectionString '@0001

            'PRODUCCION
            'Return "Data Source=190.117.126.71;Initial Catalog=ERPTCG; Persist Security Info=True; User ID=sa; Password=2450L0rayL0ra; Connect Timeout=120"

            'DESARROLLO
            Return "Data Source=190.117.126.71;Initial Catalog=ERPTCGDesa; Persist Security Info=True; User ID=sa; Password=2450L0rayL0ra; Connect Timeout=120"

            'Return "Data Source=190.117.119.215;Initial Catalog=ERPTCG; Persist Security Info=True; User ID=sa; Password=2450L0rayL0ra; Connect Timeout=120"

            'LOCAL
            'Return "Data Source=LADERA;Initial Catalog=ERPTCG; Persist Security Info=True; User ID=sa; Password=2450L0rayL0ra; Connect Timeout=120"

            'Return "Data Source=192.168.0.8;Initial Catalog=ERPTCG; Persist Security Info=True; User ID=sa; Password=2450L0rayL0ra; Connect Timeout=120"
            'Return "Data Source=127.0.0.1;Initial Catalog=ERPTCG; Persist Security Info=True; User ID=sa; Password=sql2014; Connect Timeout=120"
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


