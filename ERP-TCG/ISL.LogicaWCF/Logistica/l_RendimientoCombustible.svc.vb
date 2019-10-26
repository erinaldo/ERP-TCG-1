'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions


<DataContract(), Serializable()> _
Public Class l_RendimientoCombustible
    Implements Il_RendimientoCombustible

    Dim odRendimientoCombustible As New d_RendimientoCombustible
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean Implements Il_RendimientoCombustible.Guardar
        Try
            If Validar(oeRendimientoCombustible) Then
                Return odRendimientoCombustible.Guardar(oeRendimientoCombustible)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As System.Collections.Generic.List(Of e_RendimientoCombustible) Implements Il_RendimientoCombustible.Listar
        Try
            Return odRendimientoCombustible.Listar(oeRendimientoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As e_RendimientoCombustible Implements Il_RendimientoCombustible.Obtener
        Try
            Return odRendimientoCombustible.Obtener(oeRendimientoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean Implements Il_RendimientoCombustible.Validar
        Try
            'If oeRendimientoCombustible.TipoOperacion = "I" Then
            '    Dim oeRend As New e_RendimientoCombustible
            '    Dim leRend As New List(Of e_RendimientoCombustible)
            '    oeRend = oeRendimientoCombustible
            '    oeRend.TipoOperacion = ""
            '    oeRend.Id = ""
            '    leRend = Listar(oeRend)
            '    If leRend.Count > 0 Then Throw New Exception("Ya existe un rendimeinto creado para esta zona y peso")
            'End If
            If oeRendimientoCombustible.Rendimiento = 0 Then
                Throw New Exception("El rendimiento debe ser mayor a 0.0")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRendimientoCombustible As e_RendimientoCombustible) As Boolean Implements Il_RendimientoCombustible.Eliminar
        Try
            Return odRendimientoCombustible.Eliminar(oeRendimientoCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
