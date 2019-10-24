
Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_EmpresaSistemas
    Dim SqlHelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_EmpresaSistemas
        Try
            Dim oeEmpresaSistemas = New e_EmpresaSistemas(
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("TokenRuc").ToString _
                             , o_fila("IndPrincipal").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("RutaDocumentos").ToString _
                             , o_fila("RutaCDR").ToString _
                             , o_fila("RutaFirma").ToString _
                             , o_fila("ClaveFirma").ToString _
                             , o_fila("Ubigeo").ToString _
                             , o_fila("Departamento").ToString _
                             , o_fila("Provincia").ToString _
                             , o_fila("Distrito").ToString _
                             , o_fila("Direccion").ToString _
                             , o_fila("UsuarioSol").ToString _
                             , o_fila("ClaveSol").ToString _
                             , o_fila("EstadoDisponibilidadBD").ToString _
                             , o_fila("MensajeInicialBD").ToString _
                             , o_fila("MensajeUsuariosConectadosBD").ToString _
                             , o_fila("EstadoDisponibilidadReplica").ToString _
                             , o_fila("MensajeInicialRP").ToString _
                             , o_fila("MensajeUsuariosConectadosRP").ToString _
                             , o_fila("Compras").ToString _
                             , o_fila("Ventas").ToString _
                             , o_fila("Contabilidad").ToString _
                             , o_fila("Administracion").ToString _
                             , o_fila("Neumaticos").ToString _
                             , o_fila("Operaciones").ToString _
                             , o_fila("Planeamiento").ToString _
                             , o_fila("Finanzas").ToString _
                             , o_fila("Logistica").ToString _
                             , o_fila("Mantenimiento").ToString _
                             , o_fila("Personal").ToString _
                             , o_fila("Tesoreria").ToString _
                             , o_fila("Comercial").ToString _
                             , o_fila("Reportes").ToString _
                             , o_fila("Seguridad").ToString _
                             , o_fila("Configuracion").ToString _
                             , o_fila("Operador").ToString _
                             , o_fila("Asistente").ToString _
                             , o_fila("Analista").ToString _
                             , o_fila("Administrador").ToString _
                             , o_fila("Supervisor").ToString _
                             , o_fila("Cajero").ToString _
                             , o_fila("Coordinador").ToString _
                             , o_fila("Jefe").ToString _
                             , o_fila("Gerente").ToString
            )
            Return oeEmpresaSistemas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As DataSet
        Try
            Dim ds As DataSet
            With oeEmpresaSistemas
                ds = SqlHelper.ExecuteDataset("[SGD].[Sp_EmpresaSistemas_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .Codigo _
                        , .Abreviatura _
                        , .Nombre _
                        , .IdEmpresa _
                        , .TokenRuc _
                        , .IndPrincipal _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo _
                        , .RutaDocumentos _
                        , .RutaCDR _
                        , .RutaFirma _
                        , .ClaveFirma _
                        , .Ubigeo _
                        , .Departamento _
                        , .Provincia _
                        , .Distrito _
                        , .Direccion _
                        , .UsuarioSol _
                        , .ClaveSol _
                        , .EstadoDisponibilidadBD _
                        , .MensajeInicialBD _
                        , .MensajeUsuariosConectadosBD _
                        , .EstadoDisponibilidadReplica _
                        , .MensajeInicialRP _
                        , .MensajeUsuariosConectadosRP _
                        , .Compras _
                        , .Ventas _
                        , .Contabilidad _
                        , .Administracion _
                        , .Neumaticos _
                        , .Operaciones _
                        , .Planeamiento _
                        , .Finanzas _
                        , .Logistica _
                        , .Mantenimiento _
                        , .Personal _
                        , .Tesoreria _
                        , .Comercial _
                        , .Reportes _
                        , .Seguridad _
                        , .Configuracion _
                        , .Operador _
                        , .Asistente _
                        , .Analista _
                        , .Administrador _
                        , .Supervisor _
                        , .Cajero _
                        , .Coordinador _
                        , .Jefe _
                        , .Gerente
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As e_EmpresaSistemas
        Try
            Dim ds As DataSet = ExecuteLST(oeEmpresaSistemas)
            If ds.Tables(0).Rows.Count > 0 Then
                oeEmpresaSistemas = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEmpresaSistemas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As List(Of e_EmpresaSistemas)
        Try
            Dim ldEmpresaSistemas As New List(Of e_EmpresaSistemas)
            Dim ds As DataSet = ExecuteLST(oeEmpresaSistemas)
            oeEmpresaSistemas = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEmpresaSistemas = Cargar(o_Fila)
                    ldEmpresaSistemas.Add(oeEmpresaSistemas)
                Next
            End If
            Return ldEmpresaSistemas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean
        Try
            Dim stResultado() As String
            With oeEmpresaSistemas
                stResultado = SqlHelper.ExecuteScalar("[SGD].[Sp_EmpresaSistemas_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .Codigo _
                        , .Abreviatura _
                        , .Nombre _
                        , .IdEmpresa _
                        , .TokenRuc _
                        , .IndPrincipal _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo _
                        , .RutaDocumentos _
                        , .RutaCDR _
                        , .RutaFirma _
                        , .ClaveFirma _
                        , .Ubigeo _
                        , .Departamento _
                        , .Provincia _
                        , .Distrito _
                        , .Direccion _
                        , .UsuarioSol _
                        , .ClaveSol _
                        , .EstadoDisponibilidadBD _
                        , .MensajeInicialBD _
                        , .MensajeUsuariosConectadosBD _
                        , .EstadoDisponibilidadReplica _
                        , .MensajeInicialRP _
                        , .MensajeUsuariosConectadosRP _
                        , .Compras _
                        , .Ventas _
                        , .Contabilidad _
                        , .Administracion _
                        , .Neumaticos _
                        , .Operaciones _
                        , .Planeamiento _
                        , .Finanzas _
                        , .Logistica _
                        , .Mantenimiento _
                        , .Personal _
                        , .Tesoreria _
                        , .Comercial _
                        , .Reportes _
                        , .Seguridad _
                        , .Configuracion _
                        , .Operador _
                        , .Asistente _
                        , .Analista _
                        , .Administrador _
                        , .Supervisor _
                        , .Cajero _
                        , .Coordinador _
                        , .Jefe _
                        , .Gerente
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmpresaSistemas As e_EmpresaSistemas) As Boolean
        Try
            With oeEmpresaSistemas
                SqlHelper.ExecuteNonQuery("[SGD].[Sp_EmpresaSistemas_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .Codigo _
                       , .Abreviatura _
                       , .Nombre _
                       , .IdEmpresa _
                       , .TokenRuc _
                       , .IndPrincipal _
                       , .UsuarioCrea _
                       , .FechaCrea _
                       , .UsuarioModifica _
                       , .FechaModifica _
                       , .Activo _
                       , .RutaDocumentos _
                       , .RutaCDR _
                       , .RutaFirma _
                       , .ClaveFirma _
                       , .Ubigeo _
                       , .Departamento _
                       , .Provincia _
                       , .Distrito _
                       , .Direccion _
                       , .UsuarioSol _
                       , .ClaveSol _
                       , .EstadoDisponibilidadBD _
                       , .MensajeInicialBD _
                       , .MensajeUsuariosConectadosBD _
                       , .EstadoDisponibilidadReplica _
                       , .MensajeInicialRP _
                       , .MensajeUsuariosConectadosRP _
                       , .Compras _
                       , .Ventas _
                       , .Contabilidad _
                       , .Administracion _
                       , .Neumaticos _
                       , .Operaciones _
                       , .Planeamiento _
                       , .Finanzas _
                       , .Logistica _
                       , .Mantenimiento _
                       , .Personal _
                       , .Tesoreria _
                       , .Comercial _
                       , .Reportes _
                       , .Seguridad _
                       , .Configuracion _
                       , .Operador _
                       , .Asistente _
                       , .Analista _
                       , .Administrador _
                       , .Supervisor _
                       , .Cajero _
                       , .Coordinador _
                       , .Jefe _
                       , .Gerente
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
