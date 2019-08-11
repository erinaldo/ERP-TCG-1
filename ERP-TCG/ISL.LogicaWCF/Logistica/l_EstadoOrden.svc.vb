Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_EstadoOrden
    Implements Il_EstadoOrden
    Dim odEstadoOrden As New d_EstadoOrden
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeEstadoOrden As EntidadesWCF.e_EstadoOrden) As Boolean Implements Il_EstadoOrden.Eliminar
        Try
            Return odEstadoOrden.Eliminar(oeEstadoOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEstadoOrden As EntidadesWCF.e_EstadoOrden) As Boolean Implements Il_EstadoOrden.Guardar
        Try
            If Validar(oeEstadoOrden) Then
                Return odEstadoOrden.Guardar(oeEstadoOrden)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEstadoOrden As EntidadesWCF.e_EstadoOrden) As System.Collections.Generic.List(Of EntidadesWCF.e_EstadoOrden) Implements Il_EstadoOrden.Listar
        Try
            Return odEstadoOrden.Listar(oeEstadoOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEstadoOrden As EntidadesWCF.e_EstadoOrden) As EntidadesWCF.e_EstadoOrden Implements Il_EstadoOrden.Obtener
        Try
            Return odEstadoOrden.Obtener(oeEstadoOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeEstadoOrden As EntidadesWCF.e_EstadoOrden) As Boolean Implements Il_EstadoOrden.Validar
        Try
            With oeEstadoOrden
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                ValidarDuplicado(.Id, .Nombre, "nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_EstadoOrden.ValidarDuplicado
        Dim oeEstadoOrden As New e_EstadoOrden
        Try
            If String.IsNullOrEmpty(valor) Then
                Return False
            Else
                Select Case campo
                    Case "nombre"
                        oeEstadoOrden.Nombre = valor
                End Select
                oeEstadoOrden = odEstadoOrden.Obtener(oeEstadoOrden)
                If Not oeEstadoOrden.Id Is Nothing And oeEstadoOrden.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
