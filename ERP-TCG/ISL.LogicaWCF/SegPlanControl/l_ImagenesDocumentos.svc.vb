'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ImagenesDocumentosVehiculos" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ImagenesDocumentosVehiculos.svc o l_ImagenesDocumentosVehiculos.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract(), Serializable()> _
Public Class l_ImagenesDocumentos
    Implements Il_ImagenesDocumentos

    Dim odImagenesDocumentosVehiculos As New d_ImagenesDocumentos

    Public Function Obtener(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos Implements Il_ImagenesDocumentos.Obtener
        Try
            Return odImagenesDocumentosVehiculos.Obtener(oeImagenesDocumentosVehiculos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As List(Of e_ImagenesDocumentos) Implements Il_ImagenesDocumentos.Listar
        Try
            Return odImagenesDocumentosVehiculos.Listar(oeImagenesDocumentosVehiculos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean Implements Il_ImagenesDocumentos.Validar
        Try
            Dim olDocVehImg As New l_ImagenesDocumentos
            If oeImagenesDocumentosVehiculos.IdTipoDocumento.Trim = "" Then Throw New Exception("Debe Seleccionar Tipo Documento")
            If oeImagenesDocumentosVehiculos.IdVehiculo.Trim = "" Then Throw New Exception("Debe Seleccionar Vehículo")
            'If oeImagenesDocumentosVehiculos.NroDocumento.Trim = "" Then Throw New Exception("Debe Ingresar Nro Documento")
            If oeImagenesDocumentosVehiculos.FechaVencimiento.Date <= oeImagenesDocumentosVehiculos.FechaVigencia.Date Then Throw New Exception("Fecha Vencimiento Debe Ser Mayor A Fecha Vigencia")

            Dim objListar As New e_ImagenesDocumentos
            Dim Listaobj As New List(Of e_ImagenesDocumentos)
            Dim Id As String = oeImagenesDocumentosVehiculos.Id.ToString.Trim()
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = oeImagenesDocumentosVehiculos.IdTipoDocumento.Trim
            'objListar.NroDocumento = oeImagenesDocumentosVehiculos.NroDocumento.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If Id = "" Then
            '    If Listaobj.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'Else
            '    Dim resultado = Listaobj.Where(Function(x) x.Id.Trim <> Id.Trim)
            '    If resultado.Count > 0 Then Throw New Exception("Número Documento Ya Existe.")
            'End If

            'Listaobj = New List(Of e_ImagenesDocumentos)
            'objListar = New e_ImagenesDocumentos
            'objListar.TipoOperacion = ""
            'objListar.Id = ""
            'objListar.IdTipoDocumento = oeImagenesDocumentosVehiculos.IdTipoDocumento.Trim
            'objListar.IdVehiculo = oeImagenesDocumentosVehiculos.IdVehiculo.Trim
            'Listaobj = olDocVehImg.Listar(objListar)
            'If Listaobj.Count = 0 Then Return True
            'If Id = "" Then
            '    Dim resultado = Listaobj.OrderByDescending(Function(x) x.FechaVencimiento)
            '    If resultado(0).FechaVencimiento.Date > oeImagenesDocumentosVehiculos.FechaVigencia.Date Then Throw New Exception("Vehículo Tiene Documento N°: " + resultado(0).NroDocumento.Trim + " Con La FechaVencimiento " + resultado(0).FechaVencimiento.Date + ", Debe Seleccionar FechaVigencia Mayor A " + resultado(0).FechaVencimiento.Date)
            'Else
            '    Dim resultado = Listaobj.Where(Function(x) x.Id.Trim <> Id.Trim).OrderByDescending(Function(y) y.FechaVencimiento)
            '    If resultado.Count = 0 Then Return True
            '    If resultado(0).FechaVencimiento.Date > oeImagenesDocumentosVehiculos.FechaVigencia.Date Then Throw New Exception("Vehículo Tiene Documento N°: " + resultado(0).NroDocumento.Trim + " Con La FechaVencimiento " + resultado(0).FechaVencimiento.Date + ", Debe Seleccionar FechaVigencia Mayor A " + resultado(0).FechaVencimiento.Date)
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean Implements Il_ImagenesDocumentos.Guardar
        Try
            If Validar(oeImagenesDocumentosVehiculos) Then
                Return odImagenesDocumentosVehiculos.Guardar(oeImagenesDocumentosVehiculos)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As Boolean Implements Il_ImagenesDocumentos.Eliminar
        Try
            Return odImagenesDocumentosVehiculos.Eliminar(oeImagenesDocumentosVehiculos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Sincronizar(ByVal oeImagenesDocumentosVehiculos As e_ImagenesDocumentos) As e_ImagenesDocumentos Implements Il_ImagenesDocumentos.Sincronizar
        Try
            Return odImagenesDocumentosVehiculos.Sincronizar(oeImagenesDocumentosVehiculos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
