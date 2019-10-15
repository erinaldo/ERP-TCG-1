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

Public Class d_OtrosIngresos
    Private sqlhelper As New SqlHelper
    Dim oeCorrelativo As New e_Correlativo
    Dim odCorrelativo As New d_Correlativo
    Dim oeTipodocumento As New e_TipoDocumento
    Dim odTipoDocumento As New d_TipoDocumento

    Private Function Cargar(ByVal o_fila As DataRow) As e_OtrosIngresos
        Try
            Dim oe = New e_OtrosIngresos(o_fila("Id").ToString _
                             , o_fila("IdConceptoIngresos").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Voucher").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("IndIngresoEgreso").ToString _
                             , o_fila("IndCerrado").ToString _
                             , o_fila("FechaCierre").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Ingreso").ToString _
                             , o_fila("Egreso").ToString _
                             , o_fila("CuentaBancaria").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("Centro").ToString _
                             , o_fila("Concepto").ToString)
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oe As e_OtrosIngresos) As e_OtrosIngresos
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_OtrosIngresos_Listar", "", oe.Id)
            If ds.Tables.Count > 0 Then
                oe = Cargar(ds.Tables(0).Rows(0))
                Return oe
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oe As e_OtrosIngresos) As List(Of e_OtrosIngresos)
        Try
            Dim ld As New List(Of e_OtrosIngresos)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("TES.Isp_OtrosIngresos_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCentro _
                        , .FechaCreacion _
                        , .FechaCierre _
                        , .IdCuentaCorriente _
                        , .IdCaja)
            End With
            oe = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oe = Cargar(o_Fila)
                    ld.Add(oe)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oe As e_OtrosIngresos) As Boolean
        Try
            Dim id As String = ""
            With oe
                Dim strCorrelativo As String = ""
                strCorrelativo = CargarCorrelativoLocal("VALE", oe.PrefijoID)
                GrabarCorrelativo(strCorrelativo, "VALE", oe.PrefijoID)
                id = sqlhelper.ExecuteScalar("TES.Isp_OtrosIngresos_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdConceptoIngresos _
                        , .IdCuentaCorriente _
                        , strCorrelativo _
                        , .Importe _
                        , .Fecha _
                        , .IndIngresoEgreso _
                        , .IndCerrado _
                        , .FechaCierre _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Activo _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .IdCentro _
                        , .Glosa _
                        , .IdTrabajador _
                        , .IdCuentaBancaria, .IdCaja)
                .Id = id
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oe As e_OtrosIngresos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_OtrosIngresos_IAE", "E", _
             "", oe.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Private Function CargarCorrelativoLocal(ByVal TipoDocumento As String, ByVal PrefijoID As String) As String
        Dim Numero As String = ""

        oeTipodocumento.TipoOperacion = "B"
        oeTipodocumento.Nombre = TipoDocumento
        oeTipodocumento = odTipoDocumento.Obtener(oeTipodocumento)

        oeCorrelativo.TipoOperacion = "1"
        oeCorrelativo.Prefijo = PrefijoID
        oeCorrelativo.IdTipoDocumento = oeTipodocumento.Id
        oeCorrelativo = odCorrelativo.ObtenerLocal(oeCorrelativo)
        Numero = oeCorrelativo.Numero + 1

        Do While Len(Numero) < 10
            Numero = 0 & Numero
        Loop
        Return Numero
    End Function

    Private Function GrabarCorrelativo(ByVal Numero As String, ByVal TipoDocumento As String, ByVal PrefijoID As String) As Boolean

        Try
            oeTipodocumento.TipoOperacion = "B"
            oeTipodocumento.Nombre = TipoDocumento
            oeTipodocumento = odTipoDocumento.Obtener(oeTipodocumento)

            Select Case PrefijoID
                Case "1CH"
                    oeCorrelativo.Serie = 1
                Case "1PY"
                    oeCorrelativo.Serie = 2
                Case "1LI"
                    oeCorrelativo.Serie = 3
                Case "1SA"
                    oeCorrelativo.Serie = 4
                Case "1LU"
                    oeCorrelativo.Serie = 5
                Case "1SI"
                    oeCorrelativo.Serie = 9
            End Select

            If Numero = "" Then
                Return False
                Exit Function
            Else
                oeCorrelativo.TipoOperacion = "I"
                oeCorrelativo.Numero = CInt(Numero)
                oeCorrelativo.Prefijo = PrefijoID
                oeCorrelativo.IdTipoDocumento = oeTipodocumento.Id
                If odCorrelativo.GuardarLocal(oeCorrelativo) Then Return True
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class

