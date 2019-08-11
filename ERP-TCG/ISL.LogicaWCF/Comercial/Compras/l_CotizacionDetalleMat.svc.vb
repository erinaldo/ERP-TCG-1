Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CotizacionDetalleMat
    Implements Il_CotizacionDetalleMat

    Dim odCotizacionDetalle As New d_CotizacionDetalleMat

    Public Function Eliminar(ByVal oeCotizacionDetalle As EntidadesWCF.e_CotizacionDetalleMat) As Boolean Implements Il_CotizacionDetalleMat.Eliminar
        Try
            Return odCotizacionDetalle.Eliminar(oeCotizacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo recepciona un objeto de tipo e_Cotizacion y devuelve un boolean,permite el acceso a travez de la instancia
    ''' odCotizacion y el metodo "Guardar" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una Variable oeCotizacion de tipo e_Cotizacion</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema=Capa de Logica</remarks>
    Public Function Guardar(ByVal oeCotizacionDetalle As EntidadesWCF.e_CotizacionDetalleMat) As Boolean Implements Il_CotizacionDetalleMat.Guardar
        Try
            If Validar(oeCotizacionDetalle) Then
                Return odCotizacionDetalle.Guardar(oeCotizacionDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite listar los detalles de la cotizacion,permite el acceso a travez de la instancia
    ''' odCotizacionDetalle y el metodo "Listar" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una variable oeCotizacionDetalle y de tipo e_CotizacionDetalleMat</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema:Capa de Logica</remarks>
    Public Function Listar(ByVal oeCotizacionDetalle As EntidadesWCF.e_CotizacionDetalleMat) As System.Collections.Generic.List(Of EntidadesWCF.e_CotizacionDetalleMat) Implements Il_CotizacionDetalleMat.Listar
        Try

            Validar(oeCotizacionDetalle)
            Return odCotizacionDetalle.Listar(oeCotizacionDetalle)

        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo recepciona un objeto oeCotizacionDetalle y devuelve un objeto oeCotizacionDetalle,permite el acceso a travez de la instancia
    ''' odCotizacionDetalle y el metodo "Obtener" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una variable oeCotizacionDetalle de tipo e_CotizacionDetalleMat</param>
    ''' <returns>Devuelve un objeto de tipo e_CotizacionDetalleMat</returns>
    ''' <remarks>Capa del Sitema:Capa de Logica</remarks>
    Public Function Obtener(ByVal oeCotizacionDetalle As EntidadesWCF.e_CotizacionDetalleMat) As EntidadesWCF.e_CotizacionDetalleMat Implements Il_CotizacionDetalleMat.Obtener
        Try
            Return odCotizacionDetalle.Obtener(oeCotizacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite validar los datos del objeto e_CotizacionDetalleMat
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una Variable oeCotizacionDetalle de tipo e_CotizacionDetalleMat</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema=Capa de Logica</remarks>
    Public Function Validar(ByVal oeCotizacionDetalle As EntidadesWCF.e_CotizacionDetalleMat) As Boolean Implements Il_CotizacionDetalleMat.Validar
        Try
            With oeCotizacionDetalle

                If oeCotizacionDetalle.TipoOperacion = "A" Then 'Si es para listar en las ordenes de compra.
                    ValidarProveedor(oeCotizacionDetalle)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ValidarProveedor(ByVal oeCotizacionDetalle As EntidadesWCF.e_CotizacionDetalleMat) Implements Il_CotizacionDetalleMat.ValidarProveedor
        Dim oeProveedor As New EntidadesWCF.e_Proveedor
        Dim olProveedor As New l_Proveedor
        Try

            'If oeCotizacionDetalle.IdProveedor <> "CERO" Then
            '    oeProveedor.Id = oeCotizacionDetalle.IdProveedor
            '    oeProveedor.Activo = True
            '    oeProveedor = olProveedor.Obtener(oeProveedor)
            '    If oeProveedor.Id = "" Then
            '        Throw New Exception("No existe el proveedor seleccionado")
            '    End If
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
