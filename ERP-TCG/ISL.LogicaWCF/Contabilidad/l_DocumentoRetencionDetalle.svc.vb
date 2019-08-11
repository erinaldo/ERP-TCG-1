Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_DocumentoRetencionDetalle
    Implements Il_DocumentoRetencionDetalle
    Dim odDocumentoRetencionDetalle As New d_DocumentoRetencionDetalle

    Public Function Obtener(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As e_DocumentoRetencionDetalle Implements Il_DocumentoRetencionDetalle.Obtener
        Try
            Return odDocumentoRetencionDetalle.Obtener(oeDocumentoRetencionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As List(Of e_DocumentoRetencionDetalle) Implements Il_DocumentoRetencionDetalle.Listar
        Try
            Return odDocumentoRetencionDetalle.Listar(oeDocumentoRetencionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean Implements Il_DocumentoRetencionDetalle.Validar
        Try
            With oeDocumentoRetencionDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean Implements Il_DocumentoRetencionDetalle.Guardar
        Try
            If Validar(oeDocumentoRetencionDetalle) Then
                Return odDocumentoRetencionDetalle.Guardar(oeDocumentoRetencionDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean Implements Il_DocumentoRetencionDetalle.Eliminar
        Try
            Return odDocumentoRetencionDetalle.Eliminar(oeDocumentoRetencionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDoc(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As List(Of e_MovimientoDocumento) Implements Il_DocumentoRetencionDetalle.ListarDoc
        Try
            Return odDocumentoRetencionDetalle.ListarDoc(oeDocumentoRetencionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
