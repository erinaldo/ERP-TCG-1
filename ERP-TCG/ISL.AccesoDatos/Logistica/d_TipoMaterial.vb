Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar los tipos de material en almacen.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla MovimientoInventario,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_TipoMaterial
    Private sqlhelper As New SqlHelper

    Private oeTipoMaterial As New e_TipoMaterial
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_TipoMaterial y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oetipomaterial) de tipo e_TipoMaterial</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_TipoMaterial
        Try
            Dim oetipomaterial = New e_TipoMaterial(fila("Id"), _
                                                    fila("Codigo"), _
                                                    fila("Nombre"), _
                                                    fila("Abreviatura"), _
                                                    fila("Activo"))
            Return oetipomaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un tipo de material, el cual es consultado por el procedimiento almacenado ALM.Isp_TipoMaterial_Listar
    ''' enviando su id del tipo de material.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_TipoMaterial.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMaterial">Recibe una variable oeTipoMaterial de tipo e_TipoMaterial</param>
    ''' <returns>Devuelve una varible oeTipoMaterial de tipo e_TipoMaterial</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Obtener(ByVal oeTipoMaterial As e_TipoMaterial) As e_TipoMaterial
        Try
            Dim ds As New DataSet
            With oeTipoMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoMaterial = New e_TipoMaterial
            End If
            Return oeTipoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_TipoMaterial, el cual es consultado por el procedimiento almacenado ALM.Isp_TipoMaterial_Listar
    ''' enviando sus atributos del tipo de material.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMaterial">Recibe una Variable oeTipoMaterial de tipo e_TipoMaterial</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_TipoMaterial</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Listar(ByVal oeTipoMaterial As e_TipoMaterial) As List(Of e_TipoMaterial)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_TipoMaterial)
            With oeTipoMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_TipoMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeTipoMaterial = Cargar(fila)
                        lista.Add(oeTipoMaterial)
                    Next
                    '    Return lista
                    'Else
                    '    Return Nothing
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los tipos de material,a travez del procedimiento almacenado
    ''' ALM.Isp_TipoMaterial_IAE,por el cual van a ser enviados y registrados los datos del tipo de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMaterial">Recibe una variable oeTipoMaterial de tipo e_TipoMaterial </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Guardar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeTipoMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMaterial_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                          .Id, _
                                          .Codigo, _
                                          .Nombre, _
                                          .Abreviatura, _
                                          .Activo, _
                                          .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un tipo de material,a travez del procedimiento almacenado
    ''' ALM.Isp_TipoMaterial_IAE,por el cual va a ser enviado el id del tipo de material a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeTipoMaterial">Recibe una variable oeTipoMaterial de tipo objeto e_TipoMaterial</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeTipoMaterial As e_TipoMaterial) As Boolean
        Try
            With oeTipoMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_TipoMaterial_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
