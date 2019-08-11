Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MontoRuta

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MontoRuta
        Try
            Dim oeMontoRuta = New e_MontoRuta( _
                             o_fila("Id").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("IndCargado").ToString _
                             , o_fila("IndNacional").ToString _
                             , o_fila("IndCategoria").ToString _
                             , o_fila("MontoSolo").ToString _
                             , o_fila("MontoAcompañado").ToString _
                             , o_fila("PorcentajeCopiloto").ToString _
                             , o_fila("PorcentajeAyudante").ToString _
                             , o_fila("BonoSolo").ToString _
                             , o_fila("BonoCruceroPiloto").ToString _
                             , o_fila("BonoCruceroCopiloto").ToString _
                             , o_fila("Kilometraje").ToString _
                             , o_fila("Vigencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString)
            Return oeMontoRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoRuta As e_MontoRuta) As e_MontoRuta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_MontoRuta_Listar", oeMontoRuta.TipoOperacion, oeMontoRuta.Id _
                        , oeMontoRuta.IdRuta, oeMontoRuta.IdTipoVehiculo, oeMontoRuta.Tipo, _
                        oeMontoRuta.FechaDesde, oeMontoRuta.FechaHasta, oeMontoRuta.IndCargado)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMontoRuta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMontoRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMontoRuta As e_MontoRuta) As List(Of e_MontoRuta)
        Try
            Dim ldMontoRuta As New List(Of e_MontoRuta)
            Dim ds As DataSet
            With oeMontoRuta
                ds = sqlhelper.ExecuteDataset("PER.Isp_MontoRuta_Listar", .TipoOperacion _
                        , .Id _
                        , .IdRuta _
                        , .IdTipoVehiculo _
                        , .Tipo _
                        , .FechaDesde _
                        , .FechaHasta _
                        , .IndCargado)
            End With
            oeMontoRuta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMontoRuta = Cargar(o_Fila)
                ldMontoRuta.Add(oeMontoRuta)
            Next
            Return ldMontoRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoRuta As e_MontoRuta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            With oeMontoRuta
                id = sqlhelper.ExecuteScalar("PER.Isp_MontoRuta_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdRuta _
                        , .IdTipoVehiculo _
                        , .Cuenta _
                        , .IndCargado _
                        , .IndNacional _
                        , .IndCategoria _
                        , .MontoSolo _
                        , .MontoAcompañado _
                        , .PorcentajeCopiloto _
                        , .PorcentajeAyudante _
                        , .BonoSolo _
                        , .BonoCruceroPiloto _
                        , .BonoCruceroCopiloto _
                        , .Kilometraje _
                        , .Vigencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMontoRuta As e_MontoRuta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_MontoRuta_IAE", "E", _
             "", oeMontoRuta.Id, "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
             0, Date.Parse("01/01/1901"), oeMontoRuta.UsuarioCreacion, 0)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtMontoRuta As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.MontoRuta", dtMontoRuta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.MontoRuta", d_DatosConfiguracion.PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
