Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

Public Class l_RubroEstadoFinanciero_Detalle
    Implements Il_RubroEstadoFinanciero_Detalle

    Private odRubroEstadoFinanciero_Detalle As New d_RubroEstadoFinanciero_Detalle

    Public Function Obtener(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As e_RubroEstadoFinanciero_Detalle Implements Il_RubroEstadoFinanciero_Detalle.Obtener
        Try
            oeRubroEstadoFinanciero_Detalle = odRubroEstadoFinanciero_Detalle.Obtener(oeRubroEstadoFinanciero_Detalle)
            Return oeRubroEstadoFinanciero_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As List(Of e_RubroEstadoFinanciero_Detalle) Implements Il_RubroEstadoFinanciero_Detalle.Listar
        Try
            Dim lstRubroEstadoFinanciero_Detalle As New List(Of e_RubroEstadoFinanciero_Detalle)
            lstRubroEstadoFinanciero_Detalle = odRubroEstadoFinanciero_Detalle.Listar(oeRubroEstadoFinanciero_Detalle)
            Return lstRubroEstadoFinanciero_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean Implements Il_RubroEstadoFinanciero_Detalle.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeRubroEstadoFinanciero_Detalle) Then
                bol_guardado = odRubroEstadoFinanciero_Detalle.Guardar(oeRubroEstadoFinanciero_Detalle)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean Implements Il_RubroEstadoFinanciero_Detalle.Eliminar
        Try
            Return odRubroEstadoFinanciero_Detalle.Eliminar(oeRubroEstadoFinanciero_Detalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeRubroEstadoFinanciero_Detalle As e_RubroEstadoFinanciero_Detalle) As Boolean
        Try
            With oeRubroEstadoFinanciero_Detalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
