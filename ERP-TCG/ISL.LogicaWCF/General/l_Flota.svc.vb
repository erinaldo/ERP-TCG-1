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
Public Class l_Flota
    Implements Il_Flota

    Dim odFlota As New d_Flota

    Public Function Eliminar(ByVal oeFlota As e_Flota) As Boolean Implements Il_Flota.Eliminar
        Try
            Return odFlota.Eliminar(oeFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFlota As e_Flota) As Boolean Implements Il_Flota.Guardar
        Try
            If Validar(oeFlota) Then
                Return odFlota.Guardar(oeFlota)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFlota As e_Flota) As System.Collections.Generic.List(Of e_Flota) Implements Il_Flota.Listar
        Try
            Return odFlota.Listar(oeFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeFlota As e_Flota) As e_Flota Implements Il_Flota.Obtener
        Try
            Return odFlota.Obtener(oeFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeFlota As e_Flota) As Boolean Implements Il_Flota.Validar
        Try
            With oeFlota
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaFlota As System.Collections.Generic.List(Of e_Flota)) As Object Implements Il_Flota.ComboGrilla
        Try
            Return odFlota.ComboGrilla(ListaFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
