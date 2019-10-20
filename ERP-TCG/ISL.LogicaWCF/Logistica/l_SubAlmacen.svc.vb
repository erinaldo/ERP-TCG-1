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
Public Class l_SubAlmacen
    Implements Il_SubAlmacen

    Dim odSubAlmacen As New d_SubAlmacen

    Public Function ComboGrilla(ByVal oeSubAlmacen As e_SubAlmacen) As Object Implements Il_SubAlmacen.ComboGrilla
        Try
            Return odSubAlmacen.ComboGrilla(oeSubAlmacen)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSubAlmacen As e_SubAlmacen) As Boolean Implements Il_SubAlmacen.Guardar
        Try
            If Validar(oeSubAlmacen) Then
                Return odSubAlmacen.Guardar(oeSubAlmacen)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar_SubAlmacen(ByVal oeSubAlmacen As e_SubAlmacen) As System.Collections.Generic.List(Of e_SubAlmacen) Implements Il_SubAlmacen.Listar_SubAlmacen
        Try
            Return odSubAlmacen.Listar_(oeSubAlmacen)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeSubAlmacen As e_SubAlmacen) As List(Of e_SubAlmacen) Implements Il_SubAlmacen.Listar
        Try
            Return odSubAlmacen.Listar(oeSubAlmacen)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeSubAlmacen As e_SubAlmacen) As e_SubAlmacen Implements Il_SubAlmacen.Obtener
        Try
            Return odSubAlmacen.Obtener(oeSubAlmacen)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeSubAlmacen As e_SubAlmacen) As Boolean Implements Il_SubAlmacen.Validar
        Try
            With oeSubAlmacen
                '---------VALIDARRRRRRRRRR-------------???
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
