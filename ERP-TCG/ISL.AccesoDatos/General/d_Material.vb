'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Tipo Orden Compra,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Material

    Private sqlhelper As New SqlHelper
    Private odMaterialCuentaContable As New d_MaterialCuentaContable
    Private odCodigoBarra As New d_CodigoBarraMaterial
    Private odCaracteristicaMaterial As New d_CaracteristicaMaterial
    Private oeMatDisNeu As New e_Material_DisenoNeu
    Private odMatDisNeu As New d_Material_DisenoNeu
    Private odMaterialAlmacen As New d_MaterialAlmacen
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Material y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeMaterial) de tipo e_Material </returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar_Detalle(ByVal fila As DataRow) As e_Material
        Try
            Dim oeMaterial = New e_Material(fila("Seleccion"), _
                                            fila("Id"), _
                                            fila("Codigo"), _
                                            fila("Nombre"), _
                                            fila("IdTipoUnidadMedida"), _
                                            fila("TipoUnidadMedida"), _
                                            fila("IdUnidadMedida"), _
                                            fila("UnidadMedida"), _
                                            fila("Medida"), _
                                            fila("Peso"), _
                                            fila("Serial"), _
                                            fila("AfectoIgv"), _
                                            fila("Glosa"), _
                                            fila("IdAlmacen"), _
                                            fila("Almacen"), _
                                            fila("IdSubAlmacen"), _
                                            fila("Activo"), _
                                            fila("Precio"), _
                                            fila("Stock"))
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar(ByVal fila As DataRow) As e_Material
        Try
            Dim oeMaterial = New e_Material(fila("Seleccion"), _
                                            fila("Id"), _
                                            fila("Codigo"), _
                                            fila("Nombre"), _
                                            fila("IdTipoMaterial"), _
                                            fila("TipoMaterial"), _
                                            fila("IdFamilia"), _
                                            fila("Familia"), _
                                            fila("IdSubFamilia"), _
                                            fila("SubFamilia"), _
                                            fila("IdTipoUnidadMedida"), _
                                            fila("TipoUnidadMedida"), _
                                            fila("IdUnidadMedida"), _
                                            fila("UnidadMedida"), _
                                            fila("Medida"), _
                                            fila("Peso"), _
                                            fila("Serial"), _
                                            fila("AfectoIgv"), _
                                            fila("Glosa"), _
                                            fila("IdAlmacen"), _
                                            fila("Almacen"), _
                                            fila("Activo"), _
                                            fila("Precio"), _
                                            fila("Stock"), _
                                            fila("IdItemGasto"), _
                                            fila("IdSubAlmacen"), _
                                            fila("SubAlmacen"), _
                                            fila("Ubicacion"), _
                                            fila("IndDivisible"),
                                            fila("IndActivoFijo"))
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar_(ByVal fila As DataRow) As e_Material
        Try
            Dim oeMaterial = New e_Material(fila("Seleccion"), _
                                            fila("IdMaterial"), _
                                            fila("Codigo"), _
                                            fila("Material"), _
                                            fila("IdUnidadMedida"), _
                                            fila("UnidadMedida"), _
                                            fila("IdSubAlmacen"), _
                                            fila("SubAlmacen"), _
                                            fila("IdAlmacen"), _
                                            fila("Almacen"), _
                                            fila("Precio"), _
                                            fila("Stock"), _
                                            fila("IdTipoUnidadMedida"), _
                                            fila("TipoUnidadMedida"))
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene un material, el cual es consultado por el procedimiento almacenado STD.Isp_Material_Listar
    ''' enviando su id del material.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Material.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMaterial">Recibe una variable oeMaterial de tipo e_Material</param>
    ''' <returns>Devuelve una varible oeMaterial de tipo -</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeMaterial As e_Material) As e_Material
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Material_Listar", _
                                          oeMaterial.TipoOperacion, _
                                          oeMaterial.Id, oeMaterial.Codigo, oeMaterial.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMaterial = New e_Material
            End If
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerMatNeu(ByVal oeMaterial As e_Material) As e_Material
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Material_Listar", _
                                          oeMaterial.TipoOperacion, _
                                          oeMaterial.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMaterial = Cargar(ds.Tables(0).Rows(0))
                oeMatDisNeu = New e_Material_DisenoNeu
                oeMatDisNeu.TipoOperacion = ""
                oeMatDisNeu.IdMaterial = oeMaterial.Id
                oeMaterial.oeMaterial_DisenoNeu = odMatDisNeu.Obtener(oeMatDisNeu)
            Else
                oeMaterial = New e_Material
            End If
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerMaterialSegunAlmacen(ByVal oeMaterial As e_Material) As e_Material
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_Material_Almacen_Listar", _
                                          oeMaterial.TipoOperacion, _
                                          "", _
                                          "", _
                                          oeMaterial.Id, _
                                          oeMaterial.IdAlmacen, _
                                          oeMaterial.Activo, _
                                          "", _
                                          "", _
                                          oeMaterial.IdSubAlmacen)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMaterial = New e_Material
            End If
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Material, el cual es consultado por el procedimiento almacenado STD.Isp_Material_Listar
    ''' enviando sus atributos del material.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMaterial">Recibe una Variable oeMaterial de tipo e_Material </param>
    ''' <returns>Devuelve una lista generica(ldMaterial) de objetos de tipo e_Material</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeMaterial As e_Material) As List(Of e_Material)
        Try
            Dim ldMaterial As New List(Of e_Material)
            Dim ds As DataSet
            With oeMaterial
                ds = sqlhelper.ExecuteDataset("STD.Isp_Material_Listar", _
                                                  .TipoOperacion, _
                                                  .Id, _
                                                  .Codigo, _
                                                  .Nombre, _
                                                  "", _
                                                  .IdTipoMaterial, _
                                                  .IdFamilia, _
                                                  .IdSubFamilia, "", .Tipo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMaterial = Cargar(o_Fila)
                    ldMaterial.Add(oeMaterial)
                Next
            End If
            Return ldMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar_(ByVal oeMaterial As e_Material) As List(Of e_Material)
        Try
            'Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldMaterial As New List(Of e_Material)
            Dim ds As DataSet
            With oeMaterial
                ds = sqlhelper.ExecuteDataset("STD.Isp_Material_Listar", _
                                                  .TipoOperacion, _
                                                  .Id, _
                                                  .Codigo, _
                                                  .Nombre, "", "", "", "", .IdCentro, .Tipo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMaterial = Cargar_(o_Fila)
                    ldMaterial.Add(oeMaterial)
                Next
            End If
            Return ldMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener_(ByVal oeMaterial As e_Material) As e_Material
        Try
            'Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            With oeMaterial
                ds = sqlhelper.ExecuteDataset("STD.Isp_Material_Listar", _
                                                  .TipoOperacion, _
                                                  .Id, _
                                                  .Codigo, _
                                                  .Nombre, "", "", "", "", .IdCentro, .Tipo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeMaterial = Cargar_(ds.Tables(0).Rows(0))
            Else
                oeMaterial = New e_Material
            End If
            Return oeMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Este metodo se encarga de llenar 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ComboGrilla(ByVal ListaMaterial As List(Of e_Material))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Material In ListaMaterial
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del material,a travez del procedimiento almacenado
    ''' STD.Isp_Material_IAE,por el cual van a ser enviados y registrados los datos del material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMaterial">Recibe una variable oeMaterial de tipo e_Material</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de material es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeMaterial As e_Material) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeMaterial
                    stResultado = sqlhelper.ExecuteScalar("STD.Isp_Material_IAE",
                                              .TipoOperacion,
                                              .PrefijoID,
                                              .Id,
                                              .Codigo,
                                              .Nombre,
                                              .IdSubFamilia,
                                              .IdUnidadMedida,
                                              .Medida,
                                              .Peso,
                                              .Serial,
                                              .AfectoIgv,
                                              .Glosa,
                                              .Activo,
                                              .IdTipoMaterial,
                                              .IdItemGasto,
                                              .UsuarioCreacion,
                                              .IndDivisible,
                                              .IndActivoFijo).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each MaterialCuentaContable As e_MaterialCuentaContable In oeMaterial.ListaMaterialCuentaContable
                        MaterialCuentaContable.Id = ""
                        MaterialCuentaContable.IdMaterial = stResultado(0)
                        MaterialCuentaContable.PrefijoID = .PrefijoID '@0001
                        odMaterialCuentaContable.Guardar(MaterialCuentaContable)
                    Next
                    For Each codigobarra As e_CodigoBarraMaterial In oeMaterial.ListaCodigoBarras
                        codigobarra.IdMaterial = stResultado(0)
                        If codigobarra.TipoOperacion = "" Then
                            codigobarra.TipoOperacion = oeMaterial.TipoOperacion
                        End If
                        codigobarra.PrefijoID = .PrefijoID '@0001
                        odCodigoBarra.Guardar(codigobarra)
                    Next
                    For Each carmat As e_CaracteristicaMaterial In oeMaterial.ListaCaracteristicaMaterial
                        carmat.IdMaterial = stResultado(0)
                        carmat.PrefijoID = .PrefijoID '@0001
                        odCaracteristicaMaterial.Guardar(carmat)
                    Next
                    For Each almacen As e_MaterialAlmacen In oeMaterial.ListaAlmacenesAsignados
                        If almacen.TipoOperacion = "" Then almacen.TipoOperacion = .TipoOperacion
                        almacen.IdMaterial = stResultado(0)
                        almacen.PrefijoID = .PrefijoID '@0001
                        odMaterialAlmacen.GuardarDetalle(almacen)
                    Next

                    If .oeMaterial_DisenoNeu IsNot Nothing Then
                        .oeMaterial_DisenoNeu.PrefijoID = .PrefijoID '@0001
                        If .oeMaterial_DisenoNeu.Id <> "" Then
                            .oeMaterial_DisenoNeu.TipoOperacion = "A"
                            .oeMaterial_DisenoNeu.IdMaterial = stResultado(0)
                            odMatDisNeu.Guardar(.oeMaterial_DisenoNeu)
                        Else
                            If .oeMaterial_DisenoNeu.IdDisenoNeumatico <> "" Then
                                .oeMaterial_DisenoNeu.TipoOperacion = "I"
                                .oeMaterial_DisenoNeu.IdMaterial = stResultado(0)
                                odMatDisNeu.Guardar(.oeMaterial_DisenoNeu)
                            End If
                        End If
                    End If
                    transScope.Complete()
                    Return True
                End With
            End Using
        Catch ex As Exception
            Throw ex 
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del material,a travez del procedimiento almacenado
    ''' STD.Isp_Material_IAE,por el cual va a ser enviado el id del material a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeMaterial">Recibe una variable oeMaterial de tipo objeto e_Material</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>

    Public Function Eliminar(ByVal oeMaterial As e_Material) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Material_IAE", "E", "", oeMaterial.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDS(ByVal oeMaterial As e_Material) As DataSet
        Try
            With oeMaterial
                Return sqlhelper.ExecuteDataset("STD.Isp_Material_Listar", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .Codigo, _
                                                .Nombre, "", "", "", "", "", .Tipo)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
