Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RegimenSalud
    Implements Il_RegimenSalud

    Private odRegimenSalud As New d_RegimenSalud
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeRegimenSalud As EntidadesWCF.e_RegimenSalud) As Boolean Implements Il_RegimenSalud.Eliminar
        Try
            Return odRegimenSalud.Eliminar(oeRegimenSalud)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeRegimenSalud As EntidadesWCF.e_RegimenSalud) As Boolean Implements Il_RegimenSalud.Guardar
        Try
            If Validar(oeRegimenSalud) Then
                Return odRegimenSalud.Guardar(oeRegimenSalud)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeRegimenSalud As EntidadesWCF.e_RegimenSalud) As List(Of EntidadesWCF.e_RegimenSalud) Implements Il_RegimenSalud.Listar
        Try
            Return odRegimenSalud.Listar(oeRegimenSalud)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeRegimenSalud As EntidadesWCF.e_RegimenSalud) As EntidadesWCF.e_RegimenSalud Implements Il_RegimenSalud.Obtener
        Try
            Return odRegimenSalud.Obtener(oeRegimenSalud)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeRegimenSalud As EntidadesWCF.e_RegimenSalud) As Boolean Implements Il_RegimenSalud.Validar
        Try
            With oeRegimenSalud
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
