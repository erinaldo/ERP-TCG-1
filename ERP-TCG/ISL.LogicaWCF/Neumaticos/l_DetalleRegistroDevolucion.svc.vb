Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleRegistroDevolucion
    Implements Il_DetalleRegistroDevolucion

    Dim odDetalleRegistroDevolucion As New d_DetalleRegistroDevolucion

    Public Function Eliminar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As Boolean Implements Il_DetalleRegistroDevolucion.Eliminar
        Try
            Return odDetalleRegistroDevolucion.Eliminar(oedetalleregistrodevolucion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As Boolean Implements Il_DetalleRegistroDevolucion.Guardar
        Try
            If Validar(oedetalleregistrodevolucion) Then
                Return odDetalleRegistroDevolucion.Guardar(oedetalleregistrodevolucion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As System.Collections.Generic.List(Of e_DetalleRegistroDevolucion) Implements Il_DetalleRegistroDevolucion.Listar
        Try
            Return odDetalleRegistroDevolucion.Listar(oedetalleregistrodevolucion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As e_DetalleRegistroDevolucion Implements Il_DetalleRegistroDevolucion.Obtener
        Try
            Return odDetalleRegistroDevolucion.Obtener(oedetalleregistrodevolucion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oedetalleregistrodevolucion As e_DetalleRegistroDevolucion) As Boolean Implements Il_DetalleRegistroDevolucion.Validar
        Try
            With oedetalleregistrodevolucion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
