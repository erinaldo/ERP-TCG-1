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
Public Class l_MenuActividad
    Implements Il_MenuActividad
    Dim odMenuActividad As New d_MenuActividad
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeMenuActividad As e_MenuActividad) As Boolean Implements Il_MenuActividad.Eliminar
        Try
            Return odMenuActividad.Eliminar(oeMenuActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMenuActividad As e_MenuActividad) As Boolean Implements Il_MenuActividad.Guardar
        Try
            If Validar(oeMenuActividad) Then
                Return odMenuActividad.Guardar(oeMenuActividad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuActividad As e_MenuActividad) As System.Collections.Generic.List(Of e_MenuActividad) Implements Il_MenuActividad.Listar
        Try
            Return odMenuActividad.Listar(oeMenuActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuActividad As e_MenuActividad) As e_MenuActividad Implements Il_MenuActividad.Obtener
        Try
            Return odMenuActividad.Obtener(oeMenuActividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMenuActividad As e_MenuActividad) As Boolean Implements Il_MenuActividad.Validar
        Try
            With oeMenuActividad
                ValidarCodigo(.Id, .Codigo)
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre ")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarCodigo(ByVal Id As String, ByVal Codigo As String) As Boolean Implements Il_MenuActividad.ValidarCodigo
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(Codigo, "No ha Ingresado Codigo ")
            Dim oeMenuActividad As New e_MenuActividad
            oeMenuActividad.Codigo = Codigo
            oeMenuActividad.Activo = True
            oeMenuActividad = odMenuActividad.Obtener(oeMenuActividad)
            If oeMenuActividad.Id <> "" Then
                If Id = "" OrElse oeMenuActividad.Id <> Id Then
                    Throw New Exception("Ya existe: " & Codigo)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
