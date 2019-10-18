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


Public Class d_Flota
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Flota
        Try
            Dim oeFlota = New e_Flota(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndZona").ToString _
                             , o_fila("IndFlota").ToString _
                             , o_fila("IndZonaD2").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IdJefeActual").ToString _
                             , o_fila("CuotaTracto").ToString)
            Return oeFlota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFlota As e_Flota) As e_Flota

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Listar]", "", oeFlota.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeFlota = Cargar(ds.Tables(0).Rows(0))
            Else
                oeFlota = New e_Flota
            End If
            Return oeFlota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeFlota As e_Flota) As List(Of e_Flota)
        Try
            Dim ldFlota As New List(Of e_Flota)
            Dim ds As DataSet
            With oeFlota
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Listar]", oeFlota.TipoOperacion _
                        , .Id _
                        , .IndZona _
                        , .IndFlota _
                        , .IndZonaD2 _
                        , .IdJefeActual)
            End With
            oeFlota = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFlota = Cargar(o_Fila)
                    ldFlota.Add(oeFlota)
                Next
            Else
                ldFlota = New List(Of e_Flota)
            End If
            Return ldFlota
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFlota As e_Flota) As Boolean

        Dim ldFlotaTrabajador As New d_Flota_Trabajador, ldFlotaCuota As New d_Flota_Cuota
        Try
            Using transScope As New TransactionScope()
                Dim strResultado As String = ""
                With oeFlota
                    strResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Flota_IAE]", _
                                              .TipoOperacion, _
                                              .PrefijoID, _
                                            .Id _
                                            , .Codigo _
                                            , .Nombre _
                                            , .Activo _
                                            , .IndZona _
                                            , .IndFlota _
                                            , .IndZonaD2 _
                                            , .Descripcion _
                                            , .IdJefeActual _
                                            , .CuotaTracto)
                    .Id = strResultado
                    For Each Jefe As e_Flota_Trabajador In .ListJefes
                        Jefe.PrefijoID = oeFlota.PrefijoID '@0001
                        If Jefe.TipoOperacion = "E" Then
                            ldFlotaTrabajador.Eliminar(Jefe)
                        Else
                            Jefe.TipoOperacion = "I"
                            Jefe.IdFlota = .Id
                            ldFlotaTrabajador.Guardar(Jefe)
                        End If
                    Next
                    For Each Cuota As e_Flota_Cuota In .ListCuotas.Where(Function(it) it.TipoOperacion <> "").ToList
                        Cuota.PrefijoID = oeFlota.PrefijoID '@0001
                        If Cuota.TipoOperacion = "E" Then
                            ldFlotaCuota.Eliminar(Cuota)
                        Else
                            Cuota.IdFlota = .Id
                            ldFlotaCuota.Guardar(Cuota)
                        End If
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeFlota As e_Flota) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_Flota_IAE]", "E", _
                                      "", _
                                      oeFlota.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaFlota As List(Of e_Flota))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Flota In ListaFlota
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
