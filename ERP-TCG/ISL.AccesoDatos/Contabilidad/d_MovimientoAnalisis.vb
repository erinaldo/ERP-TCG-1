Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MovimientoAnalisis

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoAnalisis
        Try
            Dim oeMovimientoAnalisis = New e_MovimientoAnalisis( _
                             o_fila("Id").ToString _
                             , o_fila("IdCentroCosto").ToString _
                             , o_fila("IdItemGasto").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("IdBanco").ToString _
                             , o_fila("IdAnalisis1").ToString _
                             , o_fila("IdAnalisis2").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdAsientoMovimiento").ToString _
                             , o_fila("MONTO") _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("Saldo") _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("IdUsuarioCrea").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("ApellidoPaterno").ToString _
                             , o_fila("ApellidoMaterno").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("Placa").ToString _
                            , o_fila("Cuenta").ToString _
                            , o_fila("IdGastoFuncion").ToString _
                            , o_fila("TipoAsiento").ToString _
                            , o_fila("NroAsiento").ToString _
                            , o_fila("Glosa").ToString _
                             , o_fila("Fecha") _
                             , o_fila("IdTipoCompra").ToString _
                                        )
          
            Return oeMovimientoAnalisis
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As e_MovimientoAnalisis

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_MovimientoAnalisis_Listar", "", oeMovimientoAnalisis.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoAnalisis = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoAnalisis
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As List(Of e_MovimientoAnalisis)
        Try
            Dim ldMovimientoAnalisis As New List(Of e_MovimientoAnalisis)
            Dim ds As DataSet
            With oeMovimientoAnalisis
                ds = sqlhelper.ExecuteDataset("CON.ISP_MovimientoAnalisis_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCentroCosto _
                        , .IdItemGasto _
                        , .IdTrabajador _
                        , .IdVehiculo _
                        , .IdRuta _
                        , .IdBanco _
                        , .IdAnalisis1 _
                        , .IdAnalisis2 _
                        , .Activo _
                        , .IdAsientoMovimiento _
                        , 0 _
                        , "" _
                        , ._ListaV _
                        , .IdPeriodo _
                        , .Ejercicio _
                        )
            End With
            oeMovimientoAnalisis = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoAnalisis = Cargar(o_Fila)
                    ldMovimientoAnalisis.Add(oeMovimientoAnalisis)
                Next
            End If
            Return ldMovimientoAnalisis

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarAnalisisCompra(ByVal IdAsiento As String) As List(Of e_MovimientoAnalisis)
        Try
            Dim oeMovimientoAnalisis As e_MovimientoAnalisis
            Dim ldMovimientoAnalisis As New List(Of e_MovimientoAnalisis)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_MovimientoAnalisis_Listar", "A" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , True _
                    , "" _
                    , 0 _
                    , IdAsiento _
                    )

            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoAnalisis = Cargar(o_Fila)
                    ldMovimientoAnalisis.Add(oeMovimientoAnalisis)
                Next
            End If
            Return ldMovimientoAnalisis

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimientoAnalisis
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoAnalisis_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCentroCosto _
                        , .IdItemGasto _
                        , .IdTrabajador _
                        , .IdVehiculo _
                        , .IdRuta _
                        , .IdBanco _
                        , .IdAnalisis1 _
                        , .IdAnalisis2 _
                        , .Activo _
                        , .IdAsientoMovimiento _
                        , .Monto _
                        , .Saldo _
                        , ._IdMovimientoAnalisis _
                        , .IdGastoFuncion _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guarda esta tabla en masivo
    ''' </summary>
    ''' <param name="DTAnalisis">Estructura de Con.MovimientoAnalisis</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarMasivo(ByVal DTAnalisis As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DTAnalisis, False)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarProrrateo(ByVal leMovAna As List(Of e_MovimientoAnalisis), ByVal DTAnalisis As DataTable) As Boolean
        Try
            Using transScope As New TransactionScope()
                For Each obj In leMovAna
                    sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoAnalisis_IAE", "E", _
                    "", obj.Id)
                Next
                sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DTAnalisis, False)
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function ActualizaMonto(ByVal IdAsientoMovimiento As String) As Boolean
        Try

            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoAnalisis_IAE", "M", "", "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , True _
                    , IdAsientoMovimiento _
                )

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.MovimientoAnalisis para casos de insercion masiva
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.MovimientoAnalisis", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "0000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInsertaProrrateo() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.MovimientoAnalisis", "1SI" _
                                  )
            Return IIf(stResultado Is Nothing, "1SI" & "0000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Cancela saldo de movimiento de analisis
    ''' </summary>
    ''' <param name="ls_TipoOperacion">S: Cancela con cero todo el saldo, P: cancela parcialmente el saldo </param>
    ''' <param name="Ids">Id que se cancela</param>
    ''' <param name="Saldo">Saldo que queda cuando es TipoOperacion P</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CancelaSaldo(ByVal ls_TipoOperacion As String, ByVal Ids As String, Optional ByVal Saldo As Double = 0) As Boolean
        Try

            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoAnalisis_IAE", ls_TipoOperacion, "", "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , "" _
                    , True _
                    , "" _
                    , 0 _
                    , Saldo _
                    , Ids _
                )

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoAnalisis As e_MovimientoAnalisis) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoAnalisis_IAE", "E", _
             "", oeMovimientoAnalisis.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function GuardarLista(ByVal leMovAnalisis As List(Of e_MovimientoAnalisis)) As Boolean
        Try
            Using transScope As New TransactionScope()
                For Each oeDet In leMovAnalisis.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                    If oeDet.TipoOperacion = "E" Then
                        Eliminar(oeDet)
                    Else
                        Guardar(oeDet)
                    End If
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
