Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_SueldoTrabajador
    Private sqlhelper As New SqlHelper
    Private oeSuelTrab As New e_SueldoTrabajador

    Private Function Cargar(ByVal o_fila As DataRow) As e_SueldoTrabajador
        Try
            Dim oeSueldoTrabajador = New e_SueldoTrabajador( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Sueldo") _
                             , o_fila("TipoPago") _
                             , o_fila("Periocidad") _
                             , o_fila("FechaActividad") _
                             , o_fila("FechaInactividad") _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeSueldoTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As e_SueldoTrabajador

        Try
            Dim ds As DataSet
            With oeSueldoTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_SueldoTrabajador_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeSueldoTrabajador = Cargar(ds.Tables(0).Rows(0))
                oeSuelTrab = New e_SueldoTrabajador
                oeSuelTrab.TipoOperacion = ""
                oeSuelTrab.IdTrabajador = oeSueldoTrabajador.IdTrabajador
                oeSuelTrab.Activo = True
                oeSueldoTrabajador.leHistorial = Listar(oeSuelTrab)
            End If
            Return oeSueldoTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As List(Of e_SueldoTrabajador)
        Try
            Dim ldSueldoTrabajador As New List(Of e_SueldoTrabajador)
            Dim ds As DataSet
            With oeSueldoTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_SueldoTrabajador_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeSueldoTrabajador = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeSueldoTrabajador = Cargar(o_Fila)
                ldSueldoTrabajador.Add(oeSueldoTrabajador)
            Next
            Return ldSueldoTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeSueldoTrabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_SueldoTrabajador_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .TipoPago _
                        , .Periocidad _
                        , .FechaActividad _
                        , .FechaInactividad _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtSueTra As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.SueldoTrabajador", dtSueTra)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeSueldoTrabajador As e_SueldoTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_SueldoTrabajador_IAE", "E", _
             "", oeSueldoTrabajador.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.SueldoTrabajador", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


End Class
