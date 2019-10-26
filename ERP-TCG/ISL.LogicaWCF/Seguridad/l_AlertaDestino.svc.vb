Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AlertaDestino
    Implements Il_AlertaDestino
    Dim odAlertaDestino As New d_AlertaDestino

    Public Function Eliminar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean Implements Il_AlertaDestino.Eliminar
        Try
            Return odAlertaDestino.Eliminar(oeAlertaDestino)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean Implements Il_AlertaDestino.Guardar
        Try
            If Validar(oeAlertaDestino) Then
                Return odAlertaDestino.Guardar(oeAlertaDestino)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlertaDestino As e_AlertaDestino) As System.Collections.Generic.List(Of e_AlertaDestino) Implements Il_AlertaDestino.Listar
        Try
            Return odAlertaDestino.Listar(oeAlertaDestino)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAlertaDestino As e_AlertaDestino) As e_AlertaDestino Implements Il_AlertaDestino.Obtener
        Try
            Return odAlertaDestino.Obtener(oeAlertaDestino)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAlertaDestino As e_AlertaDestino) As Boolean Implements Il_AlertaDestino.Validar
        Try
            With oeAlertaDestino
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
