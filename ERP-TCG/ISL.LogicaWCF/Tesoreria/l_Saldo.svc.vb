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

<DataContract(), Serializable()> _
Public Class l_Saldo
    Implements Il_Saldo
    Dim odSaldo As New d_Saldo

    Public Function Eliminar(ByVal oeSaldo As e_Saldo) As Boolean Implements Il_Saldo.Eliminar
        Try
            Return odSaldo.Eliminar(oeSaldo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSaldo As e_Saldo) As Boolean Implements Il_Saldo.Guardar
        Try
            If Validar(oeSaldo) Then
                Return odSaldo.Guardar(oeSaldo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSaldo As e_Saldo) As System.Collections.Generic.List(Of e_Saldo) Implements Il_Saldo.Listar
        Try
            Return odSaldo.Listar(oeSaldo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeSaldo As e_Saldo) As e_Saldo Implements Il_Saldo.Obtener
        Try
            Return odSaldo.Obtener(oeSaldo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeSaldo As e_Saldo) As Boolean Implements Il_Saldo.Validar
        Try
            With oeSaldo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
