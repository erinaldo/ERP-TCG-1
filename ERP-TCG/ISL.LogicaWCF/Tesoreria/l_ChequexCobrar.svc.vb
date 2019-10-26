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
Public Class l_ChequexCobrar
    Implements Il_ChequexCobrar

    Dim odChequexCobrar As New d_ChequexCobrar
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean Implements Il_ChequexCobrar.Eliminar
        Try
            Return odChequexCobrar.Eliminar(oeChequexCobrar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean Implements Il_ChequexCobrar.Guardar
        Try
            If Validar(oeChequexCobrar) Then
                Return odChequexCobrar.Guardar(oeChequexCobrar)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeChequexCobrar As e_ChequexCobrar) As System.Collections.Generic.List(Of e_ChequexCobrar) Implements Il_ChequexCobrar.Listar
        Try
            Return odChequexCobrar.Listar(oeChequexCobrar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeChequexCobrar As e_ChequexCobrar) As e_ChequexCobrar Implements Il_ChequexCobrar.Obtener
        Try
            Return odChequexCobrar.Obtener(oeChequexCobrar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeChequexCobrar As e_ChequexCobrar) As Boolean Implements Il_ChequexCobrar.Validar
        Try
            With oeChequexCobrar
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdBanco, "No ha ingresado el Banco")
                l_FuncionesGenerales.ValidarCampoNoNulo(.NroCheque, "No ha ingresado Nro de Cheque")
                l_FuncionesGenerales.ValidarCampoNoNulo(.TipoOperacion, "No ha ingresado Tipo Operacion")
                'Validación que impide grabar cheques sin monto 
                l_FuncionesGenerales.ValidarNumero(.Monto, "Ingrese un Monto")
                If .Cobrado Then
                    If .FechaCobro = #1/1/1901# Then Throw New Exception("Ingrese Fecha de Cobro")
                    If .FechaCobro < .Fecha Then Throw New Exception("La Fecha de Cobro debe ser igual o mayor a la Fecha de Cheque")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajadorCobro, "No ha ingresado el Trabajador que cobra el cheque")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
