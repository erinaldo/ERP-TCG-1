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
Public Class l_EntornoTrabajo
    Implements Il_EntornoTrabajo

    Dim odEntornoTrabajo As New d_EntornoTrabajo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeEntornoTrabajo As EntidadesWCF.e_EntornoTrabajo) As Boolean Implements Il_EntornoTrabajo.Eliminar
        Try
            Return odEntornoTrabajo.Eliminar(oeEntornoTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEntornoTrabajo As EntidadesWCF.e_EntornoTrabajo) As Boolean Implements Il_EntornoTrabajo.Guardar
        Try
            If Validar(oeEntornoTrabajo) Then
                Return odEntornoTrabajo.Guardar(oeEntornoTrabajo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEntornoTrabajo As EntidadesWCF.e_EntornoTrabajo) As System.Collections.Generic.List(Of EntidadesWCF.e_EntornoTrabajo) Implements Il_EntornoTrabajo.Listar
        Try
            Return odEntornoTrabajo.Listar(oeEntornoTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEntornoTrabajo As EntidadesWCF.e_EntornoTrabajo) As EntidadesWCF.e_EntornoTrabajo Implements Il_EntornoTrabajo.Obtener
        Try
            Return odEntornoTrabajo.Obtener(oeEntornoTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEntornoTrabajo As EntidadesWCF.e_EntornoTrabajo) As Boolean Implements Il_EntornoTrabajo.Validar
        Try
            With oeEntornoTrabajo
                l_FuncionesGenerales.ValidarCampoNoNulo(oeEntornoTrabajo.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
