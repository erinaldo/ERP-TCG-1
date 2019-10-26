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

Public Class d_ControlPermisos
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlPermisos
        Try
            Dim oeControlPermisos = New e_ControlPermisos(o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("IdSituacionAdministrativa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaSalida").ToString _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("Motivo").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("TipoPermiso") _
                             , o_fila("IndConfirmaSalida") _
                             , o_fila("FechaConfirmaSalida").ToString _
                             , o_fila("IndConfirmaIngreso") _
                             , o_fila("FechaConfirmaIngreso").ToString _
                             , o_fila("IdJefeArea").ToString _
                             , o_fila("IdJefeAdministracion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo") _
                             , o_fila("DiasExcedidos").ToString _
                             , o_fila("DiasPermiso").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("JefeArea").ToString _
                             , o_fila("JefeAdministracion").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IndPapeleta").ToString _
                             , o_fila("IdOcupacion").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("IndVenta").ToString _
                             , o_fila("FechaInicioVta").ToString _
                             , o_fila("FechaFinVta").ToString _
                             , o_fila("DiasVendidos").ToString _
                             , o_fila("TotalDias") _
                             , o_fila("IndGoce"))
            Return oeControlPermisos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlPermisos As e_ControlPermisos) As e_ControlPermisos
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_ControlPermisos_Listar" _
                                          , "" _
                                          , oeControlPermisos.Id)
            If ds.Tables.Count > 0 Then
                oeControlPermisos = Cargar(ds.Tables(0).Rows(0))
                Return oeControlPermisos
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeControlPermisos As e_ControlPermisos) As List(Of e_ControlPermisos)
        Try
            Dim ldControlPermisos As New List(Of e_ControlPermisos)
            Dim ds As DataSet
            With oeControlPermisos
                ds = sqlhelper.ExecuteDataset("PER.Isp_ControlPermisos_Listar" _
                                                , .TipoOperacion _
                                                , .Id _
                                                , .IdTrabajador _
                                                , .IdArea _
                                                , .IdCentro _
                                                , .Fecha _
                                                , .FechaSalida)
            End With
            oeControlPermisos = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlPermisos = Cargar(o_Fila)
                    ldControlPermisos.Add(oeControlPermisos)
                Next
            End If
            Return ldControlPermisos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean
        Try
            Dim id As String = ""
            With oeControlPermisos
                id = sqlhelper.ExecuteScalar("PER.Isp_ControlPermisos_IAE", _
                                             .TipoOperacion _
                                            , "" _
                                            , .PrefijoID _
                                            , .Id _
                                            , .IdCentro _
                                            , .IdTrabajador _
                                            , .IdArea _
                                            , .Fecha _
                                            , .FechaSalida _
                                            , .FechaIngreso _
                                            , .IdSituacionAdministrativa _
                                            , .Observacion _
                                            , .TipoPermiso _
                                            , .IndConfirmaSalida _
                                            , .FechaConfirmaSalida _
                                            , .IndConfirmaIngreso _
                                            , .FechaConfirmaIngreso _
                                            , .IdJefeArea _
                                            , .IdJefeAdministracion _
                                            , .UsuarioCreacion _
                                            , Date.Now _
                                            , .Activo _
                                            , .IndPapeleta _
                                            , .IdOcupacion _
                                            , .IndVenta _
                                            , .FechaInicioVtaVacaciones _
                                            , .FechaFinVtaVacaciones _
                                            , .TotalDias)
                .Id = id
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlPermisos As e_ControlPermisos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_ControlPermisos_IAE" _
                                      , "E" _
                                      , "" _
                                      , "" _
                                      , oeControlPermisos.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function IdCodigoInsertar(ByVal PrefijoID As String) As String()
        Try
            Dim oe As New e_ControlPermisos With {.TipoOperacion = "Z"}
            Dim strResultado() As String
            'Objeto ControlPermiso solo llenado con el centro
            Dim odCentro As New d_Centro
            oe.IdCentro = odCentro.Obtener(New e_Centro With {.TipoOperacion = "2"}).Id
            With oe
                strResultado = sqlhelper.ExecuteScalar("PER.Isp_ControlPermisos_IAE",
                                                        .TipoOperacion _
                                                        , "" _
                                                        , PrefijoID _
                                                        , .Id _
                                                        , .IdCentro).ToString.Split("_")

            End With
            Return strResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(CadenaXML As String) As Boolean
        Try
            sqlhelper.ExecuteScalar("PER.Isp_ControlPermisos_IAE",
                                      "M" _
                                      , CadenaXML)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
