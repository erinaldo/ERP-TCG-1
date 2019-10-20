'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_Capacitacion
    Implements Il_Capacitacion

    Dim odCapacitacion As New d_Capacitacion

    Public Function Eliminar(oeCapacitacion As e_Capacitacion) As Boolean Implements Il_Capacitacion.Eliminar
        Try
            odCapacitacion = New d_Capacitacion
            Return odCapacitacion.Eliminar(oeCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeCapacitacion As e_Capacitacion) As Boolean Implements Il_Capacitacion.Guardar
        Try
            odCapacitacion = New d_Capacitacion
            If Validar(oeCapacitacion) Then
                Return odCapacitacion.Guardar(oeCapacitacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeCapacitacion As e_Capacitacion) As List(Of e_Capacitacion) Implements Il_Capacitacion.Listar
        Try
            odCapacitacion = New d_Capacitacion
            Return odCapacitacion.Listar(oeCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeCapacitacion As e_Capacitacion) As e_Capacitacion Implements Il_Capacitacion.Obtener
        Try
            odCapacitacion = New d_Capacitacion
            Return odCapacitacion.Obtener(oeCapacitacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeCapacitacion As e_Capacitacion) As Boolean Implements Il_Capacitacion.Validar
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
