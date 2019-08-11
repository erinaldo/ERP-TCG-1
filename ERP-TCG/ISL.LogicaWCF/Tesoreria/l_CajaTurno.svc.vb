Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CajaTurno
    Implements Il_CajaTurno

    Dim odCajaTurno As New d_CajaTurno

    Public Function Eliminar(ByVal oeCajaTurno As EntidadesWCF.e_CajaTurno) As Boolean Implements Il_CajaTurno.Eliminar
        Try
            Return odCajaTurno.Eliminar(oeCajaTurno)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCajaTurno As EntidadesWCF.e_CajaTurno) As Boolean Implements Il_CajaTurno.Guardar
        Try
            If Validar(oeCajaTurno) Then
                Return odCajaTurno.Guardar(oeCajaTurno)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCajaTurno As EntidadesWCF.e_CajaTurno) As System.Collections.Generic.List(Of EntidadesWCF.e_CajaTurno) Implements Il_CajaTurno.Listar
        Try
            Return odCajaTurno.Listar(oeCajaTurno)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCajaTurno As EntidadesWCF.e_CajaTurno) As EntidadesWCF.e_CajaTurno Implements Il_CajaTurno.Obtener
        Try
            Return odCajaTurno.Obtener(oeCajaTurno)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCajaTurno As EntidadesWCF.e_CajaTurno) As Boolean Implements Il_CajaTurno.Validar
        Try
            With oeCajaTurno
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
