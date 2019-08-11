Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Seguimiento
    Implements Il_Seguimiento

    Dim odSeguimiento As New d_Seguimiento

    Public Function Eliminar(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As Boolean Implements Il_Seguimiento.Eliminar
        Try
            Return odSeguimiento.Eliminar(oeSeguimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As Boolean Implements Il_Seguimiento.Guardar
        Try
            'If Validar(oeSeguimiento) Then
            Return odSeguimiento.Guardar(oeSeguimiento)
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar1(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As Boolean Implements Il_Seguimiento.Guardar1
        Try
            'If Validar(oeSeguimiento) Then
            Return odSeguimiento.Guardar1(oeSeguimiento)
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_Seguimiento) Implements Il_Seguimiento.Listar
        Try
            Return odSeguimiento.Listar(oeSeguimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_Seguimiento) Implements Il_Seguimiento.Listar2
        Try
            Return odSeguimiento.Listar2(oeSeguimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As EntidadesWCF.e_Seguimiento Implements Il_Seguimiento.Obtener
        Try
            Return odSeguimiento.Obtener(oeSeguimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerRango(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As EntidadesWCF.e_Seguimiento Implements Il_Seguimiento.ObtenerRango
        Try
            Return odSeguimiento.ObtenerSeguimientoRango(oeSeguimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeSeguimiento As EntidadesWCF.e_Seguimiento) As Boolean Implements Il_Seguimiento.Validar
        Try
            With oeSeguimiento
                For Each operacion As e_OperacionDetalle In oeSeguimiento.OperacionDetalle
                    If operacion.Flete = 0 Then Throw New Exception("El monto del flete no puede ser 0")
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarImportar(ByVal listaViaje As List(Of EntidadesWCF.e_Viaje)) As Boolean Implements Il_Seguimiento.GuardarImportar
        Try
            Return odSeguimiento.GuardarImportar(listaViaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
