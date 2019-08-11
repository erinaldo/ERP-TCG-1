Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_InformeDetrac_Det
    Implements Il_InformeDetrac_Det

    Dim odInformeDetrac_Det As New d_InformeDetrac_Det

    Public Function Eliminar(ByVal oeInformeDetrac_Det As EntidadesWCF.e_InformeDetrac_Det) As Boolean Implements Il_InformeDetrac_Det.Eliminar
        Try
            Return odInformeDetrac_Det.Eliminar(oeInformeDetrac_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeInformeDetrac_Det As EntidadesWCF.e_InformeDetrac_Det) As Boolean Implements Il_InformeDetrac_Det.Guardar
        Try
            If Validar(oeInformeDetrac_Det) Then
                Return odInformeDetrac_Det.Guardar(oeInformeDetrac_Det)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeInformeDetrac_Det As EntidadesWCF.e_InformeDetrac_Det) As System.Collections.Generic.List(Of EntidadesWCF.e_InformeDetrac_Det) Implements Il_InformeDetrac_Det.Listar
        Try
            Return odInformeDetrac_Det.Listar(oeInformeDetrac_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeInformeDetrac_Det As EntidadesWCF.e_InformeDetrac_Det) As EntidadesWCF.e_InformeDetrac_Det Implements Il_InformeDetrac_Det.Obtener
        Try
            Return odInformeDetrac_Det.Obtener(oeInformeDetrac_Det)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeInformeDetrac_Det As EntidadesWCF.e_InformeDetrac_Det) As Boolean Implements Il_InformeDetrac_Det.Validar
        Try
            With oeInformeDetrac_Det
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
