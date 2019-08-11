Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Venta
    Implements Il_Venta

    Dim odVenta As New d_Venta

    Public Function Eliminar(ByVal oeVenta As EntidadesWCF.e_Venta) As Boolean Implements Il_Venta.Eliminar
        Try
            Return odVenta.Eliminar(oeVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeVenta As EntidadesWCF.e_Venta) As Boolean Implements Il_Venta.Guardar
        Try
            If Validar(oeVenta) Then
                Return odVenta.Guardar(oeVenta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeVenta As EntidadesWCF.e_Venta) As System.Collections.Generic.List(Of EntidadesWCF.e_Venta) Implements Il_Venta.Listar
        Try
            Return odVenta.Listar(oeVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeVenta As EntidadesWCF.e_Venta) As EntidadesWCF.e_Venta Implements Il_Venta.Obtener
        Try
            Return odVenta.Obtener(oeVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeVenta As EntidadesWCF.e_Venta) As Boolean Implements Il_Venta.Validar
        Try
            With oeVenta
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
