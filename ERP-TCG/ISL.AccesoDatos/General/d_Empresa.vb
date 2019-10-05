Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

''' <summary>
''' Clase que gestiona las empresa.
''' Fecha de Actualizacion:31/10/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Empresa,Capa del Sistema: Capa de Acceso a Datos.</remarks>

Public Class d_Empresa

    Dim sqlHelper As New SqlHelper
    Private odTelefono As New d_Telefono
    Private odEmail As New d_Email
    Private oeEmail As New e_Email
    Private oeTelefono As New e_Telefono
    Private oeClienteProveedor As New e_ClienteProveedor
    Private odClienteProveedor As New d_ClienteProveedor
    Private oePETipoPago As New e_PersonaEmpresa_TipoPago
    Private odPETipoPago As New d_PersonaEmpresa_TipoPago
    Private oePersona As New e_Persona
    Private odPersona As New d_Persona

    ''' <summary>
    ''' El metodo se encarga de recibir un registro en una variable o_fila de tipo datarow
    ''' el cual es cargado a una varible de tipo e_Empresa y enviada al metodo que lo llamo.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="o_fila">Recibe una variable o_fila de tipo datarow.</param>
    ''' <returns>Devuelve una variable(oeEmpresa) de tipo e_Empresa</returns>
    ''' <remarks>Capa del Sistema:Capa de Acceso a Datos</remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Empresa
        Try
            Dim oeEmpresa = New e_Empresa(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("RUC").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdTipoEmpresa").ToString _
                             , o_fila("TipoEmpresa").ToString _
                             , o_fila("IdDireccionTanqueo").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("IndAgentePercepcion").ToString _
                             , o_fila("IndAgenteRetencion").ToString _
                             , o_fila("IndBuenContribuyente").ToString _
                             , o_fila("IndCanjeDocumento").ToString _
                             , o_fila("IndAceptaLetras").ToString _
                             , o_fila("IndAceptaCheque").ToString _
                             , o_fila("Morosidad").ToString _
                             , o_fila("Credito").ToString _
                             , o_fila("IndNivelComercial").ToString _
                             , o_fila("IndClasificacion").ToString _
                             , o_fila("IndRelacionada").ToString _
                             , o_fila("DireccionFiscal").ToString)
            oeEmpresa.IndCategoriaEmpresaSGI = o_fila("IndCategoriaSGI").ToString
            Return oeEmpresa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una empresa, el cual es consultado por el procedimiento almacenado STD.Isp_Empresa_Listar
    ''' enviando su id de la empresa.Una vez obtenido el registro consultado es cargado y devuelto en un objeto de tipo e_Empresa.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEmpresa">Recibe una variable oe de tipo e_Empresa</param>
    ''' <returns>Devuelve una varible oe de tipo e_Empresa</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeEmpresa As e_Empresa) As e_Empresa
        Try
            Dim ds As DataSet
            Dim oeDireccionEP As New e_Direccion_EmpresaPersona
            Dim odDireccionEP As New d_Direccion_EmpresaPersona
            Dim IndCompleto As Boolean = oeEmpresa.CargaCompleta 'Para Obtener el Objeto Empresa Completo
            ds = sqlHelper.ExecuteDataset("STD.Isp_Empresa_Listar", "", oeEmpresa.Id, "", oeEmpresa.Ruc, oeEmpresa.Nombre)
            oeEmpresa = New e_Empresa
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeEmpresa = Cargar(ds.Tables(0).Rows(0))
                If IndCompleto Then
                    'Obtiene Direcciones
                    oeDireccionEP.IdPersonaEmpresa = oeEmpresa.Id
                    oeDireccionEP.TipoPersonaEmpresa = "2"
                    oeEmpresa.leDireccionEP = odDireccionEP.ListarTodo(oeDireccionEP)
                    'Obtiene Emails
                    oeEmail.TipoOperacion = "2"
                    oeEmail.Principal = -1
                    oeEmail.IdPersonaEmpresa = oeEmpresa.Id
                    oeEmpresa.leEmail = odEmail.Listar(oeEmail)
                    'Obtiene Telefonos
                    oeTelefono.TipoOperacion = "2"
                    oeTelefono.IdPersonaEmpresa = oeEmpresa.Id
                    oeEmpresa.leTelefono = odTelefono.Listar(oeTelefono)
                    'Obtiene contactos 
                    oePersona.TipoOperacion = "C"
                    oePersona.Id = oeEmpresa.Id
                    oeEmpresa.leContactos = odPersona.Listar(oePersona)
                    '  oeEmpresa.leTelefono = odTelefono.Listar(oeTelefono)
                    'Obtiene Indicadores Cliente, Proveedor, Comisionista
                    oeClienteProveedor = New e_ClienteProveedor
                    oeClienteProveedor.TipoOperacion = ""
                    oeClienteProveedor.Activo = True
                    oeClienteProveedor.TipoPersonaEmpresa = 2
                    oeClienteProveedor.IdPersonaEmpresa = oeEmpresa.Id
                    oeEmpresa.oeClienteProveedor = odClienteProveedor.Obtener(oeClienteProveedor)
                    'Obtener Tipo Pago
                    If oeEmpresa.oeClienteProveedor.Id <> "" Then
                        oePETipoPago.TipoOperacion = ""
                        oePETipoPago.IdClienteProveedor = oeEmpresa.oeClienteProveedor.Id
                        oeEmpresa.leTipoPago = odPETipoPago.Listar(oePETipoPago)
                    End If
                End If
            End If
            Return oeEmpresa
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Metodo que obtiene una lista generica de objetos de tipo e_Empresa, el cual es consultado por el procedimiento almacenado
    ''' STD.Isp_Empresa_Listar enviando sus atributos de la empresa.Una vez obtenido los registros son cargados y 
    ''' devueltos en una lista generica.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEmpresa">Recibe una Variable oeEmpresa de tipo e_Empresa </param>
    ''' <returns>Devuelve una lista generica(ldEmpresa) de objetos de tipo e_Empresa</returns>
    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeEmpresa As e_Empresa) As List(Of e_Empresa)
        Try
            Dim ldEmpresa As New List(Of e_Empresa)
            Dim ds As DataSet
            With oeEmpresa
                ds = sqlHelper.ExecuteDataset("STD.Isp_Empresa_Listar", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .Codigo _
                                            , .Ruc _
                                            , .Nombre _
                                            , .Abreviatura _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .IdTipoEmpresa _
                                            , .IndCategoriaEmpresaSGI)
            End With
            oeEmpresa = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEmpresa = Cargar(o_Fila)                                     
                    ldEmpresa.Add(oeEmpresa)
                Next
            Else
                ldEmpresa = New List(Of e_Empresa)
            End If
            Return ldEmpresa
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal Empresa As List(Of e_Empresa))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Empresa In Empresa
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    ''' <summary>
    ''' Metodo que se encargara de registrar los datos de la empresa,a travez del procedimiento almacenado
    ''' STD.Isp_Empresa_IAE,por el cual van a ser enviados y registrados los datos de la empresa y
    ''' obtendremos una respuesta de confirmacion del registro guardado
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEmpresa">Recibe una variable oeEmpresa de tipo e_Empresa</param>
    ''' <returns>Devuelve una valor de tipo Boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"I" o "A" de actualizar,Si la confirmacion del registro
    '''  de la empresa es positiva= true sino false,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Guardar(ByVal oeEmpresa As e_Empresa) As String
        Try

            Dim odDireccionEP As New d_Direccion_EmpresaPersona
            Dim oeDireccion As New e_Direccion
            Dim odDireccion As New d_Direccion
            Dim idClienteProveedor As String = ""

            Dim id As String = ""
            Dim idDireccion As String = ""
            Using TransScope As New TransactionScope()
                With oeEmpresa
                    id = sqlHelper.ExecuteScalar("STD.Isp_Empresa_IAE", .TipoOperacion, _
                            .Id _
                            , .Codigo _
                            , .Ruc _
                            , .Nombre _
                            , .Abreviatura _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .PrefijoID _
                            , .IdTipoEmpresa _
                            , .IdMoneda _
                            , .IndAgentePercepcion _
                            , .IndAgenteRetencion _
                            , .IndBuenContribuyente _
                            , .IndCanjeDocumento _
                            , .IndAceptaLetras _
                            , .IndAceptaCheque _
                            , .Morosidad _
                            , .Credito _
                            , .IndNivelComercial _
                            , .IndClasificacion _
                            , .IndRelacionada _
                            , "" _
                            , "" _
                            , .DireccionFiscal)

                    If .leDireccionEP IsNot Nothing Then
                        For Each oeDEP As e_Direccion_EmpresaPersona In .leDireccionEP
                            oeDEP.TipoPersonaEmpresa = "2"
                            oeDEP.IdPersonaEmpresa = id
                            oeDEP.PrefijoID = .PrefijoID '@0001
                            Select Case oeDEP.TipoOperacion
                                Case "C"
                                    oeDireccion = New e_Direccion
                                    oeDireccion.TipoOperacion = "I"
                                    oeDireccion.UsuarioCreacion = .UsuarioCreacion
                                    oeDireccion.CCPP = oeDEP.oeDireccion.CCPP
                                    oeDireccion.IdTipoVia = oeDEP.oeDireccion.IdTipoVia
                                    oeDireccion.IdTipoZona = oeDEP.oeDireccion.IdTipoZona
                                    oeDireccion.Numero = oeDEP.oeDireccion.Numero
                                    oeDireccion.Departamento = oeDEP.oeDireccion.Departamento
                                    oeDireccion.NumeroInterior = oeDEP.oeDireccion.NumeroInterior
                                    oeDireccion.Manzana = oeDEP.oeDireccion.Manzana
                                    oeDireccion.Lote = oeDEP.oeDireccion.Lote
                                    oeDireccion.Kilometro = oeDEP.oeDireccion.Kilometro
                                    oeDireccion.Block = oeDEP.oeDireccion.Block
                                    oeDireccion.Etapa = oeDEP.oeDireccion.Etapa
                                    oeDireccion.Referencia = oeDEP.oeDireccion.Referencia
                                    oeDireccion.Via = oeDEP.oeDireccion.Via
                                    oeDireccion.Zona = oeDEP.oeDireccion.Zona
                                    oeDireccion.IdLugar = oeDEP.oeDireccion.IdLugar
                                    oeDireccion.CentroCosto = oeDEP.oeDireccion.IdLugar
                                    oeDireccion.PrefijoID = .PrefijoID '@0001
                                    idDireccion = odDireccion.Guardar(oeDireccion)
                                    oeDEP.oeDireccion.Id = idDireccion
                                    oeDEP.TipoOperacion = "I"
                                    odDireccionEP.Guardar(oeDEP)
                                Case "I"
                                    odDireccionEP.Guardar(oeDEP)
                                Case "A"
                                    oeDireccion = New e_Direccion
                                    oeDireccion.TipoOperacion = "A"
                                    oeDireccion.Id = oeDEP.oeDireccion.Id
                                    oeDireccion.IdTipoVia = oeDEP.oeDireccion.IdTipoVia
                                    oeDireccion.IdTipoZona = oeDEP.oeDireccion.IdTipoZona
                                    oeDireccion.Via = oeDEP.oeDireccion.Via
                                    oeDireccion.Zona = oeDEP.oeDireccion.Zona
                                    oeDireccion.Numero = oeDEP.oeDireccion.Numero
                                    oeDireccion.Departamento = oeDEP.oeDireccion.Departamento
                                    oeDireccion.NumeroInterior = oeDEP.oeDireccion.NumeroInterior
                                    oeDireccion.Manzana = oeDEP.oeDireccion.Manzana
                                    oeDireccion.Lote = oeDEP.oeDireccion.Lote
                                    oeDireccion.Kilometro = oeDEP.oeDireccion.Kilometro
                                    oeDireccion.Block = oeDEP.oeDireccion.Block
                                    oeDireccion.Etapa = oeDEP.oeDireccion.Etapa
                                    oeDireccion.Referencia = oeDEP.oeDireccion.Referencia
                                    oeDireccion.CCPP = oeDEP.oeDireccion.CCPP
                                    oeDireccion.IdLugar = oeDEP.oeDireccion.IdLugar
                                    oeDireccion.CentroCosto = oeDEP.oeDireccion.CentroCosto
                                    oeDireccion.IdPais = oeDEP.oeDireccion.IdPais
                                    oeDireccion.PrefijoID = .PrefijoID '@0001
                                    odDireccion.Guardar(oeDireccion)
                                    odDireccionEP.Guardar(oeDEP)
                                Case "E"
                                    odDireccionEP.Eliminar(oeDEP)
                            End Select

                        Next
                    End If
                    If Not .leEmail Is Nothing Then
                        For Each oeEmail As e_Email In .leEmail
                            oeEmail.TipoPersonaEmpresa = 2
                            oeEmail.IdPersonaEmpresa = id
                            oeEmail.PrefijoID = .PrefijoID '@0001
                            odEmail.Guardar(oeEmail)
                        Next
                    End If
                    If Not .leTelefono Is Nothing Then
                        For Each oeTelefono As e_Telefono In .leTelefono
                            oeTelefono.TipoPersonaEmpresa = 2
                            oeTelefono.IdPersonaEmpresa = id
                            oeTelefono.PrefijoID = .PrefijoID '@0001
                            odTelefono.Guardar(oeTelefono)
                        Next
                    End If
                    If .oeClienteProveedor.Id <> "" Then
                        .oeClienteProveedor.TipoOperacion = "A"
                        .oeClienteProveedor.Activo = True
                        .oeClienteProveedor.PrefijoID = .PrefijoID '@0001
                        odClienteProveedor.Guardar(.oeClienteProveedor)
                    Else
                        If .oeClienteProveedor.Cliente = 1 _
                        Or .oeClienteProveedor.Proveedor = 1 _
                        Or .oeClienteProveedor.Comisionista = 1 Then
                            .oeClienteProveedor.TipoOperacion = "I"
                            .oeClienteProveedor.Activo = True
                            .oeClienteProveedor.UsuarioCreacion = .UsuarioCreacion
                            .oeClienteProveedor.TipoPersonaEmpresa = 2
                            .oeClienteProveedor.Codigo = .Codigo
                            .oeClienteProveedor.IdPersonaEmpresa = id
                            .oeClienteProveedor.PrefijoID = .PrefijoID '@0001
                            odClienteProveedor.Guardar(.oeClienteProveedor)
                        End If
                    End If
                    idClienteProveedor = .oeClienteProveedor.Id
                    If Not .leTipoPago Is Nothing Then
                        For Each oeTipoPago As e_PersonaEmpresa_TipoPago In .leTipoPago
                            oeTipoPago.PrefijoID = .PrefijoID '@0001
                            oeTipoPago.IdClienteProveedor = .oeClienteProveedor.Id
                            Select Case oeTipoPago.TipoOperacion
                                Case "I" : odPETipoPago.Guardar(oeTipoPago)
                                Case "E" : odPETipoPago.Eliminar(oeTipoPago)
                            End Select
                        Next
                    End If
                    If .leContactos IsNot Nothing Then
                        For Each oePersona As e_Persona In .leContactos
                            If oePersona.Id <> "" Then
                                oePersona.UsuarioCreacion = oeEmpresa.UsuarioCreacion
                                oePersona.PrefijoID = .PrefijoID '@0001
                                InsertarContacto(oePersona, id)
                            End If
                        Next
                    End If
                End With
                TransScope.Complete()
                Return IIf(idClienteProveedor.Equals(""), id, idClienteProveedor)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizaFec(ByVal oeEmpresa As e_Empresa) As Boolean
        Try

            With oeEmpresa
                sqlHelper.ExecuteNonQuery("STD.Isp_Empresa_IAE", .TipoOperacion, _
                        .Id _
                        , .Codigo _
                        , .Ruc _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID _
                        , .IdTipoEmpresa _
                    )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function InsertarContacto(ByVal oePersona As e_Persona, ByVal codigo As String) As Boolean
        Try

            With oePersona
                sqlHelper.ExecuteNonQuery("STD.Isp_Empresa_IAE", "C", _
                        codigo _
                        , .Codigo _
                        , "" _
                        , "" _
                        , "" _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID _
                        , "" _
                        , "" _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , 0 _
                        , .Id _
                        , .IdContacto
                    )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Metodo que se encargara de desactivar un regitro de la empresa,a travez del procedimiento almacenado
    ''' STD.Isp_Empresa_IAE,por el cual va a ser enviado el id de la empresa a desactivar, obtendremos 
    ''' una respuesta de confirmacion del registro guardado.
    ''' Fecha de Actualizacion:31/10/2011
    ''' </summary>
    ''' <param name="oeEmpresa">Recibe una variable oeEmpresa de tipo objeto e_Empresa</param>
    ''' <returns>Devuelve un valor de tipo boolean</returns>
    ''' <remarks>Manda como parametro el tipo de operacion:"E",Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Eliminar(ByVal oeEmpresa As e_Empresa) As Boolean
        Try
            sqlHelper.ExecuteNonQuery("STD.Isp_Empresa_IAE", "E", oeEmpresa.Id, "", "", "", "", 1, oeEmpresa.UsuarioCreacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
