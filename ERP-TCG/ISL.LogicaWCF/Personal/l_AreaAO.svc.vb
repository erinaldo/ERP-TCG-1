Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AreaAO
    Implements Il_AreaAO

    Dim odAreaAO As New d_AreaAO
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeAreaAO As EntidadesWCF.e_AreaAO) As Boolean Implements Il_AreaAO.Eliminar
        Try
            Return odAreaAO.Eliminar(oeAreaAO)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAreaAO As EntidadesWCF.e_AreaAO) As Boolean Implements Il_AreaAO.Guardar
        Try
            If Validar(oeAreaAO) Then
                Return odAreaAO.Guardar(oeAreaAO)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAreaAO As EntidadesWCF.e_AreaAO) As System.Collections.Generic.List(Of EntidadesWCF.e_AreaAO) Implements Il_AreaAO.Listar
        Try
            Return odAreaAO.Listar(oeAreaAO)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAreaAO As EntidadesWCF.e_AreaAO) As EntidadesWCF.e_AreaAO Implements Il_AreaAO.Obtener
        Try
            Return oeAreaAO.Obtener(oeAreaAO)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAreaAO As EntidadesWCF.e_AreaAO) As Boolean Implements Il_AreaAO.Validar
        Try
            With oeAreaAO
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class


