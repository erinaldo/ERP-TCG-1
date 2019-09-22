Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient


''' <summary>
''' Clase que gestiona los telefonos con lo que cuenta la empresa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Telefono,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Telefono
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Telefono y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeTelefonoMovil) de tipo e_Telefono</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal o_fila As DataRow) As e_Telefono
        Try
            Dim oeTelefono = New e_Telefono( _
                             o_fila("Id").ToString _
                             , o_fila("Tipo") _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("CodigoLargaDistancia").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Principal") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            oeTelefono.IdOperadorTelefonico = o_fila("IdOperadorTelefonico").ToString
            Return oeTelefono
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un telefono, el cual es consultado por el procedimiento almacenado STD.Isp_Telefono_Listar
    ''' enviando su id del telefono.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Telefono.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTelefono">Recibe una variable oeTelefonoMovil de tipo e_Telefono</param>
    ''' <returns>Devuelve una varible oeTelefonoMovil de tipo e_Telefono</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeTelefono As e_Telefono) As e_Telefono
        Try
            Dim ds As DataSet
            With oeTelefono
                ds = sqlhelper.ExecuteDataset("STD.Isp_Telefono_Listar", "", .Id, .Tipo, .TipoPersonaEmpresa, _
                                              .IdPersonaEmpresa, .CodigoLargaDistancia, .Nombre, .Principal, .UsuarioCreacion, .Activo)
            End With
            oeTelefono = New e_Telefono
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTelefono = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTelefono
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Telefono, el cual es consultado por el procedimiento
    ''' almacenado STD.Isp_Telefono_Listar,enviando sus atributos del telefono.Una vez obtenido los registros
    ''' son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTelefono">Recibe una Variable oeTelefonoMovil de tipo e_Telefono </param>
    ''' <returns>Devuelve una lista generica(ldTelefonoMovil) de objetos de tipo e_Telefono</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    ''' 
    Public Function Listar(ByVal oeTelefono As e_Telefono) As List(Of e_Telefono)
        Try
            Dim ldTelefonoMovil As New List(Of e_Telefono)
            Dim ds As DataSet
            With oeTelefono
                ds = sqlhelper.ExecuteDataset("STD.Isp_Telefono_Listar", .TipoOperacion _
                        , .Id _
                        , .Tipo _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .CodigoLargaDistancia _
                        , .Nombre _
                        , .Principal _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeTelefono = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTelefono = Cargar(o_Fila)
                    ldTelefonoMovil.Add(oeTelefono)
                Next
                Return ldTelefonoMovil
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del telefono,a travez del procedimiento almacenado
    ''' STD.Isp_Telefono_IAE,por el cual van a ser enviados y registrados los datos del telefono y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTelefono">Recibe una variable oeTelefonoMovil de tipo e_Telefono</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    ''' del telefono es positiva= true sino false 
    ''' Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeTelefono As e_Telefono) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeTelefono
                sqlhelper.ExecuteNonQuery("STD.Isp_Telefono_IAE", .TipoOperacion _
                        , .Id _
                        , .Tipo _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .CodigoLargaDistancia _
                        , .Nombre _
                        , .Principal _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                        , .IdOperadorTelefonico
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del telefono,a travez del procedimiento almacenado
    ''' STD.Isp_Telefono_IAE,por el cual va a ser enviado el id del telefono a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTelefono">Recibe una variable oeTelefonoMovil de tipo objeto e_Telefono</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeTelefono As e_Telefono) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Telefono_IAE", "E", oeTelefono.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
