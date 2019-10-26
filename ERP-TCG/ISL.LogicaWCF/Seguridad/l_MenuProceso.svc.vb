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
Public Class l_MenuProceso
    Implements Il_MenuProceso
    Dim odProceso As New d_MenuProceso
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeProceso As e_MenuProceso) As Boolean Implements Il_MenuProceso.Eliminar
        Try
            Return odProceso.Eliminar(oeProceso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProceso As e_MenuProceso) As Boolean Implements Il_MenuProceso.Guardar
        Try
            If Validar(oeProceso) Then
                Return odProceso.Guardar(oeProceso)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProceso As e_MenuProceso) As System.Collections.Generic.List(Of e_MenuProceso) Implements Il_MenuProceso.Listar
        Try
            Return odProceso.Listar(oeProceso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String) As System.Collections.Generic.List(Of e_MenuProceso) Implements Il_MenuProceso.ListarMenu
        Try
            Return odProceso.ListarMenu(idUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProceso As e_MenuProceso) As e_MenuProceso Implements Il_MenuProceso.Obtener
        Try
            Return odProceso.Obtener(oeProceso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeProceso As e_MenuProceso) As Boolean Implements Il_MenuProceso.Validar
        Try
            With oeProceso
                l_FuncionesGenerales.ValidarCampoNoNulo(oeProceso.Codigo, "Ingrese Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(oeProceso.Nombre, "Ingrese Nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(oeProceso.Abreviatura, "Ingrese Abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
