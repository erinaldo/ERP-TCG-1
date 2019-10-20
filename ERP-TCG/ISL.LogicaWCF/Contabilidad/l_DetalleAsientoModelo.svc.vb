Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleAsientoModelo

    Implements Il_DetalleAsientoModelo

    Dim odDetalleAsientoModelo As New d_DetalleAsientoModelo

    Public Function Eliminar(oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean Implements Il_DetalleAsientoModelo.Eliminar
        Try
            Return odDetalleAsientoModelo.Eliminar(oeDetalleAsientoModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean Implements Il_DetalleAsientoModelo.Guardar
        Try
            If Validar(oeDetalleAsientoModelo) Then
                Return odDetalleAsientoModelo.Guardar(oeDetalleAsientoModelo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleAsientoModelo As e_DetalleAsientoModelo) As List(Of e_DetalleAsientoModelo) Implements Il_DetalleAsientoModelo.Listar
        Try
            Return odDetalleAsientoModelo.Listar(oeDetalleAsientoModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleAsientoModelo As e_DetalleAsientoModelo) As e_DetalleAsientoModelo Implements Il_DetalleAsientoModelo.Obtener
        Try
            Return odDetalleAsientoModelo.Obtener(oeDetalleAsientoModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean Implements Il_DetalleAsientoModelo.Validar
        Try
            With oeDetalleAsientoModelo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
