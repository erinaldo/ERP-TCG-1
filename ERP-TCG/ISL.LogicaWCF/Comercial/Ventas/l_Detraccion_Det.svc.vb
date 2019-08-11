Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Detraccion_Det
    Implements Il_Detraccion_Det

    Dim odDetraccion_Det As New d_Detraccion_Det

    Public Function Eliminar(ByVal oeDetraccion_Det As EntidadesWCF.e_Detraccion_Det) As Boolean Implements Il_Detraccion_Det.Eliminar
        Try
            Return odDetraccion_Det.Eliminar(oeDetraccion_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarLista(ByVal leDetraccionDet As System.Collections.Generic.List(Of EntidadesWCF.e_Detraccion_Det)) As Boolean Implements Il_Detraccion_Det.EliminarLista
        Try
            Return odDetraccion_Det.EliminarLista(leDetraccionDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetraccion_Det As EntidadesWCF.e_Detraccion_Det) As Boolean Implements Il_Detraccion_Det.Guardar
        Try
            If Validar(oeDetraccion_Det) Then
                Return odDetraccion_Det.Guardar(oeDetraccion_Det)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(ByVal leDetraccionDet As System.Collections.Generic.List(Of EntidadesWCF.e_Detraccion_Det)) As Boolean Implements Il_Detraccion_Det.GuardarLista
        Try
            Return odDetraccion_Det.GuardarLista(leDetraccionDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetraccion_Det As EntidadesWCF.e_Detraccion_Det) As System.Collections.Generic.List(Of EntidadesWCF.e_Detraccion_Det) Implements Il_Detraccion_Det.Listar
        Try
            Return odDetraccion_Det.Listar(oeDetraccion_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetraccion_Det As EntidadesWCF.e_Detraccion_Det) As EntidadesWCF.e_Detraccion_Det Implements Il_Detraccion_Det.Obtener
        Try
            Return odDetraccion_Det.Obtener(oeDetraccion_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetraccion_Det As EntidadesWCF.e_Detraccion_Det) As Boolean Implements Il_Detraccion_Det.Validar
        Try
            With oeDetraccion_Det
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
