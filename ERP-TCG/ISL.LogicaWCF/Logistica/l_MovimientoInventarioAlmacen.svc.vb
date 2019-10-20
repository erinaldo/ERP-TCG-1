Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MovimientoInventarioAlmacen
    Implements Il_MovimientoInventarioAlmacen
    Dim odMovimientoInventarioAlmacen As New d_MovimientoInventarioAlmacen

    Public Function Eliminar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean Implements Il_MovimientoInventarioAlmacen.Eliminar
        Try
            Return odMovimientoInventarioAlmacen.Eliminar(oeMovimientoInventarioAlmacen)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal lista As System.Collections.Generic.List(Of e_MovimientoInventarioAlmacen)) As Boolean Implements Il_MovimientoInventarioAlmacen.Guardar
        Try
            Return odMovimientoInventarioAlmacen.Guardar(lista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar1(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As Boolean Implements Il_MovimientoInventarioAlmacen.Guardar1
        Try
            Return odMovimientoInventarioAlmacen.Guardar(oeMovimientoInventarioAlmacen)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As System.Collections.Generic.List(Of e_MovimientoInventarioAlmacen) Implements Il_MovimientoInventarioAlmacen.Listar
        Try
            Return odMovimientoInventarioAlmacen.Listar(oeMovimientoInventarioAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoInventarioAlmacen As e_MovimientoInventarioAlmacen) As e_MovimientoInventarioAlmacen Implements Il_MovimientoInventarioAlmacen.Obtener
        Try
            Return odMovimientoInventarioAlmacen.Obtener(oeMovimientoInventarioAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
