Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleDocumentoVehiculo
    Implements Il_DetalleDocumentoVehiculo

    Dim odDetalleDocumentoVehiculo As New d_DetalleDocumentoVehiculo

    Public Function Obtener(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As e_DetalleDocumentoVehiculo Implements Il_DetalleDocumentoVehiculo.Obtener
        Try
            Return odDetalleDocumentoVehiculo.Obtener(oeDetalleDocumentoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As List(Of e_DetalleDocumentoVehiculo) Implements Il_DetalleDocumentoVehiculo.Listar
        Try
            Return odDetalleDocumentoVehiculo.Listar(oeDetalleDocumentoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean Implements Il_DetalleDocumentoVehiculo.Validar
        Try
            With oeDetalleDocumentoVehiculo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean Implements Il_DetalleDocumentoVehiculo.Guardar
        Try
            If Validar(oeDetalleDocumentoVehiculo) Then
                Return odDetalleDocumentoVehiculo.Guardar(oeDetalleDocumentoVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleDocumentoVehiculo As e_DetalleDocumentoVehiculo) As Boolean Implements Il_DetalleDocumentoVehiculo.Eliminar
        Try
            Return odDetalleDocumentoVehiculo.Eliminar(oeDetalleDocumentoVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
