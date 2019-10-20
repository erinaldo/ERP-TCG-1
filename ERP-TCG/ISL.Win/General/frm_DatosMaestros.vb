'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports System.Collections.Generic
Imports System.Xml
Imports System.IO

Public Class frm_DatosMaestros
    Inherits ISL.Win.frm_MenuPadre
    Private ruta As String = System.AppDomain.CurrentDomain.BaseDirectory()

    Private Shared instancia As frm_DatosMaestros = Nothing
    Private Shared Operacion As String
    Private DTM As New Data.DataTable

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DatosMaestros()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Metodos"

    Private Sub DTMaestros()
        With DTM
            .Columns.Add(New Data.DataColumn("Nro", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Tabla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Archivo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Carga", Type.GetType("System.String")))
        End With
    End Sub

    Private Sub f_DatosTabla()
        Dim ofila As DataRow = DTM.NewRow
        ofila("Nro") = "1"
        ofila("Tabla") = "CuentaBancaria"
        ofila("Archivo") = "CuentaBancaria.xml"
        ofila("Carga") = "0"
        DTM.Rows.Add(ofila)

        ofila = DTM.NewRow
        ofila("Nro") = "2"
        ofila("Tabla") = "MedioPago"
        ofila("Archivo") = "MedioPago.xml"
        ofila("Carga") = "0"
        DTM.Rows.Add(ofila)

        ofila = DTM.NewRow
        ofila("Nro") = "3"
        ofila("Tabla") = "FlujoCaja"
        ofila("Archivo") = "FlujoCaja.xml"
        ofila("Carga") = "1"
        DTM.Rows.Add(ofila)

        ofila = DTM.NewRow
        ofila("Nro") = "4"
        ofila("Tabla") = "TipoDocumento"
        ofila("Archivo") = "TipoDocumento.xml"
        ofila("Carga") = "1"
        DTM.Rows.Add(ofila)
    End Sub

    Private Sub Generar()
        CuentaBancariaXML("CuentaBancaria.xml")
        MedioPagoXML("MedioPago.xml")
        FlujoCajaXML("FlujoCaja.xml")
        TipoDocumentoXML("TipoDocumento.xml")
    End Sub

    Private Sub CuentaBancariaXML(ByVal ls_nombre As String)
        Try
            Dim oeCtaBancaria As New e_CuentaBancaria
            Dim leCtaBancaria As New List(Of e_CuentaBancaria)
            Dim olCtaBancaria As New l_CuentaBancaria
            oeCtaBancaria.Activo = True
            leCtaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
            Dim obj As Type
            obj = GetType(List(Of e_CuentaBancaria))
            Dim objWriter As New Serialization.XmlSerializer(GetType(List(Of e_CuentaBancaria)))
            Dim objfile As New StreamWriter(ruta + "datos_maestros/" + ls_nombre)
            objWriter.Serialize(objfile, leCtaBancaria)
            objfile.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MedioPagoXML(ByVal ls_nombre As String)
        Try
            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            Dim obj As Type
            obj = GetType(List(Of e_MedioPago))
            Dim objWriter As New Serialization.XmlSerializer(GetType(List(Of e_MedioPago)))
            Dim objfile As New StreamWriter(ruta + "datos_maestros/" + ls_nombre)
            objWriter.Serialize(objfile, leMedioPago)
            objfile.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub FlujoCajaXML(ByVal ls_nombre As String)
        Try
            Dim oeFlujo As New e_FlujoCaja
            Dim leFlujo As New List(Of e_FlujoCaja)
            Dim olFlujo As New l_FlujoCaja
            oeFlujo.Activo = True
            leFlujo.AddRange(olFlujo.Listar(oeFlujo))
            Dim obj As Type
            obj = GetType(List(Of e_FlujoCaja))
            Dim objWriter As New Serialization.XmlSerializer(GetType(List(Of e_FlujoCaja)))
            Dim objfile As New StreamWriter(ruta + "datos_maestros/" + ls_nombre)
            objWriter.Serialize(objfile, leFlujo)
            objfile.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub TipoDocumentoXML(ByVal ls_nombre As String)
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim leTipoDoc As New List(Of e_TipoDocumento)
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.Activo = True
            oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))

            Dim obj As Type
            obj = GetType(List(Of e_TipoDocumento))
            Dim objWriter As New Serialization.XmlSerializer(GetType(List(Of e_TipoDocumento)))
            Dim objfile As New StreamWriter(ruta + "datos_maestros/" + ls_nombre)
            objWriter.Serialize(objfile, leTipoDoc)
            objfile.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub frm_DatosMaestros_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_DatosMaestros_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frm_DatosMaestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTMaestros()
        f_DatosTabla()
        gridTablasMaestras.DataSource = DTM
    End Sub

    Private Sub btn_Recarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recarga.Click
        Generar()
    End Sub

End Class
