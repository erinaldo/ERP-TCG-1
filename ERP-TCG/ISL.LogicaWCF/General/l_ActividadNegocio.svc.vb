Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ActividadNegocio
    Implements Il_ActividadNegocio

    Dim odActividadNegocio As New d_ActividadNegocio
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean Implements Il_ActividadNegocio.Eliminar
        Try
            Return odActividadNegocio.Eliminar(oeActividadNegocio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean Implements Il_ActividadNegocio.Guardar
        Try
            If Validar(oeActividadNegocio) Then
                Return odActividadNegocio.Guardar(oeActividadNegocio)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet() As System.Data.DataSet Implements Il_ActividadNegocio.ListarDataSet
        Try
            Return odActividadNegocio.Listar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeActividadNegocio As e_ActividadNegocio) As System.Collections.Generic.List(Of e_ActividadNegocio) Implements Il_ActividadNegocio.Listar
        Try
            Return odActividadNegocio.Listar(oeActividadNegocio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividadNegocio As e_ActividadNegocio) As e_ActividadNegocio Implements Il_ActividadNegocio.Obtener
        Try
            Return odActividadNegocio.Obtener(oeActividadNegocio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean Implements Il_ActividadNegocio.Validar
        Try
            With oeActividadNegocio
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese Nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarLista(ByVal leActividadNegocio As System.Collections.Generic.List(Of e_ActividadNegocio)) As Boolean Implements Il_ActividadNegocio.ValidarLista
        Try
            If Not leActividadNegocio Is Nothing Then
                For i As Integer = 0 To leActividadNegocio.Count - 1
                    Validar(leActividadNegocio.Item(i))
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
