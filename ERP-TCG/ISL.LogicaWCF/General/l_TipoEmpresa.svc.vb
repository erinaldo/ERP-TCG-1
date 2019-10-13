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
Public Class l_TipoEmpresa
    Implements Il_TipoEmpresa

    Dim odTipoEmpresa As New d_TipoEmpresa
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoEmpresa As EntidadesWCF.e_TipoEmpresa) As Boolean Implements Il_TipoEmpresa.Eliminar
        Try
            Return odTipoEmpresa.Eliminar(oeTipoEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoEmpresa As EntidadesWCF.e_TipoEmpresa) As Boolean Implements Il_TipoEmpresa.Guardar
        Try
            If Validar(oeTipoEmpresa) Then
                Return odTipoEmpresa.Guardar(oeTipoEmpresa)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoEmpresa As EntidadesWCF.e_TipoEmpresa) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoEmpresa) Implements Il_TipoEmpresa.Listar
        Try
            Return odTipoEmpresa.Listar(oeTipoEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoEmpresa As EntidadesWCF.e_TipoEmpresa) As EntidadesWCF.e_TipoEmpresa Implements Il_TipoEmpresa.Obtener
        Try
            Return odTipoEmpresa.Obtener(oeTipoEmpresa)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoEmpresa As EntidadesWCF.e_TipoEmpresa) As Boolean Implements Il_TipoEmpresa.Validar
        Try
            With oeTipoEmpresa
                '---------VALIDARRRRRRRRRR-------------
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar el Codigo del Tipo Empresa")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el Nombre del Tipo Empresa")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
