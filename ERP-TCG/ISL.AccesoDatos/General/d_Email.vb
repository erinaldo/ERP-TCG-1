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
''' Clase que permite el acceso a los datos del Email 
''' </summary>
''' <remarks></remarks>
''' <example>Este ejemplo permite recuperar una lista de todos los <c>Emails</c> activos 
''' Método 
''' <code> 
'''     'Definimos el objeto de tipo d_Email
'''     Dim odEmail As New d_Email
'''     'Debemos asignar una entidad de tipo e_Email
'''     Dim oeEmail As New e_Email
'''     'Podemos asignarle valores a la entidad de tipo e_Email
'''     oeEmail.Activo = True
'''     'Recuperamos una lista de Emails activos a partir de una entidad de tipo e_Email
'''     Return odEmail.Listar(oeEmail)
''' </code> 
''' </example> 
''' <history> 
'''     [Pablo Chávez] 31/10/2011 Creación 
''' </history>
Public Class d_Email

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo ----- y enviada al metodo que lo llamo.
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeEmail) de tipo e_Email</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Email
        Try
            Dim oeEmail = New e_Email( _
                             o_fila("Id") _
                             , o_fila("TipoPersonaEmpresa") _
                             , o_fila("IdPersonaEmpresa") _
                             , o_fila("Nombre") _
                             , o_fila("Principal") _
                             , o_fila("Activo") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion") _
                             , o_fila("NombreCompleto") _
            )
            Return oeEmail
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un email, el cual es consultado por el procedimiento almacenado STD.Isp_Email_Listar
    ''' enviando su id del email.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Email.
    ''' </summary>
    ''' <param name="oeEmail">Recibe una variable oeEmail de tipo e_Email</param>
    ''' <returns>Devuelve una varible oeEmail de tipo e_Email</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeEmail As e_Email) As e_Email
        Try
            Dim ds As DataSet
            With oeEmail
                ds = sqlhelper.ExecuteDataset("STD.Isp_Email_Listar", "", .Id, .TipoPersonaEmpresa, .IdPersonaEmpresa, .Principal, .Nombre, .UsuarioCreacion, .Activo)
            End With
            oeEmail = New e_Email
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEmail = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEmail
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Email, el cual es consultado por el procedimiento almacenado STD.Isp_Email_Listar
    ''' enviando sus atributos del email.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' </summary>
    ''' <param name="oeEmail">Recibe una Variable oeEmail de tipo e_Email </param>
    ''' <returns>Devuelve una lista generica(ldEmail) de objetos de tipo e_Email</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeEmail As e_Email) As List(Of e_Email)
        Try
            Dim ldEmail As New List(Of e_Email)
            Dim ds As DataSet
            With oeEmail
                ds = sqlhelper.ExecuteDataset("STD.Isp_Email_Listar", .TipoOperacion _
                        , .Id _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .Principal _
                        , .Nombre _
                        , .UsuarioCreacion _
                         , .Activo _
                        )
            End With
            oeEmail = New e_Email
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEmail = Cargar(o_Fila)
                    ldEmail.Add(oeEmail)
                Next
                '    Return ldEmail
                'Else
                '    Return Nothing
            End If
            Return ldEmail
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del email,a travez del procedimiento almacenado
    ''' STD.Isp_Email_IAE,por el cual van a ser enviados y registrados los datos del email y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEmail">Recibe una variable oeEmail de tipo e_Email</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del 
    ''' registro del email es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeEmail As e_Email) As Boolean
        Try
            With oeEmail
                sqlhelper.ExecuteNonQuery("STD.Isp_Email_IAE", .TipoOperacion _
                        , .Id _
                        , .TipoPersonaEmpresa _
                        , .IdPersonaEmpresa _
                        , .Principal _
                        , .Nombre _
                         , .UsuarioCreacion _
                        , .Activo _
                       , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLista(leEmail As List(Of e_Email)) As Boolean
        Try
            For Each oeAuxEmail In leEmail
                Guardar(oeAuxEmail)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del email,a travez del procedimiento almacenado
    ''' STD.Isp_Email_IAE,por el cual va a ser enviado el id del email a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEmail">Recibe una variable oeEmail de tipo objeto e_Email</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeEmail As e_Email) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Email_IAE", "E", oeEmail.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
