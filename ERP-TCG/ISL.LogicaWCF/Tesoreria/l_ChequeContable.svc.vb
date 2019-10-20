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
Public Class l_ChequeContable
    Implements Il_ChequeContable

    Dim odChequeContable As New d_ChequeContable
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeChequeContable As e_ChequeContable) As Boolean Implements Il_ChequeContable.Eliminar
        Try
            Return odChequeContable.Eliminar(oeChequeContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeChequeContable As e_ChequeContable) As Boolean Implements Il_ChequeContable.Guardar
        Try
            If Validar(oeChequeContable) Then
                Return odChequeContable.Guardar(oeChequeContable)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeChequeContable As e_ChequeContable) As System.Collections.Generic.List(Of e_ChequeContable) Implements Il_ChequeContable.Listar
        Try
            Return odChequeContable.Listar(oeChequeContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeChequeContable As e_ChequeContable) As e_ChequeContable Implements Il_ChequeContable.Obtener
        Try
            Return odChequeContable.Obtener(oeChequeContable)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeChequeContable As e_ChequeContable) As Boolean Implements Il_ChequeContable.Validar
        Try
            With oeChequeContable
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdBanco, "Seleccione Banco")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCuentaBancaria, "Seleccione Cuenta Bancaria")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NumeroChequera, "Ingrese Numero de Chequera")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Fecha, "Ingrese Fecha")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NumeroInicial, "Ingrese Numero Inicial")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NumeroFinal, "Ingrese Numero Final")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NumeroEmitir, "Ingrese Numero a Emitir")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
