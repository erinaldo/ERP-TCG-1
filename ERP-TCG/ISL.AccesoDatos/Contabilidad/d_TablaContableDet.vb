Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class d_TablaContableDet
    Private sqlhelper As New SqlHelper
    Private odTipoCompra As New d_TipoCompra
    Private odTipoVenta As New d_TipoVenta
    Private odCuenasGenerales As New d_CuentasGenerales


    Private Function Cargar(ByVal o_fila As DataRow) As e_TablaContableDet
        Try
            Dim oeTablaContableDet = New e_TablaContableDet( _
                             o_fila("Id").ToString _
                             , o_fila("IdTablaContable").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Texto1").ToString _
                             , o_fila("Texto2").ToString _
                             , o_fila("Texto3").ToString _
                             , o_fila("Valor1").ToString _
                             , o_fila("Valor2").ToString _
                             , o_fila("Valor3").ToString _
                             , o_fila("Logico1").ToString _
                             , o_fila("Logico2").ToString _
                             , o_fila("Logico3").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndTablaContable").ToString _
                             , o_fila("IdTablaContableDet").ToString)
            Return oeTablaContableDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTablaContableDet As e_TablaContableDet) As e_TablaContableDet

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_TablaContableDet_Listar", oeTablaContableDet.TipoOperacion, oeTablaContableDet.Id)
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeTablaContableDet = Cargar(ds.Tables(0).Rows(0))
                End If
            End If
            Return oeTablaContableDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTablaContableDet As e_TablaContableDet) As List(Of e_TablaContableDet)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldTablaContableDet As New List(Of e_TablaContableDet)
            Dim ds As DataSet
            With oeTablaContableDet
                ds = sqlhelper.ExecuteDataset("CON.ISP_TablaContableDet_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTabla _
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
                        , .Activo)
            End With
            oeTablaContableDet = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTablaContableDet = Cargar(o_Fila)
                    ldTablaContableDet.Add(oeTablaContableDet)
                Next
            End If
            Return ldTablaContableDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarBind(ByVal oeTablaContableDet As e_TablaContableDet) As BindingList(Of e_TablaContableDet)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            Dim ldTablaContableDet As New BindingList(Of e_TablaContableDet)
            Dim ds As DataSet

            With oeTablaContableDet

                ds = sqlhelper.ExecuteDataset("CON.ISP_TablaContableDet_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTabla _
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
                        , .Activo)
            End With
            oeTablaContableDet = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTablaContableDet = Cargar(o_Fila)
                    ldTablaContableDet.Add(oeTablaContableDet)
                Next
            End If
            Return ldTablaContableDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTablaContableDet As e_TablaContableDet) As Boolean
        Dim stResultado As String()
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTablaContableDet
                stResultado = sqlhelper.ExecuteScalar("CON.ISP_TablaContableDet_IAE", _
                                                      .TipoOperacion, _
                                                      .PrefijoID, _
                                                        .Id _
                                                    , .IdTabla _
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
                                                    , .IndTablaContable _
                                                    , .IdTablaContableDet).ToString.Split("_")

                If .TipoOperacion = "X" Then
                    For Each TipoCompra As e_TipoCompra In oeTablaContableDet.ListaTipoCompra
                        TipoCompra.IdTablaContableDet = stResultado(0)
                        If TipoCompra.TipoOperacion = "E" Then
                            odTipoCompra.Eliminar(TipoCompra)
                        Else
                            odTipoCompra.Guardar(TipoCompra)
                        End If
                    Next
                    For Each TipoVenta As e_TipoVenta In oeTablaContableDet.ListaTipoVenta
                        TipoVenta.IdTablaContableDet = stResultado(0)
                        If TipoVenta.TipoOperacion = "E" Then
                            odTipoVenta.Eliminar(TipoVenta)
                        Else
                            odTipoVenta.Guardar(TipoVenta)
                        End If
                    Next
                    For Each CuentasGenerales As e_CuentasGenerales In oeTablaContableDet.ListaCuentasGenerales
                        'CuentasGenerales.Id = ""
                        CuentasGenerales.TipoOperacion = IIf(String.IsNullOrEmpty(CuentasGenerales.Id), "I", "A")
                        CuentasGenerales.IdTablaContableDet = stResultado(0)
                        odCuenasGenerales.Guardar(CuentasGenerales)
                    Next
                End If
            End With

            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtTabCtble As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("CON.TablaContableDet", dtTabCtble)
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeTablaContableDet As e_TablaContableDet) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("CON.ISP_TablaContableDet_IAE", "E", _
             "", oeTablaContableDet.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.TablaContableDet", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
