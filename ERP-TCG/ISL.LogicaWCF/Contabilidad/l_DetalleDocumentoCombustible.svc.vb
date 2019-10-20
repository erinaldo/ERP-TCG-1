Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleDocumentoCombustible
    Implements Il_DetalleDocumentoCombustible

    Dim odDetalleDocumentoCombustible As New d_DetalleDocumentoCombustible

    Public Function Eliminar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean Implements Il_DetalleDocumentoCombustible.Eliminar
        Try
            Return odDetalleDocumentoCombustible.Eliminar(oeDetalleDocumentoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean Implements Il_DetalleDocumentoCombustible.Guardar
        Try
            If Validar(oeDetalleDocumentoCombustible) Then
                Return odDetalleDocumentoCombustible.Guardar(oeDetalleDocumentoCombustible)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function Listar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As System.Collections.Generic.List(Of e_DetalleDocumentoCombustible) Implements Il_DetalleDocumentoCombustible.Listar
    '    Try
    '        Return odDetalleDocumentoCombustible.Listar(oeDetalleDocumentoCombustible)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    'Public Function Obtener(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As e_DetalleDocumentoCombustible Implements Il_DetalleDocumentoCombustible.Obtener
    '    Try
    '        Return odDetalleDocumentoCombustible.Obtener(oeDetalleDocumentoCombustible)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function Validar(ByVal oeDetalleDocumentoCombustible As e_DetalleDocumentoCombustible) As Boolean Implements Il_DetalleDocumentoCombustible.Validar
        Try
            With oeDetalleDocumentoCombustible
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
