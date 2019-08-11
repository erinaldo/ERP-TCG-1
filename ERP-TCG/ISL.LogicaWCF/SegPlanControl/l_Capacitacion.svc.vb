Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_Capacitacion
    Implements Il_Capacitacion

    Dim odCapacitacion As d_Capacitacion

    Public Function Eliminar(oeCapacitacion As EntidadesWCF.e_Capacitacion) As Boolean Implements Il_Capacitacion.Eliminar
        Try
            odCapacitacion = New d_Capacitacion
            Return odCapacitacion.Eliminar(oeCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeCapacitacion As EntidadesWCF.e_Capacitacion) As Boolean Implements Il_Capacitacion.Guardar
        Try
            odCapacitacion = New d_Capacitacion
            If Validar(oeCapacitacion) Then
                Return odCapacitacion.Guardar(oeCapacitacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeCapacitacion As EntidadesWCF.e_Capacitacion) As List(Of EntidadesWCF.e_Capacitacion) Implements Il_Capacitacion.Listar
        Try
            odCapacitacion = New d_Capacitacion
            Return odCapacitacion.Listar(oeCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeCapacitacion As EntidadesWCF.e_Capacitacion) As EntidadesWCF.e_Capacitacion Implements Il_Capacitacion.Obtener
        Try
            odCapacitacion = New d_Capacitacion
            Return odCapacitacion.Obtener(oeCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeCapacitacion As EntidadesWCF.e_Capacitacion) As Boolean Implements Il_Capacitacion.Validar
        Try
            With oeCapacitacion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
