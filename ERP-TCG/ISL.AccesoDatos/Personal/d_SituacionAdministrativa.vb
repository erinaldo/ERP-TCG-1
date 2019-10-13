'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
''' <summary>
''' Clase que gestiona las diversas situaciones administrativas del personal o empleados de la empresa
''' Fecha de Actualizacion:05/12/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla SituacionAdministrativa,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_SituacionAdministrativa
    Private oeSituacionAdministrativa As New e_SituacionAdministrativa
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_SituacionAdministrativa y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeSituacionAdministrativa) de tipo e_SituacionAdministrativa</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_SituacionAdministrativa
        Try
            Dim oeSituacionAdministrativa = New e_SituacionAdministrativa( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Remunerado").ToString _
                             , o_fila("AcumulaVacaciones").ToString _
                             , o_fila("CodigoPlame").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeSituacionAdministrativa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un SituacionAdministrativa de establecimiento, el cual es consultado por el procedimiento almacenado PER.Isp_SituacionAdministrativa_Listar
    ''' enviando su id del SituacionAdministrativa.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_SituacionAdministrativa.
    ''' Fecha de Actualizacion:05/12/2011
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa">Recibe una variable oeSituacionAdministrativa de tipo e_SituacionAdministrativa</param>
    ''' <returns>Devuelve una varible oeSituacionAdministrativa de tipo e_SituacionAdministrativa</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As e_SituacionAdministrativa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_SituacionAdministrativa_Listar", "", oeSituacionAdministrativa.Id, oeSituacionAdministrativa.Codigo, oeSituacionAdministrativa.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSituacionAdministrativa = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSituacionAdministrativa = New e_SituacionAdministrativa
            End If
            Return oeSituacionAdministrativa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Caso especial para obtener la situación administrativa específica a partir de su Id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal id As String) As e_SituacionAdministrativa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_SituacionAdministrativa_Listar", "", oeSituacionAdministrativa.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeSituacionAdministrativa = Cargar(ds.Tables(0).Rows(0))
            Else
                oeSituacionAdministrativa = New e_SituacionAdministrativa
            End If
            Return oeSituacionAdministrativa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_SituacionAdministrativa, el cual es consultado por el procedimiento almacenado PER.Isp_SituacionAdministrativa_Listar
    ''' enviando sus atributos del SituacionAdministrativa.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:05/12/2011
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa">Recibe una Variable oeSituacionAdministrativa de tipo e_SituacionAdministrativa </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_SituacionAdministrativa</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As List(Of e_SituacionAdministrativa)
        Try
            Dim ldSituacionAdministrativa As New List(Of e_SituacionAdministrativa)
            Dim ds As DataSet
            With oeSituacionAdministrativa
                ds = sqlhelper.ExecuteDataset("PER.Isp_SituacionAdministrativa_Listar", "" _
                                        , .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                         , .Activo)

                If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeSituacionAdministrativa = Cargar(fila)
                        ldSituacionAdministrativa.Add(oeSituacionAdministrativa)
                    Next
                End If
            End With
            Return ldSituacionAdministrativa

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del SituacionAdministrativa,a travez del procedimiento almacenado
    ''' PER.Isp_SituacionAdministrativa_IAE,por el cual van a ser enviados y registrados los datos del SituacionAdministrativa y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:05/12/2011
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa">Recibe una variable oeSituacionAdministrativa de tipo e_SituacionAdministrativa</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro de 
    ''' SituacionAdministrativa es positiva= true sino false Capa del Sistema:Capa Datos</remarks>
    Public Function Guardar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean
        Try
            With oeSituacionAdministrativa
                sqlhelper.ExecuteNonQuery("PER.Isp_SituacionAdministrativa_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                        .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Abreviatura _
                                        , .Remunerado _
                                        , .AcumulaVacaciones _
                                        , .CodigoPlame _
                                        , .IndTipo _
                                        , .UsuarioCreacion _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de SituacionAdministrativa,a travez del procedimiento almacenado
    ''' PER.Isp_SituacionAdministrativa_IAE,por el cual va a ser enviado el id del SituacionAdministrativa a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:05/12/2011
    ''' </summary>
    ''' <param name="oeSituacionAdministrativa">Recibe una variable oeSituacionAdministrativa de tipo objeto e_SituacionAdministrativa</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeSituacionAdministrativa As e_SituacionAdministrativa) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_SituacionAdministrativa_IAE", _
                                      "E", _
                                        "", _
                                        oeSituacionAdministrativa.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

