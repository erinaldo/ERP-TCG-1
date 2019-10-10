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
Public Class l_RegistroInventario
    Implements Il_RegistroInventario

    Dim odRegistroInventario As New d_RegistroInventario

    Public Function Eliminar(ByVal oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As Boolean Implements Il_RegistroInventario.Eliminar
        Try
            Return odRegistroInventario.Eliminar(oeRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal lstRegistroInventario As System.Collections.Generic.List(Of EntidadesWCF.e_RegistroInventario)) As Boolean Implements Il_RegistroInventario.Guardar
        Try
            Return odRegistroInventario.AjusarKardex(lstRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As System.Collections.Generic.List(Of EntidadesWCF.e_RegistroInventario) Implements Il_RegistroInventario.Listar
        Try
            Return odRegistroInventario.Listar(oeRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarIngresosSalidas(ByVal oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As System.Data.DataSet Implements Il_RegistroInventario.ListarIngresosSalidas
        Try
            Return odRegistroInventario.ListarIngresosSalidas(oeRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarSOrden(oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As System.Collections.Generic.List(Of EntidadesWCF.e_RegistroInventario) Implements Il_RegistroInventario.ListarSOrden
        Try
            Return odRegistroInventario.ListarRegistro(oeRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarStock(ByVal oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As System.Data.DataSet Implements Il_RegistroInventario.ListarStock
        Try
            Return odRegistroInventario.ListarStock(oeRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As EntidadesWCF.e_RegistroInventario Implements Il_RegistroInventario.Obtener
        Try
            Return odRegistroInventario.Obtener(oeRegistroInventario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRegistroInventario As EntidadesWCF.e_RegistroInventario) As Boolean Implements Il_RegistroInventario.Validar
        Try
            With oeRegistroInventario
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Rectificar(oeRegistroInventario As e_RegistroInventario) As Boolean Implements Il_RegistroInventario.Rectificar
        Try
            Return odRegistroInventario.GuardarRegistroInventario(oeRegistroInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerRegInv(oeRegistroInventario As e_RegistroInventario) As e_RegistroInventario Implements Il_RegistroInventario.ObtenerRegInv
        Try
            Return odRegistroInventario.ObtenerRegInv(oeRegistroInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
