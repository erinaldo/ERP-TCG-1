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
Public Class l_Email
    Implements Il_Email

    Dim odEmail As New d_Email
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeEmail As EntidadesWCF.e_Email) As Boolean Implements Il_Email.Eliminar
        Try
            Return odEmail.Eliminar(oeEmail)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEmail As EntidadesWCF.e_Email) As Boolean Implements Il_Email.Guardar
        Try
            If Validar(oeEmail) Then
                Return odEmail.Guardar(oeEmail)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEmail As EntidadesWCF.e_Email) As System.Collections.Generic.List(Of EntidadesWCF.e_Email) Implements Il_Email.Listar
        Try
            Return odEmail.Listar(oeEmail)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEmail As EntidadesWCF.e_Email) As EntidadesWCF.e_Email Implements Il_Email.Obtener
        Try
            Return odEmail.Obtener(oeEmail)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEmail As EntidadesWCF.e_Email) As Boolean Implements Il_Email.Validar
        Try
            ValidarNombre(oeEmail.Id, oeEmail.Nombre)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarLista(ByVal leEmail As System.Collections.Generic.List(Of EntidadesWCF.e_Email)) As Boolean Implements Il_Email.ValidarLista
        Try
            If Not leEmail Is Nothing Then
                'For i As Integer = 0 To leEmail.Count - 1
                '    Validar(leEmail.Item(i))
                'Next
                For Each oeAuxEmail In leEmail
                    Validar(oeAuxEmail)
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNombre(ByVal Id As String, ByVal Nombre As String) As Boolean Implements Il_Email.ValidarNombre
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(Nombre, "No ha Ingresado Email")
            Dim oeEmail As New e_Email
            oeEmail.Nombre = Nombre
            oeEmail = odEmail.Obtener(oeEmail)
            If oeEmail.Id <> "" Then
                If Id = "" Then Throw New Exception("Ya existe Emial: " & Nombre)
                If oeEmail.Id <> Id Then Throw New Exception("Ya existe Emial: " & Nombre)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarListar(leEmail As List(Of e_Email)) As Boolean Implements Il_Email.GuardarListar
        Try
            If ValidarLista(leEmail) Then
                Return odEmail.GuardarLista(leEmail)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
