Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenCompraMaterial
    Implements Il_OrdenCompraMaterial

    Dim odDetalleOrdenCompra As New d_OrdenCompraMaterial

    Public Function Eliminar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean Implements Il_OrdenCompraMaterial.Eliminar
        Try
            Return odDetalleOrdenCompra.Eliminar(oeOrdenMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean Implements Il_OrdenCompraMaterial.Guardar
        Try
            If Validar(oeOrdenMaterial) Then
                Return odDetalleOrdenCompra.Guardar(oeOrdenMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub GuardarLista(ByVal llOrden As System.Collections.Generic.List(Of e_OrdenCompraMaterial)) Implements Il_OrdenCompraMaterial.GuardarLista
        Try
            For Each oeDetalleOrden As e_OrdenCompraMaterial In llOrden
                oeDetalleOrden.TipoOperacion = "A"
                odDetalleOrdenCompra.Guardar(oeDetalleOrden)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Listar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As System.Collections.Generic.List(Of e_OrdenCompraMaterial) Implements Il_OrdenCompraMaterial.Listar
        Try
            Return odDetalleOrdenCompra.Listar(oeOrdenMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarHistorial(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As System.Data.DataSet Implements Il_OrdenCompraMaterial.ListarHistorial
        Try
            Return odDetalleOrdenCompra.ListarHistorial(oeOrdenMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As e_OrdenCompraMaterial Implements Il_OrdenCompraMaterial.Obtener
        Try
            Return odDetalleOrdenCompra.Obtener(oeOrdenMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenMaterial As e_OrdenCompraMaterial) As Boolean Implements Il_OrdenCompraMaterial.Validar
        Try
            With oeOrdenMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
