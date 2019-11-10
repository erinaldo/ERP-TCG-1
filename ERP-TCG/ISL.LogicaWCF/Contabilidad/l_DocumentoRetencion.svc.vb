Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.ServicioExterno
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DocumentoRetencion
    Implements Il_DocumentoRetencion

    Dim odDocumentoRetencion As New d_DocumentoRetencion
    Dim osRetencionElectronico As New s_Retencion
    Dim olDatosConfiguracion As New l_Configuracion

    Public Function Eliminar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean Implements Il_DocumentoRetencion.Eliminar
        Try
            Return odDocumentoRetencion.Eliminar(oeDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean Implements Il_DocumentoRetencion.Guardar
        Try
            If Validar(oeDocumentoRetencion) Then
                Return odDocumentoRetencion.Guardar(oeDocumentoRetencion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As System.Collections.Generic.List(Of e_DocumentoRetencion) Implements Il_DocumentoRetencion.Listar
        Try
            Return odDocumentoRetencion.Listar(oeDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As e_DocumentoRetencion Implements Il_DocumentoRetencion.Obtener
        Try
            Return odDocumentoRetencion.Obtener(oeDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean Implements Il_DocumentoRetencion.Validar
        Try
            With oeDocumentoRetencion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function UltimoNroRetencion(ByVal Serie As String) As String Implements Il_DocumentoRetencion.UltimoNroRetencion
        Try
            Return odDocumentoRetencion.UltimoDocRetencion(Serie)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ImprimirDocumentoRetencion(ByVal IdDocumentoRetencion As String) As System.Data.DataTable Implements Il_DocumentoRetencion.ImprimirDocumentoRetencion
        Try
            Return odDocumentoRetencion.ImprimirDocumentoRetencion(IdDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EnviarSunat(oeDocumentoRetencion As e_DocumentoRetencion) As Boolean Implements Il_DocumentoRetencion.EnviarSunat
        Try
            'Dim strRuta As String = olDatosConfiguracion.DocElectronico() '@0001
            Dim dsRetencion As DataSet
            dsRetencion = odDocumentoRetencion.ObtenerRetencion(oeDocumentoRetencion)
            'osRetencionElectronico.GenerarXml(dsRetencion.Tables(0), dsRetencion.Tables(1), strRuta, "", "", "", False, oeDocumentoRetencion.UsuarioModifica)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ImpresionElectronico(oeDocumentoRetencion As e_DocumentoRetencion) As DataSet Implements Il_DocumentoRetencion.ImpresionElectronico
        Try
            Return odDocumentoRetencion.ObtenerRetencion(oeDocumentoRetencion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComunicaBajaSunat(oeDocumentoRetencion As e_DocumentoRetencion) As String Implements Il_DocumentoRetencion.ComunicaBajaSunat
        Try
            Dim ls_Respuesta As String = ""
            'Dim strRuta As String = olDatosConfiguracion.DocElectronico() '@0001
            Dim dsRetencion As DataSet
            dsRetencion = odDocumentoRetencion.ObtenerRetencion(oeDocumentoRetencion)
            'ls_Respuesta = osRetencionElectronico.GenerarXmlComprobantesBaja(dsRetencion.Tables(0), oeDocumentoRetencion.FechaEmision, strRuta, oeDocumentoRetencion.UsuarioCrea)
            Return ls_Respuesta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function EnviarXMLGetStatus(ByVal ticket As String, usuario As String, ByVal PrefijoID As String, ByVal strRuta As String) As String
        'Dim strRuta As String = olDatosConfiguracion.DocElectronico() '@0001
        Return osRetencionElectronico.EnviarXMLGetStatus(strRuta, ticket, usuario, PrefijoID)
    End Function
    Public Function ConsultarDocumento(oeDocumentoRetencion As e_DocumentoRetencion, ByVal strRuta As String) As Boolean Implements Il_DocumentoRetencion.ConsultarDocumento
        Try
            'Dim strRuta As String = olDatosConfiguracion.DocElectronico() '@0001
            Dim dsRetencion As DataSet
            dsRetencion = odDocumentoRetencion.ObtenerRetencion(oeDocumentoRetencion)
            osRetencionElectronico.ConsultarDocumento(dsRetencion, strRuta, oeDocumentoRetencion.UsuarioModifica, False)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
