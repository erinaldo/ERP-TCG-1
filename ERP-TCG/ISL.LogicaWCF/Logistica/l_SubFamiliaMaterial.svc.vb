Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_SubFamiliaMaterial
    Implements Il_SubFamiliaMaterial
    Private odSubFamiliaMaterial As New d_SubFamiliaMaterial
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeSubFamiliaMaterial As EntidadesWCF.e_SubFamiliaMaterial) As Boolean Implements Il_SubFamiliaMaterial.Eliminar
        Try
            Return odSubFamiliaMaterial.Eliminar(oeSubFamiliaMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeSubFamiliaMaterial As EntidadesWCF.e_SubFamiliaMaterial) As Boolean Implements Il_SubFamiliaMaterial.Guardar
        Try
            If Validar(oeSubFamiliaMaterial) Then
                Return odSubFamiliaMaterial.Guardar(oeSubFamiliaMaterial)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSubFamiliaMaterial As EntidadesWCF.e_SubFamiliaMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_SubFamiliaMaterial) Implements Il_SubFamiliaMaterial.Listar
        Try
            Return odSubFamiliaMaterial.Listar(oeSubFamiliaMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSubFamiliaMaterial As EntidadesWCF.e_SubFamiliaMaterial) As EntidadesWCF.e_SubFamiliaMaterial Implements Il_SubFamiliaMaterial.Obtener
        Try
            Return odSubFamiliaMaterial.Obtener(oeSubFamiliaMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeSubFamiliaMaterial As EntidadesWCF.e_SubFamiliaMaterial) As Boolean Implements Il_SubFamiliaMaterial.Validar
        Try
            With oeSubFamiliaMaterial
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdFamilia, "Debe ingresar la familia")
                If .TipoOperacion = "I" Then ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarFamilia(.IdFamilia)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_SubFamiliaMaterial.ValidarDuplicado
        Dim oeSubFamiliaMaterial As New e_SubFamiliaMaterial
        Try
            If valor = "" Then
                Return False
            Else
                Select Case campo
                    Case "codigo"
                        oeSubFamiliaMaterial.Codigo = valor
                    Case "nombre"
                        oeSubFamiliaMaterial.Nombre = valor
                    Case "abreviatura"
                        oeSubFamiliaMaterial.Abreviatura = valor
                End Select
                oeSubFamiliaMaterial = odSubFamiliaMaterial.Obtener(oeSubFamiliaMaterial)
                If Not oeSubFamiliaMaterial.Id Is Nothing And oeSubFamiliaMaterial.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFamilia(ByVal id As String) As Boolean Implements Il_SubFamiliaMaterial.ValidarFamilia
        Try
            Dim oeFamilia As New e_FamiliaMaterial
            Dim odFamilia As New d_FamiliaMaterial
            oeFamilia.Id = id
            oeFamilia = odFamilia.Obtener(oeFamilia)
            If oeFamilia.Id = "" Then
                Throw New Exception("Familia seleccionada no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
