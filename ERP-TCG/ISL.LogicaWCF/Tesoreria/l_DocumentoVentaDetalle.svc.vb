Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DocumentoVentaDetalle
    Implements Il_DocumentoVentaDetalle
    Dim odDocumentoVentaDetalle As New d_DocumentoVentaDetalle

    Public Function Eliminar(ByVal oeDocumentoVentaDetalle As EntidadesWCF.e_DocumentoVentaDetalle) As Boolean Implements Il_DocumentoVentaDetalle.Eliminar
        Try
            Return odDocumentoVentaDetalle.Eliminar(oeDocumentoVentaDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVentaDetalle As EntidadesWCF.e_DocumentoVentaDetalle) As Boolean Implements Il_DocumentoVentaDetalle.Guardar
        Try
            If Validar(oeDocumentoVentaDetalle) Then
                Return odDocumentoVentaDetalle.Guardar(oeDocumentoVentaDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVentaDetalle As EntidadesWCF.e_DocumentoVentaDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_DocumentoVentaDetalle) Implements Il_DocumentoVentaDetalle.Listar
        Try
            Return odDocumentoVentaDetalle.Listar(oeDocumentoVentaDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoVentaDetalle As EntidadesWCF.e_DocumentoVentaDetalle) As EntidadesWCF.e_DocumentoVentaDetalle Implements Il_DocumentoVentaDetalle.Obtener
        Try
            Return odDocumentoVentaDetalle.Obtener(oeDocumentoVentaDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoVentaDetalle As EntidadesWCF.e_DocumentoVentaDetalle) As Boolean Implements Il_DocumentoVentaDetalle.Validar
        Try
            With oeDocumentoVentaDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
