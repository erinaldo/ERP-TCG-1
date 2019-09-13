Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Descuentos

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Descuentos
        Try
            Dim oeDescuentos = New e_Descuentos( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("MontoAdelanto") _
                             , o_fila("MontoSancion") _
                             , o_fila("IndTipo") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeDescuentos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDescuentos As e_Descuentos) As e_Descuentos

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_Descuentos_Listar", "", oeDescuentos.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDescuentos = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDescuentos
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDescuentos As e_Descuentos) As List(Of e_Descuentos)
        Try
            Dim ldDescuentos As New List(Of e_Descuentos)
            Dim ds As DataSet
            With oeDescuentos
                ds = sqlhelper.ExecuteDataset("PER.Isp_Descuentos_Listar", "" _
                        , .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .MontoAdelanto _
                        , .MontoSancion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDescuentos = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDescuentos = Cargar(o_Fila)
                ldDescuentos.Add(oeDescuentos)
            Next
            Return ldDescuentos
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDescuentos As e_Descuentos) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDescuentos
                sqlhelper.ExecuteNonQuery("PER.Isp_Descuentos_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .MontoAdelanto _
                        , .MontoSancion _
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

    Public Function GuardarMasivo(ByVal dtDscto As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.Descuentos", dtDscto)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDescuentos As e_Descuentos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_Descuentos_IAE", "E", _
             "", oeDescuentos.Id)
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
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.Descuentos", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
