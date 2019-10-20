Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenCompraServicio
    Implements Il_OrdenCompraServicio

    Dim odDetalleOrdenCompra As New d_OrdenCompraServicio

    Public Function Eliminar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean Implements Il_OrdenCompraServicio.Eliminar
        Try
            Return odDetalleOrdenCompra.Eliminar(oeOrdenServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean Implements Il_OrdenCompraServicio.Guardar
        Try
            If Validar(oeOrdenServicio) Then
                Return odDetalleOrdenCompra.Guardar(oeOrdenServicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub GuardarLista(ByVal llOrden As System.Collections.Generic.List(Of e_OrdenCompraServicio)) Implements Il_OrdenCompraServicio.GuardarLista
        Try
            For Each oeDetalleOrden As e_OrdenCompraServicio In llOrden
                oeDetalleOrden.TipoOperacion = "A"
                odDetalleOrdenCompra.Guardar(oeDetalleOrden)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Listar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As System.Collections.Generic.List(Of e_OrdenCompraServicio) Implements Il_OrdenCompraServicio.Listar
        Try
            Return odDetalleOrdenCompra.Listar(oeOrdenServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenServicio As e_OrdenCompraServicio) As e_OrdenCompraServicio Implements Il_OrdenCompraServicio.Obtener
        Try
            Return odDetalleOrdenCompra.Obtener(oeOrdenServicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenServicio As e_OrdenCompraServicio) As Boolean Implements Il_OrdenCompraServicio.Validar
        Try
            With oeOrdenServicio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
