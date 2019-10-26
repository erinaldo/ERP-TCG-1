'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_UnidadMedida
    Implements Il_UnidadMedida

    Private odUnidadMedida As New d_UnidadMedida
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(ByVal oeUnidadMedida As e_UnidadMedida) As Object Implements Il_UnidadMedida.ComboGrilla
        Try
            Return odUnidadMedida.ComboGrilla(oeUnidadMedida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean Implements Il_UnidadMedida.Eliminar
        Try
            Return odUnidadMedida.Eliminar(oeUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean Implements Il_UnidadMedida.Guardar
        Try
            If Validar(oeUnidadMedida) Then
                Return odUnidadMedida.Guardar(oeUnidadMedida)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeUnidadMedida As e_UnidadMedida) As System.Collections.Generic.List(Of e_UnidadMedida) Implements Il_UnidadMedida.Listar
        Try
            Return odUnidadMedida.Listar(oeUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarD(ByVal oeUnidadMedida As e_UnidadMedida) As System.Data.DataSet Implements Il_UnidadMedida.ListarD
        Try
            Return odUnidadMedida.ListarD(oeUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeUnidadMedida As e_UnidadMedida) As e_UnidadMedida Implements Il_UnidadMedida.Obtener
        Try
            Return odUnidadMedida.Obtener(oeUnidadMedida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeUnidadMedida As e_UnidadMedida) As Boolean Implements Il_UnidadMedida.Validar
        Try
            With oeUnidadMedida
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoUnidadMedida, "Debe ingresar el tipo de unidad de medida")
                ValidarDuplicado(.Id, .Nombre, "codigo")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Abreviatura, "abreviatura")
                ValidarTipoUnidadMedida(.IdTipoUnidadMedida)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_UnidadMedida.ValidarDuplicado
        Dim oeUnidadMedida As New e_UnidadMedida
        Try
            If valor = "" Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeUnidadMedida.Codigo = valor
                    Case "nombre"
                        oeUnidadMedida.Nombre = valor
                    Case "abreviatura"
                        oeUnidadMedida.Abreviatura = valor
                End Select
                oeUnidadMedida = odUnidadMedida.Obtener(oeUnidadMedida)
                If Not oeUnidadMedida.Id Is Nothing And oeUnidadMedida.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTipoUnidadMedida(ByVal id As String) As Boolean Implements Il_UnidadMedida.ValidarTipoUnidadMedida
        Try
            Dim oeTipoUnidadMedida As New e_TipoUnidadMedida
            Dim odTipoUnidadMedida As New d_TipoUnidadMedida
            oeTipoUnidadMedida.Id = id
            oeTipoUnidadMedida = odTipoUnidadMedida.Obtener(oeTipoUnidadMedida)
            If oeTipoUnidadMedida.Id = "" Then
                Throw New Exception("Tipo de Unidad de Medida seleccionada no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
