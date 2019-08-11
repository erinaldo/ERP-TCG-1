Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleCapacitacion
    Implements Il_DetalleCapacitacion

    Dim odDetalleCapacitacion As d_DetalleCapacitacion

    Public Function Eliminar(oeDetalleCapacitacion As EntidadesWCF.e_DetalleCapacitacion) As Boolean Implements Il_DetalleCapacitacion.Eliminar
        Try
            odDetalleCapacitacion = New d_DetalleCapacitacion
            Return odDetalleCapacitacion.Eliminar(oeDetalleCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleCapacitacion As EntidadesWCF.e_DetalleCapacitacion) As Boolean Implements Il_DetalleCapacitacion.Guardar
        Try
            odDetalleCapacitacion = New d_DetalleCapacitacion
            If Validar(oeDetalleCapacitacion) Then
                Return odDetalleCapacitacion.Guardar(oeDetalleCapacitacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleCapacitacion As EntidadesWCF.e_DetalleCapacitacion) As List(Of EntidadesWCF.e_DetalleCapacitacion) Implements Il_DetalleCapacitacion.Listar
        Try
            odDetalleCapacitacion = New d_DetalleCapacitacion
            Return odDetalleCapacitacion.Listar(oeDetalleCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleCapacitacion As EntidadesWCF.e_DetalleCapacitacion) As EntidadesWCF.e_DetalleCapacitacion Implements Il_DetalleCapacitacion.Obtener
        Try
            odDetalleCapacitacion = New d_DetalleCapacitacion
            Return odDetalleCapacitacion.Obtener(oeDetalleCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleCapacitacion As EntidadesWCF.e_DetalleCapacitacion) As Boolean Implements Il_DetalleCapacitacion.Validar
        Try
            With oeDetalleCapacitacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
