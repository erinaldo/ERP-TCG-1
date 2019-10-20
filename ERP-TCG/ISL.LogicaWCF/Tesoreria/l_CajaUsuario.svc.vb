Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CajaUsuario
    Implements Il_CajaUsuario

    Dim odCajaUsuario As New d_CajaUsuario
    Dim Existe As Boolean = False
    Dim TipoOperacion As String
    Dim _Activo As Boolean = True
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean Implements Il_CajaUsuario.Eliminar
        Try
            Return odCajaUsuario.Eliminar(oeCajaUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean Implements Il_CajaUsuario.Guardar
        Try
            If Validar(oeCajaUsuario) Then
                'If Existe = False Then
                '    oeCajaUsuario.Activo = _Activo
                '    oeCajaUsuario.TipoOperacion = TipoOperacion
                Return odCajaUsuario.Guardar(oeCajaUsuario)
                'End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCajaUsuario As e_CajaUsuario) As System.Collections.Generic.List(Of e_CajaUsuario) Implements Il_CajaUsuario.Listar
        Try
            Return odCajaUsuario.Listar(oeCajaUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCajaUsuario As e_CajaUsuario) As e_CajaUsuario Implements Il_CajaUsuario.Obtener
        Try
            Return odCajaUsuario.Obtener(oeCajaUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean Implements Il_CajaUsuario.Validar
        Try
            With oeCajaUsuario
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCaja, "Seleccione Caja")
                'ValidarDuplicado(.Id, .IdCaja, .IdTrabajador, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal CAJA As String, ByVal USUARIO As String, ByVal ACTIVO As Boolean) As Boolean Implements Il_CajaUsuario.ValidarDuplicado
        Try
            Dim oeCajaUsuario As New e_CajaUsuario
            oeCajaUsuario.Activo = ACTIVO
            'oeCajaUsuario.Id = ID
            oeCajaUsuario.IdCaja = CAJA
            oeCajaUsuario.IdTrabajador = USUARIO
            oeCajaUsuario = odCajaUsuario.Obtener(oeCajaUsuario)
            If oeCajaUsuario.Id <> "" Then
                If oeCajaUsuario.IdTrabajador = USUARIO And oeCajaUsuario.IdCaja = CAJA Then
                    If oeCajaUsuario.Activo Then
                        Existe = True
                    Else
                        Existe = False
                        TipoOperacion = "A"
                        _Activo = True
                    End If
                Else
                    'Existe = False
                    TipoOperacion = "I"
                End If
            Else
                TipoOperacion = "I"
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
