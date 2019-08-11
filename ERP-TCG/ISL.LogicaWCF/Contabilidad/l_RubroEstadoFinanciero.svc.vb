Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_RubroEstadoFinanciero
    Implements Il_RubroEstadoFinanciero

    Private odRubroEstadoFinanciero As New d_RubroEstadoFinanciero

    Public Function Obtener(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As e_RubroEstadoFinanciero Implements Il_RubroEstadoFinanciero.Obtener
        Try
            oeRubroEstadoFinanciero = odRubroEstadoFinanciero.Obtener(oeRubroEstadoFinanciero)
            Return oeRubroEstadoFinanciero
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As List(Of e_RubroEstadoFinanciero) Implements Il_RubroEstadoFinanciero.Listar
        Try
            Dim lstRubroEstadoFinanciero As New List(Of e_RubroEstadoFinanciero)
            lstRubroEstadoFinanciero = odRubroEstadoFinanciero.Listar(oeRubroEstadoFinanciero)
            Return lstRubroEstadoFinanciero
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean Implements Il_RubroEstadoFinanciero.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeRubroEstadoFinanciero) Then
                bol_guardado = odRubroEstadoFinanciero.Guardar(oeRubroEstadoFinanciero)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean Implements Il_RubroEstadoFinanciero.Eliminar
        Try
            Return odRubroEstadoFinanciero.Eliminar(oeRubroEstadoFinanciero)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeRubroEstadoFinanciero As e_RubroEstadoFinanciero) As Boolean
        Try
            With oeRubroEstadoFinanciero
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
