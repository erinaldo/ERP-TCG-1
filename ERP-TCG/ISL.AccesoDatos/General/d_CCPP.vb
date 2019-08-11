Imports ISL.EntidadesWCF
''' <summary>
''' Clase parcial de lo que es ubigeo para acceder a la información de los CCPPs.
''' Fecha de Actualizacion:10/02/2012
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Ubigeo,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_CCPP
    Private sqlhelper As New SqlHelper

    Private oeCCPP As New e_CCPP
    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_CCPP y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:10/02/2012
    ''' </summary>
    ''' <param name="fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeCCPP) de tipo e_CCPP</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Cargar(ByVal fila As DataRow) As e_CCPP
        Try
            Dim oeCCPP = New e_CCPP(fila("Id"), _
                                    fila("CCDD"), _
                                    fila("CCPP"), _
                                    fila("CCDI"), _
                                    fila("CODCCPP"), _
                                    fila("NOMBCCPP"), _
                                    fila("Activo"), _
                                    fila("IdEmpresa"))
            Return oeCCPP
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una CCPP, el cual es consultado por el procedimiento almacenado STD.Isp_CCPP_Listar
    ''' enviando su id de la CCPP.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_CCPP.
    ''' Fecha de Actualizacion:10/02/2012
    ''' </summary>
    ''' <param name="oeCCPP">Recibe una variable oeCCPP de tipo e_CCPP</param>
    ''' <returns>Devuelve una varible oeCCPP de tipo e_CCPP</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeCCPP As e_CCPP) As e_CCPP
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_CCPP_Listar", "", oeCCPP.Id)
            If ds.Tables.Count > 0 Then
                oeCCPP = Cargar(ds.Tables(0).Rows(0))
                Return oeCCPP
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_CCPP, el cual es consultado por el procedimiento almacenado Isp_CCPP_Listar
    ''' enviando sus atributos del CCPP.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:10/02/2012
    ''' </summary>
    ''' <param name="oeCCPP">Recibe una Variable oeCCPP de tipo e_CCPP </param>
    ''' <returns>Devuelve una lista generica(lista) de objetos de tipo e_CCPP</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeCCPP As e_CCPP) As List(Of e_CCPP)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_CCPP)
            With oeCCPP
                ds = sqlhelper.ExecuteDataset("STD.Isp_CCPP_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .CodigoDepartamento, _
                                              .CodigoProvincia, _
                                              .CodigoDistrito, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeCCPP = Cargar(fila)
                        lista.Add(oeCCPP)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del CCPP,a travez del procedimiento almacenado 
    ''' STD.Isp_CCPP_IAE,por el cual van a ser enviados y registrados los datos del CCPP y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:10/02/2012
    ''' </summary>
    ''' <param name="oeCCPP">Recibe una variable oeCCPP de tipo e_CCPP</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del 
    ''' CCPP es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeCCPP As e_CCPP) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeCCPP
                sqlhelper.ExecuteNonQuery("STD.Isp_CCPP_IAE", .TipoOperacion, .Id, .CodigoDepartamento, .CodigoProvincia, .CodigoDistrito, .Codigo, .Nombre, .Activo)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del CCPP,a travez del procedimiento almacenado
    ''' STD.Isp_CCPP_IAE,por el cual va a ser enviado el id del CCPP a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:10/02/2012
    ''' </summary>
    ''' <param name="oeCCPP">Recibe una variable oeCCPP de tipo objeto e_CCPP</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeCCPP As e_CCPP) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeCCPP
                sqlhelper.ExecuteNonQuery("STD.Isp_CCPP_IAE", "E", "", .Id)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
