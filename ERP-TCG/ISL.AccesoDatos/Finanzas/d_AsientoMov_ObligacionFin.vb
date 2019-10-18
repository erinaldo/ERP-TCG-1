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

Public Class d_AsientoMov_ObligacionFin
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoMov_ObligacionFin
        Try
            Dim oeAsientoMov_ObligacionFin = New e_AsientoMov_ObligacionFin( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsientoMovimiento").ToString _
                             , o_fila("IdObligacionFinanciera").ToString _
                             , o_fila("Activo") _
                             , o_fila("IdObligacionPago").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("NroBoucher").ToString _
                             , o_fila("Fecha") _
                             , o_fila("TipoCambio") _
                             , o_fila("TotalMN").ToString _
                             , o_fila("TotalME").ToString _
                             , o_fila("FlujoCaja").ToString _
                             , o_fila("MedioPago").ToString _
                             , o_fila("NumeroCuenta").ToString _
                             , o_fila("Banco").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("TipoAsiento").ToString _
                             , o_fila("NroAsiento").ToString _
                             , o_fila("Glosa").ToString _
            )
            Return oeAsientoMov_ObligacionFin
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As e_AsientoMov_ObligacionFin

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.AsientoMov_ObligacionFin_Listar", "",
            Left(oeAsientoMov_ObligacionFin.PrefijoID, 1), "", oeAsientoMov_ObligacionFin.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAsientoMov_ObligacionFin = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsientoMov_ObligacionFin
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As List(Of e_AsientoMov_ObligacionFin)
        Try
            Dim ldAsientoMov_ObligacionFin As New List(Of e_AsientoMov_ObligacionFin)
            Dim ds As DataSet
            With oeAsientoMov_ObligacionFin
                ds = sqlhelper.ExecuteDataset("FIN.AsientoMov_ObligacionFin_Listar", .TipoOperacion _
        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .IdAsientoMovimiento _
                        , .IdObligacionFinanciera _
                        , .Activo _
                        , .IdObligacionPago
                        )
            End With
            oeAsientoMov_ObligacionFin = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAsientoMov_ObligacionFin = Cargar(o_Fila)
                    ldAsientoMov_ObligacionFin.Add(oeAsientoMov_ObligacionFin)
                Next
            End If
            Return ldAsientoMov_ObligacionFin
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean
        Try
            With oeAsientoMov_ObligacionFin
                sqlhelper.ExecuteNonQuery("FIN.AsientoMov_ObligacionFin_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdAsientoMovimiento _
                        , .IdObligacionFinanciera _
                        , .Activo _
                        , .IdObligacionPago _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("FIN.Isp_ObligacionDocumento_IAE", "E", _
             "", oeAsientoMov_ObligacionFin.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Extornar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean
        Try
            With oeAsientoMov_ObligacionFin
                sqlhelper.ExecuteNonQuery("FIN.AsientoMov_ObligacionFin_IAE", .TipoOperacion, "", .Id, _
                                          .IdAsientoMovimiento, .IdObligacionFinanciera, 1, .IdObligacionPago, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.AsientoMov_MovDoc para casos de insercion masiva
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "FIN.AsientoMov_ObligacionFin", Left(PrefijoID, 1) & "SI"
                    )
            Return IIf(stResultado Is Nothing, Left(PrefijoID, 1) & "SI" & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guarda esta tabla en masivo
    ''' </summary>
    ''' <param name="DTAsientoMov_Ofin">Estructura de Con.AsientoMov_MovDoc</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarMasivo(ByVal DTAsientoMov_Ofin As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("FIN.AsientoMov_ObligacionFin", DTAsientoMov_Ofin, False)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
