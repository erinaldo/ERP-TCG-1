Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoGastoDetalle
    Implements Il_TipoGastoDetalle
    Dim odTipoGastoDetalle As New d_TipoGastoDetalle
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoGastoDetalle As EntidadesWCF.e_TipoGastoDetalle) As Boolean Implements Il_TipoGastoDetalle.Eliminar
        Try
            Return odTipoGastoDetalle.Eliminar(oeTipoGastoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoGastoDetalle As EntidadesWCF.e_TipoGastoDetalle) As Boolean Implements Il_TipoGastoDetalle.Guardar
        Try
            If Validar(oeTipoGastoDetalle) Then
                Return odTipoGastoDetalle.Guardar(oeTipoGastoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoGastoDetalle As EntidadesWCF.e_TipoGastoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoGastoDetalle) Implements Il_TipoGastoDetalle.Listar
        Try
            Return odTipoGastoDetalle.Listar(oeTipoGastoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoGastoDetalle As EntidadesWCF.e_TipoGastoDetalle) As EntidadesWCF.e_TipoGastoDetalle Implements Il_TipoGastoDetalle.Obtener
        Try
            Return odTipoGastoDetalle.Obtener(oeTipoGastoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoGastoDetalle As EntidadesWCF.e_TipoGastoDetalle) As Boolean Implements Il_TipoGastoDetalle.Validar
        Try
            With oeTipoGastoDetalle
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdFlujoCaja, "Seleccione Flujo Gasto")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
