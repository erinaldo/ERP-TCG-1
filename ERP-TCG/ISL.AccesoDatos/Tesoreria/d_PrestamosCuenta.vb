Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_PrestamosCuenta
    Private sqlhelper As New SqlHelper
    Dim oeCorrelativo As New e_Correlativo
    Dim odCorrelativo As New d_Correlativo
    Dim oeTipodocumento As New e_TipoDocumento
    Dim odTipoDocumento As New d_TipoDocumento

    Private Function Cargar(ByVal o_fila As DataRow) As e_PrestamosCuenta
        Try
            Dim oePrestamosCuenta = New e_PrestamosCuenta( _
                             o_fila("Id").ToString _
                             , o_fila("IdConceptoIngresos").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("IndIngEgr").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Voucher").ToString _
                             , o_fila("UsuarioAutoriza").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Ingreso").ToString _
                             , o_fila("Egreso").ToString _
                             , o_fila("Autoriza").ToString _
                             , o_fila("Concepto").ToString)
            Return oePrestamosCuenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePrestamosCuenta As e_PrestamosCuenta) As e_PrestamosCuenta

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_OtrosIngresos_Listar", "",
            Left(oePrestamosCuenta.PrefijoID, 1), "", oePrestamosCuenta.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oePrestamosCuenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePrestamosCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As List(Of e_PrestamosCuenta)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldPrestamosCuenta As New List(Of e_PrestamosCuenta)
            Dim ds As DataSet
            With oePrestamosCuenta
                ds = sqlhelper.ExecuteDataset("TES.ISP_PrestamosCuenta_Listar", .TipoOperacion _
                        , .Id, .IdConceptoIngresos, .Fecha, .FechaHasta, .IdCentro)
            End With
            oePrestamosCuenta = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePrestamosCuenta = Cargar(o_Fila)
                    ldPrestamosCuenta.Add(oePrestamosCuenta)
                Next
            End If
            Return ldPrestamosCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odAsiento As New d_Asiento
            Dim Id As String = ""
            Using transScope As New TransactionScope
                With oePrestamosCuenta
                    .Voucher = CargarCorrelativoLocal("VALE", oePrestamosCuenta.PrefijoID)
                    GrabarCorrelativo(.Voucher, "VALE", oePrestamosCuenta.PrefijoID)
                    Id = sqlhelper.ExecuteScalar("TES.ISP_PrestamosCuenta_IAE", .TipoOperacion, .PrefijoID, _
                            .Id, .IdConceptoIngresos, .Importe, .IndIngEgr, .Glosa, .Voucher, .UsuarioAutoriza _
                            , .UsuarioCreacion, .Fecha, .IdCentro, .FechaCierre, .oeCtaBancaria.Id)

                    .Id = Id
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Private Function GrabarCorrelativo(ByVal Numero As String, ByVal TipoDocumento As String, ByVal PrefijoID As String) As Boolean

        Dim d_DatosConfiguracion As New d_DatosConfiguracion

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

    Private Function CargarCorrelativoLocal(ByVal TipoDocumento As String, ByVal PrefijoID As String) As String


        Dim Numero As String = ""
        Dim d_DatosConfiguracion As New d_DatosConfiguracion

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

    Public Function Eliminar(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.ISP_PrestamosCuenta_IAE", "E", _
             "", oePrestamosCuenta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function CierreCta(ByVal oePrestamosCuenta As e_PrestamosCuenta) As Boolean
        Try
            Dim odSaldo As New d_Saldo
            Using transScope As New TransactionScope
                With oePrestamosCuenta
                    sqlhelper.ExecuteNonQuery("TES.ISP_PrestamosCuenta_IAE", .TipoOperacion, "", _
                                "", .IdConceptoIngresos, 0, "", "", "", "" _
                                , .UsuarioCreacion, Date.Parse("01/01/1901"), .IdCentro, .FechaCierre)
                    .oeSaldo.TipoOperacion = "I"
                    odSaldo.Guardar(.oeSaldo)
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
