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
Public Class l_Area
    Implements Il_Area

    Dim odArea As New d_Area
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeArea As e_Area) As Boolean Implements Il_Area.Eliminar
        Try
            Return odArea.Eliminar(oeArea)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeArea As e_Area) As Boolean Implements Il_Area.Guardar
        Try
            If Validar(oeArea) Then
                Return odArea.Guardar(oeArea)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeArea As e_Area) As System.Collections.Generic.List(Of e_Area) Implements Il_Area.Listar
        Try
            Return odArea.Listar(oeArea)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeArea As e_Area) As e_Area Implements Il_Area.Obtener
        Try
            Return odArea.Obtener(oeArea)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeArea As e_Area) As Boolean Implements Il_Area.Validar
        Try
            With oeArea
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
