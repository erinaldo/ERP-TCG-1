Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

''' <summary>
''' Esta clase se encarga de gestionar las cotizaciones enviadas por los proveedores.
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Cotizacion,
''' Capa del Sistema: Capa de logica.</remarks>

<DataContract(), Serializable()> _
Public Class l_Cotizacion
    Implements Il_Cotizacion

    Dim odCotizacion As New d_Cotizacion

    ''' <summary>
    ''' Este metodo recepciona un objeto de tipo e_Cotizacion y devuelve un boolean,permite el acceso a travez de la instancia
    ''' odCotizacion y el metodo "Eliminar" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacion">Recibe una Variable oeCotizacion de tipo e_Cotizacion</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema=Capa de Logica</remarks>
    Public Function Eliminar(ByVal oeCotizacion As EntidadesWCF.e_Cotizacion) As Boolean Implements Il_Cotizacion.Eliminar
        Try
            Return odCotizacion.Eliminar(oeCotizacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo recepciona un objeto de tipo e_Cotizacion y devuelve un boolean,permite el acceso a travez de la instancia
    ''' odCotizacion y el metodo "Guardar" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacion">Recibe una Variable oeCotizacion de tipo e_Cotizacion</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema=Capa de Logica</remarks>
    Public Function Guardar(ByVal oeCotizacion As EntidadesWCF.e_Cotizacion) As Boolean Implements Il_Cotizacion.Guardar
        Try
            If Validar(oeCotizacion) Then
                Return odCotizacion.Guardar(oeCotizacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite listar las cotizaciones segun un rango de fecha y teniendo en consideracion el estado de la 
    ''' cotizacion.
    ''' </summary>
    ''' <returns>Devuelve una lista generica de objetos de tipo e_Cotizacion</returns>
    ''' <remarks>Capa del Sistema:Capa de Logica</remarks>
    Public Function Listar(ByVal oeCotizacion As EntidadesWCF.e_Cotizacion) As System.Collections.Generic.List(Of EntidadesWCF.e_Cotizacion) Implements Il_Cotizacion.Listar
        Try
            ValidarL(oeCotizacion)
            Return odCotizacion.Listar(oeCotizacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite listar las cotizaciones segun un rango de fecha y teniendo en consideracion el estado de la 
    ''' cotizacion, en este caso devuelve un dataset.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="desde">Recibe una variable que indica la fecha de inicio del tipo date</param>
    ''' <param name="hasta">Recibe una variable que indica la fecha de fin del tipo date</param>
    ''' <param name="estado">Recibe una variable que indica el estado la cotizacion de tipo boolean</param>
    ''' <returns>Devuelve un dataset</returns>
    ''' <remarks>Capa del Sistema:Capa de Logica</remarks>
    Public Function ListarDataSet(ByVal desde As Date, ByVal hasta As Date, ByVal estado As Boolean) As System.Data.DataSet Implements Il_Cotizacion.ListarDataSet
        Try
            Return odCotizacion.ListarDataSet(desde, hasta, estado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo recepciona un objeto cotizacion y devuelve un objeto cotizacion,permite el acceso a travez de la instancia
    ''' odCotizacion y el metodo "Obtener" poder acceder a la capa de datos.
    ''' </summary>
    ''' <param name="oeCotizacion">Recibe una variable oeCotizacion de tipo e_Cotizacion</param>
    ''' <returns>Devuelve un objeto tipo e_Cotizacion</returns>
    ''' <remarks>Capa del Sitema:Capa de Logica</remarks>
    Public Function Obtener(ByVal oeCotizacion As EntidadesWCF.e_Cotizacion) As EntidadesWCF.e_Cotizacion Implements Il_Cotizacion.Obtener
        Try
            Return odCotizacion.Obtener(oeCotizacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Este metodo permite validar los datos del objeto e_Cotizacion
    ''' </summary>
    ''' <param name="oeCotizacion">Recibe una Variable oeCotizacion de tipo e_Cotizacion</param>
    ''' <returns>Devuelve un valor booleano</returns>
    ''' <remarks>Capa del Sistema=Capa de Logica</remarks>
    Public Function Validar(ByVal oeCotizacion As EntidadesWCF.e_Cotizacion) As Boolean Implements Il_Cotizacion.Validar
        Try
            With oeCotizacion
                If (Not .lstCotizacionProveedor Is Nothing) AndAlso .lstCotizacionProveedor.Count = 0 Then
                    Throw New Exception("Debe agregar al menos un proveedor para generar una cotización.")
                Else
                    If .TipoOperacion = "I" Then
                        For Each cotpro As EntidadesWCF.e_Cotizacion_Proveedor In .lstCotizacionProveedor
                            With cotpro
                                If oeCotizacion.IndMaterialServicio = "M" Then
                                    If (Not .lstCotizacionDetalleMat Is Nothing) AndAlso .lstCotizacionDetalleMat.Count = 0 Then
                                        Throw New Exception("Debe agregar al menos un material para generar una cotización.")
                                    End If
                                Else
                                    If (Not .lstCotizacionDetalleSer Is Nothing) AndAlso .lstCotizacionDetalleSer.Count = 0 Then
                                        Throw New Exception("Debe agregar al menos un servicio para generar una cotización.")
                                    End If
                                End If
                            End With
                        Next
                    End If
                    If .Glosa.Trim = String.Empty Then Throw New Exception("Ingrese Glosa")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarL(ByVal oeCotizacion As EntidadesWCF.e_Cotizacion) As Boolean Implements Il_Cotizacion.ValidarL
        Try
            With oeCotizacion
                If oeCotizacion.FechaFinal.Date < oeCotizacion.FechaInicio.Date Then
                    Throw New Exception("La fecha de fin debe ser mayor o igual a la fecha de inicio.")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
