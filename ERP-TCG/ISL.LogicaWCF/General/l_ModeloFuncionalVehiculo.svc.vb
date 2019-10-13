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
Public Class l_ModeloFuncionalVehiculo
    Implements Il_ModeloFuncionalVehiculo

    Dim odModeloFuncionalVehiculo As New d_ModeloFuncionalVehiculo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeModeloFuncionalVehiculo As EntidadesWCF.e_ModeloFuncionalVehiculo) As Boolean Implements Il_ModeloFuncionalVehiculo.Eliminar
        Try
            Return odModeloFuncionalVehiculo.Eliminar(oeModeloFuncionalVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeModeloFuncionalVehiculo As EntidadesWCF.e_ModeloFuncionalVehiculo) As Boolean Implements Il_ModeloFuncionalVehiculo.Guardar
        Try
            If Validar(oeModeloFuncionalVehiculo) Then
                Return odModeloFuncionalVehiculo.Guardar(oeModeloFuncionalVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeModeloFuncionalVehiculo As EntidadesWCF.e_ModeloFuncionalVehiculo) As System.Collections.Generic.List(Of EntidadesWCF.e_ModeloFuncionalVehiculo) Implements Il_ModeloFuncionalVehiculo.Listar
        Try
            Return odModeloFuncionalVehiculo.Listar(oeModeloFuncionalVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeModeloFuncionalVehiculo As EntidadesWCF.e_ModeloFuncionalVehiculo) As EntidadesWCF.e_ModeloFuncionalVehiculo Implements Il_ModeloFuncionalVehiculo.Obtener
        Try
            Return odModeloFuncionalVehiculo.Obtener(oeModeloFuncionalVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeModeloFuncionalVehiculo As EntidadesWCF.e_ModeloFuncionalVehiculo) As Boolean Implements Il_ModeloFuncionalVehiculo.Validar
        Try
            With oeModeloFuncionalVehiculo
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
