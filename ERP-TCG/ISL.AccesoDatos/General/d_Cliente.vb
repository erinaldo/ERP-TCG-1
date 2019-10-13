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
''' Clase que gestiona los clientes que trabajan con la empresa
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla ClienteProveedor,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Cliente

    Private sqlhelper As New SqlHelper

    Private oeCliente As e_Cliente
    Private oePersona As New e_Persona
    Private odPersona As New d_Persona
    Private oeEmpresa As New e_Empresa
    Private odEmpresa As New d_Empresa

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo ----- y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeCliente) de tipo e_Cliente</returns>
    ''' <remarks>Capa del Sistema:Capa Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Cliente
        Try
            Dim oeCliente = New e_Cliente( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("TipoPersonaEmpresa").ToString _
                             , o_fila("IdPersonaEmpresa").ToString _
                             , o_fila("Nombre").ToString.Trim _
                             , o_fila("FechaActividad").ToString _
                             , o_fila("Comisionista").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("IndRelacionada").ToString _
            )
            Return oeCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene un cliente, el cual es consultado por el procedimiento almacenado [STD].[Isp_Cliente_Listar]
    ''' enviando su id del cliente.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Cliente.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCliente">Objeto cliente, para recuperar datos debe tener asignado el Id del cliente</param>
    ''' <returns>Devuelve una varible oeCliente de tipo e_Cliente</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeCliente As e_Cliente) As e_Cliente
        Try
            Dim ds As DataSet
            Dim TipoOperacion As String
            TipoOperacion = oeCliente.TipoOperacion
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Cliente_Listar]", _
                                            oeCliente.TipoOperacion, _
                                            oeCliente.Id, _
                                            oeCliente.Codigo, _
                                            oeCliente.TipoPersonaEmpresa, _
                                            oeCliente.Activo, _
                                            oeCliente.Comisionista, _
                                            oeCliente.Dni, _
                                            oeCliente.TipoClienteProveedor, _
                                            oeCliente.IdPersona)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCliente = Cargar(ds.Tables(0).Rows(0))
                If TipoOperacion <> "1" Then
                    If oeCliente.TipoPersonaEmpresa = 1 Then
                        oePersona = New e_Persona
                        oePersona.Id = oeCliente.IdPersona
                        oePersona = odPersona.Obtener(oePersona)
                        oeCliente.oePersona = oePersona
                    Else
                        oeEmpresa = New e_Empresa
                        oeEmpresa.Id = oeCliente.IdEmpresa
                        oeEmpresa = odEmpresa.Obtener(oeEmpresa)
                        oeCliente.oeEmpresa = oeEmpresa
                    End If
                End If
            Else
                oeCliente = New e_Cliente
            End If
            Return oeCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Cliente, el cual es consultado por el procedimiento almacenado [STD].[Isp_Cliente_Listar]
    ''' enviando sus atributos del cliente.Una vez obtenido los registros son cargados y devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCliente">Recibe una Variable oeCliente de tipo e_Cliente </param>
    ''' <returns>Devuelve una lista generica(ldCliente) de objetos de tipo e_Cliente</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeCliente As e_Cliente) As List(Of e_Cliente)
        Try
            Dim ldCliente As New List(Of e_Cliente)
            Dim ds As DataSet
            With oeCliente
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Cliente_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .Activo _
                        , .Comisionista _
                        , .Dni _
                        , .TipoClienteProveedor _
                        , .IdPersona _
                        , .Nombre)
            End With

            oeCliente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCliente = Cargar(o_Fila)
                    ldCliente.Add(oeCliente)
                Next
            End If
            Return ldCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal Listacliente As List(Of e_Cliente))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Cliente In Listacliente
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos del cliente,a travez del procedimiento almacenado
    ''' CON.ISP_XXXXXXXXXXXXXXX_IAE,por el cual van a ser enviados y registrados los datos del cliente y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCliente">Recibe una variable oeCliente de tipo e_Cliente</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro del 
    ''' cliente es positiva= true sino false Capa del Sistema:Capa Datos</remarks>
    Public Function Guardar(ByVal oeCliente As e_Cliente) As Boolean
        Try
            Dim idPersonaEmpresa As String = ""
            With oeCliente
                If .TipoPersonaEmpresa = 1 Then
                    oeCliente.oePersona.Activo = oeCliente.Activo
                    oeCliente.oePersona.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odPersona.Guardar(oeCliente.oePersona)
                    oeCliente.IdPersona = idPersonaEmpresa
                Else
                    oeCliente.oeEmpresa.Activo = oeCliente.Activo
                    oeCliente.oeEmpresa.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odEmpresa.Guardar(oeCliente.oeEmpresa)
                    oeCliente.IdPersona = idPersonaEmpresa
                End If
                sqlhelper.ExecuteNonQuery("STD.Isp_Cliente_IAE", .TipoOperacion, _
                        .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .IdPersona _
                        , .FechaActividad _
                        , .Comisionista _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarClienteCom(ByVal oeCliente As e_Cliente) As Integer
        Try
            Dim codigo = 0
            Dim idPersonaEmpresa As String = ""
            With oeCliente
                If .TipoPersonaEmpresa = 1 Then
                    oeCliente.oePersona.Activo = oeCliente.Activo
                    oeCliente.oePersona.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odPersona.Guardar(oeCliente.oePersona)
                    oeCliente.IdPersona = idPersonaEmpresa
                Else
                    oeCliente.oeEmpresa.Activo = oeCliente.Activo
                    oeCliente.oeEmpresa.PrefijoID = oeCliente.PrefijoID '@0001
                    idPersonaEmpresa = odEmpresa.Guardar(oeCliente.oeEmpresa)
                    oeCliente.IdPersona = idPersonaEmpresa
                End If
                codigo = sqlhelper.ExecuteScalar("STD.Isp_Cliente_IAE", .TipoOperacion,
                        .Id _
                        , .Codigo _
                        , .TipoPersonaEmpresa _
                        , .IdPersona _
                        , .FechaActividad _
                        , .Comisionista _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return codigo
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro del cliente,a travez del procedimiento almacenado
    ''' CON.ISP_XXXXXXXXXXXXXXX_IAE,por el cual va a ser enviado el id del cliente a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeCliente">Recibe una variable oeCliente de tipo objeto e_Cliente</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeCliente As e_Cliente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Cliente_IAE", "E", oeCliente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

   
End Class
