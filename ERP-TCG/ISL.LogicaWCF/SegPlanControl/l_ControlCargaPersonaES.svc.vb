Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlCargaPersonaES
    Implements Il_ControlCargaPersonaES

    Dim odControlCargaPersonaES As New d_ControlCargaPersonaES

    Public Function Eliminar(ByVal oeControlCargaPersonaES As EntidadesWCF.e_ControlCargaPersonaES) As Boolean Implements Il_ControlCargaPersonaES.Eliminar
        Try
            Return odControlCargaPersonaES.Eliminar(oeControlCargaPersonaES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlCargaPersonaES As EntidadesWCF.e_ControlCargaPersonaES) As Boolean Implements Il_ControlCargaPersonaES.Guardar
        Try
            If Validar(oeControlCargaPersonaES) Then
                Return odControlCargaPersonaES.Guardar(oeControlCargaPersonaES)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlCargaPersonaES As EntidadesWCF.e_ControlCargaPersonaES) As System.Collections.Generic.List(Of EntidadesWCF.e_ControlCargaPersonaES) Implements Il_ControlCargaPersonaES.Listar
        Try
            Return odControlCargaPersonaES.Listar(oeControlCargaPersonaES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlCargaPersonaES As EntidadesWCF.e_ControlCargaPersonaES) As EntidadesWCF.e_ControlCargaPersonaES Implements Il_ControlCargaPersonaES.Obtener
        Try
            Return odControlCargaPersonaES.Obtener(oeControlCargaPersonaES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlCargaPersonaES As EntidadesWCF.e_ControlCargaPersonaES) As Boolean Implements Il_ControlCargaPersonaES.Validar
        Try
            With oeControlCargaPersonaES
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
