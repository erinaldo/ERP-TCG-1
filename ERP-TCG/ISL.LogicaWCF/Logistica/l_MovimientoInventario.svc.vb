Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MovimientoInventario
    Implements Il_MovimientoInventario
    Private odMovimientoInventario As New d_MovimientoInventario
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeMovimientoInventario As EntidadesWCF.e_MovimientoInventario) As Boolean Implements Il_MovimientoInventario.Eliminar
        Try
            Return odMovimientoInventario.Eliminar(oeMovimientoInventario)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoInventario As EntidadesWCF.e_MovimientoInventario) As Boolean Implements Il_MovimientoInventario.Guardar
        Try
            If Validar(oeMovimientoInventario) Then
                Return odMovimientoInventario.Guardar(oeMovimientoInventario)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoInventario As EntidadesWCF.e_MovimientoInventario) As System.Collections.Generic.List(Of EntidadesWCF.e_MovimientoInventario) Implements Il_MovimientoInventario.Listar
        Try
            Return odMovimientoInventario.Listar(oeMovimientoInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoInventario As EntidadesWCF.e_MovimientoInventario) As EntidadesWCF.e_MovimientoInventario Implements Il_MovimientoInventario.Obtener
        Try
            Return odMovimientoInventario.Obtener(oeMovimientoInventario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeMovimientoInventario As EntidadesWCF.e_MovimientoInventario) As Boolean Implements Il_MovimientoInventario.Validar
        Try
            With oeMovimientoInventario
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese el nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoMovimientoInventario, "Ingrese el tipo de movimiento de inventario")
                ValidarDuplicado(.Id, .Nombre, "nombre")
                ValidarDuplicado(.Id, .Abreviatura, "abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_MovimientoInventario.ValidarDuplicado
        Dim oeMovimientoInventario As New e_MovimientoInventario
        Try
            If valor = "" Then
                Return False
            Else
                'oeMovimientoInventario.TipoOperacion = ""
                Select Case campo
                    'Case "codigo"
                    '    oeMovimientoInventario.Codigo = valor
                    Case "nombre"
                        oeMovimientoInventario.Nombre = valor
                    Case "abreviatura"
                        oeMovimientoInventario.Abreviatura = valor
                End Select
                oeMovimientoInventario = odMovimientoInventario.Obtener(oeMovimientoInventario)

                If Not String.IsNullOrEmpty(oeMovimientoInventario.Id) And oeMovimientoInventario.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & " :" & valor)

                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
