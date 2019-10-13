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

<DataContract(), Serializable()> _
Public Class l_DetalleEntornoTrabajo
    Implements Il_DetalleEntornoTrabajo
    Dim odDetalleEntornoTrabajo As New d_DetalleEntornoTrabajo

    Public Function Eliminar(ByVal oeDetalleEntornoTrabajo As EntidadesWCF.e_DetalleEntornoTrabajo) As Boolean Implements Il_DetalleEntornoTrabajo.Eliminar
        Try
            Return odDetalleEntornoTrabajo.Eliminar(oeDetalleEntornoTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleEntornoTrabajo As EntidadesWCF.e_DetalleEntornoTrabajo) As Boolean Implements Il_DetalleEntornoTrabajo.Guardar
        Try
            If Validar(oeDetalleEntornoTrabajo) Then
                Return odDetalleEntornoTrabajo.Guardar(oeDetalleEntornoTrabajo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(ByVal leDetalleEntornoTrabajo As System.Collections.Generic.List(Of EntidadesWCF.e_DetalleEntornoTrabajo)) As Boolean Implements Il_DetalleEntornoTrabajo.GuardarLista
        Try
            For Each oe As e_DetalleEntornoTrabajo In leDetalleEntornoTrabajo
                Guardar(oe)
            Next
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleEntornoTrabajo As EntidadesWCF.e_DetalleEntornoTrabajo) As System.Collections.Generic.List(Of EntidadesWCF.e_DetalleEntornoTrabajo) Implements Il_DetalleEntornoTrabajo.Listar
        Try
            Return odDetalleEntornoTrabajo.Listar(oeDetalleEntornoTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleEntornoTrabajo As EntidadesWCF.e_DetalleEntornoTrabajo) As EntidadesWCF.e_DetalleEntornoTrabajo Implements Il_DetalleEntornoTrabajo.Obtener
        Try
            Return odDetalleEntornoTrabajo.Obtener(oeDetalleEntornoTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleEntornoTrabajo As EntidadesWCF.e_DetalleEntornoTrabajo) As Boolean Implements Il_DetalleEntornoTrabajo.Validar
        Try
            With oeDetalleEntornoTrabajo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
