Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Cargo
    Implements Il_Cargo

    Dim odCargo As New d_Cargo
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCargo As EntidadesWCF.e_Cargo) As Boolean Implements Il_Cargo.Eliminar
        Try
            Return odCargo.Eliminar(oeCargo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCargo As EntidadesWCF.e_Cargo) As Boolean Implements Il_Cargo.Guardar
        Try
            If Validar(oeCargo) Then
                Return odCargo.Guardar(oeCargo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCargo As EntidadesWCF.e_Cargo) As System.Collections.Generic.List(Of EntidadesWCF.e_Cargo) Implements Il_Cargo.Listar
        Try
            Return odCargo.Listar(oeCargo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCargo As EntidadesWCF.e_Cargo) As EntidadesWCF.e_Cargo Implements Il_Cargo.Obtener
        Try
            Return odCargo.Obtener(oeCargo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCargo As EntidadesWCF.e_Cargo) As Boolean Implements Il_Cargo.Validar
        Try
            With oeCargo
                l_FuncionesGenerales.ValidarCampoNoNulo(oeCargo.Nombre, "No se ha Ingresado Nombre")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Codigo, "codigo")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Cargo.ValidarDuplicado
        Dim oeCargo As New e_Cargo
        Try
            If String.IsNullOrEmpty(valor) Then Throw New Exception("No se ha definido que información se va a verificar si existe")
            If String.IsNullOrEmpty(campo) Then Throw New Exception("No se ha especificado el campo que se va a validar")
            Select Case campo
                Case "codigo"
                    oeCargo.Codigo = valor
                Case "nombre"
                    oeCargo.Nombre = valor
            End Select
            oeCargo = odCargo.Obtener(oeCargo)
            If Not String.IsNullOrEmpty(oeCargo.Id) And oeCargo.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & ": " & valor)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
