Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleAporteDescuento
    Implements Il_DetalleAporteDescuento

    Private odDetalleAporteDescuento As New d_DetalleAporteDescuento
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean Implements Il_DetalleAporteDescuento.Eliminar
        Try
            Return odDetalleAporteDescuento.Eliminar(oeDetalleAporteDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean Implements Il_DetalleAporteDescuento.Guardar
        Try
            If Validar(oeDetalleAporteDescuento) Then
                Return odDetalleAporteDescuento.Guardar(oeDetalleAporteDescuento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleAporteDescuento As e_DetalleAporteDescuento) As System.Collections.Generic.List(Of e_DetalleAporteDescuento) Implements Il_DetalleAporteDescuento.Listar
        Try
            Return odDetalleAporteDescuento.Listar(oeDetalleAporteDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleAporteDescuento As e_DetalleAporteDescuento) As e_DetalleAporteDescuento Implements Il_DetalleAporteDescuento.Obtener
        Try
            Return odDetalleAporteDescuento.Obtener(oeDetalleAporteDescuento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleAporteDescuento As e_DetalleAporteDescuento) As Boolean Implements Il_DetalleAporteDescuento.Validar
        Try
            With oeDetalleAporteDescuento
                l_FuncionesGenerales.ValidarCampoNoNulo(.UnidadCalculo, "No ha Ingresado Unidad Calculo")
                If .MontoCalculo = 0 Then Throw New Exception("No ha Ingresado Monto Calculo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
