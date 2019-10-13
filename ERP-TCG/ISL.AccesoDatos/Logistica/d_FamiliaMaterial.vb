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
''' Clase que se encarga de gestionar las familias de material de los articulos en almacen, ejemplo, repuestos,familia 10,etc.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla FamiliaMaterial,Capa del Sistema: Capa de Datos.</remarks>

Public Class d_FamiliaMaterial

    Private sqlhelper As New SqlHelper

    Private oeFamiliaMaterial As New e_FamiliaMaterial
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_FamiliaMaterial y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oefamiliamaterial) de tipo e_FamiliaMaterial</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_FamiliaMaterial
        Try
            Dim oefamiliamaterial = New e_FamiliaMaterial( _
                                                          fila("Id"), _
                                                          fila("Codigo"), _
                                                          fila("Nombre"), _
                                                          fila("Activo"), _
                                                          fila("IdTipoMaterial"), _
                                                          fila("TipoMaterial"))
            Return oefamiliamaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una familia de material, el cual es consultado por el procedimiento almacenado ALM.Isp_FamiliaMaterial_Listar
    ''' enviando su id de la familia de material.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_FamiliaMaterial.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFamiliaMaterial">Recibe una variable oeFamiliaMaterial de tipo e_FamiliaMaterial</param>
    ''' <returns>Devuelve una varible oeFamiliaMaterial de tipo e_FamiliaMaterial</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>
    Public Function Obtener(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As e_FamiliaMaterial
        Try
            Dim ds As New DataSet
            With oeFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_FamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre _
                                              )
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeFamiliaMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeFamiliaMaterial = New e_FamiliaMaterial
            End If
            Return oeFamiliaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_FamiliaMaterial, el cual es consultado por el procedimiento almacenado ALM.Isp_FamiliaMaterial_Listar
    ''' enviando sus atributos de la familia de material.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFamiliaMaterial">Recibe una Variable oeFamiliaMaterial de tipo e_FamiliaMaterial</param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_FamiliaMaterial</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa Datos</remarks>

    Public Function Listar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As List(Of e_FamiliaMaterial)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_FamiliaMaterial)
            With oeFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_FamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Activo, _
                                              .IdTipoMaterial)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeFamiliaMaterial = Cargar(fila)
                    lista.Add(oeFamiliaMaterial)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la familia material,a travez del procedimiento almacenado
    ''' ALM.Isp_FamiliaMaterial_IAE,por el cual van a ser enviados y registrados los datos de la familia de material y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFamiliaMaterial">Recibe una variable oeFamiliaMaterial de tipo e_FamiliaMaterial </param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro 
    ''' de tipo de documento es positiva= true sino false Capa del Sistema:Capa Datos</remarks>
    Public Function Guardar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean
        Try
            With oeFamiliaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_FamiliaMaterial_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .IdTipoMaterial,
                                          .Codigo,
                                          .Nombre,
                                          .Activo,
                                          .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del tipo de la familia de material,a travez del procedimiento almacenado
    ''' ALM.Isp_FamiliaMaterial_IAE,por el cual va a ser enviado el id de la familia material a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeFamiliaMaterial">Recibe una variable oeFamiliaMaterial de tipo objeto e_FamiliaMaterial</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa Datos</remarks>

    Public Function Eliminar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean
        Try
            With oeFamiliaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_FamiliaMaterial_IAE", _
                                          "E", "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
