﻿'=================================================================================================================
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
Public Class l_MenuGrupo
    Implements Il_MenuGrupo
    Dim odMenuGrupo As New d_MenuGrupo

    Public Function Eliminar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean Implements Il_MenuGrupo.Eliminar
        Try
            Return odMenuGrupo.Eliminar(oeMenuGrupo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean Implements Il_MenuGrupo.Guardar
        Try
            If Validar(oeMenuGrupo) Then
                Return odMenuGrupo.Guardar(oeMenuGrupo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuGrupo As e_MenuGrupo) As System.Collections.Generic.List(Of e_MenuGrupo) Implements Il_MenuGrupo.Listar
        Try
            Return odMenuGrupo.Listar(oeMenuGrupo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuGrupo As e_MenuGrupo) As e_MenuGrupo Implements Il_MenuGrupo.Obtener
        Try
            Return odMenuGrupo.Obtener(oeMenuGrupo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean Implements Il_MenuGrupo.Validar
        Try
            With oeMenuGrupo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
