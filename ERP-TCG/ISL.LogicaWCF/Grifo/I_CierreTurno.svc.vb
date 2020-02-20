﻿Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

<DataContract(), Serializable()>
Public Class l_CierreTurno
    Implements Il_CierreTurno
    Private odCierreTurno As New d_CierreTurno
    Private odCierreTurno_Detalle As New d_CierreTurno_Detalle

    Public Function Obtener(ByVal oeCierreTurno As e_CierreTurno) As e_CierreTurno Implements Il_CierreTurno.Obtener

        Try
            oeCierreTurno = odCierreTurno.Obtener(oeCierreTurno)
            oeCierreTurno.Detalles = odCierreTurno_Detalle.Listar(New e_CierreTurno_Detalle With {.TipoOperacion = "", .IdCierreTurno = oeCierreTurno.Id})
            Return oeCierreTurno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function dt_CierreTurno_Impresion(ByVal Item As e_CierreTurno) As DataTable
        Try
            Return odCierreTurno.dt_CierreTurno_Impresion(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function dt_CierreTurnoDetalle_Impresion(ByVal Item As e_CierreTurno_Detalle) As DataTable
        Try
            Return odCierreTurno.dt_CierreTurnoDetalle_Impresion(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCierreTurno As e_CierreTurno) As List(Of e_CierreTurno) Implements Il_CierreTurno.Listar
        Try
            Return odCierreTurno.Listar(oeCierreTurno)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCierreTurno As e_CierreTurno) As e_CierreTurno Implements Il_CierreTurno.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeCierreTurno) Then
                oeCierreTurno = odCierreTurno.Guardar(oeCierreTurno)
            End If
            Return oeCierreTurno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreTurno As e_CierreTurno) As Boolean Implements Il_CierreTurno.Eliminar
        Try
            Return odCierreTurno.Eliminar(oeCierreTurno)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function Validar(ByVal oeCierreTurno As e_CierreTurno) As Boolean
        Try
            With oeCierreTurno
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
