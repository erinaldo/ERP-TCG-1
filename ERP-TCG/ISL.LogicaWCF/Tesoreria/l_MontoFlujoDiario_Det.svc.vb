Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MontoFlujoDiario_Det
    Implements Il_MontoFlujoDiario_Det
    Dim odMontoFlujoDiario_Det As New d_MontoFlujoDiario_Det

    Public Function Eliminar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean Implements Il_MontoFlujoDiario_Det.Eliminar
        Try
            Return odMontoFlujoDiario_Det.Eliminar(oeMontoFlujoDiario_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean Implements Il_MontoFlujoDiario_Det.Guardar
        Try
            If Validar(oeMontoFlujoDiario_Det) Then
                Return odMontoFlujoDiario_Det.Guardar(oeMontoFlujoDiario_Det)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As System.Collections.Generic.List(Of e_MontoFlujoDiario_Det) Implements Il_MontoFlujoDiario_Det.Listar
        Try
            Return odMontoFlujoDiario_Det.Listar(oeMontoFlujoDiario_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As e_MontoFlujoDiario_Det Implements Il_MontoFlujoDiario_Det.Obtener
        Try
            Return odMontoFlujoDiario_Det.Obtener(oeMontoFlujoDiario_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMontoFlujoDiario_Det As e_MontoFlujoDiario_Det) As Boolean Implements Il_MontoFlujoDiario_Det.Validar
        Try
            With oeMontoFlujoDiario_Det
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
