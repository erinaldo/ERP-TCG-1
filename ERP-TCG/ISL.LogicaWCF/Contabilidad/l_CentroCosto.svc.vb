Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CentroCosto
    Implements Il_CentroCosto

    Dim odCentroCosto As New d_CentroCosto
    Dim l_FuncionesGenerales As New l_FuncionesGenerales
    Dim odCentroCostoUbicaciones As New d_CentroCostoUbicaciones

    Public Function ComboGrilla(ByVal oeCentroCosto As EntidadesWCF.e_CentroCosto) As Object Implements Il_CentroCosto.ComboGrilla
        Try
            Return odCentroCosto.ComboGrilla(oeCentroCosto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCentroCosto As EntidadesWCF.e_CentroCosto) As Boolean Implements Il_CentroCosto.Eliminar
        Try
            Return odCentroCosto.Eliminar(oeCentroCosto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCentroCosto As EntidadesWCF.e_CentroCosto) As Boolean Implements Il_CentroCosto.Guardar
        Try
            If Validar(oeCentroCosto) Then
                Return odCentroCosto.Guardar(oeCentroCosto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCentroCosto As EntidadesWCF.e_CentroCosto) As System.Collections.Generic.List(Of EntidadesWCF.e_CentroCosto) Implements Il_CentroCosto.Listar
        Try
            Return odCentroCosto.Listar(oeCentroCosto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCentroCosto As EntidadesWCF.e_CentroCosto) As EntidadesWCF.e_CentroCosto Implements Il_CentroCosto.Obtener
        Try
            Return odCentroCosto.Obtener(oeCentroCosto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCentroCosto As EntidadesWCF.e_CentroCosto) As Boolean Implements Il_CentroCosto.Validar
        Try
            With oeCentroCosto
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarUbicaciones(ByVal oeCentroCostoUbicaciones As EntidadesWCF.e_CentroCostoUbicaciones) As Boolean Implements Il_CentroCosto.EliminarUbicaciones
        Try
            Return odCentroCostoUbicaciones.Eliminar(oeCentroCostoUbicaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarUbicaciones(ByVal oeCentroCostoUbicaciones As EntidadesWCF.e_CentroCostoUbicaciones) As Boolean Implements Il_CentroCosto.GuardarUbicaciones
        Try
            Return odCentroCostoUbicaciones.Guardar(oeCentroCostoUbicaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarUbicaciones(ByVal oeCentroCostoUbicaciones As EntidadesWCF.e_CentroCostoUbicaciones) As System.Collections.Generic.List(Of EntidadesWCF.e_CentroCostoUbicaciones) Implements Il_CentroCosto.ListarUbicaciones
        Try
            Return odCentroCostoUbicaciones.Listar(oeCentroCostoUbicaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerUbicaciones(ByVal oeCentroCostoUbicaciones As EntidadesWCF.e_CentroCostoUbicaciones) As EntidadesWCF.e_CentroCostoUbicaciones Implements Il_CentroCosto.ObtenerUbicaciones
        Try
            Return odCentroCostoUbicaciones.Obtener(oeCentroCostoUbicaciones)
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
