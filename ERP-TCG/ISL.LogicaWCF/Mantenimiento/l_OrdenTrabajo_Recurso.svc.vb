Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajo_Recurso
    Implements Il_OrdenTrabajo_Recurso
    Dim odOrdenTrabajo_Recurso As New d_OrdenTrabajo_Recurso

    Public Function Eliminar(ByVal oeOrdenTrabajo_Recurso As EntidadesWCF.e_OrdenTrabajo_Recurso) As Boolean Implements Il_OrdenTrabajo_Recurso.Eliminar
        Try
            Return odOrdenTrabajo_Recurso.Eliminar(oeOrdenTrabajo_Recurso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo_Recurso As EntidadesWCF.e_OrdenTrabajo_Recurso) As Boolean Implements Il_OrdenTrabajo_Recurso.Guardar
        Try
            If Validar(oeOrdenTrabajo_Recurso) Then
                Return odOrdenTrabajo_Recurso.Guardar(oeOrdenTrabajo_Recurso)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_Recurso As EntidadesWCF.e_OrdenTrabajo_Recurso) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenTrabajo_Recurso) Implements Il_OrdenTrabajo_Recurso.Listar
        Try
            Return odOrdenTrabajo_Recurso.Listar(oeOrdenTrabajo_Recurso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As System.Data.DataSet Implements Il_OrdenTrabajo_Recurso.ListarDataSet
        Try
            Return odOrdenTrabajo_Recurso.Listar(ls_IdOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_Recurso As EntidadesWCF.e_OrdenTrabajo_Recurso) As EntidadesWCF.e_OrdenTrabajo_Recurso Implements Il_OrdenTrabajo_Recurso.Obtener
        Try
            Return odOrdenTrabajo_Recurso.Obtener(oeOrdenTrabajo_Recurso)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajo_Recurso As EntidadesWCF.e_OrdenTrabajo_Recurso) As Boolean Implements Il_OrdenTrabajo_Recurso.Validar
        Try
            With oeOrdenTrabajo_Recurso
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
