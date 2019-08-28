﻿Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: si cambia aquí el nombre de clase "l_CierreCaja", también debe actualizar la referencia a "l_CierreCaja" tanto en Web.config como en el archivo .svc asociado.

Public Class l_CierreCaja
    Implements Il_CierreCaja

    Dim odCierreCaja As New d_CierreCaja

    Public Function Obtener(ByVal oeCierreCaja As e_CierreCaja) As e_CierreCaja Implements Il_CierreCaja.Obtener
        Try
            Return odCierreCaja.Obtener(oeCierreCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCierreCaja As e_CierreCaja) As List(Of e_CierreCaja) Implements Il_CierreCaja.Listar
        Try
            Return odCierreCaja.Listar(oeCierreCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCierreCaja As e_CierreCaja) As Boolean Implements Il_CierreCaja.Validar
        Try
            With oeCierreCaja
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeCierreCaja As e_CierreCaja) As Boolean Implements Il_CierreCaja.Guardar
        Try
            If Validar(oeCierreCaja) Then
                Return odCierreCaja.Guardar(oeCierreCaja)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreCaja As e_CierreCaja) As Boolean Implements Il_CierreCaja.Eliminar
        Try
            Return odCierreCaja.Eliminar(oeCierreCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class