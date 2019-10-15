'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_ChequesControl
    Implements Il_ChequesControl

    Dim odChequesControl As New d_ChequesControl

    Public Function Obtener(ByVal oeChequesControl As e_ChequesControl) As e_ChequesControl Implements Il_ChequesControl.Obtener
        Try
            Return odChequesControl.Obtener(oeChequesControl)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeChequesControl As e_ChequesControl) As List(Of e_ChequesControl) Implements Il_ChequesControl.Listar
        Try
            Return odChequesControl.Listar(oeChequesControl)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeChequesControl As e_ChequesControl) As Boolean Implements Il_ChequesControl.Validar
        Try
            If oeChequesControl.TipoOperacion = "I" Then ValidarCuentaBancaria(oeChequesControl.IdCuentaBancaria)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCuentaBancaria(ByVal IdCuentaBancaria As String) As Boolean Implements Il_ChequesControl.ValidarCuentaBancaria
        Try
            Dim oeCheCtr As New e_ChequesControl
            oeCheCtr.TipoOperacion = "2"
            oeCheCtr.IdCuentaBancaria = IdCuentaBancaria
            oeCheCtr = odChequesControl.Obtener(oeCheCtr)
            If oeCheCtr.Id <> "" Then Throw New Exception("CuentaBancaria ya asociada a un Talonario. Verificar")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeChequesControl As e_ChequesControl) As Boolean Implements Il_ChequesControl.Guardar
        Try
            If Validar(oeChequesControl) Then
                Return odChequesControl.Guardar(oeChequesControl)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequesControl As e_ChequesControl) As Boolean Implements Il_ChequesControl.Eliminar
        Try
            Return odChequesControl.Eliminar(oeChequesControl)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
