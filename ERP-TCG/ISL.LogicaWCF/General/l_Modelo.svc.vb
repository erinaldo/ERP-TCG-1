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
Public Class l_Modelo
    Implements Il_Modelo

    Dim oeModelo As e_Modelo
    Dim odModeloVehiculo As d_Modelo
    Dim l_FuncionesGenerales As l_FuncionesGenerales

    Public Function ComboGrilla(ByVal loModelo As List(Of e_Modelo)) As Object Implements Il_Modelo.ComboGrilla
        Try
            odModeloVehiculo = New d_Modelo
            Return odModeloVehiculo.ComboGrilla(loModelo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeModeloVehiculo As e_Modelo) As Boolean Implements Il_Modelo.Eliminar
        Try
            odModeloVehiculo = New d_Modelo
            Return odModeloVehiculo.Eliminar(oeModeloVehiculo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeModeloVehiculo As e_Modelo) As Boolean Implements Il_Modelo.Guardar
        Try
            odModeloVehiculo = New d_Modelo
            If Validar(oeModeloVehiculo) Then
                Return odModeloVehiculo.Guardar(oeModeloVehiculo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeModeloVehiculo As e_Modelo) As System.Collections.Generic.List(Of e_Modelo) Implements Il_Modelo.Listar
        Try
            odModeloVehiculo = New d_Modelo
            Return odModeloVehiculo.Listar(oeModeloVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeModeloVehiculo As e_Modelo) As e_Modelo Implements Il_Modelo.Obtener
        Try
            odModeloVehiculo = New d_Modelo
            Return odModeloVehiculo.Obtener(oeModeloVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeModeloVehiculo As e_Modelo) As Boolean Implements Il_Modelo.Validar
        Try
            l_FuncionesGenerales = New l_FuncionesGenerales
            If oeModeloVehiculo.TipoOperacion <> "1" Then
                With oeModeloVehiculo
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                    ValidarDuplicado(oeModeloVehiculo)
                End With
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Modelo As e_Modelo) As Boolean Implements Il_Modelo.ValidarDuplicado
        Try
            odModeloVehiculo = New d_Modelo
            oeModelo = New e_Modelo
            oeModelo.Nombre = ls_Modelo.Nombre.Trim
            oeModelo = odModeloVehiculo.Obtener(oeModelo)
            If oeModelo.Id <> "" Then
                If ls_Modelo.Id.Trim = "" OrElse (oeModelo.Id <> ls_Modelo.Id And oeModelo.IdMarca = ls_Modelo.IdMarca) Then
                    Throw New Exception("Ya existe: " & ls_Modelo.Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
