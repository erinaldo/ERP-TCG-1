'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Kardex
    Private sqlhelper As New SqlHelper
    'Private Function Cargar(ByVal o_fila As DataRow) As e_Kardex
    '    Try
    '        Dim oeKardex = New e_Kardex( _
    '                         o_fila("Id").ToString _
    '                         , o_fila("IdPeriodo").ToString _
    '                         , o_fila("IdCuentaContable").ToString _
    '                         , o_fila("Total").ToString _
    '                         , o_fila("IdUsuarioCreacion").ToString _
    '                         , o_fila("FechaCreacion").ToString _
    '                         , o_fila("IdPeriodoSgt").ToString _
    '                         , o_fila("Activo").ToString _
    '        )
    '        Return oeKardex
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function Obtener(ByVal oeKardex As e_Kardex) As e_Kardex

    '    Try
    '        
    '        Dim ds As DataSet
    '        ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", _
    '        Left(.PrefijoID, 1), "", oeKardex.Id)
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            oeKardex = Cargar(ds.Tables(0).Rows(0))
    '        End If
    '        Return oeKardex
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function



    'Public Function Guardar(ByVal oeKardex As e_Kardex) As Boolean
    '    Try
    '        
    '        With oeKardex
    '            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID, _
    '                    .Id _
    '                    , .IdPeriodo _
    '                    , .IdCuentaContable _
    '                    , .Total _
    '                    , .IdUsuarioCreacion _
    '                    , .FechaCreacion _
    '                    , .IdPeriodoSgt _
    '                    , .Activo _
    '                )
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '        Return False
    '    End Try
    'End Function

    'Public Function Eliminar(ByVal oeKardex As e_Kardex) As Boolean
    '    Try
    '        sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
    '         "", oeKardex.Id)
    '        Return True
    '    Catch ex As Exception
    '        Throw
    '        Return False
    '    End Try
    'End Function

    Public Function ListarKardex(ByVal oeKardex As e_Kardex) As DataTable
        Try
            Dim ldKardex As New List(Of e_Kardex)
            Dim ds As DataSet
            With oeKardex
                ds = sqlhelper.ExecuteDataset("CON.Kardex_Listar", .TipoOperacion _
                                              , .PrefijoID _
                        , .Id _
                        , .IdPeriodo _
                        , .IdCuentaContable _
                        , .IdPeriodoSgt _
                        , .Activo
                        )
            End With
            oeKardex = Nothing
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.MovimientoAnalisis para casos de insercion masiva
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta_Kardex(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.Kardex", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "0000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta_KardexDetalle(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.KardexDetalle", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta_KardexSaldo(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.KardexSaldo", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "0000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtKardex As DataTable, ByVal dtKardexDetalle As DataTable, _
                                  ByVal dtKardexSaldo As DataTable) As Boolean
        Try
            Using transScope As New TransactionScope()
                GuardarMasivo_Kardex(dtKardex)
                GuardarMasivo_KardexDetalle(dtKardexDetalle)
                GuardarMasivo_KardexSaldo(dtKardexSaldo)
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo_Kardex(ByVal dtKardex As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.Kardex", dtKardex)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo_KardexDetalle(ByVal dtKardexDetalle As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.KardexDetalle", dtKardexDetalle)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo_KardexSaldo(ByVal dtKardexSaldo As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.KardexSaldo", dtKardexSaldo)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Listar_KardexCorte(ByVal kardex As e_Kardex) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Kardex_Valorizado", kardex.Año, kardex.Mes, kardex.IdPeriodo)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal kardex As e_Kardex) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_InventarioPermanenteValorizado", kardex.Año, kardex.Mes, kardex.IdPeriodo, kardex.IdCuentaContable)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function



    Public Function Listar2(ByVal kardex As e_Kardex) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_InventarioPermanenteValorizado2",
                                          kardex.TipoOperacion,
                                          kardex.Año, kardex.Mes,
                                          kardex.IdPeriodo, kardex.IdCuentaContable, kardex.IdSubAlmacen)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public connectionString As String = d_Conexion.CadenaConexionSGI()

    'Public Function Listar2(ByVal kardex As EntidadesWCF.e_Kardex) As DataTable
    '    Try
    '        Dim ds As SqlDataReader
    '        Dim Tabla As New DataTable

    '        ds = sqlhelper.ExecuteReader(connectionString, "CON.Isp_InventarioPermanenteValorizado2", _
    '                                      kardex.TipoOperacion, _
    '                                     kardex.Año, kardex.Mes, _
    '                                      kardex.IdPeriodo, _
    '                                        kardex.IdCuentaContable, _
    '                                        kardex.IdSubAlmacen)
    '        Tabla.Load(ds, LoadOption.OverwriteChanges)
    '        Return Tabla

    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function


    Public Function ListarCortePeriodo(ByVal kardex As e_Kardex) As DataSet
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Kardex_Listar", kardex.TipoOperacion)
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
