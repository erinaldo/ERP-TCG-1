Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Almacen
    Implements Il_Almacen

    Private odAlmacen As New d_Almacen
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeAlmacen As EntidadesWCF.e_Almacen) As Boolean Implements Il_Almacen.Eliminar
        Try
            Return odAlmacen.Eliminar(oeAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeAlmacen As EntidadesWCF.e_Almacen) As Boolean Implements Il_Almacen.Guardar
        Try
            If Validar(oeAlmacen) Then
                Return odAlmacen.Guardar(oeAlmacen)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAlmacen As EntidadesWCF.e_Almacen) As System.Collections.Generic.List(Of EntidadesWCF.e_Almacen) Implements Il_Almacen.Listar
        Try
            Return odAlmacen.Listar(oeAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAlmacen As EntidadesWCF.e_Almacen) As EntidadesWCF.e_Almacen Implements Il_Almacen.Obtener
        Try
            Return odAlmacen.Obtener(oeAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeAlmacen As EntidadesWCF.e_Almacen) As Boolean Implements Il_Almacen.Validar
        Try
            With oeAlmacen
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Direccion, "Debe ingresar el Direccion")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCentro, "Debe Seleccionar el Centro")
                If .TipoOperacion = "I" Then
                    ValidarDuplicado(.Id, .Codigo, "codigo")
                    ValidarDuplicado(.Id, .Nombre, "nombre")
                End If
                If String.IsNullOrEmpty(.IdProveedor) Then Throw New Exception("Seleccione Proveedor.")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Almacen.ValidarDuplicado
        Dim oeAlmacen As New e_Almacen
        Try
            If String.IsNullOrEmpty(valor) Then
                Return False
            Else
                Select Case campo
                    Case "nombre"
                        oeAlmacen.Nombre = valor
                    Case "abreviatura"
                        oeAlmacen.Abreviatura = valor
                    Case "codigo"
                        oeAlmacen.Codigo = valor
                End Select
                oeAlmacen = odAlmacen.Obtener(oeAlmacen)
                If Not oeAlmacen.Id Is Nothing Then
                    If oeAlmacen.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & ":" & valor)
                End If
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
