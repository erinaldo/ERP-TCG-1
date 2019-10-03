Imports ISL.EntidadesWCF
Imports System.Transactions

''' <summary>
''' Clase: Trabajador
''' Fecha: 15/10/2011
''' </summary>
''' <remarks></remarks>
Public Class d_Trabajador

    Dim oeOcupacionTrabajador As New e_OcupacionTrabajador
    Dim odOcupacionTrabajador As New d_OcupacionTrabajador
    Dim oePersona As New e_Persona
    Dim odPersona As New d_Persona
    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim odCuentaCorriente As New d_CuentaCorriente
    Private oeDireccionEP As New e_Direccion_EmpresaPersona, odDireccionEP As New d_Direccion_EmpresaPersona
    Private oeSueldo As New e_SueldoTrabajador, odSueldo As New d_SueldoTrabajador
    Private oeFondoPension As New e_FondoPensionTrabajador, odFondoPension As New d_FondoPensionTrabajador
    Private oeCtaBancaria As New e_CuentaCtePersonal, odCtaBancaria As New d_CuentaCtePersonal
    Private oeContrato As New e_Contratos, odContrato As New d_Contratos
    Private oeRegimenSalud As New e_RegimenSalud, odRegSalud As New d_RegimenSalud
    Private oeSeguroComplementario As New e_SeguroComplementario, odSeguroComp As New d_SeguroComplementrio
    Private oeDerHab As New e_DerechoHabiente, odDerHab As New d_DerechoHabiente

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' Cargar un Trabajador
    ''' </summary>
    ''' <param name="o_fila">Fila de Dato de Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Cargar(ByVal o_fila As DataRow) As e_Trabajador
        Try
            Dim valorSexo As Integer = IIf(IsDBNull(o_fila("Sexo")), 1, o_fila("Sexo"))
            Dim objSexo As New e_Sexo(CType(valorSexo, String))
            Dim oeTrabajador = New e_Trabajador(0, _
                                            o_fila("Id"), _
                                            o_fila("IdArea"), _
                                            o_fila("Area"), _
                                            o_fila("IdCargo"), _
                                            o_fila("Cargo"), _
                                            o_fila("IdPersona").ToString.Trim, _
                                            o_fila("Codigo"), _
                                            o_fila("DNI"), _
                                            o_fila("ApellidoPaterno"), _
                                            o_fila("ApellidoMaterno"), _
                                            o_fila("Nombre"), _
                                            objSexo, _
                                            o_fila("FechaNacimiento"), _
                                            o_fila("FechaIngreso"), _
                                            o_fila("FechaCese"), _
                                            o_fila("Activo"), _
                                             o_fila("IdOcupacion"), _
                                            o_fila("Ocupacion"), _
                                            o_fila("Disponible"), _
                                            IIf(IsDBNull(o_fila("IdEstadoCivil")), "", o_fila("IdEstadoCivil")), _
                                            IIf(IsDBNull(o_fila("IdGradoInstruccion")), "", o_fila("IdGradoInstruccion")), _
                                            IIf(IsDBNull(o_fila("IdLugarNacimiento")), "", o_fila("IdLugarNacimiento")), _
                                            IIf(IsDBNull(o_fila("IdTipoRelacionLaboral")), "", o_fila("IdTipoRelacionLaboral")), _
                                            IIf(IsDBNull(o_fila("RelacionLaboral")), "", o_fila("RelacionLaboral")) _
                                            , o_fila("IndEstado") _
                                            , o_fila("IndHijos") _
                                            , o_fila("IndTipo") _
                                            , o_fila("IndPiloto") _
                                            , o_fila("ClaveSeguridad").ToString _
                                            , o_fila("IdCentro").ToString _
                                            , o_fila("IndRuta") _
                                            )
            Return oeTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtiene un Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeTrabajador As e_Trabajador) As e_Trabajador
        Try
            Dim ds As DataSet
            Dim indCompleto As Boolean = oeTrabajador.CargaCompleto
            With oeTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_Trabajador_Listar", .TipoOperacion, _
                                              .Id, _
                                              .oeArea.Id, _
                                              .oeOcupacion.Id, _
                                              .oePersona.Id, _
                                              "", _
                                              "", _
                                              1, _
                                              .ClaveSeguridad)
            End With
            oeTrabajador = New e_Trabajador
            If ds.Tables(0).Rows.Count > 0 Then
                oeTrabajador = Cargar(ds.Tables(0).Rows(0))
                If indCompleto Then
                    'Cargar Ocupaciones
                    oeOcupacionTrabajador = New e_OcupacionTrabajador
                    oeOcupacionTrabajador.IdTrabajador = oeTrabajador.Id
                    oeOcupacionTrabajador.Principal = -1
                    oeTrabajador.leOcupacionTrabajador = odOcupacionTrabajador.Listar(oeOcupacionTrabajador)
                    'Cargar Cuentas Corrientes
                    oeCuentaCorriente = New e_CuentaCorriente
                    oeCuentaCorriente.IdTrabajador = oeTrabajador.Id
                    oeCuentaCorriente.Activo = 1
                    oeCuentaCorriente.Tipo = 0
                    oeCuentaCorriente.Tipooperacion = ""
                    oeTrabajador.oeCuentaCorriente = odCuentaCorriente.Obtener(oeCuentaCorriente)
                    'Cargar Datos Personales
                    oePersona = New e_Persona
                    oePersona.Id = oeTrabajador.oePersona.Id
                    oePersona.CargaCompleta = True
                    oeTrabajador.oePersona = odPersona.Obtener(oePersona)
                    'Cargar Sueldo
                    oeSueldo = New e_SueldoTrabajador
                    oeSueldo.TipoOperacion = ""
                    oeSueldo.Vigente = -1
                    oeSueldo.Activo = True
                    oeSueldo.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leSueldo = odSueldo.Listar(oeSueldo)
                    'Cargar Fondo Pension
                    oeFondoPension = New e_FondoPensionTrabajador
                    oeFondoPension.TipoOperacion = ""
                    oeFondoPension.Vigente = -1
                    oeFondoPension.Activo = True
                    oeFondoPension.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leFondoPension = odFondoPension.Listar(oeFondoPension)
                    'Cargar Cuentas Bancarias
                    oeCtaBancaria = New e_CuentaCtePersonal
                    oeCtaBancaria.TipoOperacion = ""
                    oeCtaBancaria.Vigente = -1
                    oeCtaBancaria.Activo = True
                    oeCtaBancaria.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leCtaBancaria = odCtaBancaria.Listar(oeCtaBancaria)
                    'Cargar Contratos
                    oeContrato = New e_Contratos
                    oeContrato.TipoOperacion = ""
                    oeContrato.Activo = True
                    oeContrato.Vigencia = True
                    oeContrato.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leContratos = odContrato.Listar(oeContrato)
                    'Cargar Regimen Salud
                    oeRegimenSalud = New e_RegimenSalud
                    oeRegimenSalud.TipoOperacion = ""
                    oeRegimenSalud.Activo = True
                    oeRegimenSalud.Vigente = -1
                    oeRegimenSalud.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leRegimenSalud = odRegSalud.Listar(oeRegimenSalud)
                    'Cargar Seguro Complementario
                    oeSeguroComplementario = New e_SeguroComplementario
                    oeSeguroComplementario.TipoOperacion = ""
                    oeSeguroComplementario.Activo = True
                    oeSeguroComplementario.Vigencia = -1
                    oeSeguroComplementario.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leSeguroComp = odSeguroComp.Listar(oeSeguroComplementario)
                    'Cargar Derecho Habiente
                    oeDerHab = New e_DerechoHabiente
                    oeDerHab.TipoOperacion = ""
                    oeDerHab.Activo = True
                    oeDerHab.IdTrabajador = oeTrabajador.Id
                    oeTrabajador.leDerechoHabiente = odDerHab.Listar(oeDerHab)
                End If
            End If
            Return oeTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Listar Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeTrabajador As e_Trabajador) As List(Of e_Trabajador)
        Try
            Dim olTrabajador As New List(Of e_Trabajador)
            Dim ds As DataSet
            With oeTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_Trabajador_Listar", .TipoOperacion, _
                                              .Id, _
                                              .oeArea.Id, _
                                              .oeOcupacion.Id, _
                                              .oePersona.Id, _
                                              .Codigo, _
                                              .oeCargo.Id, _
                                              .Activo)
            End With
            oeTrabajador = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTrabajador = Cargar(o_Fila)
                    olTrabajador.Add(oeTrabajador)
                Next
            End If
            Return olTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeTrabajador As e_Trabajador) As List(Of e_Trabajador)
        Try
            Dim olTrabajador As New List(Of e_Trabajador)
            Dim ds As DataSet
            With oeTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_Trabajador_Listar", .TipoOperacion, _
                                              .Id, _
                                              .oeArea.Id, _
                                              .oeOcupacion.Id, _
                                              .oePersona.Id, _
                                              .Codigo, _
                                              .oeCargo.Id, _
                                              .Activo)
            End With
            oeTrabajador = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTrabajador = Cargar(o_Fila)
                    oeTrabajador.Centro = o_Fila("Centro").ToString
                    olTrabajador.Add(oeTrabajador)
                Next
            End If
            Return olTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guardar Datos de Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeTrabajador As e_Trabajador) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            Using TransScope As New TransactionScope
                Dim _idpadre As String = odPersona.Guardar(oeTrabajador.oePersona)
                If _idpadre <> "" Then
                    With oeTrabajador
                        id = sqlhelper.ExecuteScalar("PER.Isp_Trabajador_IAE", .TipoOperacion, _
                         .Id, .oeArea.Id, _idpadre, .Codigo, .FechaIngreso, .FechaCese, _
                         .Activo, .oeCargo.Id, .IdEstadoCivil, .IdGradoInstruccion, .IdLugarNacimiento, _
                         .FechaCreacion, .UsuarioCreacion, .ClaveSeguridad, .Disponible, .PrefijoID _
                         , .IndEstado, .IndHijo, .IndTipo, .IndPiloto)
                    End With
                    oeTrabajador.Id = id
                    If oeTrabajador.leOcupacionTrabajador IsNot Nothing Then
                        For Each oeOcupacionTrabajador As e_OcupacionTrabajador In oeTrabajador.leOcupacionTrabajador
                            oeOcupacionTrabajador.IdTrabajador = id
                            Select Case oeOcupacionTrabajador.TipoOperacion
                                Case "I", "A"
                                    odOcupacionTrabajador.Guardar(oeOcupacionTrabajador)
                                Case "E"
                                    odOcupacionTrabajador.Eliminar(oeOcupacionTrabajador)
                            End Select
                        Next
                    End If
                    If oeTrabajador.oeCuentaCorriente IsNot Nothing Then
                        oeTrabajador.oeCuentaCorriente.IdTrabajador = id
                        oeTrabajador.oeCuentaCorriente.IdMoneda = "1CH01"
                        oeTrabajador.oeCuentaCorriente.Tipo = 0
                        oeTrabajador.oeCuentaCorriente.Glosa = "CUENTA CTE"
                        oeTrabajador.oeCuentaCorriente.Saldo = 0
                        oeTrabajador.oeCuentaCorriente.IdEstado = "HABILITADO"
                        oeTrabajador.oeCuentaCorriente.Usuario = "1CH000000086"
                        If oeTrabajador.oeCuentaCorriente.Id <> "" Then
                            oeTrabajador.oeCuentaCorriente.Tipooperacion = "A"
                        Else
                            oeTrabajador.oeCuentaCorriente.Tipooperacion = "I"
                        End If
                        odCuentaCorriente.Guardar(oeTrabajador.oeCuentaCorriente)
                    End If
                    If Not oeTrabajador.leCtaBancaria Is Nothing Then
                        For Each oeCtaBan In oeTrabajador.leCtaBancaria
                            oeCtaBan.IdTrabajador = id
                            If oeCtaBan.TipoOperacion = "E" Then
                                odCtaBancaria.Eliminar(oeCtaBan)
                            Else
                                odCtaBancaria.Guardar(oeCtaBan)
                            End If
                        Next
                    End If
                    If Not oeTrabajador.leSueldo Is Nothing Then
                        For Each oeSueTra In oeTrabajador.leSueldo
                            oeSueTra.IdTrabajador = id
                            If oeSueTra.TipoOperacion = "E" Then
                                odSueldo.Eliminar(oeSueTra)
                            Else
                                odSueldo.Guardar(oeSueTra)
                            End If
                        Next
                    End If
                    If Not oeTrabajador.leFondoPension Is Nothing Then
                        For Each oeFonTra In oeTrabajador.leFondoPension
                            oeFonTra.IdTrabajador = id
                            If oeFonTra.TipoOperacion = "E" Then
                                odFondoPension.Eliminar(oeFonTra)
                            Else
                                odFondoPension.Guardar(oeFonTra)
                            End If
                        Next
                    End If
                    If Not oeTrabajador.leContratos Is Nothing Then
                        For Each oeContr In oeTrabajador.leContratos
                            oeContr.IdTrabajador = id
                            If oeContr.TipoOperacion = "E" Then
                                odContrato.Eliminar(oeContr)
                            Else
                                odContrato.Guardar(oeContr)
                            End If
                        Next
                    End If
                    If Not oeTrabajador.leRegimenSalud Is Nothing Then
                        For Each oeRegSalud In oeTrabajador.leRegimenSalud
                            oeRegSalud.IdTrabajador = id
                            If oeRegSalud.TipoOperacion = "E" Then
                                odRegSalud.Eliminar(oeRegSalud)
                            Else
                                odRegSalud.Guardar(oeRegSalud)
                            End If
                        Next
                    End If
                    If Not oeTrabajador.leSeguroComp Is Nothing Then
                        For Each oeSeguroComp In oeTrabajador.leSeguroComp
                            oeSeguroComp.IdTrabajador = id
                            If oeSeguroComp.TipoOperacion = "E" Then
                                odSeguroComp.Eliminar(oeSeguroComp)
                            Else
                                odSeguroComp.Guardar(oeSeguroComp)
                            End If
                        Next
                    End If
                    If Not oeTrabajador.leDerechoHabiente Is Nothing Then
                        For Each oeDerHabAux In oeTrabajador.leDerechoHabiente
                            oeDerHabAux.IdTrabajador = id
                            If oeDerHabAux.TipoOperacion = "E" Then
                                odDerHab.Eliminar(oeDerHabAux)
                            Else
                                odDerHab.Guardar(oeDerHabAux)
                            End If
                        Next
                    End If
                End If
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CambiarClaveSeguridad(ByVal oeTRabajador As e_Trabajador) As Boolean
        Try
            With oeTRabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_Trabajador_IAE", "C", _
                         .Id, "", "", .Codigo, #1/1/1901#, #1/1/1901#, _
                         True, "", "", "", "", _
                         #1/1/1901#, "", .ClaveSeguridad)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Eliminar un Trabajador
    ''' </summary>
    ''' <param name="oeTrabajador">Objeto Trabajador</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeTrabajador As e_Trabajador) As Boolean
        Try
            With oeTrabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_Trabajador_IAE" _
                                          , "E" _
                                          , .Id _
                                          , "" _
                                          , .oePersona.Id)
            End With
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

    Public Function EliminacionDefinitiva(ByVal oeTrabajador As e_Trabajador) As Boolean
        Try
            With oeTrabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_Trabajador_IAE" _
                                          , "X" _
                                          , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaTrabajador As List(Of e_Trabajador))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        Dim newRow0 As DataRow = ds.NewRow()
        newRow0("Id") = "0"
        newRow0("Nombre") = "NINGUNO"
        ds.Rows.Add(newRow0)
        For Each item As e_Trabajador In ListaTrabajador
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.oePersona.NombreCompleto
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function ObtenerObjeto(ByVal oeTrabajador As e_Trabajador) As e_Trabajador
        Try
            Dim ds As DataSet
            With oeTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_Trabajador_Listar", .TipoOperacion, _
                                              .Id, _
                                              .oeArea.Id, _
                                              .oeOcupacion.Id, _
                                              .oePersona.Id, _
                                              "", _
                                              "", _
                                              1, _
                                              .ClaveSeguridad)
            End With
            oeTrabajador = New e_Trabajador
            If ds.Tables(0).Rows.Count > 0 Then
                oeTrabajador = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTrabajador
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return oeTrabajador
        End Try
    End Function

    Public Function CargarDatosGenerales(ByVal oeTrabajador As e_Trabajador) As Data.DataSet
        Try
            Dim ds As DataSet
            With oeTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_DatosTrabGen_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Return ds
                Else
                    Throw New Exception("No se Encontro datos en la tabla")
                End If
            Else
                Throw New Exception("No se Encontro ninguna Tabla")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Migrar(ByVal oeTrabajador As e_Trabajador) As Boolean
        Try
            Using TransScope As New TransactionScope
                With oeTrabajador
                    sqlhelper.ExecuteNonQuery("PER.Isp_Trabajador_IAE" _
                                          , .TipoOperacion _
                                          , "" _
                                          , "" _
                                          , "" _
                                          , .Codigo)
                End With

                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#Region "Información para onomásticos de trabajadores"

    ''' <summary>
    ''' Genera una lista de trabajadores con sus respectivas fechas de nacimiento
    ''' </summary>
    ''' <param name="mes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarOnomasticos(Optional ByVal mes As String = "", Optional ByVal dia As String = "") As List(Of e_Onomastico)
        Try
            Dim olOnomastico As New List(Of e_Onomastico)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_Onomasticos_Obtener", mes, dia)
            Dim oeOnomastico As New e_Onomastico
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOnomastico = CargarOnomasticos(o_Fila)
                    olOnomastico.Add(oeOnomastico)
                Next
                Return olOnomastico
            Else
                Return olOnomastico
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarOnomasticos(ByVal o_fila As DataRow) As e_Onomastico
        Try
            Dim oeOnomastico = New e_Onomastico(o_fila("Dia"), _
                                            o_fila("Mes"), _
                                            o_fila("NombreCompleto"), _
                                            o_fila("Area"), _
                                            o_fila("OrdenMes"), _
                                            o_fila("Edad"), _
                                            o_fila("Dni"))
            Return oeOnomastico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
