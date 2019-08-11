Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DocumentoSinAsociacion
    Implements Il_DocumentoSinAsociacion

    Dim odDocumentoSinAsociacion As New d_DocumentoSinAsociacion

    Public Function Eliminar(ByVal oeDocumentoSinAsociacion As EntidadesWCF.e_DocumentoSinAsociacion) As Boolean Implements Il_DocumentoSinAsociacion.Eliminar
        Try
            Return odDocumentoSinAsociacion.Eliminar(oeDocumentoSinAsociacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoSinAsociacion As EntidadesWCF.e_DocumentoSinAsociacion) As Boolean Implements Il_DocumentoSinAsociacion.Guardar
        Try
            If Validar(oeDocumentoSinAsociacion) Then
                Return odDocumentoSinAsociacion.Guardar(oeDocumentoSinAsociacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoSinAsociacion As EntidadesWCF.e_DocumentoSinAsociacion) As System.Collections.Generic.List(Of EntidadesWCF.e_DocumentoSinAsociacion) Implements Il_DocumentoSinAsociacion.Listar
        Try
            Return odDocumentoSinAsociacion.Listar(oeDocumentoSinAsociacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoSinAsociacion As EntidadesWCF.e_DocumentoSinAsociacion) As EntidadesWCF.e_DocumentoSinAsociacion Implements Il_DocumentoSinAsociacion.Obtener
        Try
            Return odDocumentoSinAsociacion.Obtener(oeDocumentoSinAsociacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoSinAsociacion As EntidadesWCF.e_DocumentoSinAsociacion) As Boolean Implements Il_DocumentoSinAsociacion.Validar
        Try
            With oeDocumentoSinAsociacion
                If String.IsNullOrEmpty(.Glosa) Then Throw New Exception("Llenar Glosa")
                If .TipoOperacion = "A" Then
                    If .Evaluado = 0 Then Throw New Exception("Escoger Evaluación")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
