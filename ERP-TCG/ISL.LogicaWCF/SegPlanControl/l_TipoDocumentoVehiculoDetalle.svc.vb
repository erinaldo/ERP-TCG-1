'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_TipoDocumentoVehiculoDetalle
    Implements Il_TipoDocumentoVehiculoDetalle

    Dim odTipoDocumentoVehiculoDetalle As New d_TipoDocumentoVehiculoDetalle

    Public Function Obtener(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As e_TipoDocumentoVehiculoDetalle Implements Il_TipoDocumentoVehiculoDetalle.Obtener
        Try
            Return odTipoDocumentoVehiculoDetalle.Obtener(oeTipoDocumentoVehiculoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As List(Of e_TipoDocumentoVehiculoDetalle) Implements Il_TipoDocumentoVehiculoDetalle.Listar
        Try
            Return odTipoDocumentoVehiculoDetalle.Listar(oeTipoDocumentoVehiculoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean Implements Il_TipoDocumentoVehiculoDetalle.Validar
        Try
            With oeTipoDocumentoVehiculoDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean Implements Il_TipoDocumentoVehiculoDetalle.Guardar
        Try
            If Validar(oeTipoDocumentoVehiculoDetalle) Then
                Return odTipoDocumentoVehiculoDetalle.Guardar(oeTipoDocumentoVehiculoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal Lista As List(Of e_TipoDocumentoVehiculoDetalle)) As Boolean Implements Il_TipoDocumentoVehiculoDetalle.Guardar
        Try
            Return odTipoDocumentoVehiculoDetalle.Guardar(Lista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoDocumentoVehiculoDetalle As e_TipoDocumentoVehiculoDetalle) As Boolean Implements Il_TipoDocumentoVehiculoDetalle.Eliminar
        Try
            Return odTipoDocumentoVehiculoDetalle.Eliminar(oeTipoDocumentoVehiculoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_TipoDocumentoVehiculoDetalle.DoWork
    End Sub

End Class
