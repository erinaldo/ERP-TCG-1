Imports ISL.EntidadesWCF
Imports System.Transactions

''' <summary>
''' Clase: Persona
''' Capa: Acceso a Datos
''' Ultima actualización: 08/11/2011
''' </summary>
''' <remarks></remarks>
Public Class d_Persona
    Private sqlhelper As New SqlHelper

    Private oePersona As e_Persona
    Private oeEmail As New e_Email
    Private oeTelefono As New e_Telefono
    Private oeDireccion As New e_Direccion
    Private odTelefono As New d_Telefono
    Private odEmail As New d_Email
    Private odDireccion As New d_Direccion
    Private oeClienteProveedor As New e_ClienteProveedor
    Private odClienteProveedor As New d_ClienteProveedor
    Private oePETipoPago As New e_PersonaEmpresa_TipoPago
    Private odPETipoPago As New d_PersonaEmpresa_TipoPago
    Private oePerDocumento As New e_PersonaDocumento
    Private odPerDocumento As New d_PersonaDocumento

    ''' <summary>
    ''' Carga los datos puntuales de una persona
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Persona
        Try
            Dim objSexo = Nothing
            'Obtiene los valores del sexo de la persona        
            If o_fila("Sexo") IsNot Nothing Then
                objSexo = New e_Sexo(CType(o_fila("Sexo"), String))
            End If
            'Crea a la persona
            Dim oePersona = New e_Persona( _
            o_fila("Id"), o_fila("Codigo"), o_fila("ApellidoPaterno"), o_fila("ApellidoMaterno"), o_fila("Nombre") _
            , objSexo, o_fila("FechaNacimiento"), o_fila("Dni"), o_fila("Activo"))
            If o_fila("IdContacto") IsNot Nothing Then
                oePersona.IdContacto = o_fila("IdContacto").ToString
            End If
            If o_fila("Telefono") IsNot Nothing Then
                oePersona.UsuarioCreacion = o_fila("Telefono").ToString
            End If
            Return oePersona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtener los datos de una persona específica
    ''' </summary>
    ''' <param name="oePersona">Objeto de tipo Persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function Obtener(ByVal oePersona As e_Persona) As e_Persona
        Try
            Dim ds As New DataSet
            Dim oeDireccionEP As New e_Direccion_EmpresaPersona
            Dim odDireccionEP As New d_Direccion_EmpresaPersona
            Dim IndCompleto As Boolean = oePersona.CargaCompleta
            With oePersona
                ds = sqlhelper.ExecuteDataset("PER.Isp_Persona_Listar", "", .Id, .Codigo, .Dni)
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oePersona = Cargar(ds.Tables(0).Rows(0))
                If IndCompleto Then
                    'Obtiene Emails 
                    oeEmail = New e_Email
                    oeEmail.TipoOperacion = "1"
                    oeEmail.Principal = -1
                    oeEmail.IdPersonaEmpresa = oePersona.Id
                    oePersona.leEmail = odEmail.Listar(oeEmail)
                    'Obtiene Telefonos
                    oeTelefono = New e_Telefono
                    oeTelefono.TipoOperacion = "1"
                    oeTelefono.IdPersonaEmpresa = oePersona.Id
                    oePersona.leTelefono = odTelefono.Listar(oeTelefono)
                    'Obtiene Direcciones
                    oeDireccionEP = New e_Direccion_EmpresaPersona
                    oeDireccionEP.IdPersonaEmpresa = oePersona.Id
                    oeDireccionEP.Principal = -1
                    oeDireccionEP.TipoPersonaEmpresa = "1"
                    oePersona.leDireccionEP = odDireccionEP.ListarTodo(oeDireccionEP)
                    'Obtine Documentos
                    oePerDocumento = New e_PersonaDocumento
                    oePerDocumento.TipoOperacion = ""
                    oePerDocumento.Activo = True
                    oePerDocumento.Vigente = 1
                    oePerDocumento.IdPersona = oePersona.Id
                    oePersona.leDocumento = odPerDocumento.Listar(oePerDocumento)
                    'Obtiene Cliente Proveedor
                    oeClienteProveedor = New e_ClienteProveedor
                    oeClienteProveedor.TipoOperacion = ""
                    oeClienteProveedor.TipoPersonaEmpresa = 1
                    oeClienteProveedor.IdPersonaEmpresa = oePersona.Id
                    oeClienteProveedor.Activo = True
                    oePersona.oeClienteProveedor = odClienteProveedor.Obtener(oeClienteProveedor)
                    'Obtener Tipo Pago
                    If oePersona.oeClienteProveedor.Id <> "" Then
                        oePETipoPago.TipoOperacion = ""
                        oePETipoPago.IdClienteProveedor = oePersona.oeClienteProveedor.Id
                        oePersona.leTipoPago = odPETipoPago.Listar(oePETipoPago)
                    End If
                End If
            End If
            Return oePersona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Crear una lista de personas
    ''' </summary>
    ''' <param name="oePersona">Objeto de tipo Persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oePersona As e_Persona) As List(Of e_Persona)
        Try
            Dim ldPersona As New List(Of e_Persona)
            Dim ds As DataSet
            With oePersona
                ds = sqlhelper.ExecuteDataset("PER.Isp_Persona_Listar", .TipoOperacion, .Id, .Codigo, _
                        .Dni, .ApellidoPaterno, .ApellidoMaterno, .Nombre, .FechaNacimiento, _
                         .Activo)
            End With
            oePersona = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePersona = Cargar(o_Fila)
                    ldPersona.Add(oePersona)
                Next
                Return ldPersona
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function listar(ByVal Activo As Boolean) As Data.DataSet
    '    Try
    '        Return SqlHelper.ExecuteDataset("", "")
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    ''' <summary>
    ''' Guardar información de una persona
    ''' </summary>
    ''' <param name="oePersona">Objeto de tipo Persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oePersona As e_Persona) As String
        Try
            Dim odDireccionEP As New d_Direccion_EmpresaPersona
            Dim oeDireccion As New e_Direccion
            Dim odDireccion As New d_Direccion
            Dim id As String = ""
            Dim idDireccion As String = ""
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using TransScope As New TransactionScope()
                With oePersona
                    Dim var As String = .Id
                    If var = "" Then
                        .TipoOperacion = "I"
                    Else
                        If .TipoOperacion <> "E" Then .TipoOperacion = "A"
                    End If

                    id = sqlhelper.ExecuteScalar("PER.Isp_Persona_IAE", .TipoOperacion, _
                     .Id, .Codigo, .ApellidoPaterno, .ApellidoMaterno, .Nombre, _
                    .oeSexo.Id, .FechaNacimiento, .Dni, .Activo, .UsuarioCreacion, .PrefijoID)
                    .Id = id
                    If .leDireccionEP IsNot Nothing Then
                        For Each oeDEP As e_Direccion_EmpresaPersona In .leDireccionEP
                            oeDEP.TipoPersonaEmpresa = 1
                            oeDEP.IdPersonaEmpresa = id
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
                                    oeDireccion.CentroAsistenciaEsSalud = oeDEP.oeDireccion.CentroAsistenciaEsSalud
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
                                    oeDireccion.CentroAsistenciaEsSalud = oeDEP.oeDireccion.CentroAsistenciaEsSalud
                                    odDireccion.Guardar(oeDireccion)
                                    odDireccionEP.Guardar(oeDEP)
                                Case "E"
                                    odDireccionEP.Eliminar(oeDEP)
                            End Select

                        Next
                    End If
                    If Not .leEmail Is Nothing Then
                        For Each oeEmail As e_Email In .leEmail
                            oeEmail.TipoPersonaEmpresa = 1
                            oeEmail.IdPersonaEmpresa = id
                            odEmail.Guardar(oeEmail)
                        Next
                    End If
                    If Not .leTelefono Is Nothing Then
                        For Each oeTelefono As e_Telefono In .leTelefono
                            oeTelefono.TipoPersonaEmpresa = 1
                            oeTelefono.IdPersonaEmpresa = id
                            odTelefono.Guardar(oeTelefono)
                        Next
                    End If
                    If .oeClienteProveedor.Id <> "" Then
                        .oeClienteProveedor.TipoOperacion = "A"
                        .oeClienteProveedor.Activo = True
                        odClienteProveedor.Guardar(.oeClienteProveedor)
                    Else
                        If .oeClienteProveedor.Cliente = 1 _
                        Or .oeClienteProveedor.Proveedor = 1 _
                        Or .oeClienteProveedor.Comisionista = 1 Then
                            .oeClienteProveedor.TipoOperacion = "I"
                            .oeClienteProveedor.Activo = True
                            .oeClienteProveedor.TipoPersonaEmpresa = 1
                            .oeClienteProveedor.Codigo = .Codigo
                            .oeClienteProveedor.UsuarioCreacion = .UsuarioCreacion
                            .oeClienteProveedor.IdPersonaEmpresa = id
                            odClienteProveedor.Guardar(.oeClienteProveedor)
                        End If
                    End If
                    If Not .leTipoPago Is Nothing Then
                        For Each oeTipoPago As e_PersonaEmpresa_TipoPago In .leTipoPago
                            oeTipoPago.IdClienteProveedor = .oeClienteProveedor.Id
                            Select Case oeTipoPago.TipoOperacion
                                Case "I" : odPETipoPago.Guardar(oeTipoPago)
                                Case "E" : odPETipoPago.Eliminar(oeTipoPago)
                            End Select
                        Next
                    End If
                    If Not .leDocumento Is Nothing Then
                        For Each oeDocPer In .leDocumento
                            oeDocPer.IdPersona = .Id
                            If oeDocPer.TipoOperacion = "E" Then
                                odPerDocumento.Eliminar(oeDocPer)
                            Else
                                odPerDocumento.Guardar(oeDocPer)
                            End If
                        Next
                    End If

                End With
                TransScope.Complete()
                Return id
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Eliminar una persona
    ''' </summary>
    ''' <param name="oePersona">Objeto de tipo Persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oePersona As e_Persona) As Boolean
        Try
            With oePersona
                sqlhelper.ExecuteNonQuery("PER.ISP_PERSONA_IAE" _
                                          , "E" _
                                          , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarDatos(ByVal oePersona As e_Persona) As Boolean
        Try
            With oePersona
                sqlhelper.ExecuteNonQuery("PER.ISP_PERSONA_IAE" _
                                          , "A" _
                                          , .Id _
                                          , .Codigo _
                                          , .ApellidoPaterno _
                                          , .ApellidoMaterno _
                                          , .Nombre _
                                          , Nothing _
                                          , Nothing _
                                          , .Dni _
                                          , .Activo _
                                          , Nothing _
                                          , Nothing )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Retorna la foto de la persona a partir de su DNI
    ''' </summary>
    ''' <param name="DNI"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Foto(ByVal DNI As String) As System.Drawing.Bitmap
        Dim odDatosConfiguracion As New d_DatosConfiguracion
        Dim sinFoto As String = odDatosConfiguracion.Fotos & "\SinFoto.jpg"
        Foto = System.Drawing.Bitmap.FromFile(sinFoto)
        If DNI.Length = 8 Then
            Try
                Dim archivoFoto As String = odDatosConfiguracion.Fotos & "\" & DNI & ".jpg"
                If System.IO.File.Exists(archivoFoto) Then
                    Foto = System.Drawing.Bitmap.FromFile(archivoFoto)
                Else
                    Foto = System.Drawing.Bitmap.FromFile(sinFoto)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End If
        Return Foto
    End Function

End Class
