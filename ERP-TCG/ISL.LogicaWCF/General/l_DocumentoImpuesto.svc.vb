Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DocumentoImpuesto
    Implements Il_DocumentoImpuesto

    Dim odDocumentoImpuesto As New d_DocumentoImpuesto

    Public Function Eliminar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean Implements Il_DocumentoImpuesto.Eliminar
        Try
            Return odDocumentoImpuesto.Eliminar(oeDocumentoImpuesto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean Implements Il_DocumentoImpuesto.Guardar
        Try
            If Validar(oeDocumentoImpuesto) Then
                Return odDocumentoImpuesto.Guardar(oeDocumentoImpuesto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As System.Collections.Generic.List(Of e_DocumentoImpuesto) Implements Il_DocumentoImpuesto.Listar
        Try
            Return odDocumentoImpuesto.Listar(oeDocumentoImpuesto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As e_DocumentoImpuesto Implements Il_DocumentoImpuesto.Obtener
        Try
            Return odDocumentoImpuesto.Obtener(oeDocumentoImpuesto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoImpuesto As e_DocumentoImpuesto) As Boolean Implements Il_DocumentoImpuesto.Validar
        Try
            With oeDocumentoImpuesto
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
