Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Ocupacion
    Implements Il_Ocupacion

    Dim odOcupacion As New d_Ocupacion

    Public Function Eliminar(ByVal oeOcupacion As EntidadesWCF.e_Ocupacion) As Boolean Implements Il_Ocupacion.Eliminar
        Try
            Return odOcupacion.Eliminar(oeOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOcupacion As EntidadesWCF.e_Ocupacion) As Boolean Implements Il_Ocupacion.Guardar
        Try
            If Validar(oeOcupacion) Then
                Return odOcupacion.Guardar(oeOcupacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOcupacion As EntidadesWCF.e_Ocupacion) As System.Collections.Generic.List(Of EntidadesWCF.e_Ocupacion) Implements Il_Ocupacion.Listar
        Try
            Return odOcupacion.Listar(oeOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar2(ByVal oeOcupacion As EntidadesWCF.e_Ocupacion) As System.Collections.Generic.List(Of EntidadesWCF.e_Ocupacion) Implements Il_Ocupacion.Listar2
        Try
            Return odOcupacion.Listar2(oeOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOcupacion As EntidadesWCF.e_Ocupacion) As EntidadesWCF.e_Ocupacion Implements Il_Ocupacion.Obtener
        Try
            Return odOcupacion.Obtener(oeOcupacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOcupacion As EntidadesWCF.e_Ocupacion) As Boolean Implements Il_Ocupacion.Validar
        Try
            With oeOcupacion
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Codigo, "codigo")
                If String.IsNullOrEmpty(.OcupacionSunat) Then Throw New Exception("Seleccione Ocupacion Sunat")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Ocupacion.ValidarDuplicado
        Dim oeOcupacion As New e_Ocupacion
        Try
            If String.IsNullOrEmpty(valor) Then Throw New Exception("No se ha definido que información se va a verificar si existe")
            If String.IsNullOrEmpty(campo) Then Throw New Exception("No se ha especificado el campo que se va a validar")
            Select Case campo
                Case "codigo"
                    oeOcupacion.Codigo = valor
                Case "nombre"
                    oeOcupacion.Nombre = valor
            End Select
            oeOcupacion = odOcupacion.Obtener(oeOcupacion)
            If Not String.IsNullOrEmpty(oeOcupacion.Id) And oeOcupacion.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & ": " & valor)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
