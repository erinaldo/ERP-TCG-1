Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Orden_Documento
    Implements Il_Orden_Documento

    Dim odOrden_Documento As New d_Orden_Documento

    Public Function Guardar(ByVal oeOrden_Documento As e_Orden_Documento) As Boolean Implements Il_Orden_Documento.Guardar
        Try
            Return odOrden_Documento.Guardar(oeOrden_Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrden_Documento As e_Orden_Documento) As e_Orden_Documento Implements Il_Orden_Documento.Obtener
        Try
            Return odOrden_Documento.Obtener(oeOrden_Documento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrden_Documento As e_Orden_Documento) As List(Of e_Orden_Documento) Implements Il_Orden_Documento.Listar
        Try
            Return odOrden_Documento.Listar(oeOrden_Documento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerDocumento(ByVal oeOrden_Documento As e_Orden_Documento) As e_MovimientoDocumento Implements Il_Orden_Documento.ObtenerDocumento
        Try
            Return odOrden_Documento.ObtenerDoc(oeOrden_Documento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerDocumentoGuiaRemision(ByVal oeOrden_Documento As e_Orden_Documento) As e_GuiaRemisionRemitente Implements Il_Orden_Documento.ObtenerDocumentoGuiaRemision
        Try
            Return odOrden_Documento.ObtenerDocGuiaRemision(oeOrden_Documento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidaOIEjecutada(ByVal oeOrden_Documento As e_Orden_Documento) As Boolean Implements Il_Orden_Documento.ValidaOIEjecutada
        Try
            oeOrden_Documento.TipoOperacion = "I"
            oeOrden_Documento = odOrden_Documento.Obtener(oeOrden_Documento)
            If oeOrden_Documento.IdOrden <> "" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
