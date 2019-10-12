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

Public Class d_ConsolidadoUtilidad

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConsolidadoUtilidad
        Try
            Dim oeConsolidadoUtilidad = New e_ConsolidadoUtilidad(o_fila("Id").ToString _
                             , o_fila("IdUtilidad").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IndSituacion") _
                             , o_fila("SueldoAnual") _
                             , o_fila("Subsidios") _
                             , o_fila("SueldoNetoAnual") _
                             , o_fila("UtilidadporSueldo") _
                             , o_fila("DiasTrabajadosAnual") _
                             , o_fila("UtilidadporDiasTrabajados") _
                             , o_fila("UtilidadTotal") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModfica").ToString _
                             , o_fila("Activo"))
            Return oeConsolidadoUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As e_ConsolidadoUtilidad

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_ConsolidadoUtilidad_Listar", "", oeConsolidadoUtilidad.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConsolidadoUtilidad = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConsolidadoUtilidad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As List(Of e_ConsolidadoUtilidad)
        Try
            Dim ldConsolidadoUtilidad As New List(Of e_ConsolidadoUtilidad)
            Dim ds As DataSet
            With oeConsolidadoUtilidad
                ds = sqlhelper.ExecuteDataset("PER.Isp_ConsolidadoUtilidad_Listar", "" , .Id _
                        , .IdUtilidad _
                        , .IdTrabajador _
                        , .IndSituacion _
                        , .SueldoAnual _
                        , .Subsidios _
                        , .SueldoNetoAnual _
                        , .UtilidadporSueldo _
                        , .DiasTrabajadosAnual _
                        , .UtilidadporDiasTrabajados _
                        , .UtilidadTotal _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModfica _
                        , .Activo)
            End With
            oeConsolidadoUtilidad = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConsolidadoUtilidad = Cargar(o_Fila)
                ldConsolidadoUtilidad.Add(oeConsolidadoUtilidad)
            Next
            Return ldConsolidadoUtilidad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConsolidadoUtilidad As e_ConsolidadoUtilidad) As Boolean
        Try
            With oeConsolidadoUtilidad
                sqlhelper.ExecuteNonQuery("PER.Isp_ConsolidadoUtilidad_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdUtilidad _
                        , .IdTrabajador _
                        , .IndSituacion _
                        , .SueldoAnual _
                        , .Subsidios _
                        , .SueldoNetoAnual _
                        , .UtilidadporSueldo _
                        , .DiasTrabajadosAnual _
                        , .UtilidadporDiasTrabajados _
                        , .UtilidadTotal _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModfica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtConUti As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.ConsolidadoUtilidad", dtConUti)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleUtilidad As e_ConsolidadoUtilidad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_ConsolidadoUtilidad_IAE", "E", _
             "", oeDetalleUtilidad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.ConsolidadoUtilidad", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
