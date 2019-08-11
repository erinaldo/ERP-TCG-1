Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Moneda
    Implements Il_Moneda

    Dim odMoneda As New d_Moneda

    Public Function ComboGrilla(ByVal ListaMoneda As System.Collections.Generic.List(Of EntidadesWCF.e_Moneda)) As Object Implements Il_Moneda.ComboGrilla
        Try
            Return odMoneda.ComboGrilla(ListaMoneda)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMoneda As EntidadesWCF.e_Moneda) As Boolean Implements Il_Moneda.Eliminar
        Try
            Return odMoneda.Eliminar(oeMoneda)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMoneda As EntidadesWCF.e_Moneda) As Boolean Implements Il_Moneda.Guardar
        Try
            If Validar(oeMoneda) Then
                Return odMoneda.Guardar(oeMoneda)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMoneda As EntidadesWCF.e_Moneda) As System.Collections.Generic.List(Of EntidadesWCF.e_Moneda) Implements Il_Moneda.Listar
        Try
            Return odMoneda.Listar(oeMoneda)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMoneda As EntidadesWCF.e_Moneda) As EntidadesWCF.e_Moneda Implements Il_Moneda.Obtener
        Try
            Return odMoneda.Obtener(oeMoneda)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMoneda As EntidadesWCF.e_Moneda) As Boolean Implements Il_Moneda.Validar
        Try
            With oeMoneda
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
