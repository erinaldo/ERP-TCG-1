Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_BonificacionProduccion

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_BonificacionProduccion
        Try
            Dim oeBonificacionProduccion = New e_BonificacionProduccion( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("MontoPlanilla") _
                             , o_fila("MontoCaja") _
                             , o_fila("IndRuta") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
                             , o_fila("Ejercicio") _
                             , o_fila("Mes") _
            )
            Return oeBonificacionProduccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As e_BonificacionProduccion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_BonificacionProduccion_Listar", "", oeBonificacionProduccion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeBonificacionProduccion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeBonificacionProduccion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As List(Of e_BonificacionProduccion)
        Try
            Dim ldBonificacionProduccion As New List(Of e_BonificacionProduccion)
            Dim ds As DataSet
            With oeBonificacionProduccion
                ds = sqlhelper.ExecuteDataset("PER.Isp_BonificacionProduccion_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .MontoPlanilla _
                        , .MontoCaja _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeBonificacionProduccion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeBonificacionProduccion = Cargar(o_Fila)
                ldBonificacionProduccion.Add(oeBonificacionProduccion)
            Next
            Return ldBonificacionProduccion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeBonificacionProduccion
                sqlhelper.ExecuteNonQuery("PER.Isp_BonificacionProduccion_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .MontoPlanilla _
                        , .MontoCaja _
                        , .IndRuta _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeBonificacionProduccion As e_BonificacionProduccion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_BonificacionProduccion_IAE", "E", _
             "", oeBonificacionProduccion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtBonPro As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("PER.BonificacionProduccion", dtBonPro)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.BonificacionProduccion", PrefijoID
                                  )
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
