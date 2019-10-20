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
Public Class l_RegistroConformidadOT
    Implements Il_RegistroConformidadOT

    Dim odRegistroConformidadOT As New d_RegistroConformidadOT

    Public Function Eliminar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean Implements Il_RegistroConformidadOT.Eliminar
        Try
            Return odRegistroConformidadOT.Eliminar(oeRegistroConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean Implements Il_RegistroConformidadOT.Guardar
        Try
            If Validar(oeRegistroConformidadOT) Then
                Return odRegistroConformidadOT.Guardar(oeRegistroConformidadOT)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As System.Collections.Generic.List(Of e_RegistroConformidadOT) Implements Il_RegistroConformidadOT.Listar
        Try
            Return odRegistroConformidadOT.Listar(oeRegistroConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As e_RegistroConformidadOT Implements Il_RegistroConformidadOT.Obtener
        Try
            Return odRegistroConformidadOT.Obtener(oeRegistroConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean Implements Il_RegistroConformidadOT.Validar
        Try
            With oeRegistroConformidadOT
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
