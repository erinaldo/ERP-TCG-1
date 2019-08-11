' NOTA: si cambia aquí el nombre de clase "l_RegistrosEditados", también debe actualizar la referencia a "l_RegistrosEditados" tanto en Web.config como en el archivo .svc asociado.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RegistrosEditados
    Implements Il_RegistrosEditados

    'Public Sub DoWork() Implements Il_RegistrosEditados.DoWork
    'End Sub

    Private odRegistrosEditados As New d_RegistrosEditados
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Obtener(ByVal oeRegistroEditados As e_RegistrosEditados) As e_RegistrosEditados Implements Il_RegistrosEditados.Obtener
        Try
            Return odRegistrosEditados.Obtener(oeRegistroEditados)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroEditados As e_RegistrosEditados) As List(Of e_RegistrosEditados) Implements Il_RegistrosEditados.Listar
        Try
            Return odRegistrosEditados.Listar(oeRegistroEditados)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistroEditados As e_RegistrosEditados) As String Implements Il_RegistrosEditados.Guardar
        Try
            Return odRegistrosEditados.Guardar(oeRegistroEditados)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistroEditados As e_RegistrosEditados) As Boolean Implements Il_RegistrosEditados.Eliminar
        Try
            Return odRegistrosEditados.Eliminar(oeRegistroEditados)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
