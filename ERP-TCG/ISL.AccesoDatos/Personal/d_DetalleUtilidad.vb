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

Public Class d_DetalleUtilidad
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleUtilidad
        Try
            Dim oeDetalleUtilidad = New e_DetalleUtilidad(o_fila("Id").ToString _
                             , o_fila("IdUtilidad").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("DNI").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Gratificacion").ToString _
                             , o_fila("BrutoMensual").ToString _
                             , o_fila("IndEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("DiasMes").ToString _
                             , o_fila("DiasLaborados").ToString _
                             , o_fila("Faltas").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeDetalleUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As e_DetalleUtilidad
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleUtilidad_Listar", "", oeDetalleUtilidad.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleUtilidad = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As List(Of e_DetalleUtilidad)
        Try
            Dim ldDetalleUtilidad As New List(Of e_DetalleUtilidad)
            Dim ds As DataSet
            With oeDetalleUtilidad
                ds = sqlhelper.ExecuteDataset("PER.Isp_DetalleUtilidad_Listar", .TipoOperacion _
                        , .Id _
                        , .IdUtilidad _
                        , .IdPeriodo _
                        , .IdTrabajador _
                        , .Año)
            End With
            oeDetalleUtilidad = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleUtilidad = Cargar(o_Fila)
                ldDetalleUtilidad.Add(oeDetalleUtilidad)
            Next
            Return ldDetalleUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean
        Try
            With oeDetalleUtilidad
                sqlhelper.ExecuteNonQuery("PER.Isp_DetalleUtilidad_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdUtilidad _
                        , .IdPeriodo _
                        , .IdTrabajador _
                        , .Gratificacion _
                        , .BrutoMensual _
                        , .IndEstado _
                        , .DiasMes _
                        , .DiasLaborados _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DetalleUtilidad_IAE", "E", _
             "", oeDetalleUtilidad.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.DetalleUtilidad", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtConUti As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.DetalleUtilidad", dtConUti)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
