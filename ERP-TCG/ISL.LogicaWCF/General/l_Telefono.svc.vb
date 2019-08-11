Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Telefono
    Implements Il_Telefono

    Dim odTelefono As New d_Telefono
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTelefono As EntidadesWCF.e_Telefono) As Boolean Implements Il_Telefono.Eliminar
        Try
            Return odTelefono.Eliminar(oeTelefono)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTelefono As EntidadesWCF.e_Telefono) As Boolean Implements Il_Telefono.Guardar
        Try
            If Validar(oeTelefono) Then
                Return odTelefono.Guardar(oeTelefono)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTelefono As EntidadesWCF.e_Telefono) As System.Collections.Generic.List(Of EntidadesWCF.e_Telefono) Implements Il_Telefono.Listar
        Try
            Return odTelefono.Listar(oeTelefono)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTelefono As EntidadesWCF.e_Telefono) As EntidadesWCF.e_Telefono Implements Il_Telefono.Obtener
        Try
            Return odTelefono.Obtener(oeTelefono)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTelefono As EntidadesWCF.e_Telefono) As Boolean Implements Il_Telefono.Validar
        Try
            ValidarNombre(oeTelefono)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarLista(ByVal leTelefono As System.Collections.Generic.List(Of EntidadesWCF.e_Telefono)) As Boolean Implements Il_Telefono.ValidarLista
        Try
            If Not leTelefono Is Nothing Then
                For Each oeTelf In leTelefono
                    Validar(oeTelf)
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNombre(oeTelefono As e_Telefono) As Boolean Implements Il_Telefono.ValidarNombre
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(oeTelefono.Nombre, "Ingrese Numero de Telefono")
            Dim _oeTelfAux As New e_Telefono
            _oeTelfAux.Nombre = oeTelefono.Nombre
            _oeTelfAux.Tipo = oeTelefono.Tipo
            _oeTelfAux = odTelefono.Obtener(oeTelefono)
            If _oeTelfAux.Id <> "" Then
                If oeTelefono.Id = "" Then Throw New Exception("Ya existe Nº Telefónico: " & oeTelefono.Nombre)
                If _oeTelfAux.Id <> oeTelefono.Id Then Throw New Exception("Ya existe Nº Telefónico: " & oeTelefono.Nombre)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
