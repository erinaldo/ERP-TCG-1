Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Estado
    Implements Il_Estado

    Dim odEstado As New d_Estado

    Public Function Listar(ByVal oeEstado As EntidadesWCF.e_Estado) As System.Collections.Generic.List(Of EntidadesWCF.e_Estado) Implements Il_Estado.Listar
        Try
            Return odEstado.Listar(oeEstado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal Lista As System.Collections.Generic.List(Of EntidadesWCF.e_Estado)) As Object Implements Il_Estado.ComboGrilla
        Try
            Return odEstado.ComboGrilla(Lista)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
