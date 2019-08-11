Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AccidentePersona
    Implements Il_AccidentePersona
    Dim odAccidentePersona As New d_AccidentePersona
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function EliminacionDefinitiva(ByVal oeAccidentePersona As EntidadesWCF.e_AccidentePersona) As Boolean Implements Il_AccidentePersona.EliminacionDefinitiva
        Try
            Return odAccidentePersona.EliminacionDefinitiva(oeAccidentePersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidentePersona As EntidadesWCF.e_AccidentePersona) As Boolean Implements Il_AccidentePersona.Eliminar
        Try
            Return odAccidentePersona.Eliminar(oeAccidentePersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAccidentePersona As EntidadesWCF.e_AccidentePersona) As Boolean Implements Il_AccidentePersona.Guardar
        Try
            If Validar(oeAccidentePersona) Then
                Return odAccidentePersona.Guardar(oeAccidentePersona)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidentePersona As EntidadesWCF.e_AccidentePersona) As System.Collections.Generic.List(Of EntidadesWCF.e_AccidentePersona) Implements Il_AccidentePersona.Listar
        Try
            Return odAccidentePersona.Listar(oeAccidentePersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAccidentePersona As EntidadesWCF.e_AccidentePersona) As EntidadesWCF.e_AccidentePersona Implements Il_AccidentePersona.Obtener
        Try
            Return odAccidentePersona.Obtener(oeAccidentePersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAccidentePersona As EntidadesWCF.e_AccidentePersona) As Boolean Implements Il_AccidentePersona.Validar
        Try
            With oeAccidentePersona
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdAccidente, "Debe especificarse a qué Accidente está vinculada la persona")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "Debe especificar qué persona y/o trabajador está relacionada al accidente")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
