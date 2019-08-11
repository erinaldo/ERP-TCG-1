Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DocumentoAsociado
    Implements Il_DocumentoAsociado

    Dim odDocumentoAsociado As New d_DocumentoAsociado

    Public Function Eliminar(ByVal oeDocumentoAsociado As EntidadesWCF.e_DocumentoAsociado) As Boolean Implements Il_DocumentoAsociado.Eliminar
        Try
            Return odDocumentoAsociado.Eliminar(oeDocumentoAsociado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoAsociado As EntidadesWCF.e_DocumentoAsociado) As Boolean Implements Il_DocumentoAsociado.Guardar
        Try
            If Validar(oeDocumentoAsociado) Then
                Return odDocumentoAsociado.Guardar(oeDocumentoAsociado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoAsociado As EntidadesWCF.e_DocumentoAsociado) As System.Collections.Generic.List(Of EntidadesWCF.e_DocumentoAsociado) Implements Il_DocumentoAsociado.Listar
        Try
            Return odDocumentoAsociado.Listar(oeDocumentoAsociado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDocAsoc(ByVal oeDocumentoAsociado As EntidadesWCF.e_DocumentoAsociado) As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoDocumento) Implements Il_DocumentoAsociado.ListarDocAsoc
        Try
            Return odDocumentoAsociado.ListarDocAsoc(oeDocumentoAsociado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoAsociado As EntidadesWCF.e_DocumentoAsociado) As EntidadesWCF.e_DocumentoAsociado Implements Il_DocumentoAsociado.Obtener
        Try
            Return odDocumentoAsociado.Obtener(oeDocumentoAsociado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoAsociado As EntidadesWCF.e_DocumentoAsociado) As Boolean Implements Il_DocumentoAsociado.Validar
        Try
            With oeDocumentoAsociado
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
