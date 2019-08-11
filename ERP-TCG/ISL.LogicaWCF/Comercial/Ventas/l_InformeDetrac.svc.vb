Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_InformeDetrac
    Implements Il_InformeDetrac

    Dim odInformeDetrac As New d_InformeDetrac

    Public Function Eliminar(ByVal oeInformeDetrac As EntidadesWCF.e_InformeDetrac) As Boolean Implements Il_InformeDetrac.Eliminar
        Try
            Return odInformeDetrac.Eliminar(oeInformeDetrac)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeInformeDetrac As EntidadesWCF.e_InformeDetrac) As Boolean Implements Il_InformeDetrac.Guardar
        Try
            If Validar(oeInformeDetrac) Then
                Return odInformeDetrac.Guardar(oeInformeDetrac)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeInformeDetrac As EntidadesWCF.e_InformeDetrac) As System.Collections.Generic.List(Of EntidadesWCF.e_InformeDetrac) Implements Il_InformeDetrac.Listar
        Try
            Return odInformeDetrac.Listar(oeInformeDetrac)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeInformeDetrac As EntidadesWCF.e_InformeDetrac) As EntidadesWCF.e_InformeDetrac Implements Il_InformeDetrac.Obtener
        Try
            Return odInformeDetrac.Obtener(oeInformeDetrac)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeInformeDetrac As EntidadesWCF.e_InformeDetrac) As Boolean Implements Il_InformeDetrac.Validar
        Try
            With oeInformeDetrac
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
