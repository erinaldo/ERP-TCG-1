Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_FamiliaMaterial
    Implements Il_FamiliaMaterial
    Dim odFamiliaMaterial As New d_FamiliaMaterial
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeFamiliaMaterial As EntidadesWCF.e_FamiliaMaterial) As Boolean Implements Il_FamiliaMaterial.Eliminar
        Try
            Return odFamiliaMaterial.Eliminar(oeFamiliaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFamiliaMaterial As EntidadesWCF.e_FamiliaMaterial) As Boolean Implements Il_FamiliaMaterial.Guardar
        Try
            If Validar(oeFamiliaMaterial) Then
                Return odFamiliaMaterial.Guardar(oeFamiliaMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFamiliaMaterial As EntidadesWCF.e_FamiliaMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_FamiliaMaterial) Implements Il_FamiliaMaterial.Listar
        Try
            Return odFamiliaMaterial.Listar(oeFamiliaMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFamiliaMaterial As EntidadesWCF.e_FamiliaMaterial) As EntidadesWCF.e_FamiliaMaterial Implements Il_FamiliaMaterial.Obtener
        Try
            Return odFamiliaMaterial.Obtener(oeFamiliaMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeFamiliaMaterial As EntidadesWCF.e_FamiliaMaterial) As Boolean Implements Il_FamiliaMaterial.Validar
        Try
            With oeFamiliaMaterial
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                ValidarDuplicado(.Id, .Codigo, "codigo")
                ValidarDuplicado(.Id, .Nombre, "nombre")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_FamiliaMaterial.ValidarDuplicado
        Dim oeFamiliaMaterial As New e_FamiliaMaterial
        Try
            If String.IsNullOrEmpty(valor) Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeFamiliaMaterial.Codigo = valor
                    Case "nombre"
                        oeFamiliaMaterial.Nombre = valor
                End Select
                oeFamiliaMaterial = odFamiliaMaterial.Obtener(oeFamiliaMaterial)
                If Not oeFamiliaMaterial.Id Is Nothing And oeFamiliaMaterial.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
