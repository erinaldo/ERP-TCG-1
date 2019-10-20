Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenTrabajo_Actividad
    Implements Il_OrdenTrabajo_Actividad

    Dim odOrdenTrabajo_Actividad As New d_OrdenTrabajo_Actividad

    Public Function Eliminar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean Implements Il_OrdenTrabajo_Actividad.Eliminar
        Try
            Return odOrdenTrabajo_Actividad.Eliminar(oeOrdenTrabajo_Actividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean Implements Il_OrdenTrabajo_Actividad.Guardar
        Try
            If Validar(oeOrdenTrabajo_Actividad) Then
                Return odOrdenTrabajo_Actividad.Guardar(oeOrdenTrabajo_Actividad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As System.Collections.Generic.List(Of e_OrdenTrabajo_Actividad) Implements Il_OrdenTrabajo_Actividad.Listar
        Try
            Return odOrdenTrabajo_Actividad.Listar(oeOrdenTrabajo_Actividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDataSet(ByVal ls_IdOrdenTrabajo As String) As System.Data.DataSet Implements Il_OrdenTrabajo_Actividad.ListarDataSet
        Try
            Return odOrdenTrabajo_Actividad.Listar(ls_IdOrdenTrabajo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As e_OrdenTrabajo_Actividad Implements Il_OrdenTrabajo_Actividad.Obtener
        Try
            Return odOrdenTrabajo_Actividad.Obtener(oeOrdenTrabajo_Actividad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenTrabajo_Actividad As e_OrdenTrabajo_Actividad) As Boolean Implements Il_OrdenTrabajo_Actividad.Validar
        Try
            With oeOrdenTrabajo_Actividad
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
