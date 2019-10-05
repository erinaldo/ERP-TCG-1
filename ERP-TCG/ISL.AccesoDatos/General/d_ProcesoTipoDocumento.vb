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
''' Clase que gestiona la ProcesoTipoDocumento 
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla ProcesoTipoDocumento,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_ProcesoTipoDocumento
    Private oeProcesoTipoDocumento As e_ProcesoTipoDocumento
    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_ProcesoTipoDocumento y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeProcesoTipoDocumento) de tipo e_ProcesoTipoDocumento</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoTipoDocumento
        Try
            Dim oeProcesoTipoDocumento = New e_ProcesoTipoDocumento(o_fila("Id"), _
                                                                    o_fila("IdTipoDocumento"), _
                                                                    o_fila("IdProceso"), _
                                                                    o_fila("Activo"), _
                                                                    o_fila("Proceso"), _
                                                                    o_fila("TipoDocumento"), _
                                                                    o_fila("Codigo"))
            Return oeProcesoTipoDocumento
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que obtiene una ProcesoTipoDocumento, el cual es consultado por el procedimiento almacenado MAN.Isp_ProcesoTipoDocumento_Listar
    ''' enviando su id de la ProcesoTipoDocumentoj.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_ProcesoTipoDocumento.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoTipoDocumento">Recibe una variable oeProcesoTipoDocumento de tipo e_ProcesoTipoDocumento</param>
    ''' <returns>Devuelve una varible oeProcesoTipoDocumento de tipo e_ProcesoTipoDocumento</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoTipoDocumento_Listar", "", oeProcesoTipoDocumento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoTipoDocumento = Cargar(ds.Tables(0).Rows(0))
                Return oeProcesoTipoDocumento
            Else
                oeProcesoTipoDocumento = New e_ProcesoTipoDocumento
                Return oeProcesoTipoDocumento
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Obtener un proceso único asociado a un documento específico
    ''' </summary>
    ''' <param name="oeProcesoTipoDocumento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerUnico(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As e_ProcesoTipoDocumento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoTipoDocumento_Listar", "", "", oeProcesoTipoDocumento.IdTipoDocumento, oeProcesoTipoDocumento.IdProceso)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoTipoDocumento = Cargar(ds.Tables(0).Rows(0))
                Return oeProcesoTipoDocumento
            Else
                oeProcesoTipoDocumento = New e_ProcesoTipoDocumento
                Return oeProcesoTipoDocumento
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_ProcesoTipoDocumento, el cual es consultado por el procedimiento almacenado [MAN].[Isp_ProcesoTipoDocumento_Listar]
    ''' enviando sus atributos de la ProcesoTipoDocumento.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoTipoDocumento">Recibe una Variable oeProcesoTipoDocumento de tipo e_ProcesoTipoDocumento </param>
    ''' <returns>Devuelve una lista generica(ldProcesoTipoDocumento) de objetos de tipo e_ProcesoTipoDocumento</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As List(Of e_ProcesoTipoDocumento)
        Try
            Dim ldProcesoTipoDocumento As New List(Of e_ProcesoTipoDocumento)
            Dim ds As DataSet
            With oeProcesoTipoDocumento
                ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoTipoDocumento_Listar", .TipoOperacion, .Id, .IdTipoDocumento, .IdProceso, .Activo)
            End With
            oeProcesoTipoDocumento = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesoTipoDocumento = Cargar(o_Fila)
                    ldProcesoTipoDocumento.Add(oeProcesoTipoDocumento)
                Next
                Return ldProcesoTipoDocumento
            Else
                ldProcesoTipoDocumento = New List(Of e_ProcesoTipoDocumento)
                Return ldProcesoTipoDocumento
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la ProcesoTipoDocumento,a travez del procedimiento almacenado
    ''' [STD].[ISP_ProcesoTipoDocumento_IAE],por el cual van a ser enviados y registrados los datos de la ProcesoTipoDocumento y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoTipoDocumento">Recibe una variable oeProcesoTipoDocumento de tipo e_ProcesoTipoDocumento</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del 
    ''' registro de tipo de documento es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean
        Try
            With oeProcesoTipoDocumento
                sqlhelper.ExecuteNonQuery("STD.ISP_ProcesoTipoDocumento_IAE", .TipoOperacion,
                .PrefijoID, .Id, .IdTipoDocumento, .IdProceso, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la ProcesoTipoDocumento,a travez del procedimiento almacenado
    ''' [STD].[ISP_ProcesoTipoDocumento_IAE],por el cual va a ser enviado el id de la ProcesoTipoDocumento a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeProcesoTipoDocumento">Recibe una variable oeProcesoTipoDocumento de tipo objeto e_ProcesoTipoDocumento</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeProcesoTipoDocumento As e_ProcesoTipoDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_ProcesoTipoDocumento_IAE", oeProcesoTipoDocumento.TipoOperacion, "", oeProcesoTipoDocumento.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
