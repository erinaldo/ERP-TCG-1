Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Placa
    Implements Il_Placa

    Dim odPlaca As New d_Placa
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oePlaca As EntidadesWCF.e_Placa) As Boolean Implements Il_Placa.Eliminar
        Try
            Return odPlaca.Eliminar(oePlaca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePlaca As EntidadesWCF.e_Placa) As Boolean Implements Il_Placa.Guardar
        Try
            If Validar(oePlaca) Then
                Return odPlaca.Guardar(oePlaca)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePlaca As EntidadesWCF.e_Placa) As System.Collections.Generic.List(Of EntidadesWCF.e_Placa) Implements Il_Placa.Listar
        Try
            Return odPlaca.Listar(oePlaca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oePlaca As EntidadesWCF.e_Placa) As EntidadesWCF.e_Placa Implements Il_Placa.Obtener
        Try
            Return odPlaca.Obtener(oePlaca)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePlaca As EntidadesWCF.e_Placa) As Boolean Implements Il_Placa.Validar
        Try
            With oePlaca
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre placa")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal Id As String, ByVal Nombre As String) As Boolean Implements Il_Placa.ValidarDuplicado
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(Nombre, "No ha Ingresado el número de placa de rodaje")
            Dim oePlaca As New e_Placa
            oePlaca.Nombre = Nombre
            oePlaca.Activo = True
            oePlaca = odPlaca.Obtener(oePlaca)
            If Id = "" OrElse oePlaca.Id <> Id Then
                Throw New Exception("La placa de rodaje: " & Nombre & ", ya se encuentra registrada")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
