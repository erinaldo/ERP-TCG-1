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

Public Class d_TablaContable
    Private sqlhelper As New SqlHelper
    Private odTablaContableDet As New d_TablaContableDet

    Private Function Cargar(ByVal o_fila As DataRow) As e_TablaContable
        Try
            Dim oeTablaContable = New e_TablaContable( _
                              o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("ColumnaTexto1").ToString _
                             , o_fila("ColumnaTexto2").ToString _
                             , o_fila("ColumnaTexto3").ToString _
                             , o_fila("ColumnaValor1").ToString _
                             , o_fila("ColumnaValor2").ToString _
                             , o_fila("ColumnaValor3").ToString _
                             , o_fila("ColumnaLogico1").ToString _
                             , o_fila("ColumnaLogico2").ToString _
                             , o_fila("ColumnaLogico3").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTablaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTablaContable As e_TablaContable) As e_TablaContable

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_TablaContable_Listar", "", oeTablaContable.Id)
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeTablaContable = Cargar(ds.Tables(0).Rows(0))
                End If
            End If

            Return oeTablaContable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTablaContable As e_TablaContable) As List(Of e_TablaContable)
        Try
            Dim ldTablaContable As New List(Of e_TablaContable)
            Dim ds As DataSet
            With oeTablaContable
                ds = SqlHelper.ExecuteDataset("CON.ISP_TablaContable_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .Texto1 _
                        , .Texto2 _
                        , .Texto3 _
                        , .Valor1 _
                        , .Valor2 _
                        , .Valor3 _
                        , .Logico1 _
                        , .Logico2 _
                        , .Logico3 _
                        , .Activo _
                        )
            End With
            oeTablaContable = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTablaContable = Cargar(o_Fila)
                    ldTablaContable.Add(oeTablaContable)
                Next
            End If
            Return ldTablaContable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTablaContable As e_TablaContable) As Boolean
        Try
            Dim stResultado() As String
            With oeTablaContable
                stResultado = sqlhelper.ExecuteScalar("CON.ISP_TablaContable_IAE", .Tipooperacion, .PrefijoID,
                         .Id _
                        , .Nombre _
                        , .Texto1 _
                        , .Texto2 _
                        , .Texto3 _
                        , .Valor1 _
                        , .Valor2 _
                        , .Valor3 _
                        , .Logico1 _
                        , .Logico2 _
                        , .Logico3 _
                        , .Activo
                    ).ToString.Split("_")

                For Each Detalle As e_TablaContableDet In .lstTablaCtbleDet
                    Detalle.IdTabla = stResultado(0)
                    Detalle.PrefijoID = oeTablaContable.PrefijoID '@0001
                    odTablaContableDet.Guardar(Detalle)
                Next

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtTabCtble As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("CON.TablaContable", dtTabCtble)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTablaContable As e_TablaContable) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CON.ISP_TablaContable_IAE", "E", _
             "", oeTablaContable.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.TablaContable", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
