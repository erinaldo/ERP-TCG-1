Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleValorizacionNeumatico
    Implements Il_DetalleValorizacionNeumatico

    Dim odDetalleValorizacionNeumatico As New d_DetalleValorizacionNeumatico

    Public Function Eliminar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean Implements Il_DetalleValorizacionNeumatico.Eliminar
        Try
            Return odDetalleValorizacionNeumatico.Eliminar(oeDetalleValorizacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean Implements Il_DetalleValorizacionNeumatico.Guardar
        Try
            If Validar(oeDetalleValorizacionNeumatico) Then
                Return odDetalleValorizacionNeumatico.Guardar(oeDetalleValorizacionNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As System.Collections.Generic.List(Of e_DetalleValorizacionNeumatico) Implements Il_DetalleValorizacionNeumatico.Listar
        Try
            Return odDetalleValorizacionNeumatico.Listar(oeDetalleValorizacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As e_DetalleValorizacionNeumatico Implements Il_DetalleValorizacionNeumatico.Obtener
        Try
            Return odDetalleValorizacionNeumatico.Obtener(oeDetalleValorizacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleValorizacionNeumatico As e_DetalleValorizacionNeumatico) As Boolean Implements Il_DetalleValorizacionNeumatico.Validar
        Try
            With oeDetalleValorizacionNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
