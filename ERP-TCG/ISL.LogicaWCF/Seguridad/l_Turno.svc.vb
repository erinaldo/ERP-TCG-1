Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Turno
    Implements Il_Turno
    Dim odTurno As New d_Turno
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTurno As EntidadesWCF.e_Turno) As Boolean Implements Il_Turno.Eliminar
        Try
            Return odTurno.Eliminar(oeTurno)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTurno As EntidadesWCF.e_Turno) As Boolean Implements Il_Turno.Guardar
        Try
            If Validar(oeTurno) Then
                Return odTurno.Guardar(oeTurno)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTurno As EntidadesWCF.e_Turno) As System.Collections.Generic.List(Of EntidadesWCF.e_Turno) Implements Il_Turno.Listar
        Try
            Return odTurno.Listar(oeTurno)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTurno As EntidadesWCF.e_Turno) As EntidadesWCF.e_Turno Implements Il_Turno.Obtener
        Try
            Return odTurno.Obtener(oeTurno)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTurno As EntidadesWCF.e_Turno) As Boolean Implements Il_Turno.Validar
        Try
            With oeTurno
                l_FuncionesGenerales.ValidarCampoNoNulo(.Dia, "No ha ingresado día")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Turno, "No ha ingresado turno")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
