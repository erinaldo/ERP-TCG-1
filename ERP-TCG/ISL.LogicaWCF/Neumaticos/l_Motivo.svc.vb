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
Public Class l_Motivo
    Implements Il_Motivo

    Dim odMotivo As New d_Motivo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeMotivo As EntidadesWCF.e_Motivo) As Boolean Implements Il_Motivo.Eliminar
        Try
            Return odMotivo.Eliminar(oeMotivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivo As EntidadesWCF.e_Motivo) As Boolean Implements Il_Motivo.Guardar
        Try
            If Validar(oeMotivo) Then
                Return odMotivo.Guardar(oeMotivo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMotivo As EntidadesWCF.e_Motivo) As System.Collections.Generic.List(Of EntidadesWCF.e_Motivo) Implements Il_Motivo.Listar
        Try
            Return odMotivo.Listar(oeMotivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivo As EntidadesWCF.e_Motivo) As EntidadesWCF.e_Motivo Implements Il_Motivo.Obtener
        Try
            Return odMotivo.Obtener(oeMotivo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMotivo As EntidadesWCF.e_Motivo) As Boolean Implements Il_Motivo.Validar
        Try
            With oeMotivo
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre.")
                If .IndAlmacen = False And .IndReencauche = False And .IndReparacion = False And .IndBaja = False Then
                    Throw New Exception("Marque por lo menos un tipo.")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
