Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleOrdenNeumatico

    Implements Il_DetalleOrdenNeumatico

    Dim odDetalleOrdenNeumatico As New d_DetalleOrdenNeumatico

    Public Function Eliminar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As Boolean Implements Il_DetalleOrdenNeumatico.Eliminar
        Try
            Return odDetalleOrdenNeumatico.Eliminar(oedetalleordenneumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As Boolean Implements Il_DetalleOrdenNeumatico.Guardar
        Try
            If Validar(oedetalleordenneumatico) Then
                Return odDetalleOrdenNeumatico.Guardar(oedetalleordenneumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As System.Collections.Generic.List(Of e_DetalleOrdenNeumatico) Implements Il_DetalleOrdenNeumatico.Listar
        Try
            Return odDetalleOrdenNeumatico.Listar(oedetalleordenneumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As e_DetalleOrdenNeumatico Implements Il_DetalleOrdenNeumatico.Obtener
        Try
            Return odDetalleOrdenNeumatico.Obtener(oedetalleordenneumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oedetalleordenneumatico As e_DetalleOrdenNeumatico) As Boolean Implements Il_DetalleOrdenNeumatico.Validar

    End Function
End Class
