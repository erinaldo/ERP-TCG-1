Imports ISL.EntidadesWCF
''' <summary>
''' Clase que se encarga de gestionar las sub familia de material de los articulos en almacen.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla SubFamiliaMterial,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_SubFamiliaMaterial

    Private sqlhelper As New SqlHelper

    Private oeSubFamiliaMaterial As New e_SubFamiliaMaterial
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_SubFamiliaMaterial y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeSubFamiliaMaterial) de tipo e_SubFamiliaMaterial</returns>
    ''' <remarks>Capa del Sistema:Capa Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_SubFamiliaMaterial
        Try
            Dim oeSubFamiliaMaterial = New e_SubFamiliaMaterial( _
                                                                fila("Id"), _
                                                                fila("Codigo"), _
                                                                fila("Nombre"), _
                                                                fila("Abreviatura"), _
                                                                fila("Activo"), _
                                                                fila("IdFamilia"), _
                                                                fila("Familia"))
            Return oeSubFamiliaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una sub familia de material, el cual es consultado por el procedimiento almacenado ALM.Isp_SubFamiliaMaterial_Listar
    ''' enviando su id de sub familia de material.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_SubFamiliaMaterial.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeSubFamiliaMaterial">Recibe una variable oeSubFamiliaMaterial de tipo e_MovimientoInventario</param>
    ''' <returns>Devuelve una varible oeSubFamiliaMaterial de tipo e_MovimientoInventario</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de acceso a Datos</remarks>

    Public Function Obtener(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As e_SubFamiliaMaterial
        Try
            Dim ds As DataSet
            With oeSubFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_SubFamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSubFamiliaMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSubFamiliaMaterial = New e_SubFamiliaMaterial
            End If
            Return oeSubFamiliaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_SubFamiliaMaterial, el cual es consultado por el procedimiento almacenado ALM.Isp_SubFamiliaMaterial_Listar
    ''' enviando sus atributos de la sub familia de material,obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeSubFamiliaMaterial">Recibe una Variable oeSubFamiliaMaterial de tipo e_SubFamiliaMaterial</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_SubFamiliaMaterial</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso aDatos</remarks>

    Public Function Listar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As List(Of e_SubFamiliaMaterial)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_SubFamiliaMaterial)
            With oeSubFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_SubFamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Abreviatura, _
                                              .Activo, _
                                              .IdFamilia)
                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeSubFamiliaMaterial = Cargar(fila)
                        lista.Add(oeSubFamiliaMaterial)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la sub familia de material,a travez del procedimiento almacenado
    ''' ALM.Isp_SubFamiliaMaterial_IAE,por el cual van a ser enviados y registrados los datos de la sub familia de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeSubFamiliaMaterial">Recibe una variable oeSubFamiliaMaterial de tipo e_SubFamiliaMaterial </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Guardar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odCtaCtblSubFam As New d_CtaCtbleSubFamiliaMat
            Dim id As String()
            With oeSubFamiliaMaterial
                id = sqlhelper.ExecuteScalar("ALM.Isp_SubFamiliaMaterial_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                          .Id, _
                                          .Codigo, _
                                          .Nombre, _
                                          .Abreviatura, _
                                          .Activo, _
                                          .IdFamilia, _
                                          .UsuarioCreacion).ToString.Split("_")
                For Each ctacble As e_CtaCtbleSubFamiliaMat In .loCtaCtbleSubFam
                    ctacble.IdSubFamilia = id(0)
                    odCtaCtblSubFam.Guardar(ctacble)
                Next

            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar una sub familia de material,a travez del procedimiento almacenado
    ''' ALM.Isp_SubFamiliaMaterial_IAE,por el cual va a ser enviado el id de la sub familia de material a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeSubFamiliaMaterial">Recibe una variable oeSubFamiliaMaterial de tipo objeto e_SubFamiliaMaterial</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa Datos</remarks>

    Public Function Eliminar(ByVal oeSubFamiliaMaterial As e_SubFamiliaMaterial) As Boolean
        Try
            With oeSubFamiliaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_SubFamiliaMaterial_IAE", _
                                          "E", _
                                          "", _
                                          .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
