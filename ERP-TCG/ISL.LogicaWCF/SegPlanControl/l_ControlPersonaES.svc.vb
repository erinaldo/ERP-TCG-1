Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ControlPersonaES
    Implements Il_ControlPersonaES

    Dim odControlPersonaES As New d_ControlPersonaES

    Public Function Eliminar(ByVal oeControlPersonaES As EntidadesWCF.e_ControlPersonaES) As Boolean Implements Il_ControlPersonaES.Eliminar
        Try
            Return odControlPersonaES.Eliminar(oeControlPersonaES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlPersonaES As EntidadesWCF.e_ControlPersonaES) As Boolean Implements Il_ControlPersonaES.Guardar
        Try
            If Validar(oeControlPersonaES) Then
                Return odControlPersonaES.Guardar(oeControlPersonaES)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlPersonaES As EntidadesWCF.e_ControlPersonaES) As System.Collections.Generic.List(Of EntidadesWCF.e_ControlPersonaES) Implements Il_ControlPersonaES.Listar
        Try
            Return odControlPersonaES.Listar(oeControlPersonaES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeControlPersonaES As EntidadesWCF.e_ControlPersonaES) As EntidadesWCF.e_ControlPersonaES Implements Il_ControlPersonaES.Obtener
        Try
            Return odControlPersonaES.Obtener(oeControlPersonaES)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeControlPersonaES As EntidadesWCF.e_ControlPersonaES) As Boolean Implements Il_ControlPersonaES.Validar
        Try
            With oeControlPersonaES
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
