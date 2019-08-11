Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

''' <summary>
''' Esta clase se encarga de gestionar los detalles de las cotizaciones enviadas por los proveedores.
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla CotizacionDetalle,Capa del Sistema: Capa de Logica.</remarks>

<DataContract(), Serializable()> _
Public Class l_Cotizacion_Proveedor
    Implements Il_Cotizacion_Proveedor

    Dim odCotizacionProveedor As New d_Cotizacion_Proveedor

    Public Function Eliminar(ByVal oeCotizacionDetalle As EntidadesWCF.e_Cotizacion_Proveedor) As Boolean Implements Il_Cotizacion_Proveedor.Eliminar
        Try
            Return odCotizacionProveedor.Eliminar(oeCotizacionDetalle)
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
    Public Function Guardar(ByVal oeCotizacionDetalle As EntidadesWCF.e_Cotizacion_Proveedor) As Boolean Implements Il_Cotizacion_Proveedor.Guardar
        Try
            If Validar(oeCotizacionDetalle) Then
                Return odCotizacionProveedor.Guardar(oeCotizacionDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite listar los detalles de la cotizacion,permite el acceso a travez de la instancia
    ''' odCotizacionProveedor y el metodo "Listar" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una variable oeCotizacionDetalle y de tipo e_Cotizacion_Proveedor</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema:Capa de Logica</remarks>
    Public Function Listar(ByVal oeCotizacionDetalle As EntidadesWCF.e_Cotizacion_Proveedor) As System.Collections.Generic.List(Of EntidadesWCF.e_Cotizacion_Proveedor) Implements Il_Cotizacion_Proveedor.Listar
        Try
            Return odCotizacionProveedor.Listar(oeCotizacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo recepciona un objeto oeCotizacionDetalle y devuelve un objeto oeCotizacionDetalle,permite el acceso a travez de la instancia
    ''' odCotizacionProveedor y el metodo "Obtener" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una variable oeCotizacionDetalle de tipo e_Cotizacion_Proveedor</param>
    ''' <returns>Devuelve un objeto de tipo e_Cotizacion_Proveedor</returns>
    ''' <remarks>Capa del Sitema:Capa de Logica</remarks>
    Public Function Obtener(ByVal oeCotizacionDetalle As EntidadesWCF.e_Cotizacion_Proveedor) As EntidadesWCF.e_Cotizacion_Proveedor Implements Il_Cotizacion_Proveedor.Obtener
        Try
            Return odCotizacionProveedor.Obtener(oeCotizacionDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite validar los datos del objeto e_Cotizacion_Proveedor
    ''' </summary>
    ''' <param name="oeCotizacionDetalle">Recibe una Variable oeCotizacionDetalle de tipo e_Cotizacion_Proveedor</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema=Capa de Logica</remarks>
    Public Function Validar(ByVal oeCotizacionDetalle As EntidadesWCF.e_Cotizacion_Proveedor) As Boolean Implements Il_Cotizacion_Proveedor.Validar
        Try
            With oeCotizacionDetalle
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Debe ingresar codigo de la cotización")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
