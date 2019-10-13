'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_VidaNeumatico
    Implements Il_VidaNeumatico

    Dim odVidaNeumatico As New d_VidaNeumatico

    Public Function Eliminar(ByVal oeVidaNeumatico As EntidadesWCF.e_VidaNeumatico) As Boolean Implements Il_VidaNeumatico.Eliminar
        Try
            Return odVidaNeumatico.Eliminar(oeVidaNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeVidaNeumatico As EntidadesWCF.e_VidaNeumatico) As e_VidaNeumatico Implements Il_VidaNeumatico.Guardar
        Try
            If Validar(oeVidaNeumatico) Then
                Return odVidaNeumatico.Guardar(oeVidaNeumatico)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeVidaNeumatico As EntidadesWCF.e_VidaNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_VidaNeumatico) Implements Il_VidaNeumatico.Listar
        Try
            Return odVidaNeumatico.Listar(oeVidaNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeVidaNeumatico As EntidadesWCF.e_VidaNeumatico) As EntidadesWCF.e_VidaNeumatico Implements Il_VidaNeumatico.Obtener
        Try
            Return odVidaNeumatico.Obtener(oeVidaNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeVidaNeumatico As EntidadesWCF.e_VidaNeumatico) As Boolean Implements Il_VidaNeumatico.Validar
        Try
            With oeVidaNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizaKM(oeVidaNeumatico As e_VidaNeumatico) As Boolean Implements Il_VidaNeumatico.ActualizaKM
        Try
            Return odVidaNeumatico.ActualizaKM(oeVidaNeumatico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
